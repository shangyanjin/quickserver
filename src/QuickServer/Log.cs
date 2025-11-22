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
using System.Drawing;
using System.Windows.Forms;

namespace QuickServer
{
    /// <summary>
    /// Logs information and errors to a RichTextBox
    /// </summary>
    public static class Log
    {
        private static RichTextBox rtfLog;

        public enum LogSection
        {
            QuickServer,
            Nginx,
            MariaDB,
            PHP,
            PostgreSQL,
            Redis,
        }

        public static string LogSectionToString(LogSection logSection)
        {
            switch (logSection) {
                case LogSection.QuickServer:
                    return "QuickServer";
                case LogSection.Nginx:
                    return "Nginx";
                case LogSection.MariaDB:
                    return "MariaDB";
                case LogSection.PHP:
                    return "PHP";
                case LogSection.PostgreSQL:
                    return "PostgreSQL";
                case LogSection.Redis:
                    return "Redis";
                default:
                    return "";
            }
        }

        private static void QuickServerLog(string message, Color color, LogSection logSection)
        {
            string SectionName = LogSectionToString(logSection);
            string DateNow = DateTime.Now.ToString();
            string str = $"{DateNow} [{SectionName}] - {message}\n";
            int textLength = rtfLog.TextLength;
            rtfLog.AppendText(str);
            if (rtfLog.Find(SectionName, textLength, RichTextBoxFinds.MatchCase) != -1) {
                rtfLog.SelectionLength = SectionName.Length;
                rtfLog.SelectionColor = color;
            }

            rtfLog.ScrollToCaret();
            rtfLog.SelectionLength = 0;
        }
        /// <summary>
        /// Log error
        /// </summary>
        public static void Error(string message, LogSection logSection = LogSection.QuickServer)
        {
            QuickServerLog(message, Color.Red, logSection);
        }
        /// <summary>
        /// Log information
        /// </summary>
        public static void Notice(string message, LogSection section = LogSection.QuickServer)
        {
            QuickServerLog(message, Color.DarkBlue, section);
        }

        public static void SetLogComponent(RichTextBox logRichTextBox)
        {
            rtfLog = logRichTextBox;
            var logContextMenu = new ContextMenu();
            var CopyItem = new MenuItem("&Copy");
            CopyItem.Click += (s, e) => {
                if (rtfLog.SelectedText != String.Empty)
                    Clipboard.SetText(rtfLog.SelectedText);
            };
            logContextMenu.MenuItems.Add(CopyItem);
            rtfLog.ContextMenu = logContextMenu;
        }
    }
}
