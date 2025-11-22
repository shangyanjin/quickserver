/*
 * Copyright (c) 2025 QuickServer
 *
 * This file is part of QuickServer.
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

using QuickServer.Configuration;
using QuickServer.UI;

namespace QuickServer.Updater
{
    /// <summary>
    /// Updater for QuickServer
    /// </summary>
    class QuickServerUpdater
    {
        private MainFrm mainForm;
        private Updater updater = new Updater();

        public QuickServerUpdater(MainFrm form)
        {
            mainForm = form;
        }

        /// <summary>
        /// Checks for updates
        /// </summary>
        public void CheckForUpdates()
        {
            updater.CurrentVersion = new Version(Application.ProductVersion);
            updater.UpdateInfoURL = new Uri("https://wnmp.x64architecture.com/update.xml");
            updater.SaveFileName = Program.StartupPath + "\\QuickServer-Upgrade-Installer.exe";

            updater.CheckForUpdate();

            if (updater.UpdateAvailable) {
                var UpdatePrompt = new UpdatePromptFrm("https://github.com/wnmp/wnmp/releases/latest", updater.CurrentVersion, updater.NewVersion) {
                    StartPosition = FormStartPosition.CenterParent
                };
                if (UpdatePrompt.ShowDialog() == DialogResult.Yes) {
                    mainForm.Enabled = false;
                    updater.Update(UpdateCanceled, UpdateDownloaded);
                }
            } else {
                Log.Notice("Your version: " + updater.CurrentVersion + " is up to date.");
            }
        }

        private void UpdateCanceled()
        {
            mainForm.Enabled = true;
        }

        private void UpdateDownloaded()
        {
            mainForm.StopAll();
            DoBackUp();
            KillProcesses();
            Process.Start(updater.SaveFileName);
            Application.Exit();
        }

        /// <summary>
        /// Backs up the configuration files for Nginx, MariaDB, and PHP
        /// </summary>
        private void DoBackUp()
        {
            string[] files = { "\\php\\php.ini", "\\conf\\nginx.conf", "\\mariadb\\my.ini" };
            foreach (string f in files) {
                string file = Program.StartupPath + f;
                if (File.Exists(file)) {
                    var dest = $"{file}.old";
                    File.Copy(file, dest, true);
                    Log.Notice("Backed up " + file + " to " + dest);
                }
            }
        }

        /// <summary>
        /// Kills Nginx, MariaDB, and PHP
        /// </summary>
        private void KillProcesses()
        {
            string[] processestokill = { "php-cgi", "nginx", "mysqld" };
            var processes = Process.GetProcesses();

            foreach (var process in processes) {
                foreach (var processToKill in processestokill) {
                    if (process.ProcessName == processToKill) {
                        process.Kill();
                        break;
                    }
                }
            }
        }

        public void DoDateEclasped()
        {
            DateTime LastCheckForUpdate = Properties.Settings.Default.LastCheckForUpdate;
            DateTime expiryDate = LastCheckForUpdate.AddDays(Properties.Settings.Default.UpdateFrequency);

            if (DateTime.Now < expiryDate)
                return;

            CheckForUpdates();

            Properties.Settings.Default.LastCheckForUpdate = DateTime.Now;
            Properties.Settings.Default.Save();
        }
    }
}