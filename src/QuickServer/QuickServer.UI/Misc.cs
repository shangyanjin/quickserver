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
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace QuickServer.UI
{
    class Misc
    {
        private const uint IO_REPARSE_TAG_SYMLINK = 0xA000000C;

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        struct WIN32_FIND_DATA
        {
            public uint dwFileAttributes;
            public System.Runtime.InteropServices.ComTypes.FILETIME ftCreationTime;
            public System.Runtime.InteropServices.ComTypes.FILETIME ftLastAccessTime;
            public System.Runtime.InteropServices.ComTypes.FILETIME ftLastWriteTime;
            public uint nFileSizeHigh;
            public uint nFileSizeLow;
            public uint dwReserved0;
            public uint dwReserved1;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string cFileName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
            public string cAlternateFileName;
        }

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr FindFirstFile(string lpFileName, out WIN32_FIND_DATA lpFindFileData);

        [Flags]
        public enum SYMBOLIC_LINK_FLAG
        {
            File = 0,
            Directory = 1,
            AllowUnprivilegedCreate = 2
        }

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.I1)]
        private static extern bool CreateSymbolicLink(string lpSymlinkFileName, string lpTargetFileName, SYMBOLIC_LINK_FLAG dwFlags);

        private static bool IsSymbolic(string path)
        {
            FileInfo pathInfo = new FileInfo(path);
            if (pathInfo.Attributes.HasFlag(FileAttributes.ReparsePoint))
            {
                WIN32_FIND_DATA FindFileData;
                FindFirstFile(path, out FindFileData);
                if (FindFileData.dwReserved0 == IO_REPARSE_TAG_SYMLINK)
                    return true;
            }
            return false;
        }

        public static bool CreateRelativeLink(string lpSymlinkFileName, string lpTargetFileName, SYMBOLIC_LINK_FLAG dwFlags, bool deleteOldLink=false)
        {
            if (Directory.Exists(lpSymlinkFileName) && !IsSymbolic(lpSymlinkFileName))
            {
                try
                {
                    Directory.Move(lpSymlinkFileName, lpSymlinkFileName + ".old");
                    Log.Notice("Moved " + lpSymlinkFileName + " to " + lpSymlinkFileName + ".old");
                }
                catch (Exception ex)
                {
                    Log.Notice(ex.Message);
                }
            }
            else if (Directory.Exists(lpSymlinkFileName) && IsSymbolic(lpSymlinkFileName))
            {
                if (!deleteOldLink)
                {
                    return true;
                }

                Directory.Delete(lpSymlinkFileName);
            }
            return CreateSymbolicLink(lpSymlinkFileName, lpTargetFileName, dwFlags);
        }

        public static void StartProcessAsync(string filename, string args = "")
        {
            new Thread(() => {
                Process.Start(filename, args);
            }).Start();
        }
        public static void OpenFileEditor(string file)
        {
            try {
                Process.Start(Properties.Settings.Default.TextEditor, file);
            } catch (Exception ex) {
                Log.Error(ex.Message);
            }
        }
    }
}
