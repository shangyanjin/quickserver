namespace QuickServer.UI
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.QuickServerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickServerOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hostToIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getHTTPHeadersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localhostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupMariaDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickServerDirButton = new System.Windows.Forms.Button();
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.applicationsGroupBox = new System.Windows.Forms.GroupBox();
            this.redisLogButton = new System.Windows.Forms.Button();
            this.redisConfigButton = new System.Windows.Forms.Button();
            this.redisRestartButton = new System.Windows.Forms.Button();
            this.redisStopButton = new System.Windows.Forms.Button();
            this.redisStartButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.redisrunning = new System.Windows.Forms.Label();
            this.postgresqlLogButton = new System.Windows.Forms.Button();
            this.postgresqlConfigButton = new System.Windows.Forms.Button();
            this.postgresqlRestartButton = new System.Windows.Forms.Button();
            this.postgresqlStopButton = new System.Windows.Forms.Button();
            this.postgresqlStartButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.postgresqlrunning = new System.Windows.Forms.Label();
            this.phpRestartButton = new System.Windows.Forms.Button();
            this.mariadbRestartButton = new System.Windows.Forms.Button();
            this.nginxRestartButton = new System.Windows.Forms.Button();
            this.phpLogButton = new System.Windows.Forms.Button();
            this.mariadbLogButton = new System.Windows.Forms.Button();
            this.nginxLogButton = new System.Windows.Forms.Button();
            this.phpConfigButton = new System.Windows.Forms.Button();
            this.mariadbConfigButton = new System.Windows.Forms.Button();
            this.nginxConfigButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.phprunning = new System.Windows.Forms.Label();
            this.mariadbrunning = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nginxrunning = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mariadbStopButton = new System.Windows.Forms.Button();
            this.mariadbStartButton = new System.Windows.Forms.Button();
            this.phpStartButton = new System.Windows.Forms.Button();
            this.phpStopButton = new System.Windows.Forms.Button();
            this.nginxStartButton = new System.Windows.Forms.Button();
            this.nginxStopButton = new System.Windows.Forms.Button();
            this.startAllButton = new System.Windows.Forms.Button();
            this.stopAllButton = new System.Windows.Forms.Button();
            this.openMariaDBShellButton = new System.Windows.Forms.Button();
            this.AppsRunningTimer = new System.Windows.Forms.Timer(this.components);
            this.QuickServerMenuStrip.SuspendLayout();
            this.applicationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuickServerMenuStrip
            // 
            this.QuickServerMenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.QuickServerMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.QuickServerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.localhostToolStripMenuItem,
            this.setupMariaDBToolStripMenuItem});
            this.QuickServerMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.QuickServerMenuStrip.Name = "QuickServerMenuStrip";
            this.QuickServerMenuStrip.Size = new System.Drawing.Size(1042, 34);
            this.QuickServerMenuStrip.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quickServerOptionsToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 28);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // quickServerOptionsToolStripMenuItem
            // 
            this.quickServerOptionsToolStripMenuItem.Name = "quickServerOptionsToolStripMenuItem";
            this.quickServerOptionsToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.quickServerOptionsToolStripMenuItem.Text = "QuickServer Options";
            this.quickServerOptionsToolStripMenuItem.Click += new System.EventHandler(this.QuickServerOptionsToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.checkForUpdatesToolStripMenuItem.Text = "Check For Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.CheckForUpdatesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(284, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(287, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hostToIPToolStripMenuItem,
            this.getHTTPHeadersToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(71, 28);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // hostToIPToolStripMenuItem
            // 
            this.hostToIPToolStripMenuItem.Name = "hostToIPToolStripMenuItem";
            this.hostToIPToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
            this.hostToIPToolStripMenuItem.Text = "Host To IP";
            this.hostToIPToolStripMenuItem.Click += new System.EventHandler(this.HostToIPToolStripMenuItem_Click);
            // 
            // getHTTPHeadersToolStripMenuItem
            // 
            this.getHTTPHeadersToolStripMenuItem.Name = "getHTTPHeadersToolStripMenuItem";
            this.getHTTPHeadersToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
            this.getHTTPHeadersToolStripMenuItem.Text = "Get HTTP Headers";
            this.getHTTPHeadersToolStripMenuItem.Click += new System.EventHandler(this.GetHTTPHeadersToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportToolStripMenuItem,
            this.reportBugToolStripMenuItem,
            this.toolStripSeparator2,
            this.websiteToolStripMenuItem,
            this.donateToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(67, 28);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            this.supportToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.supportToolStripMenuItem.Text = "Community Support";
            this.supportToolStripMenuItem.Click += new System.EventHandler(this.SupportToolStripMenuItem_Click);
            // 
            // reportBugToolStripMenuItem
            // 
            this.reportBugToolStripMenuItem.Name = "reportBugToolStripMenuItem";
            this.reportBugToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.reportBugToolStripMenuItem.Text = "Report Bug";
            this.reportBugToolStripMenuItem.Click += new System.EventHandler(this.ReportBugToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(283, 6);
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.websiteToolStripMenuItem.Text = "Website";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.WebsiteToolStripMenuItem_Click);
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.donateToolStripMenuItem.Text = "Donate";
            this.donateToolStripMenuItem.Click += new System.EventHandler(this.DonateToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // localhostToolStripMenuItem
            // 
            this.localhostToolStripMenuItem.Name = "localhostToolStripMenuItem";
            this.localhostToolStripMenuItem.Size = new System.Drawing.Size(103, 28);
            this.localhostToolStripMenuItem.Text = "localhost";
            this.localhostToolStripMenuItem.Click += new System.EventHandler(this.LocalhostToolStripMenuItem_Click);
            // 
            // setupMariaDBToolStripMenuItem
            // 
            this.setupMariaDBToolStripMenuItem.Name = "setupMariaDBToolStripMenuItem";
            this.setupMariaDBToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.setupMariaDBToolStripMenuItem.Text = "Setup MariaDB";
            this.setupMariaDBToolStripMenuItem.Click += new System.EventHandler(this.setupMariaDBToolStripMenuItem_Click);
            // 
            // quickServerDirButton
            // 
            this.quickServerDirButton.Location = new System.Drawing.Point(835, 232);
            this.quickServerDirButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.quickServerDirButton.Name = "quickServerDirButton";
            this.quickServerDirButton.Size = new System.Drawing.Size(142, 55);
            this.quickServerDirButton.TabIndex = 65;
            this.quickServerDirButton.Text = "QuickServer Directory";
            this.quickServerDirButton.UseVisualStyleBackColor = true;
            this.quickServerDirButton.Click += new System.EventHandler(this.QuickServerDirButton_Click);
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.BackColor = System.Drawing.Color.White;
            this.logRichTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logRichTextBox.Location = new System.Drawing.Point(0, 435);
            this.logRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.ReadOnly = true;
            this.logRichTextBox.Size = new System.Drawing.Size(1042, 183);
            this.logRichTextBox.TabIndex = 61;
            this.logRichTextBox.Text = "";
            // 
            // applicationsGroupBox
            // 
            this.applicationsGroupBox.Controls.Add(this.redisLogButton);
            this.applicationsGroupBox.Controls.Add(this.redisConfigButton);
            this.applicationsGroupBox.Controls.Add(this.redisRestartButton);
            this.applicationsGroupBox.Controls.Add(this.redisStopButton);
            this.applicationsGroupBox.Controls.Add(this.redisStartButton);
            this.applicationsGroupBox.Controls.Add(this.label10);
            this.applicationsGroupBox.Controls.Add(this.redisrunning);
            this.applicationsGroupBox.Controls.Add(this.postgresqlLogButton);
            this.applicationsGroupBox.Controls.Add(this.postgresqlConfigButton);
            this.applicationsGroupBox.Controls.Add(this.postgresqlRestartButton);
            this.applicationsGroupBox.Controls.Add(this.postgresqlStopButton);
            this.applicationsGroupBox.Controls.Add(this.postgresqlStartButton);
            this.applicationsGroupBox.Controls.Add(this.label9);
            this.applicationsGroupBox.Controls.Add(this.postgresqlrunning);
            this.applicationsGroupBox.Controls.Add(this.phpRestartButton);
            this.applicationsGroupBox.Controls.Add(this.mariadbRestartButton);
            this.applicationsGroupBox.Controls.Add(this.nginxRestartButton);
            this.applicationsGroupBox.Controls.Add(this.phpLogButton);
            this.applicationsGroupBox.Controls.Add(this.mariadbLogButton);
            this.applicationsGroupBox.Controls.Add(this.nginxLogButton);
            this.applicationsGroupBox.Controls.Add(this.phpConfigButton);
            this.applicationsGroupBox.Controls.Add(this.mariadbConfigButton);
            this.applicationsGroupBox.Controls.Add(this.nginxConfigButton);
            this.applicationsGroupBox.Controls.Add(this.label8);
            this.applicationsGroupBox.Controls.Add(this.label7);
            this.applicationsGroupBox.Controls.Add(this.phprunning);
            this.applicationsGroupBox.Controls.Add(this.mariadbrunning);
            this.applicationsGroupBox.Controls.Add(this.label6);
            this.applicationsGroupBox.Controls.Add(this.label4);
            this.applicationsGroupBox.Controls.Add(this.label3);
            this.applicationsGroupBox.Controls.Add(this.nginxrunning);
            this.applicationsGroupBox.Controls.Add(this.label1);
            this.applicationsGroupBox.Controls.Add(this.mariadbStopButton);
            this.applicationsGroupBox.Controls.Add(this.mariadbStartButton);
            this.applicationsGroupBox.Controls.Add(this.phpStartButton);
            this.applicationsGroupBox.Controls.Add(this.phpStopButton);
            this.applicationsGroupBox.Controls.Add(this.nginxStartButton);
            this.applicationsGroupBox.Controls.Add(this.nginxStopButton);
            this.applicationsGroupBox.Location = new System.Drawing.Point(18, 37);
            this.applicationsGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.applicationsGroupBox.Name = "applicationsGroupBox";
            this.applicationsGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.applicationsGroupBox.Size = new System.Drawing.Size(742, 360);
            this.applicationsGroupBox.TabIndex = 60;
            this.applicationsGroupBox.TabStop = false;
            this.applicationsGroupBox.Text = "Applications";
            // 
            // redisLogButton
            // 
            this.redisLogButton.Location = new System.Drawing.Point(632, 309);
            this.redisLogButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.redisLogButton.Name = "redisLogButton";
            this.redisLogButton.Size = new System.Drawing.Size(75, 39);
            this.redisLogButton.TabIndex = 92;
            this.redisLogButton.Text = "Logs";
            this.redisLogButton.UseVisualStyleBackColor = true;
            this.redisLogButton.Click += new System.EventHandler(this.RedisLogButton_Click);
            // 
            // redisConfigButton
            // 
            this.redisConfigButton.Location = new System.Drawing.Point(498, 309);
            this.redisConfigButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.redisConfigButton.Name = "redisConfigButton";
            this.redisConfigButton.Size = new System.Drawing.Size(124, 39);
            this.redisConfigButton.TabIndex = 91;
            this.redisConfigButton.Text = "Configuration";
            this.redisConfigButton.UseVisualStyleBackColor = true;
            this.redisConfigButton.Click += new System.EventHandler(this.RedisConfigButton_Click);
            // 
            // redisRestartButton
            // 
            this.redisRestartButton.Location = new System.Drawing.Point(414, 309);
            this.redisRestartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.redisRestartButton.Name = "redisRestartButton";
            this.redisRestartButton.Size = new System.Drawing.Size(75, 39);
            this.redisRestartButton.TabIndex = 90;
            this.redisRestartButton.Text = "Restart";
            this.redisRestartButton.UseVisualStyleBackColor = true;
            this.redisRestartButton.Click += new System.EventHandler(this.RedisRestartButton_Click);
            // 
            // redisStopButton
            // 
            this.redisStopButton.Location = new System.Drawing.Point(330, 309);
            this.redisStopButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.redisStopButton.Name = "redisStopButton";
            this.redisStopButton.Size = new System.Drawing.Size(75, 39);
            this.redisStopButton.TabIndex = 89;
            this.redisStopButton.Text = "Stop";
            this.redisStopButton.UseVisualStyleBackColor = true;
            this.redisStopButton.Click += new System.EventHandler(this.RedisStopButton_Click);
            // 
            // redisStartButton
            // 
            this.redisStartButton.Location = new System.Drawing.Point(246, 309);
            this.redisStartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.redisStartButton.Name = "redisStartButton";
            this.redisStartButton.Size = new System.Drawing.Size(75, 39);
            this.redisStartButton.TabIndex = 88;
            this.redisStartButton.Text = "Start";
            this.redisStartButton.UseVisualStyleBackColor = true;
            this.redisStartButton.Click += new System.EventHandler(this.RedisStartButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(118, 313);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 25);
            this.label10.TabIndex = 87;
            this.label10.Text = "Redis";
            // 
            // redisrunning
            // 
            this.redisrunning.AutoSize = true;
            this.redisrunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redisrunning.ForeColor = System.Drawing.Color.DarkRed;
            this.redisrunning.Location = new System.Drawing.Point(33, 309);
            this.redisrunning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.redisrunning.Name = "redisrunning";
            this.redisrunning.Size = new System.Drawing.Size(31, 29);
            this.redisrunning.TabIndex = 86;
            this.redisrunning.Text = "X";
            // 
            // postgresqlLogButton
            // 
            this.postgresqlLogButton.Location = new System.Drawing.Point(632, 248);
            this.postgresqlLogButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.postgresqlLogButton.Name = "postgresqlLogButton";
            this.postgresqlLogButton.Size = new System.Drawing.Size(75, 39);
            this.postgresqlLogButton.TabIndex = 85;
            this.postgresqlLogButton.Text = "Logs";
            this.postgresqlLogButton.UseVisualStyleBackColor = true;
            this.postgresqlLogButton.Click += new System.EventHandler(this.PostgresqlLogButton_Click);
            // 
            // postgresqlConfigButton
            // 
            this.postgresqlConfigButton.Location = new System.Drawing.Point(498, 248);
            this.postgresqlConfigButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.postgresqlConfigButton.Name = "postgresqlConfigButton";
            this.postgresqlConfigButton.Size = new System.Drawing.Size(124, 39);
            this.postgresqlConfigButton.TabIndex = 84;
            this.postgresqlConfigButton.Text = "Configuration";
            this.postgresqlConfigButton.UseVisualStyleBackColor = true;
            this.postgresqlConfigButton.Click += new System.EventHandler(this.PostgresqlConfigButton_Click);
            // 
            // postgresqlRestartButton
            // 
            this.postgresqlRestartButton.Location = new System.Drawing.Point(414, 248);
            this.postgresqlRestartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.postgresqlRestartButton.Name = "postgresqlRestartButton";
            this.postgresqlRestartButton.Size = new System.Drawing.Size(75, 39);
            this.postgresqlRestartButton.TabIndex = 83;
            this.postgresqlRestartButton.Text = "Restart";
            this.postgresqlRestartButton.UseVisualStyleBackColor = true;
            this.postgresqlRestartButton.Click += new System.EventHandler(this.PostgresqlRestartButton_Click);
            // 
            // postgresqlStopButton
            // 
            this.postgresqlStopButton.Location = new System.Drawing.Point(330, 248);
            this.postgresqlStopButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.postgresqlStopButton.Name = "postgresqlStopButton";
            this.postgresqlStopButton.Size = new System.Drawing.Size(75, 39);
            this.postgresqlStopButton.TabIndex = 82;
            this.postgresqlStopButton.Text = "Stop";
            this.postgresqlStopButton.UseVisualStyleBackColor = true;
            this.postgresqlStopButton.Click += new System.EventHandler(this.PostgresqlStopButton_Click);
            // 
            // postgresqlStartButton
            // 
            this.postgresqlStartButton.Location = new System.Drawing.Point(246, 248);
            this.postgresqlStartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.postgresqlStartButton.Name = "postgresqlStartButton";
            this.postgresqlStartButton.Size = new System.Drawing.Size(75, 39);
            this.postgresqlStartButton.TabIndex = 81;
            this.postgresqlStartButton.Text = "Start";
            this.postgresqlStartButton.UseVisualStyleBackColor = true;
            this.postgresqlStartButton.Click += new System.EventHandler(this.PostgresqlStartButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(118, 252);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 25);
            this.label9.TabIndex = 80;
            this.label9.Text = "PostgreSQL";
            // 
            // postgresqlrunning
            // 
            this.postgresqlrunning.AutoSize = true;
            this.postgresqlrunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postgresqlrunning.ForeColor = System.Drawing.Color.DarkRed;
            this.postgresqlrunning.Location = new System.Drawing.Point(33, 248);
            this.postgresqlrunning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.postgresqlrunning.Name = "postgresqlrunning";
            this.postgresqlrunning.Size = new System.Drawing.Size(31, 29);
            this.postgresqlrunning.TabIndex = 79;
            this.postgresqlrunning.Text = "X";
            // 
            // phpRestartButton
            // 
            this.phpRestartButton.Location = new System.Drawing.Point(414, 183);
            this.phpRestartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phpRestartButton.Name = "phpRestartButton";
            this.phpRestartButton.Size = new System.Drawing.Size(75, 39);
            this.phpRestartButton.TabIndex = 78;
            this.phpRestartButton.Text = "Restart";
            this.phpRestartButton.UseVisualStyleBackColor = true;
            this.phpRestartButton.Click += new System.EventHandler(this.PhpRestartButton_Click);
            // 
            // mariadbRestartButton
            // 
            this.mariadbRestartButton.Location = new System.Drawing.Point(414, 122);
            this.mariadbRestartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mariadbRestartButton.Name = "mariadbRestartButton";
            this.mariadbRestartButton.Size = new System.Drawing.Size(75, 39);
            this.mariadbRestartButton.TabIndex = 77;
            this.mariadbRestartButton.Text = "Restart";
            this.mariadbRestartButton.UseVisualStyleBackColor = true;
            this.mariadbRestartButton.Click += new System.EventHandler(this.MariadbRestartButton_Click);
            // 
            // nginxRestartButton
            // 
            this.nginxRestartButton.Location = new System.Drawing.Point(414, 62);
            this.nginxRestartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nginxRestartButton.Name = "nginxRestartButton";
            this.nginxRestartButton.Size = new System.Drawing.Size(75, 39);
            this.nginxRestartButton.TabIndex = 76;
            this.nginxRestartButton.Text = "Restart";
            this.nginxRestartButton.UseVisualStyleBackColor = true;
            this.nginxRestartButton.Click += new System.EventHandler(this.NginxRestartButton_Click);
            // 
            // phpLogButton
            // 
            this.phpLogButton.Location = new System.Drawing.Point(632, 183);
            this.phpLogButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phpLogButton.Name = "phpLogButton";
            this.phpLogButton.Size = new System.Drawing.Size(75, 39);
            this.phpLogButton.TabIndex = 75;
            this.phpLogButton.Text = "Logs";
            this.phpLogButton.UseVisualStyleBackColor = true;
            this.phpLogButton.Click += new System.EventHandler(this.PhpLogButton_Click);
            // 
            // mariadbLogButton
            // 
            this.mariadbLogButton.Location = new System.Drawing.Point(632, 122);
            this.mariadbLogButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mariadbLogButton.Name = "mariadbLogButton";
            this.mariadbLogButton.Size = new System.Drawing.Size(75, 39);
            this.mariadbLogButton.TabIndex = 74;
            this.mariadbLogButton.Text = "Logs";
            this.mariadbLogButton.UseVisualStyleBackColor = true;
            this.mariadbLogButton.Click += new System.EventHandler(this.MariadbLogButton_Click);
            // 
            // nginxLogButton
            // 
            this.nginxLogButton.Location = new System.Drawing.Point(632, 64);
            this.nginxLogButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nginxLogButton.Name = "nginxLogButton";
            this.nginxLogButton.Size = new System.Drawing.Size(75, 39);
            this.nginxLogButton.TabIndex = 73;
            this.nginxLogButton.Text = "Logs";
            this.nginxLogButton.UseVisualStyleBackColor = true;
            this.nginxLogButton.Click += new System.EventHandler(this.NginxLogButton_Click);
            // 
            // phpConfigButton
            // 
            this.phpConfigButton.Location = new System.Drawing.Point(498, 183);
            this.phpConfigButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phpConfigButton.Name = "phpConfigButton";
            this.phpConfigButton.Size = new System.Drawing.Size(124, 39);
            this.phpConfigButton.TabIndex = 72;
            this.phpConfigButton.Text = "Configuration";
            this.phpConfigButton.UseVisualStyleBackColor = true;
            this.phpConfigButton.Click += new System.EventHandler(this.PhpConfigButton_Click);
            // 
            // mariadbConfigButton
            // 
            this.mariadbConfigButton.Location = new System.Drawing.Point(498, 122);
            this.mariadbConfigButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mariadbConfigButton.Name = "mariadbConfigButton";
            this.mariadbConfigButton.Size = new System.Drawing.Size(124, 39);
            this.mariadbConfigButton.TabIndex = 71;
            this.mariadbConfigButton.Text = "Configuration";
            this.mariadbConfigButton.UseVisualStyleBackColor = true;
            this.mariadbConfigButton.Click += new System.EventHandler(this.MariadbConfigButton_Click);
            // 
            // nginxConfigButton
            // 
            this.nginxConfigButton.Location = new System.Drawing.Point(498, 62);
            this.nginxConfigButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nginxConfigButton.Name = "nginxConfigButton";
            this.nginxConfigButton.Size = new System.Drawing.Size(124, 39);
            this.nginxConfigButton.TabIndex = 70;
            this.nginxConfigButton.Text = "Configuration";
            this.nginxConfigButton.UseVisualStyleBackColor = true;
            this.nginxConfigButton.Click += new System.EventHandler(this.NginxConfigButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(118, 191);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 25);
            this.label8.TabIndex = 69;
            this.label8.Text = "PHP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 68;
            this.label7.Text = "MariaDB";
            // 
            // phprunning
            // 
            this.phprunning.AutoSize = true;
            this.phprunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phprunning.ForeColor = System.Drawing.Color.DarkRed;
            this.phprunning.Location = new System.Drawing.Point(33, 187);
            this.phprunning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phprunning.Name = "phprunning";
            this.phprunning.Size = new System.Drawing.Size(31, 29);
            this.phprunning.TabIndex = 67;
            this.phprunning.Text = "X";
            // 
            // mariadbrunning
            // 
            this.mariadbrunning.AutoSize = true;
            this.mariadbrunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mariadbrunning.ForeColor = System.Drawing.Color.DarkRed;
            this.mariadbrunning.Location = new System.Drawing.Point(33, 126);
            this.mariadbrunning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mariadbrunning.Name = "mariadbrunning";
            this.mariadbrunning.Size = new System.Drawing.Size(31, 29);
            this.mariadbrunning.TabIndex = 66;
            this.mariadbrunning.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(246, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 63;
            this.label4.Text = "Nginx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Application";
            // 
            // nginxrunning
            // 
            this.nginxrunning.AutoSize = true;
            this.nginxrunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nginxrunning.ForeColor = System.Drawing.Color.DarkRed;
            this.nginxrunning.Location = new System.Drawing.Point(33, 65);
            this.nginxrunning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nginxrunning.Name = "nginxrunning";
            this.nginxrunning.Size = new System.Drawing.Size(31, 29);
            this.nginxrunning.TabIndex = 61;
            this.nginxrunning.Text = "X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "Running";
            // 
            // mariadbStopButton
            // 
            this.mariadbStopButton.Location = new System.Drawing.Point(330, 123);
            this.mariadbStopButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mariadbStopButton.Name = "mariadbStopButton";
            this.mariadbStopButton.Size = new System.Drawing.Size(75, 39);
            this.mariadbStopButton.TabIndex = 57;
            this.mariadbStopButton.Text = "Stop";
            this.mariadbStopButton.UseVisualStyleBackColor = true;
            this.mariadbStopButton.Click += new System.EventHandler(this.MariadbStopButton_Click);
            // 
            // mariadbStartButton
            // 
            this.mariadbStartButton.Location = new System.Drawing.Point(246, 123);
            this.mariadbStartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mariadbStartButton.Name = "mariadbStartButton";
            this.mariadbStartButton.Size = new System.Drawing.Size(75, 39);
            this.mariadbStartButton.TabIndex = 56;
            this.mariadbStartButton.Text = "Start";
            this.mariadbStartButton.UseVisualStyleBackColor = true;
            this.mariadbStartButton.Click += new System.EventHandler(this.MariadbStartButton_Click);
            // 
            // phpStartButton
            // 
            this.phpStartButton.Location = new System.Drawing.Point(246, 183);
            this.phpStartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phpStartButton.Name = "phpStartButton";
            this.phpStartButton.Size = new System.Drawing.Size(75, 39);
            this.phpStartButton.TabIndex = 55;
            this.phpStartButton.Text = "Start";
            this.phpStartButton.UseVisualStyleBackColor = true;
            this.phpStartButton.Click += new System.EventHandler(this.PhpStartButton_Click);
            // 
            // phpStopButton
            // 
            this.phpStopButton.Location = new System.Drawing.Point(330, 183);
            this.phpStopButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phpStopButton.Name = "phpStopButton";
            this.phpStopButton.Size = new System.Drawing.Size(75, 39);
            this.phpStopButton.TabIndex = 54;
            this.phpStopButton.Text = "Stop";
            this.phpStopButton.UseVisualStyleBackColor = true;
            this.phpStopButton.Click += new System.EventHandler(this.PhpStopButton_Click);
            // 
            // nginxStartButton
            // 
            this.nginxStartButton.Location = new System.Drawing.Point(246, 62);
            this.nginxStartButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nginxStartButton.Name = "nginxStartButton";
            this.nginxStartButton.Size = new System.Drawing.Size(75, 39);
            this.nginxStartButton.TabIndex = 53;
            this.nginxStartButton.Text = "Start";
            this.nginxStartButton.UseVisualStyleBackColor = true;
            this.nginxStartButton.Click += new System.EventHandler(this.NginxStartButton_Click);
            // 
            // nginxStopButton
            // 
            this.nginxStopButton.Location = new System.Drawing.Point(330, 62);
            this.nginxStopButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nginxStopButton.Name = "nginxStopButton";
            this.nginxStopButton.Size = new System.Drawing.Size(75, 39);
            this.nginxStopButton.TabIndex = 52;
            this.nginxStopButton.Text = "Stop";
            this.nginxStopButton.UseVisualStyleBackColor = true;
            this.nginxStopButton.Click += new System.EventHandler(this.NginxStopButton_Click);
            // 
            // startAllButton
            // 
            this.startAllButton.Location = new System.Drawing.Point(835, 45);
            this.startAllButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startAllButton.Name = "startAllButton";
            this.startAllButton.Size = new System.Drawing.Size(142, 50);
            this.startAllButton.TabIndex = 62;
            this.startAllButton.Text = "Start all";
            this.startAllButton.UseVisualStyleBackColor = true;
            this.startAllButton.Click += new System.EventHandler(this.StartAllButton_Click);
            // 
            // stopAllButton
            // 
            this.stopAllButton.Location = new System.Drawing.Point(835, 102);
            this.stopAllButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stopAllButton.Name = "stopAllButton";
            this.stopAllButton.Size = new System.Drawing.Size(142, 50);
            this.stopAllButton.TabIndex = 63;
            this.stopAllButton.Text = "Stop all";
            this.stopAllButton.UseVisualStyleBackColor = true;
            this.stopAllButton.Click += new System.EventHandler(this.StopAllButton_Click);
            // 
            // openMariaDBShellButton
            // 
            this.openMariaDBShellButton.Location = new System.Drawing.Point(835, 159);
            this.openMariaDBShellButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openMariaDBShellButton.Name = "openMariaDBShellButton";
            this.openMariaDBShellButton.Size = new System.Drawing.Size(142, 68);
            this.openMariaDBShellButton.TabIndex = 64;
            this.openMariaDBShellButton.Text = "Open MariaDB Shell";
            this.openMariaDBShellButton.UseVisualStyleBackColor = true;
            this.openMariaDBShellButton.Click += new System.EventHandler(this.OpenMariaDBShellButton_Click);
            // 
            // AppsRunningTimer
            // 
            this.AppsRunningTimer.Enabled = true;
            this.AppsRunningTimer.Interval = 1000;
            this.AppsRunningTimer.Tick += new System.EventHandler(this.AppsRunningTimer_Tick);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 618);
            this.Controls.Add(this.quickServerDirButton);
            this.Controls.Add(this.logRichTextBox);
            this.Controls.Add(this.applicationsGroupBox);
            this.Controls.Add(this.startAllButton);
            this.Controls.Add(this.stopAllButton);
            this.Controls.Add(this.openMariaDBShellButton);
            this.Controls.Add(this.QuickServerMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.QuickServerMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.Text = "QuickServer Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.Shown += new System.EventHandler(this.MainFrm_Shown);
            this.Resize += new System.EventHandler(this.MainFrm_Resize);
            this.QuickServerMenuStrip.ResumeLayout(false);
            this.QuickServerMenuStrip.PerformLayout();
            this.applicationsGroupBox.ResumeLayout(false);
            this.applicationsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip QuickServerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button quickServerDirButton;
        public System.Windows.Forms.RichTextBox logRichTextBox;
        private System.Windows.Forms.GroupBox applicationsGroupBox;
        private System.Windows.Forms.Button phpLogButton;
        private System.Windows.Forms.Button mariadbLogButton;
        private System.Windows.Forms.Button nginxLogButton;
        private System.Windows.Forms.Button phpConfigButton;
        private System.Windows.Forms.Button mariadbConfigButton;
        private System.Windows.Forms.Button nginxConfigButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem quickServerOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localhostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hostToIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getHTTPHeadersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportBugToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button nginxRestartButton;
        private System.Windows.Forms.Button mariadbStopButton;
        private System.Windows.Forms.Button mariadbStartButton;
        private System.Windows.Forms.Button phpStartButton;
        private System.Windows.Forms.Button phpStopButton;
        private System.Windows.Forms.Button nginxStartButton;
        private System.Windows.Forms.Button nginxStopButton;
        private System.Windows.Forms.Button phpRestartButton;
        private System.Windows.Forms.Button mariadbRestartButton;
        private System.Windows.Forms.Button startAllButton;
        private System.Windows.Forms.Button stopAllButton;
        private System.Windows.Forms.Button openMariaDBShellButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label phprunning;
        private System.Windows.Forms.Label mariadbrunning;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nginxrunning;
        private System.Windows.Forms.Timer AppsRunningTimer;
        private System.Windows.Forms.ToolStripMenuItem setupMariaDBToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label postgresqlrunning;
        private System.Windows.Forms.Label redisrunning;
        private System.Windows.Forms.Button postgresqlStartButton;
        private System.Windows.Forms.Button postgresqlStopButton;
        private System.Windows.Forms.Button postgresqlRestartButton;
        private System.Windows.Forms.Button postgresqlConfigButton;
        private System.Windows.Forms.Button postgresqlLogButton;
        private System.Windows.Forms.Button redisStartButton;
        private System.Windows.Forms.Button redisStopButton;
        private System.Windows.Forms.Button redisRestartButton;
        private System.Windows.Forms.Button redisConfigButton;
        private System.Windows.Forms.Button redisLogButton;
    }
}