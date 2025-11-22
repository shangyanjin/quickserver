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
using System.Windows.Forms;

namespace QuickServer.Updater
{
    public partial class UpdatePromptFrm : Form
    {
        private string changeLogUrl;

        protected override CreateParams CreateParams
        {
            get {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~0x00040000; // Remove WS_THICKFRAME (Disables resizing)
                return cp;
            }
        }

        public UpdatePromptFrm(string ChangeLogUrl, Version CurrentVersion, Version NewVersion)
        {
            InitializeComponent();
            changeLogUrl = ChangeLogUrl;
            currentVersionLabel.Text = CurrentVersion.ToString();
            newVersionLabel.Text = NewVersion.ToString();
        }

        private void ViewChangelogLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(changeLogUrl);
        }

        private void YesButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void NoButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}
