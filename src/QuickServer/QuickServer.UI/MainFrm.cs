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
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using QuickServer.Programs;
using QuickServer.Updater;
using QuickServer.UI;

namespace QuickServer.UI
{
    public partial class MainFrm : Form
    {
        protected override CreateParams CreateParams
        {
            get {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~0x00040000; // Remove WS_THICKFRAME (Disables resizing)
                return cp;
            }
        }

        public NginxProgram Nginx;
        public MariaDBProgram MariaDB;
        public PHPProgram PHP;
        public PostgreSQLProgram PostgreSQL;
        public RedisProgram Redis;

        ContextMenuStrip NginxConfigContextMenuStrip, NginxLogContextMenuStrip;
        ContextMenuStrip MariaDBConfigContextMenuStrip, MariaDBLogContextMenuStrip;
        ContextMenuStrip PHPConfigContextMenuStrip, PHPLogContextMenuStrip;
        ContextMenuStrip PostgreSQLConfigContextMenuStrip, PostgreSQLLogContextMenuStrip;
        ContextMenuStrip RedisConfigContextMenuStrip, RedisLogContextMenuStrip;
        private QuickServerUpdater updater;
        private NotifyIcon ni = new NotifyIcon();
        private bool visiblecore = true;

        public void SetupNginx()
        {
            Nginx = new NginxProgram(Program.StartupPath + "\\nginx\\nginx.exe") {
                ProgLogSection = Log.LogSection.Nginx,
                StartArgs = "",
                StopArgs = "-s stop",
                ConfDir = Program.StartupPath + "\\nginx\\conf\\",
                LogDir = Program.StartupPath + "\\nginx\\logs\\",
                WorkingDir = Program.StartupPath + "\\nginx"
            };
        }

        public void SetupMariaDB()
        {
            MariaDB = new MariaDBProgram(Program.StartupPath + "\\mariadb\\bin\\mysqld.exe") {
                ProgLogSection = Log.LogSection.MariaDB,
                StartArgs = "--install-manual QuickServer-MariaDB",
                StopArgs = "/c sc delete QuickServer-MariaDB",
                ConfDir = Program.StartupPath + "\\mariadb\\data\\",
                LogDir = Program.StartupPath + "\\mariadb\\data\\",
                WorkingDir = Program.StartupPath + "\\mariadb"
            };
        }

        public void SetupPHP()
        {
            PHP = new PHPProgram(Program.StartupPath + "\\php\\php-cgi.exe") {
                ProgLogSection = Log.LogSection.PHP,
                ConfDir = Program.StartupPath + "\\php\\",
                LogDir = Program.StartupPath + "\\php\\logs\\",
                WorkingDir = Program.StartupPath + "\\php"
            };
            SetCurlCAPath();
        }

        public void SetupPostgreSQL()
        {
            string pgCtlExe = Program.StartupPath + "\\pgsql\\bin\\pg_ctl.exe";
            if (!File.Exists(pgCtlExe))
            {
                pgCtlExe = Program.StartupPath + "\\pgsql\\bin\\postgres.exe";
            }

            PostgreSQL = new PostgreSQLProgram(pgCtlExe)
            {
                ProgLogSection = Log.LogSection.PostgreSQL,
                StartArgs = "start -D \"" + Program.StartupPath + "\\pgsql\\data\" -w",
                StopArgs = "/c sc delete " + PostgreSQLProgram.ServiceName,
                ConfDir = Program.StartupPath + "\\pgsql\\conf\\",
                LogDir = Program.StartupPath + "\\pgsql\\data\\log\\",
                WorkingDir = Program.StartupPath + "\\pgsql"
            };
        }

        public void SetupRedis()
        {
            Redis = new RedisProgram(Program.StartupPath + "\\redis\\redis-server.exe")
            {
                ProgLogSection = Log.LogSection.Redis,
                StartArgs = Program.StartupPath + "\\redis\\redis.conf",
                StopArgs = null,
                ConfDir = Program.StartupPath + "\\redis\\",
                LogDir = Program.StartupPath + "\\redis\\logs\\",
                WorkingDir = Program.StartupPath + "\\redis"
            };
        }

