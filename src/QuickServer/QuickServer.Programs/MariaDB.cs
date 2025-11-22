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
using System.Diagnostics;
using System.IO;
using System.ServiceProcess;

namespace QuickServer.Programs
{
    public class MariaDBProgram : QuickServerProgram
    {
        public const string ServiceName = "QuickServer-MariaDB";
        private ServiceController MariaDBController = new ServiceController();

        public MariaDBProgram(string exeFile) : base(exeFile)
        {
            /* Set MariaDB service details */
            MariaDBController.MachineName = Environment.MachineName;
            MariaDBController.ServiceName = ServiceName;
        }

        public void RemoveService()
        {
            try {
                MariaDBController.Close();
                StartProcess("cmd.exe", StopArgs, WorkingDir, true);
            } catch (Exception) { }
        }

        public void InstallService()
        {
            if (!File.Exists(ExeFileName)) {
                Log.Error("File " + ExeFileName + " not found.", ProgLogSection);
                return;
            }
            if (ServiceExists())
                RemoveService();
            StartProcess(ExeFileName, StartArgs, WorkingDir, true);
        }

        public bool ServiceExists()
        {
            ServiceController[] services = ServiceController.GetServices();
            for (var i = 0; i < services.Length; i++) {
                if (services[i].ServiceName == ServiceName)
                    return true;
            }
            return false;
        }

        public void OpenShell()
        {
            if (IsRunning() == false)
                Start();

            try
            {
                Process.Start(Program.StartupPath + "/mariadb/bin/mysql.exe", "-u root -p");
                Log.Notice("Started MariaDB shell", ProgLogSection);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ProgLogSection);
            }
        }

        public override void Start()
        {
            try {
                InstallService();
                MariaDBController.Start();
                Log.Notice("Started", ProgLogSection);
            } catch (Exception ex) {
                Log.Error("Start():" + ex.Message, ProgLogSection);
            }
        }

        public override void Stop()
        {
            try {
                MariaDBController.Stop();
                RemoveService();
                Log.Notice("Stopped", ProgLogSection);
            } catch (Exception ex) {
                Log.Error("Stop():" + ex.Message, ProgLogSection);
            }
        }

        public override bool IsRunning()
        {
            try {
                MariaDBController.Refresh();
                return MariaDBController.Status == ServiceControllerStatus.Running;
            } catch (Exception) {
                return false;
            }
        }
    }
}
