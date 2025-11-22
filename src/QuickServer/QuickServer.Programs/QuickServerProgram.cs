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

using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace QuickServer.Programs
{
    public class QuickServerProgram
    {
        public string ExeFileName { get; set; }            // Location of the executable file
        public Log.LogSection ProgLogSection { get; set; } // LogSection of the program
        public string StartArgs { get; set; }              // Start Arguments
        public string StopArgs { get; set; }               // Stop Arguments
        public string ConfDir { get; set; }                // Directory where all the programs configuration files are
        public string LogDir { get; set; }                 // Directory where all the programs log files are
        public string WorkingDir { get; set; }             // Working directory of the program

        private string processName;

        public QuickServerProgram(string exeFile)
        {
            ExeFileName = exeFile;
            processName = Path.GetFileNameWithoutExtension(ExeFileName);
        }

        public static void StartProcess(
            string exe,
            string args,
            string workingDir = null,
            bool waitforexit = false,
            Dictionary<string, string> envvariables = null)
        {
            using (Process process = new Process())
            {
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                if (workingDir == null)
                {
                    workingDir = Program.StartupPath;
                }
                process.StartInfo.WorkingDirectory = workingDir;
                process.StartInfo.FileName = exe;
                process.StartInfo.Arguments = args;
                if (envvariables != null)
                {
                    foreach (var v in envvariables)
                        process.StartInfo.EnvironmentVariables.Add(v.Key, v.Value);
                }
                process.Start();
                if (waitforexit)
                    process.WaitForExit();
            }
        }

        public static void StartProcessAsAdmin(
            string exe,
            string args,
            bool waitforexit = false)
        {
            using (Process process = new Process())
            {
                process.StartInfo.WorkingDirectory = Program.StartupPath;
                process.StartInfo.FileName = exe;
                process.StartInfo.Arguments = args;
                process.StartInfo.Verb = "runas";
                process.Start();
                if (waitforexit)
                    process.WaitForExit();
            }
        }

        public virtual void Start()
        {
            if (!File.Exists(ExeFileName)) {
                Log.Error("File " + ExeFileName + " not found.", ProgLogSection);
                return;
            }
            if (IsRunning()) {
                Log.Error("Already running.", ProgLogSection);
                return;
            }
            StartProcess(ExeFileName, StartArgs, WorkingDir);
            Log.Notice("Started", ProgLogSection);
        }

        public virtual void Stop()
        {
            if (!File.Exists(ExeFileName)) {
                Log.Error("File " + ExeFileName + " not found.", ProgLogSection);
                return;
            }
            if (!IsRunning()) {
                Log.Error("Not running.", ProgLogSection);
                return;
            }
            if (StopArgs != null) {
                StartProcess(ExeFileName, StopArgs, WorkingDir, true);
            }
            var procs = Process.GetProcessesByName(processName);
            for (var i = 0; i < procs.Length; i++) {
                procs[i].Kill();
            }
            Log.Notice("Stopped", ProgLogSection);
        }

        public virtual void Restart()
        {

            Stop();
            Thread.Sleep(1000);
            Start();
            Log.Notice("Restarted", ProgLogSection);
        }

        public virtual bool IsRunning()
        {
            return Process.GetProcessesByName(processName).Length != 0;
        }
    }
}