        private void AddToSystemPath()
        {
            try
            {
                string currentPath = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Process);
                var pathsToAdd = new Dictionary<string, string>
                {
                    { Program.StartupPath + "\\nginx", "Nginx" },
                    { Program.StartupPath + "\\mariadb\\bin", "MariaDB" },
                    { Program.StartupPath + "\\php", "PHP" },
                    { Program.StartupPath + "\\pgsql\\bin", "PostgreSQL" },
                    { Program.StartupPath + "\\redis", "Redis" }
                };

                string newPath = currentPath;
                bool pathChanged = false;

                foreach (var kvp in pathsToAdd)
                {
                    string path = kvp.Key;
                    string serviceName = kvp.Value;
                    
                    if (Directory.Exists(path) && !currentPath.Contains(path))
                    {
                        newPath += ";" + path;
                        pathChanged = true;
                        Log.Notice("Added " + serviceName + " to PATH", Log.LogSection.QuickServer);
                    }
                }

                if (pathChanged)
                {
                    Environment.SetEnvironmentVariable("PATH", newPath, EnvironmentVariableTarget.Process);
                }
            }
            catch (Exception ex)
            {
                Log.Error("AddToSystemPath(): " + ex.Message, Log.LogSection.QuickServer);
            }
        }

        private void SetCurlCAPath()
        {
            string phpini = Program.StartupPath + "\\php\\php.ini";
            if (!File.Exists(phpini))
                return;

            string[] file = File.ReadAllLines(phpini);
            for (int i = 0; i < file.Length; i++) {
                if (file[i].Contains("curl.cainfo") == false)
                    continue;

                Regex reg = new Regex("(curl\\.cainfo).*?(=)");
                string orginal = reg.Match(file[i]).ToString();
                if (orginal == String.Empty)
                    continue;
                string replace = "curl.cainfo = " + "\"" + Program.StartupPath + @"\contrib\cacert.pem" + "\"";
                file[i] = replace;
            }
            using (var sw = new StreamWriter(phpini)) {
                foreach (var line in file)
                    sw.WriteLine(line);
            }
        }

        /// <summary>
        /// Adds configuration files or log files to a context menu strip
        /// </summary>
        private void DirFiles(string path, string directory, ContextMenuStrip cms)
        {
            var dInfo = new DirectoryInfo(path);

            if (!dInfo.Exists)
                return;

            cms.Items.Clear();

            var files = dInfo.GetFiles(directory);
            foreach (var file in files) {
                cms.Items.Add(file.Name);
            }
        }

        private void SetupConfigAndLogMenuStrips()
        {
            NginxConfigContextMenuStrip = new ContextMenuStrip();
            NginxConfigContextMenuStrip.ItemClicked += (s, e) => {
                Misc.OpenFileEditor(Nginx.ConfDir + e.ClickedItem.ToString());
            };
            NginxLogContextMenuStrip = new ContextMenuStrip();
            NginxLogContextMenuStrip.ItemClicked += (s, e) => {
                Misc.OpenFileEditor(Nginx.LogDir + e.ClickedItem.ToString());
            };
            MariaDBConfigContextMenuStrip = new ContextMenuStrip();
            MariaDBConfigContextMenuStrip.ItemClicked += (s, e) => {
                Misc.OpenFileEditor(MariaDB.ConfDir + e.ClickedItem.ToString());
            };
            MariaDBLogContextMenuStrip = new ContextMenuStrip();
            MariaDBLogContextMenuStrip.ItemClicked += (s, e) => {
                Misc.OpenFileEditor(MariaDB.LogDir + e.ClickedItem.ToString());
            };
            PHPConfigContextMenuStrip = new ContextMenuStrip();
            PHPConfigContextMenuStrip.ItemClicked += (s, e) => {
                Misc.OpenFileEditor(PHP.ConfDir + e.ClickedItem.ToString());
            };
            PHPLogContextMenuStrip = new ContextMenuStrip();
            PHPLogContextMenuStrip.ItemClicked += (s, e) => {
                Misc.OpenFileEditor(PHP.LogDir + e.ClickedItem.ToString());
            };

            PostgreSQLConfigContextMenuStrip = new ContextMenuStrip();
            PostgreSQLConfigContextMenuStrip.ItemClicked += (s, e) => {
                Misc.OpenFileEditor(PostgreSQL.ConfDir + e.ClickedItem.ToString());
            };
            PostgreSQLLogContextMenuStrip = new ContextMenuStrip();
            PostgreSQLLogContextMenuStrip.ItemClicked += (s, e) => {
                Misc.OpenFileEditor(PostgreSQL.LogDir + e.ClickedItem.ToString());
            };

            RedisConfigContextMenuStrip = new ContextMenuStrip();
            RedisConfigContextMenuStrip.ItemClicked += (s, e) => {
                Misc.OpenFileEditor(Redis.ConfDir + e.ClickedItem.ToString());
            };
            RedisLogContextMenuStrip = new ContextMenuStrip();
            RedisLogContextMenuStrip.ItemClicked += (s, e) => {
                Misc.OpenFileEditor(Redis.LogDir + e.ClickedItem.ToString());
            };

        }

