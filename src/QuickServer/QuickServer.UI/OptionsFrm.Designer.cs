namespace QuickServer.UI
{
    partial class OptionsFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsFrm));
            this.Cancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.General = new System.Windows.Forms.TabPage();
            this.applicationSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.StartMinimizedToTray = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.MinimizeToTrayInsteadOfClosing = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.StartNginxLaunchCB = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.StartMySQLLaunchCB = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.selecteditor = new System.Windows.Forms.Button();
            this.updateCheckIntervalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartPHPLaunchCB = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StartPostgreSQLLaunchCB = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.StartRedisLaunchCB = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.StartQuickServerWithWindows = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.autoUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.editorTB = new System.Windows.Forms.TextBox();
            this.MinimizeQuickServerToTray = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PHP = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.phpExtListBox = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PHP_PROCESSES = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.PHP_PORT = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.Nginx = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nginxConfigTextBox = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.nginxPortNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.labelNginxPort = new System.Windows.Forms.Label();
            this.MariaDB = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.mysqlConfigTextBox = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.mysqlPortNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.labelMysqlPort = new System.Windows.Forms.Label();
            this.PostgreSQL = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.pgsqlConfigTextBox = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.pgsqlPortNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.labelPgsqlPort = new System.Windows.Forms.Label();
            this.Redis = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.redisConfigTextBox = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.redisPortNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.labelRedisPort = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.General.SuspendLayout();
            this.applicationSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateCheckIntervalNumericUpDown)).BeginInit();
            this.PHP.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PHP_PROCESSES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHP_PORT)).BeginInit();
            this.Nginx.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nginxPortNumericUpDown)).BeginInit();
            this.MariaDB.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mysqlPortNumericUpDown)).BeginInit();
            this.PostgreSQL.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgsqlPortNumericUpDown)).BeginInit();
            this.Redis.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redisPortNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(275, 386);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 20;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.General);
            this.tabControl1.Controls.Add(this.Nginx);
            this.tabControl1.Controls.Add(this.MariaDB);
            this.tabControl1.Controls.Add(this.PostgreSQL);
            this.tabControl1.Controls.Add(this.Redis);
            this.tabControl1.Controls.Add(this.PHP);
            this.tabControl1.Location = new System.Drawing.Point(7, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(347, 328);
            this.tabControl1.TabIndex = 19;
            // 
            // General
            // 
            this.General.Controls.Add(this.applicationSettingsGroupBox);
            this.General.Location = new System.Drawing.Point(4, 22);
            this.General.Name = "General";
            this.General.Padding = new System.Windows.Forms.Padding(3);
            this.General.Size = new System.Drawing.Size(339, 302);
            this.General.TabIndex = 0;
            this.General.Text = "General";
            this.General.UseVisualStyleBackColor = true;
            // 
            // applicationSettingsGroupBox
            // 
            this.applicationSettingsGroupBox.Controls.Add(this.StartMinimizedToTray);
            this.applicationSettingsGroupBox.Controls.Add(this.label13);
            this.applicationSettingsGroupBox.Controls.Add(this.MinimizeToTrayInsteadOfClosing);
            this.applicationSettingsGroupBox.Controls.Add(this.label12);
            this.applicationSettingsGroupBox.Controls.Add(this.StartNginxLaunchCB);
            this.applicationSettingsGroupBox.Controls.Add(this.label11);
            this.applicationSettingsGroupBox.Controls.Add(this.StartMySQLLaunchCB);
            this.applicationSettingsGroupBox.Controls.Add(this.label10);
            this.applicationSettingsGroupBox.Controls.Add(this.selecteditor);
            this.applicationSettingsGroupBox.Controls.Add(this.updateCheckIntervalNumericUpDown);
            this.applicationSettingsGroupBox.Controls.Add(this.label6);
            this.applicationSettingsGroupBox.Controls.Add(this.label1);
            this.applicationSettingsGroupBox.Controls.Add(this.StartPHPLaunchCB);
            this.applicationSettingsGroupBox.Controls.Add(this.label3);
            this.applicationSettingsGroupBox.Controls.Add(this.StartPostgreSQLLaunchCB);
            this.applicationSettingsGroupBox.Controls.Add(this.label16);
            this.applicationSettingsGroupBox.Controls.Add(this.StartRedisLaunchCB);
            this.applicationSettingsGroupBox.Controls.Add(this.label17);
            this.applicationSettingsGroupBox.Controls.Add(this.StartQuickServerWithWindows);
            this.applicationSettingsGroupBox.Controls.Add(this.label2);
            this.applicationSettingsGroupBox.Controls.Add(this.autoUpdateCheckBox);
            this.applicationSettingsGroupBox.Controls.Add(this.label5);
            this.applicationSettingsGroupBox.Controls.Add(this.editorTB);
            this.applicationSettingsGroupBox.Controls.Add(this.MinimizeQuickServerToTray);
            this.applicationSettingsGroupBox.Controls.Add(this.label4);
            this.applicationSettingsGroupBox.Location = new System.Drawing.Point(6, 6);
            this.applicationSettingsGroupBox.Name = "applicationSettingsGroupBox";
            this.applicationSettingsGroupBox.Size = new System.Drawing.Size(327, 280);
            this.applicationSettingsGroupBox.TabIndex = 16;
            this.applicationSettingsGroupBox.TabStop = false;
            this.applicationSettingsGroupBox.Text = "Application Settings";
            // 
            // StartMinimizedToTray
            // 
            this.StartMinimizedToTray.AutoSize = true;
            this.StartMinimizedToTray.Location = new System.Drawing.Point(15, 209);
            this.StartMinimizedToTray.Name = "StartMinimizedToTray";
            this.StartMinimizedToTray.Size = new System.Drawing.Size(15, 14);
            this.StartMinimizedToTray.TabIndex = 24;
            this.StartMinimizedToTray.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 210);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Start QuickServer minimized";
            // 
            // MinimizeToTrayInsteadOfClosing
            // 
            this.MinimizeToTrayInsteadOfClosing.AutoSize = true;
            this.MinimizeToTrayInsteadOfClosing.Location = new System.Drawing.Point(15, 189);
            this.MinimizeToTrayInsteadOfClosing.Name = "MinimizeToTrayInsteadOfClosing";
            this.MinimizeToTrayInsteadOfClosing.Size = new System.Drawing.Size(15, 14);
            this.MinimizeToTrayInsteadOfClosing.TabIndex = 22;
            this.MinimizeToTrayInsteadOfClosing.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Minimize to tray instead of closing";
            // 
            // StartNginxLaunchCB
            // 
            this.StartNginxLaunchCB.AutoSize = true;
            this.StartNginxLaunchCB.Location = new System.Drawing.Point(15, 69);
            this.StartNginxLaunchCB.Name = "StartNginxLaunchCB";
            this.StartNginxLaunchCB.Size = new System.Drawing.Size(15, 14);
            this.StartNginxLaunchCB.TabIndex = 18;
            this.StartNginxLaunchCB.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Start Nginx on launch";
            // 
            // StartMySQLLaunchCB
            // 
            this.StartMySQLLaunchCB.AutoSize = true;
            this.StartMySQLLaunchCB.Location = new System.Drawing.Point(15, 89);
            this.StartMySQLLaunchCB.Name = "StartMySQLLaunchCB";
            this.StartMySQLLaunchCB.Size = new System.Drawing.Size(15, 14);
            this.StartMySQLLaunchCB.TabIndex = 16;
            this.StartMySQLLaunchCB.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Start MariaDB on launch";
            // 
            // selecteditor
            // 
            this.selecteditor.Location = new System.Drawing.Point(205, 22);
            this.selecteditor.Name = "selecteditor";
            this.selecteditor.Size = new System.Drawing.Size(26, 20);
            this.selecteditor.TabIndex = 14;
            this.selecteditor.Text = "...";
            this.selecteditor.UseVisualStyleBackColor = true;
            this.selecteditor.Click += new System.EventHandler(this.Selecteditor_Click);
            // 
            // updateCheckIntervalNumericUpDown
            // 
            this.updateCheckIntervalNumericUpDown.Location = new System.Drawing.Point(191, 248);
            this.updateCheckIntervalNumericUpDown.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.updateCheckIntervalNumericUpDown.Name = "updateCheckIntervalNumericUpDown";
            this.updateCheckIntervalNumericUpDown.Size = new System.Drawing.Size(66, 20);
            this.updateCheckIntervalNumericUpDown.TabIndex = 13;
            this.updateCheckIntervalNumericUpDown.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Update check interval (in days)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editor:";
            // 
            // StartPHPLaunchCB
            // 
            this.StartPHPLaunchCB.AutoSize = true;
            this.StartPHPLaunchCB.Location = new System.Drawing.Point(15, 109);
            this.StartPHPLaunchCB.Name = "StartPHPLaunchCB";
            this.StartPHPLaunchCB.Size = new System.Drawing.Size(15, 14);
            this.StartPHPLaunchCB.TabIndex = 7;
            this.StartPHPLaunchCB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start PHP on launch";
            // 
            // StartPostgreSQLLaunchCB
            // 
            this.StartPostgreSQLLaunchCB.AutoSize = true;
            this.StartPostgreSQLLaunchCB.Location = new System.Drawing.Point(15, 129);
            this.StartPostgreSQLLaunchCB.Name = "StartPostgreSQLLaunchCB";
            this.StartPostgreSQLLaunchCB.Size = new System.Drawing.Size(15, 14);
            this.StartPostgreSQLLaunchCB.TabIndex = 25;
            this.StartPostgreSQLLaunchCB.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(32, 130);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(146, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Start PostgreSQL on launch";
            // 
            // StartRedisLaunchCB
            // 
            this.StartRedisLaunchCB.AutoSize = true;
            this.StartRedisLaunchCB.Location = new System.Drawing.Point(15, 149);
            this.StartRedisLaunchCB.Name = "StartRedisLaunchCB";
            this.StartRedisLaunchCB.Size = new System.Drawing.Size(15, 14);
            this.StartRedisLaunchCB.TabIndex = 27;
            this.StartRedisLaunchCB.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 150);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Start Redis on launch";
            // 
            // StartQuickServerWithWindows
            // 
            this.StartQuickServerWithWindows.AutoSize = true;
            this.StartQuickServerWithWindows.Location = new System.Drawing.Point(15, 49);
            this.StartQuickServerWithWindows.Name = "StartQuickServerWithWindows";
            this.StartQuickServerWithWindows.Size = new System.Drawing.Size(15, 14);
            this.StartQuickServerWithWindows.TabIndex = 4;
            this.StartQuickServerWithWindows.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Start QuickServer with Windows";
            // 
            // autoUpdateCheckBox
            // 
            this.autoUpdateCheckBox.AutoSize = true;
            this.autoUpdateCheckBox.Location = new System.Drawing.Point(15, 229);
            this.autoUpdateCheckBox.Name = "autoUpdateCheckBox";
            this.autoUpdateCheckBox.Size = new System.Drawing.Size(15, 14);
            this.autoUpdateCheckBox.TabIndex = 11;
            this.autoUpdateCheckBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Automatically check for updates";
            // 
            // editorTB
            // 
            this.editorTB.Location = new System.Drawing.Point(54, 22);
            this.editorTB.Name = "editorTB";
            this.editorTB.ReadOnly = true;
            this.editorTB.Size = new System.Drawing.Size(144, 20);
            this.editorTB.TabIndex = 1;
            // 
            // MinimizeQuickServerToTray
            // 
            this.MinimizeQuickServerToTray.AutoSize = true;
            this.MinimizeQuickServerToTray.Location = new System.Drawing.Point(15, 169);
            this.MinimizeQuickServerToTray.Name = "MinimizeQuickServerToTray";
            this.MinimizeQuickServerToTray.Size = new System.Drawing.Size(15, 14);
            this.MinimizeQuickServerToTray.TabIndex = 9;
            this.MinimizeQuickServerToTray.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Minimize to tray instead of minimizing";
            // 
            // PHP
            // 
            this.PHP.Controls.Add(this.groupBox3);
            this.PHP.Controls.Add(this.groupBox2);
            this.PHP.Location = new System.Drawing.Point(4, 22);
            this.PHP.Name = "PHP";
            this.PHP.Padding = new System.Windows.Forms.Padding(3);
            this.PHP.Size = new System.Drawing.Size(339, 302);
            this.PHP.TabIndex = 1;
            this.PHP.Text = "PHP";
            this.PHP.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.phpExtListBox);
            this.groupBox3.Location = new System.Drawing.Point(6, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 174);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PHP Extensions";
            // 
            // phpExtListBox
            // 
            this.phpExtListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phpExtListBox.FormattingEnabled = true;
            this.phpExtListBox.Location = new System.Drawing.Point(3, 16);
            this.phpExtListBox.Name = "phpExtListBox";
            this.phpExtListBox.Size = new System.Drawing.Size(320, 155);
            this.phpExtListBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PHP_PROCESSES);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.PHP_PORT);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 80);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PHP Settings";
            // 
            // PHP_PROCESSES
            // 
            this.PHP_PROCESSES.Location = new System.Drawing.Point(108, 19);
            this.PHP_PROCESSES.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PHP_PROCESSES.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PHP_PROCESSES.Name = "PHP_PROCESSES";
            this.PHP_PROCESSES.Size = new System.Drawing.Size(69, 20);
            this.PHP_PROCESSES.TabIndex = 3;
            this.PHP_PROCESSES.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "PHP Processes:";
            // 
            // PHP_PORT
            // 
            this.PHP_PORT.Location = new System.Drawing.Point(108, 44);
            this.PHP_PORT.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PHP_PORT.Name = "PHP_PORT";
            this.PHP_PORT.Size = new System.Drawing.Size(69, 20);
            this.PHP_PORT.TabIndex = 1;
            this.PHP_PORT.Value = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "PHP Port:";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(183, 386);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 18;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Nginx
            // 
            this.Nginx.Controls.Add(this.groupBox5);
            this.Nginx.Controls.Add(this.groupBox6);
            this.Nginx.Location = new System.Drawing.Point(4, 22);
            this.Nginx.Name = "Nginx";
            this.Nginx.Padding = new System.Windows.Forms.Padding(3);
            this.Nginx.Size = new System.Drawing.Size(339, 302);
            this.Nginx.TabIndex = 2;
            this.Nginx.Text = "Nginx";
            this.Nginx.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.nginxConfigTextBox);
            this.groupBox5.Location = new System.Drawing.Point(6, 80);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(327, 216);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nginx Configuration";
            // 
            // nginxConfigTextBox
            // 
            this.nginxConfigTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nginxConfigTextBox.Font = new System.Drawing.Font("Courier New", 9F);
            this.nginxConfigTextBox.Location = new System.Drawing.Point(3, 16);
            this.nginxConfigTextBox.Multiline = true;
            this.nginxConfigTextBox.Name = "nginxConfigTextBox";
            this.nginxConfigTextBox.ReadOnly = true;
            this.nginxConfigTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.nginxConfigTextBox.Size = new System.Drawing.Size(321, 197);
            this.nginxConfigTextBox.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.nginxPortNumericUpDown);
            this.groupBox6.Controls.Add(this.labelNginxPort);
            this.groupBox6.Location = new System.Drawing.Point(6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(327, 68);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nginx Settings";
            // 
            // nginxPortNumericUpDown
            // 
            this.nginxPortNumericUpDown.Location = new System.Drawing.Point(108, 28);
            this.nginxPortNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nginxPortNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nginxPortNumericUpDown.Name = "nginxPortNumericUpDown";
            this.nginxPortNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.nginxPortNumericUpDown.TabIndex = 1;
            this.nginxPortNumericUpDown.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // labelNginxPort
            // 
            this.labelNginxPort.AutoSize = true;
            this.labelNginxPort.Location = new System.Drawing.Point(18, 30);
            this.labelNginxPort.Name = "labelNginxPort";
            this.labelNginxPort.Size = new System.Drawing.Size(73, 13);
            this.labelNginxPort.TabIndex = 0;
            this.labelNginxPort.Text = "Nginx Port:";
            // 
            // MariaDB
            // 
            this.MariaDB.Controls.Add(this.groupBox7);
            this.MariaDB.Controls.Add(this.groupBox8);
            this.MariaDB.Location = new System.Drawing.Point(4, 22);
            this.MariaDB.Name = "MariaDB";
            this.MariaDB.Size = new System.Drawing.Size(339, 302);
            this.MariaDB.TabIndex = 3;
            this.MariaDB.Text = "MariaDB";
            this.MariaDB.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.mysqlConfigTextBox);
            this.groupBox7.Location = new System.Drawing.Point(6, 80);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(327, 216);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "MariaDB Configuration";
            // 
            // mysqlConfigTextBox
            // 
            this.mysqlConfigTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mysqlConfigTextBox.Font = new System.Drawing.Font("Courier New", 9F);
            this.mysqlConfigTextBox.Location = new System.Drawing.Point(3, 16);
            this.mysqlConfigTextBox.Multiline = true;
            this.mysqlConfigTextBox.Name = "mysqlConfigTextBox";
            this.mysqlConfigTextBox.ReadOnly = true;
            this.mysqlConfigTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mysqlConfigTextBox.Size = new System.Drawing.Size(321, 197);
            this.mysqlConfigTextBox.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.mysqlPortNumericUpDown);
            this.groupBox8.Controls.Add(this.labelMysqlPort);
            this.groupBox8.Location = new System.Drawing.Point(6, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(327, 68);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "MariaDB Settings";
            // 
            // mysqlPortNumericUpDown
            // 
            this.mysqlPortNumericUpDown.Location = new System.Drawing.Point(108, 28);
            this.mysqlPortNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.mysqlPortNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.mysqlPortNumericUpDown.Name = "mysqlPortNumericUpDown";
            this.mysqlPortNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.mysqlPortNumericUpDown.TabIndex = 1;
            this.mysqlPortNumericUpDown.Value = new decimal(new int[] {
            3306,
            0,
            0,
            0});
            // 
            // labelMysqlPort
            // 
            this.labelMysqlPort.AutoSize = true;
            this.labelMysqlPort.Location = new System.Drawing.Point(18, 30);
            this.labelMysqlPort.Name = "labelMysqlPort";
            this.labelMysqlPort.Size = new System.Drawing.Size(80, 13);
            this.labelMysqlPort.TabIndex = 0;
            this.labelMysqlPort.Text = "MariaDB Port:";
            // 
            // PostgreSQL
            // 
            this.PostgreSQL.Controls.Add(this.groupBox9);
            this.PostgreSQL.Controls.Add(this.groupBox10);
            this.PostgreSQL.Location = new System.Drawing.Point(4, 22);
            this.PostgreSQL.Name = "PostgreSQL";
            this.PostgreSQL.Size = new System.Drawing.Size(339, 302);
            this.PostgreSQL.TabIndex = 4;
            this.PostgreSQL.Text = "PostgreSQL";
            this.PostgreSQL.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.pgsqlConfigTextBox);
            this.groupBox9.Location = new System.Drawing.Point(6, 80);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(327, 216);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "PostgreSQL Configuration";
            // 
            // pgsqlConfigTextBox
            // 
            this.pgsqlConfigTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgsqlConfigTextBox.Font = new System.Drawing.Font("Courier New", 9F);
            this.pgsqlConfigTextBox.Location = new System.Drawing.Point(3, 16);
            this.pgsqlConfigTextBox.Multiline = true;
            this.pgsqlConfigTextBox.Name = "pgsqlConfigTextBox";
            this.pgsqlConfigTextBox.ReadOnly = true;
            this.pgsqlConfigTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.pgsqlConfigTextBox.Size = new System.Drawing.Size(321, 197);
            this.pgsqlConfigTextBox.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.pgsqlPortNumericUpDown);
            this.groupBox10.Controls.Add(this.labelPgsqlPort);
            this.groupBox10.Location = new System.Drawing.Point(6, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(327, 68);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "PostgreSQL Settings";
            // 
            // pgsqlPortNumericUpDown
            // 
            this.pgsqlPortNumericUpDown.Location = new System.Drawing.Point(108, 28);
            this.pgsqlPortNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.pgsqlPortNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pgsqlPortNumericUpDown.Name = "pgsqlPortNumericUpDown";
            this.pgsqlPortNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.pgsqlPortNumericUpDown.TabIndex = 1;
            this.pgsqlPortNumericUpDown.Value = new decimal(new int[] {
            5432,
            0,
            0,
            0});
            // 
            // labelPgsqlPort
            // 
            this.labelPgsqlPort.AutoSize = true;
            this.labelPgsqlPort.Location = new System.Drawing.Point(18, 30);
            this.labelPgsqlPort.Name = "labelPgsqlPort";
            this.labelPgsqlPort.Size = new System.Drawing.Size(85, 13);
            this.labelPgsqlPort.TabIndex = 0;
            this.labelPgsqlPort.Text = "PostgreSQL Port:";
            // 
            // Redis
            // 
            this.Redis.Controls.Add(this.groupBox11);
            this.Redis.Controls.Add(this.groupBox12);
            this.Redis.Location = new System.Drawing.Point(4, 22);
            this.Redis.Name = "Redis";
            this.Redis.Size = new System.Drawing.Size(339, 302);
            this.Redis.TabIndex = 5;
            this.Redis.Text = "Redis";
            this.Redis.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.redisConfigTextBox);
            this.groupBox11.Location = new System.Drawing.Point(6, 80);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(327, 216);
            this.groupBox11.TabIndex = 2;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Redis Configuration";
            // 
            // redisConfigTextBox
            // 
            this.redisConfigTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.redisConfigTextBox.Font = new System.Drawing.Font("Courier New", 9F);
            this.redisConfigTextBox.Location = new System.Drawing.Point(3, 16);
            this.redisConfigTextBox.Multiline = true;
            this.redisConfigTextBox.Name = "redisConfigTextBox";
            this.redisConfigTextBox.ReadOnly = true;
            this.redisConfigTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.redisConfigTextBox.Size = new System.Drawing.Size(321, 197);
            this.redisConfigTextBox.TabIndex = 0;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.redisPortNumericUpDown);
            this.groupBox12.Controls.Add(this.labelRedisPort);
            this.groupBox12.Location = new System.Drawing.Point(6, 6);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(327, 68);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Redis Settings";
            // 
            // redisPortNumericUpDown
            // 
            this.redisPortNumericUpDown.Location = new System.Drawing.Point(108, 28);
            this.redisPortNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.redisPortNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.redisPortNumericUpDown.Name = "redisPortNumericUpDown";
            this.redisPortNumericUpDown.Size = new System.Drawing.Size(69, 20);
            this.redisPortNumericUpDown.TabIndex = 1;
            this.redisPortNumericUpDown.Value = new decimal(new int[] {
            6379,
            0,
            0,
            0});
            // 
            // labelRedisPort
            // 
            this.labelRedisPort.AutoSize = true;
            this.labelRedisPort.Location = new System.Drawing.Point(18, 30);
            this.labelRedisPort.Name = "labelRedisPort";
            this.labelRedisPort.Size = new System.Drawing.Size(70, 13);
            this.labelRedisPort.TabIndex = 0;
            this.labelRedisPort.Text = "Redis Port:";
            // 
            // OptionsFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 421);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsFrm";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.tabControl1.ResumeLayout(false);
            this.General.ResumeLayout(false);
            this.applicationSettingsGroupBox.ResumeLayout(false);
            this.applicationSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updateCheckIntervalNumericUpDown)).EndInit();
            this.PHP.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PHP_PROCESSES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PHP_PORT)).EndInit();
            this.Nginx.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nginxPortNumericUpDown)).EndInit();
            this.MariaDB.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mysqlPortNumericUpDown)).EndInit();
            this.PostgreSQL.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pgsqlPortNumericUpDown)).EndInit();
            this.Redis.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redisPortNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage General;
        private System.Windows.Forms.GroupBox applicationSettingsGroupBox;
        private System.Windows.Forms.CheckBox StartMinimizedToTray;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox MinimizeToTrayInsteadOfClosing;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox StartNginxLaunchCB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox StartMySQLLaunchCB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button selecteditor;
        private System.Windows.Forms.NumericUpDown updateCheckIntervalNumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox StartPHPLaunchCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox StartPostgreSQLLaunchCB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox StartRedisLaunchCB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox StartQuickServerWithWindows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox autoUpdateCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox editorTB;
        private System.Windows.Forms.CheckBox MinimizeQuickServerToTray;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage PHP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox phpExtListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown PHP_PROCESSES;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown PHP_PORT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TabPage Nginx;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox nginxConfigTextBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown nginxPortNumericUpDown;
        private System.Windows.Forms.Label labelNginxPort;
        private System.Windows.Forms.TabPage MariaDB;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox mysqlConfigTextBox;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.NumericUpDown mysqlPortNumericUpDown;
        private System.Windows.Forms.Label labelMysqlPort;
        private System.Windows.Forms.TabPage PostgreSQL;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox pgsqlConfigTextBox;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.NumericUpDown pgsqlPortNumericUpDown;
        private System.Windows.Forms.Label labelPgsqlPort;
        private System.Windows.Forms.TabPage Redis;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox redisConfigTextBox;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.NumericUpDown redisPortNumericUpDown;
        private System.Windows.Forms.Label labelRedisPort;
    }
}