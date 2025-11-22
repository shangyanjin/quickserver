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
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;

namespace QuickServer.Programs
{
    public class PHPProgram : QuickServerProgram
    {
        private Socket sock;
        public PHPProgram(string exeFile) : base(exeFile)
        {

        }

        public override void Start()
        {
            uint ProcessCount = Properties.Settings.Default.PHPProcessCount;
            ushort port = Properties.Settings.Default.PHPPort;
            string phpini = Program.StartupPath + "\\php\\php.ini";

            if (IsRunning()) {
                Log.Error("Already running.", ProgLogSection);
                return;
            }

            try {
                if (sock != null)
                    sock.Close();
                sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                sock.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                sock.Bind(new IPEndPoint(IPAddress.Any, port));
                sock.Listen(16384);
                var env_vars = new Dictionary<string, string>
                {
                    { "PHP_FCGI_MAX_REQUESTS", "0" }
                };


                for (var i = 1; i <= ProcessCount; i++)
                {

                    StartProcess(ExeFileName, $"-b localhost:{port} -c {phpini}", WorkingDir, false, env_vars);
                    Log.Notice("Starting PHP " + i + "/" + ProcessCount, ProgLogSection);
                }
                Log.Notice("PHP started", ProgLogSection);
            }
            catch (Exception ex)
            {
                Log.Error("StartPHP(): " + ex.Message, ProgLogSection);
            }
        }
    }
}