        private void CreateQuickServerCertificate()
        {
            if (!Directory.Exists(Nginx.ConfDir))
                Directory.CreateDirectory(Nginx.ConfDir);

            string keyFile = Nginx.ConfDir + "\\key.pem";
            string certFile = Nginx.ConfDir + "\\cert.pem";

            if (File.Exists(keyFile) && File.Exists(certFile))
                return;

            Nginx.GenerateSSLKeyPair();
        }

        private MenuItem CreateQuickServerProgramMenuItem(QuickServerProgram prog)
        {
            MenuItem item = new MenuItem();

            item.Text = Log.LogSectionToString(prog.ProgLogSection);
            MenuItem start = item.MenuItems.Add("Start");
            start.Click += (s, e) => { prog.Start(); };
            MenuItem stop = item.MenuItems.Add("Stop");
            stop.Click += (s, e) => { prog.Stop(); };
            MenuItem restart = item.MenuItems.Add("Restart");
            restart.Click += (s, e) => { prog.Restart(); };

            return item;
        }

        private void SetupTrayMenu()
        {
            MenuItem controlpanel = new MenuItem("QuickServer Control Panel");
            controlpanel.Click += (s, e) => {
                visiblecore = true;
                base.SetVisibleCore(true);
                WindowState = FormWindowState.Normal;
                Show();
            };
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add(controlpanel);
            cm.MenuItems.Add("-");
            cm.MenuItems.Add(CreateQuickServerProgramMenuItem(Nginx));
            cm.MenuItems.Add(CreateQuickServerProgramMenuItem(MariaDB));
            cm.MenuItems.Add(CreateQuickServerProgramMenuItem(PHP));
            cm.MenuItems.Add(CreateQuickServerProgramMenuItem(PostgreSQL));
            cm.MenuItems.Add(CreateQuickServerProgramMenuItem(Redis));
            cm.MenuItems.Add("-");
            MenuItem exit = new MenuItem("Exit");
            exit.Click += (s, e) => { Application.Exit(); };
            cm.MenuItems.Add(exit);
            cm.MenuItems.Add("-");
            ni.ContextMenu = cm;
            ni.Icon = Properties.Resources.logo;
            ni.Click += (s, e) => {
                visiblecore = true;
                base.SetVisibleCore(true);
                WindowState = FormWindowState.Normal;
                Show();
            };
            ni.Visible = true;
        }

        protected override void SetVisibleCore(bool value)
        {
            if (visiblecore == false) {
                value = false;
                if (!IsHandleCreated)
                    CreateHandle();
            }
            base.SetVisibleCore(value);
        }

        public MainFrm()
        {
            if (Properties.Settings.Default.StartMinimizedToTray) {
                Visible = false;
                Hide();
            }
            InitializeComponent();
            Log.SetLogComponent(logRichTextBox);
            Log.Notice("Initializing Control Panel");
            Log.Notice("QuickServer Version: " + Application.ProductVersion);
            Log.Notice("QuickServer Directory: " + Program.StartupPath);

            SetupNginx();
            SetupMariaDB();
            SetupPHP();
            SetupPostgreSQL();
            SetupRedis();
            
            AddToSystemPath();

            if (!File.Exists(Program.StartupPath + "\\www"))
            {
                Misc.CreateRelativeLink(Program.StartupPath + "\\www", Program.StartupPath + "\\nginx\\www", Misc.SYMBOLIC_LINK_FLAG.Directory);
            }

            SetupConfigAndLogMenuStrips();
            SetupTrayMenu();
            updater = new QuickServerUpdater(this);

            try
            {
                CreateQuickServerCertificate();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }

            if (Properties.Settings.Default.StartMinimizedToTray) {
                visiblecore = false;
                base.SetVisibleCore(false);
            }

            if (Properties.Settings.Default.StartNginxOnLaunch)
            {
                Nginx.Start();
            }

            if (Properties.Settings.Default.StartMariaDBOnLaunch)
            {
                MariaDB.Start();
            }

            if (Properties.Settings.Default.StartPHPOnLaunch)
            {
                PHP.Start();
            }

            if (Properties.Settings.Default.StartPostgreSQLOnLaunch)
            {
                PostgreSQL.Start();
            }

            if (Properties.Settings.Default.StartRedisOnLaunch)
            {
                Redis.Start();
            }
        }

