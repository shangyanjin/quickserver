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
using System.Net.NetworkInformation;
using System.Xml;
using System.Windows.Forms;

using QuickServer.UI;

namespace QuickServer.Updater
{
    class Updater
    {
        public Version CurrentVersion { get; set; }
        public Uri UpdateInfoURL { get; set; }
        public string SaveFileName { get; set; }
        public bool UpdateAvailable { get; private set; }
        public Version NewVersion { get; private set; }

        private Uri updateDownloadURL;
        private UpdateProgressFrm updateProgress;
        private WebClient webClient;
        private Action updateDownloaded;
        private Action updateCanceled;

        /// <summary>
        /// Checks for update
        /// 
        /// Sets UpdateAvailable to true if an update was found and
        /// Sets UpdateAvailable to false if an update was not found
        /// </summary>
        public void CheckForUpdate()
        {
            if (!ReadUpdateXML()) {
                Log.Error("Couldn't read update information.");
                return;
            }

            UpdateAvailable = CurrentVersion.CompareTo(NewVersion) < 0;
        }

        /// <summary>
        /// Downloads Update
        /// </summary>
        public void Update(Action UpdateCanceled, Action UpdateDownloaded)
        {
            updateDownloaded = UpdateDownloaded;
            updateCanceled = UpdateCanceled;

            updateProgress = new UpdateProgressFrm();
            updateProgress.FormClosed += UpdateProgress_FormClosed;

            updateProgress.StartPosition = FormStartPosition.CenterParent;
            updateProgress.Show();

            webClient = new WebClient();
            webClient.DownloadProgressChanged += WebClient_DownloadProgressChanged;
            webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;

            webClient.DownloadFileAsync(updateDownloadURL, SaveFileName);
        }

        void UpdateProgress_FormClosed(object sender, FormClosedEventArgs e)
        {
            webClient.CancelAsync();
            updateCanceled();
        }

        void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            updateProgress.updateProgressBar.Value = e.ProgressPercentage;
            updateProgress.progressLabel.Text = e.ProgressPercentage.ToString() + "%";
        }

        void WebClient_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Cancelled) {
                webClient.Dispose();
                return;
            }
            webClient.Dispose();
            updateProgress.Close();
            updateDownloaded();
        }

        private bool ReadUpdateXML()
        {
            string elementName = "";

            try {
                var reader = new XmlTextReader(UpdateInfoURL.OriginalString);
                reader.MoveToContent();

                if ((reader.NodeType != XmlNodeType.Element) && (reader.Name != "appinfo"))
                    return false;

                while (reader.Read()) {
                    if (reader.NodeType == XmlNodeType.Element) {
                        elementName = reader.Name;
                    } else {
                        if ((reader.NodeType != XmlNodeType.Text) || !reader.HasValue)
                            continue;
                        switch (elementName) {
                            case "version":
                                NewVersion = new Version(reader.Value);
                                break;
                            case "upgradeurl":
                                updateDownloadURL = new Uri(reader.Value);
                                break;
                        }
                    }
                }

                return true;
            } catch (Exception ex) {
                Log.Error(ex.Message);
                return false;
            }
        }
    }
}