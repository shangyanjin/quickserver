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
    public class PostgreSQLProgram : QuickServerProgram
    {
        public const string ServiceName = "QuickServer-PostgreSQL";
        private ServiceController PostgreSQLController = new ServiceController();
        private string dataDir;
        private string initdbExe;

        public PostgreSQLProgram(string exeFile) : base(exeFile)
        {
            dataDir = Program.StartupPath + "\\postgresql\\data";
            initdbExe = Program.StartupPath + "\\postgresql\\bin\\initdb.exe";
            
            PostgreSQLController.MachineName = Environment.MachineName;
            PostgreSQLController.ServiceName = ServiceName;
        }

        public void InitializeDatabase()
        {
            if (Directory.Exists(dataDir) && Directory.GetFiles(dataDir).Length > 0)
            {
                Log.Notice("PostgreSQL data directory already initialized", ProgLogSection);
                return;
            }

            if (!File.Exists(initdbExe))
            {
                Log.Error("initdb.exe not found at " + initdbExe, ProgLogSection);
                return;
            }

            try
            {
                Directory.CreateDirectory(dataDir);
                string args = $"-D \"{dataDir}\" -U postgres --locale=C --encoding=UTF8";
                StartProcess(initdbExe, args, WorkingDir, true);
                Log.Notice("PostgreSQL database initialized", ProgLogSection);
            }
            catch (Exception ex)
            {
                Log.Error("InitializeDatabase(): " + ex.Message, ProgLogSection);
            }
        }

        public void RemoveService()
        {
            try
            {
                PostgreSQLController.Close();
                StartProcess("cmd.exe", StopArgs, WorkingDir, true);
            }
            catch (Exception) { }
        }

        public void InstallService()
        {
            if (!File.Exists(ExeFileName))
            {
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
            for (var i = 0; i < services.Length; i++)
            {
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
                string psqlExe = Program.StartupPath + "\\postgresql\\bin\\psql.exe";
                if (File.Exists(psqlExe))
                {
                    Process.Start(psqlExe, "-U postgres -d postgres");
                    Log.Notice("Started PostgreSQL shell", ProgLogSection);
                }
                else
                {
                    Log.Error("psql.exe not found", ProgLogSection);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ProgLogSection);
            }
        }

        public override void Start()
        {
            if (!File.Exists(ExeFileName))
            {
                Log.Error("File " + ExeFileName + " not found.", ProgLogSection);
                return;
            }
            if (IsRunning())
            {
                Log.Error("Already running.", ProgLogSection);
                return;
            }

            try
            {
                InitializeDatabase();
                
                // Try to start using pg_ctl if available, otherwise use service
                string pgCtlExe = Program.StartupPath + "\\postgresql\\bin\\pg_ctl.exe";
                if (File.Exists(pgCtlExe))
                {
                    StartProcess(pgCtlExe, StartArgs, WorkingDir);
                    Log.Notice("Started", ProgLogSection);
                }
                else
                {
                    // Fallback to service method
                    InstallService();
                    PostgreSQLController.Start();
                    Log.Notice("Started", ProgLogSection);
                }
            }
            catch (Exception ex)
            {
                Log.Error("Start(): " + ex.Message, ProgLogSection);
            }
        }

        public override void Stop()
        {
            try
            {
                // Try to stop using pg_ctl if available
                string pgCtlExe = Program.StartupPath + "\\postgresql\\bin\\pg_ctl.exe";
                if (File.Exists(pgCtlExe))
                {
                    string stopArgs = "stop -D \"" + dataDir + "\" -m fast";
                    StartProcess(pgCtlExe, stopArgs, WorkingDir, true);
                    Log.Notice("Stopped", ProgLogSection);
                }
                else
                {
                    // Fallback to service method
                    PostgreSQLController.Stop();
                    RemoveService();
                    Log.Notice("Stopped", ProgLogSection);
                }
            }
            catch (Exception ex)
            {
                Log.Error("Stop(): " + ex.Message, ProgLogSection);
            }
        }

        public override bool IsRunning()
        {
            try
            {
                // Check if postgres process is running
                var procs = Process.GetProcessesByName("postgres");
                if (procs.Length > 0)
                    return true;

                // Also check service status
                PostgreSQLController.Refresh();
                return PostgreSQLController.Status == ServiceControllerStatus.Running;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

