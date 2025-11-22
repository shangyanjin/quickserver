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
using System.IO;
using System.Windows.Forms;
using System.Linq;
using Microsoft.Win32;
using QuickServer.Configuration;

namespace QuickServer.UI
{
    /// <summary>
    /// Form that allows configuring QuickServer options.
    /// </summary>
    public partial class OptionsFrm : Form
    {
        public MainFrm mainForm;
        private string Editor;
        private PHPConfigurationManager PHPConfigurationMgr = new PHPConfigurationManager();

        public OptionsFrm(MainFrm form)
        {
            mainForm = form;
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~0x00040000; // Remove WS_THICKFRAME (Disables resizing)
                return cp;
            }
        }

        /* Options releated functions */

        /// <summary>
        /// Populates the options with there saved values
        /// </summary>
        private void UpdateOptions()
        {
            editorTB.Text = Properties.Settings.Default.TextEditor;
            StartQuickServerWithWindows.Checked = Properties.Settings.Default.StartWithWindows;
            StartNginxLaunchCB.Checked = Properties.Settings.Default.StartNginxOnLaunch;
            StartMySQLLaunchCB.Checked = Properties.Settings.Default.StartMariaDBOnLaunch;
            StartPHPLaunchCB.Checked = Properties.Settings.Default.StartPHPOnLaunch;
            StartMinimizedToTray.Checked = Properties.Settings.Default.StartMinimizedToTray;
            MinimizeQuickServerToTray.Checked = Properties.Settings.Default.MinimizeToTray;
            autoUpdateCheckBox.Checked = Properties.Settings.Default.AutoCheckForUpdates;
            updateCheckIntervalNumericUpDown.Value = Properties.Settings.Default.UpdateFrequency;
            PHP_PROCESSES.Value = Properties.Settings.Default.PHPProcessCount;
            PHP_PORT.Value = Properties.Settings.Default.PHPPort;
            MinimizeToTrayInsteadOfClosing.Checked = Properties.Settings.Default.MinimizeInsteadOfClosing;
            foreach (var str in GetNginxVersions())
            {
                nginxBin.Items.Add(str);
            }
            foreach (var str in GetMariaDBVersions())
            {
                mariadbBin.Items.Add(str);
            }
            foreach (var str in GetPHPVersions()) {
                phpBin.Items.Add(str);
            }
            nginxBin.SelectedIndex = nginxBin.Items.IndexOf(Properties.Settings.Default.NginxVersion);
            mariadbBin.SelectedIndex = mariadbBin.Items.IndexOf(Properties.Settings.Default.MariaDBVersion);
            phpBin.SelectedIndex = phpBin.Items.IndexOf(Properties.Settings.Default.PHPVersion);
        }

        private void Options_Load(object sender, EventArgs e)
        {
            UpdateOptions();
        }

