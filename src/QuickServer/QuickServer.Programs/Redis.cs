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

namespace QuickServer.Programs
{
    public class RedisProgram : QuickServerProgram
    {
        private string configFile;

        public RedisProgram(string exeFile) : base(exeFile)
        {
            configFile = Program.StartupPath + "\\redis\\redis.conf";
        }

        public void CreateDefaultConfig()
        {
            if (File.Exists(configFile))
                return;

            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(configFile));
                string dataDir = Program.StartupPath + "\\redis\\data";
                Directory.CreateDirectory(dataDir);
                string logDir = Program.StartupPath + "\\redis\\logs";
                Directory.CreateDirectory(logDir);

                string defaultConfig = "# Redis configuration file for QuickServer\n" +
                    "port 6379\n" +
                    "bind 127.0.0.1\n" +
                    "dir \"" + dataDir.Replace("\\", "/") + "\"\n" +
                    "logfile \"" + (logDir + "\\redis.log").Replace("\\", "/") + "\"\n" +
                    "save 900 1\n" +
                    "save 300 10\n" +
                    "save 60 10000\n";

                File.WriteAllText(configFile, defaultConfig);
                Log.Notice("Created default Redis configuration", ProgLogSection);
            }
            catch (Exception ex)
            {
                Log.Error("CreateDefaultConfig(): " + ex.Message, ProgLogSection);
            }
        }

        public void OpenShell()
        {
            if (IsRunning() == false)
                Start();

            try
            {
                string redisCliExe = Program.StartupPath + "\\redis\\redis-cli.exe";
                if (File.Exists(redisCliExe))
                {
                    System.Diagnostics.Process.Start(redisCliExe);
                    Log.Notice("Started Redis shell", ProgLogSection);
                }
                else
                {
                    Log.Error("redis-cli.exe not found", ProgLogSection);
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
                CreateDefaultConfig();
                StartProcess(ExeFileName, configFile, WorkingDir);
                Log.Notice("Started", ProgLogSection);
            }
            catch (Exception ex)
            {
                Log.Error("Start(): " + ex.Message, ProgLogSection);
            }
        }
    }
}

