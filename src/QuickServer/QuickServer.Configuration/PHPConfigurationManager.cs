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
using System.IO;
using System.Text.RegularExpressions;

namespace QuickServer.Configuration
{
    class PHPConfigurationManager
    {
        public class PHPExtension
        {
            public int LineNum;
            public string Name;
            public bool Enabled;
            public bool ZendExtension;
        }

        public List<PHPExtension> PHPExtensions;

        private string IniFilePath;
        private string[] TmpIniFile;

        public void LoadPHPExtensions(string phpBinPath)
        {
            IniFilePath = Program.StartupPath + "\\php-bins\\" + phpBinPath + "\\php.ini";
            TmpIniFile = File.ReadAllLines(IniFilePath);
            PHPExtensions = new List<PHPExtension>();

            for (int linenum = 0; linenum < TmpIniFile.Length; linenum++) {
                string str = TmpIniFile[linenum].Trim();
                if (str == String.Empty)
                    continue;
                if (str[0] == ';') {
                    string tmp = str.Substring(1);
                    if (!tmp.StartsWith("extension") && !tmp.StartsWith("zend_extension"))
                        continue;
                }
                // (zend_extension|extension)\s*\=\s*["]?(.*?\.dll)
                var m = Regex.Match(str, @"(zend_extension|extension)(=)((?:[a-z][a-z0-9_]*))");
                if (m.Success) {
                    PHPExtension Ext = new PHPExtension() {
                        Name = m.Groups[3].Value,
                        ZendExtension = m.Groups[1].Value == "zend_extension",
                        Enabled = str[0] != ';',
                        LineNum = linenum,
                    };
                    PHPExtensions.Add(Ext);
                }
            }
        }

        public void SavePHPIniOptions()
        {
            foreach (var ext in PHPExtensions) {
                string extension_token = ext.ZendExtension ? "zend_extension" : "extension";
                TmpIniFile[ext.LineNum] = String.Format("{0}{1}={2}", ext.Enabled ? "" : ";", extension_token, ext.Name);
            }
            File.WriteAllLines(IniFilePath, TmpIniFile);
        }
    }
}