        /* Menu */

        /* File */

        private void QuickServerOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var optionForm = new OptionsFrm(this);
            optionForm.ShowDialog(this);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /* Applications Group Box */

        private void CtxButton(object sender, ContextMenuStrip contextMenuStrip)
        {
            var btnSender = (Button)sender;
            var ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            contextMenuStrip.Show(ptLowerLeft);
        }

        private void NginxStartButton_Click(object sender, EventArgs e)
        {
            Nginx.Start();
        }

        private void MariadbStartButton_Click(object sender, EventArgs e)
        {
            MariaDB.Start();
        }

        private void PhpStartButton_Click(object sender, EventArgs e)
        {
            PHP.Start();
        }

        private void NginxStopButton_Click(object sender, EventArgs e)
        {
            Nginx.Stop();
        }

        private void MariadbStopButton_Click(object sender, EventArgs e)
        {
            MariaDB.Stop();
        }

        private void PhpStopButton_Click(object sender, EventArgs e)
        {
            PHP.Stop();
        }

        private void NginxRestartButton_Click(object sender, EventArgs e)
        {
            Nginx.Restart();
        }

        private void MariadbRestartButton_Click(object sender, EventArgs e)
        {
            MariaDB.Restart();
        }

        private void PhpRestartButton_Click(object sender, EventArgs e)
        {
            PHP.Restart();
        }

