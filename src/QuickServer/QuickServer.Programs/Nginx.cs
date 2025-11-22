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

namespace QuickServer.Programs
{
    public class NginxProgram : QuickServerProgram
    {
        public NginxProgram(string exeFile) : base(exeFile)
        {
        }

        public override void Restart()
        {
            try
            {
                StartProcess(ExeFileName, "-s reload", WorkingDir);
                Log.Notice("Started", ProgLogSection);
            }
            catch (Exception ex)
            {
                Log.Error("Start():" + ex.Message, ProgLogSection);
            }
        }

        public void GenerateSSLKeyPair()
        {
            try
            {
                StartProcess(ExeFileName, "-b", WorkingDir);
                Log.Notice("Generated SSL Keypair", ProgLogSection);
            }
            catch (Exception ex)
            {
                Log.Error("Failed to generate SSL Keypair: " + ex.Message, ProgLogSection);
            }
        }
    }
}
