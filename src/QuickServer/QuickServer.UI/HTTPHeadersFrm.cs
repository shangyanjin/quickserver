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
using System.Net;
using System.Windows.Forms;

namespace QuickServer.UI
{
    public partial class HTTPHeadersFrm : Form
    {
        public HTTPHeadersFrm()
        {
            InitializeComponent();
        }

        private void GetHeadersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            httpHeadersListView.Items.Clear();
            try {
                var request = (HttpWebRequest)WebRequest.Create(urlTextBox.Text);
                request.Method = "GET";
                request.ContentType = "application/x-www-form-urlencoded";
                using (var response = request.GetResponse()) {
                    foreach (var str in response.Headers.AllKeys) {
                        var item = new ListViewItem(str);
                        item.SubItems.Add(response.Headers[str]);
                        httpHeadersListView.Items.Add(item);
                    }
                }
            } catch (Exception ex) {
                Log.Error(ex.Message);
            }
        }
    }
}