        private void NginxConfigButton_Click(object sender, EventArgs e)
        {
            try
            {
                DirFiles(Nginx.ConfDir, "*.conf", NginxConfigContextMenuStrip);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            CtxButton(sender, NginxConfigContextMenuStrip);
        }

        private void MariadbConfigButton_Click(object sender, EventArgs e)
        {
            try
            {
                DirFiles(MariaDB.ConfDir, "my.ini", MariaDBConfigContextMenuStrip);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            CtxButton(sender, MariaDBConfigContextMenuStrip);
        }

        private void PhpConfigButton_Click(object sender, EventArgs e)
        {
            try
            {
                DirFiles(PHP.ConfDir, "php.ini", PHPConfigContextMenuStrip);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            CtxButton(sender, PHPConfigContextMenuStrip);
        }

        private void NginxLogButton_Click(object sender, EventArgs e)
        {
            try
            {
                DirFiles(Nginx.LogDir, "*.log", NginxLogContextMenuStrip);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            CtxButton(sender, NginxLogContextMenuStrip);
        }

        private void MariadbLogButton_Click(object sender, EventArgs e)
        {
            try
            {
                DirFiles(MariaDB.LogDir, "*.err", MariaDBLogContextMenuStrip);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            CtxButton(sender, MariaDBLogContextMenuStrip);
        }

        private void PhpLogButton_Click(object sender, EventArgs e)
        {
            try
            {
                DirFiles(PHP.LogDir, "*.log", PHPLogContextMenuStrip);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            CtxButton(sender, PHPLogContextMenuStrip);
        }

        private void PostgresqlStartButton_Click(object sender, EventArgs e)
        {
            PostgreSQL.Start();
        }

        private void PostgresqlStopButton_Click(object sender, EventArgs e)
        {
            PostgreSQL.Stop();
        }

        private void PostgresqlRestartButton_Click(object sender, EventArgs e)
        {
            PostgreSQL.Restart();
        }

        private void PostgresqlConfigButton_Click(object sender, EventArgs e)
        {
            try
            {
                DirFiles(PostgreSQL.ConfDir, "*.conf", PostgreSQLConfigContextMenuStrip);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            CtxButton(sender, PostgreSQLConfigContextMenuStrip);
        }

        private void PostgresqlLogButton_Click(object sender, EventArgs e)
        {
            try
            {
                DirFiles(PostgreSQL.LogDir, "*.log", PostgreSQLLogContextMenuStrip);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            CtxButton(sender, PostgreSQLLogContextMenuStrip);
        }

        private void RedisStartButton_Click(object sender, EventArgs e)
        {
            Redis.Start();
        }

        private void RedisStopButton_Click(object sender, EventArgs e)
        {
            Redis.Stop();
        }

        private void RedisRestartButton_Click(object sender, EventArgs e)
        {
            Redis.Restart();
        }

        private void RedisConfigButton_Click(object sender, EventArgs e)
        {
            try
            {
                DirFiles(Redis.ConfDir, "*.conf", RedisConfigContextMenuStrip);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            CtxButton(sender, RedisConfigContextMenuStrip);
        }

        private void RedisLogButton_Click(object sender, EventArgs e)
        {
            try
            {
                DirFiles(Redis.LogDir, "*.log", RedisLogContextMenuStrip);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            CtxButton(sender, RedisLogContextMenuStrip);
        }

        /* */

        public void StopAll()
        {
            Nginx.Stop();
            MariaDB.Stop();
            PHP.Stop();
            PostgreSQL.Stop();
            Redis.Stop();
        }

        private void StartAllButton_Click(object sender, EventArgs e)
        {
            Redis.Start();
            PostgreSQL.Start();
            Nginx.Start();
            MariaDB.Start();
            PHP.Start();
        }

        private void StopAllButton_Click(object sender, EventArgs e)
        {
            StopAll();
        }

        private void CheckForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updater.CheckForUpdates();
        }

        private void GetHTTPHeadersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HTTPHeadersFrm httpHeadersFrm = new HTTPHeadersFrm() {
                StartPosition = FormStartPosition.CenterParent
            };
            httpHeadersFrm.Show(this);
        }

        private void HostToIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HostToIPFrm hostToIPFrm = new HostToIPFrm() {
                StartPosition = FormStartPosition.CenterParent
            };
            hostToIPFrm.Show(this);
        }

        private void SupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Misc.StartProcessAsync("https://groups.google.com/forum/#!forum/wnmp-users");
        }

        private void WebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Misc.StartProcessAsync("https://wnmp.x64architecture.com");
        }

        private void DonateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Misc.StartProcessAsync("https://wnmp.x64architecture.com/donate");
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutFrm = new AboutFrm() {
                StartPosition = FormStartPosition.CenterParent
            };
            aboutFrm.ShowDialog(this);
        }

        private void ReportBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Misc.StartProcessAsync("https://github.com/wnmp/wnmp/issues/new");
        }

        private void SetRunningStatusLabel(Label label, bool running)
        {
            if (running) {
                label.Text = "?";
                label.ForeColor = Color.Green;
            } else {
                label.Text = "X";
                label.ForeColor = Color.DarkRed;
            }
        }

        private void AppsRunningTimer_Tick(object sender, EventArgs e)
        {
            SetRunningStatusLabel(nginxrunning, Nginx.IsRunning());
            SetRunningStatusLabel(phprunning, PHP.IsRunning());
            SetRunningStatusLabel(mariadbrunning, MariaDB.IsRunning());
            SetRunningStatusLabel(postgresqlrunning, PostgreSQL.IsRunning());
            SetRunningStatusLabel(redisrunning, Redis.IsRunning());
        }

        private void LocalhostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Misc.StartProcessAsync("http://localhost");
        }

        private void OpenMariaDBShellButton_Click(object sender, EventArgs e)
        {
            MariaDB.OpenShell();
        }

        private void setupMariaDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var setupMariaDBFrm = new SetupMariaDB(MariaDB))
            {
                setupMariaDBFrm.StartPosition = FormStartPosition.CenterParent;
                setupMariaDBFrm.ShowDialog(this);
            }
        }

        private void QuickServerDirButton_Click(object sender, EventArgs e)
        {
            Misc.StartProcessAsync("explorer.exe", Program.StartupPath);
        }

        private void MainFrm_Shown(object sender, EventArgs e)
        {
            // MariaDB setup window is no longer automatically opened on startup
            // Users can access it via the "Setup MariaDB" menu item if needed
            /*
            if (!Properties.Settings.Default.MariaDBIsSetup || !Directory.Exists(Program.StartupPath + "\\mariadb\\data"))
            {
                using (var setupMariaDBFrm = new SetupMariaDB(MariaDB))
                {
                    setupMariaDBFrm.StartPosition = FormStartPosition.CenterParent;
                    setupMariaDBFrm.ShowDialog(this);
                }
                if (!Properties.Settings.Default.MariaDBIsSetup)
                {
                    Properties.Settings.Default.MariaDBIsSetup = true;
                    Properties.Settings.Default.Save();
                }
                SetupConfigAndLogMenuStrips();
            }
            */
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && Properties.Settings.Default.MinimizeInsteadOfClosing) {
                e.Cancel = true;
                Hide();
            } else {
                Properties.Settings.Default.Save();
            }
        }

        private void MainFrm_Resize(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MinimizeToTray == false)
                return;

            if (WindowState == FormWindowState.Minimized)
                Hide();
        }
    }
}