        private void SetSettings()
        {
            Properties.Settings.Default.TextEditor = editorTB.Text;
            Properties.Settings.Default.StartWithWindows = StartQuickServerWithWindows.Checked;
            Properties.Settings.Default.StartNginxOnLaunch = StartNginxLaunchCB.Checked;
            Properties.Settings.Default.StartMariaDBOnLaunch = StartMySQLLaunchCB.Checked;
            Properties.Settings.Default.StartPHPOnLaunch = StartPHPLaunchCB.Checked;
            Properties.Settings.Default.StartMinimizedToTray = StartMinimizedToTray.Checked;
            Properties.Settings.Default.MinimizeToTray = MinimizeQuickServerToTray.Checked;
            Properties.Settings.Default.MinimizeInsteadOfClosing = MinimizeToTrayInsteadOfClosing.Checked;
            Properties.Settings.Default.AutoCheckForUpdates = autoUpdateCheckBox.Checked;
            Properties.Settings.Default.PHPProcessCount = (uint)PHP_PROCESSES.Value;
            Properties.Settings.Default.PHPPort = (ushort)PHP_PORT.Value;
            Properties.Settings.Default.UpdateFrequency = (uint)updateCheckIntervalNumericUpDown.Value;
            try
            {
                StartWithWindows();
                UpdateNgxPHPConfig();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            if (Properties.Settings.Default.NginxVersion != nginxBin.Text)
            {
                Properties.Settings.Default.NginxVersion = nginxBin.Text;
                mainForm.SetupNginx();
            }
            if (Properties.Settings.Default.MariaDBVersion != mariadbBin.Text)
            {
                Properties.Settings.Default.MariaDBVersion = mariadbBin.Text;
                mainForm.SetupMariaDB();
            }
            if (Properties.Settings.Default.PHPVersion != phpBin.Text)
            {
                Properties.Settings.Default.PHPVersion = phpBin.Text;
                mainForm.SetupPHP();
            }
            Save_PHPExtOptions();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SetSettings();
            Properties.Settings.Default.Save();
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        /* Editor releated functions */

        private void SetEditor()
        {
            var input = "";
            var dialog = new OpenFileDialog {
                Filter = "executable files (*.exe)|*.exe|All files (*.*)|*.*",
                Title = "Select a text editor"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
                input = dialog.FileName;

            editorTB.Text = dialog.FileName;
            Editor = dialog.FileName;

            if (input == "")
                Editor = "notepad.exe";
            editorTB.Text = Editor;
        }

        private void Selecteditor_Click(object sender, EventArgs e)
        {
            SetEditor();
        }

        private void EditorTB_DoubleClick(object sender, EventArgs e)
        {
            SetEditor();
        }

        private string[] GetNginxVersions()
        {
            if (Directory.Exists(Program.StartupPath + "\\nginx-bins") == false)
                return new string[0];
            return Directory.GetDirectories(Program.StartupPath + "\\nginx-bins").Select(d => new DirectoryInfo(d).Name).ToArray();
        }

        private string[] GetMariaDBVersions()
        {
            if (Directory.Exists(Program.StartupPath + "\\mariadb-bins") == false)
                return new string[0];
            return Directory.GetDirectories(Program.StartupPath + "\\mariadb-bins").Select(d => new DirectoryInfo(d).Name).ToArray();
        }

        private string[] GetPHPVersions()
        {
            if (Directory.Exists(Program.StartupPath + "\\php-bins") == false)
                return new string[0];
            return Directory.GetDirectories(Program.StartupPath + "\\php-bins").Select(d => new DirectoryInfo(d).Name).ToArray();
        }

        private void UpdateNgxPHPConfig()
        {
            short port = (short)PHP_PORT.Value;

            using (var sw = new StreamWriter(mainForm.Nginx.WorkingDir + "\\conf\\php_processes.conf")) {
                sw.WriteLine("# DO NOT MODIFY!!! THIS FILE IS MANAGED BY THE QUICKSERVER CONTROL PANEL.\r\n");
                sw.WriteLine("upstream php_processes {");
                sw.WriteLine("    server 127.0.0.1:" + port + " weight=1;");
                sw.WriteLine("}");
            }
        }


        private void StartWithWindows()
        {
            var root = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (root == null)
                return;
            if (StartQuickServerWithWindows.Checked) {
                if (root.GetValue("QuickServer") == null)
                    root.SetValue("QuickServer", "\"" + Application.ExecutablePath + "\"");
            } else {
                if (root.GetValue("QuickServer") != null)
                    root.DeleteValue("QuickServer");
            }
        }

        /* PHP Extensions Manager */

        private void Save_PHPExtOptions()
        {
            for (var i = 0; i < phpExtListBox.Items.Count; i++) {
                PHPConfigurationMgr.PHPExtensions[i].Enabled = phpExtListBox.GetItemChecked(i);
            }
            PHPConfigurationMgr.SavePHPIniOptions();
        }

        private void PhpBin_SelectedIndexChanged(object sender, EventArgs e)
        {
            phpExtListBox.Items.Clear();
            PHPConfigurationMgr.LoadPHPExtensions(phpBin.Text);

            foreach (var ext in PHPConfigurationMgr.PHPExtensions)
                phpExtListBox.Items.Add(ext.Name, ext.Enabled);
        }
    }
}