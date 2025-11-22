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
using System.Linq;
using System.Windows.Forms;
using QuickServer.Programs;

namespace QuickServer.UI
{
    partial class SetupMariaDB : Form
    {
        private readonly string dataDirectory = Program.StartupPath + "\\mariadb\\data";
        private readonly string installExe = Program.StartupPath + "\\mariadb\\bin\\mysql_install_db.exe";
        private readonly MariaDBProgram MariaDB;

        public SetupMariaDB(MariaDBProgram mariaDB)
        {
            MariaDB = mariaDB;
            InitializeComponent();
        }

        private void setupButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(rootPasswordTextBox.Text) || rootPasswordTextBox.Text.Any(Char.IsWhiteSpace)) {
                MessageBox.Show("Password may not be blank or contain spaces.", "Invalid Password Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MariaDB.RemoveService();
            string args = $"--service={MariaDBProgram.ServiceName} --password={rootPasswordTextBox.Text}";
            if (allowRemoteRootAccessCheckbox.Checked) {
                args += " --allow-remote-root-access";
            }
            QuickServerProgram.StartProcessAsAdmin(installExe, args, true);
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            rootPasswordTextBox.UseSystemPasswordChar = !rootPasswordTextBox.UseSystemPasswordChar;
        }

        private void SetupMariaDB_Shown(object sender, EventArgs e)
        {
            if (Directory.Exists(dataDirectory)) {
                DialogResult result = MessageBox.Show("The MariaDB data directory \'" + dataDirectory + "\' already exists, to continue with the setup it will be deleted. Is that OK? Please backup any data that you don't want lost in that directory before proceeding.", "MariaDB Setup", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) {
                    Close();
                    return;
                }
                else
                {
                    try {
                        Directory.Delete(dataDirectory, true);
                    } catch (Exception ex) {
                        Log.Error(ex.Message);
                    }
                }

            }
        }
    }
}
