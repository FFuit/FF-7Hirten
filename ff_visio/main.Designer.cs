namespace ff_visio
{
    
    partial class main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.benutzerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabSeite1 = new System.Windows.Forms.TabPage();
            this.lb_DbVerbunden = new System.Windows.Forms.Label();
            this.lb_FahrzeugVerbunden = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bt_Trend = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pB_TempHalle = new System.Windows.Forms.ProgressBar();
            this.pB_Druck = new System.Windows.Forms.ProgressBar();
            this.lb_Datum1 = new System.Windows.Forms.Label();
            this.tb_wertTAuto = new System.Windows.Forms.TextBox();
            this.tb_wertTHalle = new System.Windows.Forms.TextBox();
            this.tb_wertDruck = new System.Windows.Forms.TextBox();
            this.lb_einheitTAuto = new System.Windows.Forms.Label();
            this.lb_einheitTHalle = new System.Windows.Forms.Label();
            this.lb_tempHalle = new System.Windows.Forms.Label();
            this.lb_tempAuto = new System.Windows.Forms.Label();
            this.lb_einheitDruck = new System.Windows.Forms.Label();
            this.lb_Druck = new System.Windows.Forms.Label();
            this.p_Druck = new System.Windows.Forms.Panel();
            this.p_TempA = new System.Windows.Forms.Panel();
            this.pB_TempAuto = new System.Windows.Forms.ProgressBar();
            this.p_TempH = new System.Windows.Forms.Panel();
            this.tabSeite2 = new System.Windows.Forms.TabPage();
            this.lb_Datum2 = new System.Windows.Forms.Label();
            this.bt_AswTan = new System.Windows.Forms.Button();
            this.bt_AswTah = new System.Windows.Forms.Button();
            this.bt_AswThn = new System.Windows.Forms.Button();
            this.bt_AswThh = new System.Windows.Forms.Button();
            this.bt_AswDn = new System.Windows.Forms.Button();
            this.bt_AswDh = new System.Windows.Forms.Button();
            this.tb_AswTempAuto = new System.Windows.Forms.TextBox();
            this.tb_AswTempHalle = new System.Windows.Forms.TextBox();
            this.tb_AswDruck = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.T_DatumUhrzeit = new System.Windows.Forms.Timer(this.components);
            this.T_VerbindungPruefen = new System.Windows.Forms.Timer(this.components);
            this.T_AktualisiereWerte = new System.Windows.Forms.Timer(this.components);
            this.T_SamstagsMail = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabSeite1.SuspendLayout();
            this.tabSeite2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.benutzerToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // benutzerToolStripMenuItem
            // 
            this.benutzerToolStripMenuItem.Name = "benutzerToolStripMenuItem";
            this.benutzerToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.benutzerToolStripMenuItem.Text = "Benutzer";
            this.benutzerToolStripMenuItem.Click += new System.EventHandler(this.benutzerToolStripMenuItem_Click);
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "RLF 2000";
            this.notifyIcon1.Visible = true;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabSeite1);
            this.TabControl.Controls.Add(this.tabSeite2);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(0, 24);
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(534, 382);
            this.TabControl.TabIndex = 13;
            // 
            // tabSeite1
            // 
            this.tabSeite1.BackColor = System.Drawing.SystemColors.Control;
            this.tabSeite1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabSeite1.Controls.Add(this.lb_DbVerbunden);
            this.tabSeite1.Controls.Add(this.lb_FahrzeugVerbunden);
            this.tabSeite1.Controls.Add(this.label14);
            this.tabSeite1.Controls.Add(this.label13);
            this.tabSeite1.Controls.Add(this.bt_Trend);
            this.tabSeite1.Controls.Add(this.label12);
            this.tabSeite1.Controls.Add(this.label11);
            this.tabSeite1.Controls.Add(this.label10);
            this.tabSeite1.Controls.Add(this.label9);
            this.tabSeite1.Controls.Add(this.label8);
            this.tabSeite1.Controls.Add(this.label7);
            this.tabSeite1.Controls.Add(this.pB_TempHalle);
            this.tabSeite1.Controls.Add(this.pB_Druck);
            this.tabSeite1.Controls.Add(this.lb_Datum1);
            this.tabSeite1.Controls.Add(this.tb_wertTAuto);
            this.tabSeite1.Controls.Add(this.tb_wertTHalle);
            this.tabSeite1.Controls.Add(this.tb_wertDruck);
            this.tabSeite1.Controls.Add(this.lb_einheitTAuto);
            this.tabSeite1.Controls.Add(this.lb_einheitTHalle);
            this.tabSeite1.Controls.Add(this.lb_tempHalle);
            this.tabSeite1.Controls.Add(this.lb_tempAuto);
            this.tabSeite1.Controls.Add(this.lb_einheitDruck);
            this.tabSeite1.Controls.Add(this.lb_Druck);
            this.tabSeite1.Controls.Add(this.p_Druck);
            this.tabSeite1.Controls.Add(this.p_TempA);
            this.tabSeite1.Controls.Add(this.pB_TempAuto);
            this.tabSeite1.Controls.Add(this.p_TempH);
            this.tabSeite1.Location = new System.Drawing.Point(4, 25);
            this.tabSeite1.Name = "tabSeite1";
            this.tabSeite1.Padding = new System.Windows.Forms.Padding(3);
            this.tabSeite1.Size = new System.Drawing.Size(526, 353);
            this.tabSeite1.TabIndex = 0;
            this.tabSeite1.Text = "aktuelle Werte";
            // 
            // lb_DbVerbunden
            // 
            this.lb_DbVerbunden.AutoSize = true;
            this.lb_DbVerbunden.BackColor = System.Drawing.SystemColors.Control;
            this.lb_DbVerbunden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DbVerbunden.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_DbVerbunden.Location = new System.Drawing.Point(158, 246);
            this.lb_DbVerbunden.Name = "lb_DbVerbunden";
            this.lb_DbVerbunden.Size = new System.Drawing.Size(38, 24);
            this.lb_DbVerbunden.TabIndex = 42;
            this.lb_DbVerbunden.Text = "XX";
            this.lb_DbVerbunden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_FahrzeugVerbunden
            // 
            this.lb_FahrzeugVerbunden.AutoSize = true;
            this.lb_FahrzeugVerbunden.BackColor = System.Drawing.SystemColors.Control;
            this.lb_FahrzeugVerbunden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FahrzeugVerbunden.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_FahrzeugVerbunden.Location = new System.Drawing.Point(158, 212);
            this.lb_FahrzeugVerbunden.Name = "lb_FahrzeugVerbunden";
            this.lb_FahrzeugVerbunden.Size = new System.Drawing.Size(38, 24);
            this.lb_FahrzeugVerbunden.TabIndex = 41;
            this.lb_FahrzeugVerbunden.Text = "XX";
            this.lb_FahrzeugVerbunden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 16);
            this.label14.TabIndex = 40;
            this.label14.Text = "Datenbank verbunden:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 16);
            this.label13.TabIndex = 39;
            this.label13.Text = "Fahrzeug verbunden:";
            // 
            // bt_Trend
            // 
            this.bt_Trend.Enabled = false;
            this.bt_Trend.Location = new System.Drawing.Point(3, 169);
            this.bt_Trend.Name = "bt_Trend";
            this.bt_Trend.Size = new System.Drawing.Size(75, 23);
            this.bt_Trend.TabIndex = 38;
            this.bt_Trend.Text = "Trend";
            this.bt_Trend.UseVisualStyleBackColor = true;
            this.bt_Trend.Click += new System.EventHandler(this.bt_Trend_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(366, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 16);
            this.label12.TabIndex = 37;
            this.label12.Text = "40";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(366, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 16);
            this.label11.TabIndex = 36;
            this.label11.Text = "40";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(366, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 16);
            this.label9.TabIndex = 34;
            this.label9.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 16);
            this.label8.TabIndex = 33;
            this.label8.Text = "-5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "-5";
            // 
            // pB_TempHalle
            // 
            this.pB_TempHalle.Location = new System.Drawing.Point(180, 63);
            this.pB_TempHalle.Name = "pB_TempHalle";
            this.pB_TempHalle.Size = new System.Drawing.Size(180, 40);
            this.pB_TempHalle.TabIndex = 30;
            // 
            // pB_Druck
            // 
            this.pB_Druck.Location = new System.Drawing.Point(180, 13);
            this.pB_Druck.Name = "pB_Druck";
            this.pB_Druck.Size = new System.Drawing.Size(180, 40);
            this.pB_Druck.TabIndex = 29;
            // 
            // lb_Datum1
            // 
            this.lb_Datum1.AutoSize = true;
            this.lb_Datum1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_Datum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Datum1.Location = new System.Drawing.Point(3, 334);
            this.lb_Datum1.Name = "lb_Datum1";
            this.lb_Datum1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_Datum1.Size = new System.Drawing.Size(95, 16);
            this.lb_Datum1.TabIndex = 28;
            this.lb_Datum1.Text = "Datum_Uhrzeit";
            this.lb_Datum1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_wertTAuto
            // 
            this.tb_wertTAuto.Location = new System.Drawing.Point(426, 68);
            this.tb_wertTAuto.Name = "tb_wertTAuto";
            this.tb_wertTAuto.ReadOnly = true;
            this.tb_wertTAuto.Size = new System.Drawing.Size(43, 22);
            this.tb_wertTAuto.TabIndex = 18;
            this.tb_wertTAuto.TabStop = false;
            this.tb_wertTAuto.Text = "--";
            this.tb_wertTAuto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_wertTAuto.TextChanged += new System.EventHandler(this.tb_wertTAuto_TextChanged);
            // 
            // tb_wertTHalle
            // 
            this.tb_wertTHalle.Location = new System.Drawing.Point(426, 118);
            this.tb_wertTHalle.Name = "tb_wertTHalle";
            this.tb_wertTHalle.ReadOnly = true;
            this.tb_wertTHalle.Size = new System.Drawing.Size(43, 22);
            this.tb_wertTHalle.TabIndex = 17;
            this.tb_wertTHalle.TabStop = false;
            this.tb_wertTHalle.Text = "--";
            this.tb_wertTHalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_wertTHalle.TextChanged += new System.EventHandler(this.tb_wertTHalle_TextChanged);
            // 
            // tb_wertDruck
            // 
            this.tb_wertDruck.BackColor = System.Drawing.SystemColors.Control;
            this.tb_wertDruck.Location = new System.Drawing.Point(426, 18);
            this.tb_wertDruck.Name = "tb_wertDruck";
            this.tb_wertDruck.ReadOnly = true;
            this.tb_wertDruck.Size = new System.Drawing.Size(43, 22);
            this.tb_wertDruck.TabIndex = 16;
            this.tb_wertDruck.TabStop = false;
            this.tb_wertDruck.Text = "--";
            this.tb_wertDruck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_wertDruck.TextChanged += new System.EventHandler(this.tb_wertDruck_TextChanged);
            // 
            // lb_einheitTAuto
            // 
            this.lb_einheitTAuto.AutoSize = true;
            this.lb_einheitTAuto.Location = new System.Drawing.Point(398, 121);
            this.lb_einheitTAuto.Name = "lb_einheitTAuto";
            this.lb_einheitTAuto.Size = new System.Drawing.Size(21, 16);
            this.lb_einheitTAuto.TabIndex = 15;
            this.lb_einheitTAuto.Text = "°C";
            // 
            // lb_einheitTHalle
            // 
            this.lb_einheitTHalle.AutoSize = true;
            this.lb_einheitTHalle.Location = new System.Drawing.Point(398, 71);
            this.lb_einheitTHalle.Name = "lb_einheitTHalle";
            this.lb_einheitTHalle.Size = new System.Drawing.Size(21, 16);
            this.lb_einheitTHalle.TabIndex = 14;
            this.lb_einheitTHalle.Text = "°C";
            // 
            // lb_tempHalle
            // 
            this.lb_tempHalle.AutoSize = true;
            this.lb_tempHalle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_tempHalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tempHalle.Location = new System.Drawing.Point(3, 103);
            this.lb_tempHalle.Name = "lb_tempHalle";
            this.lb_tempHalle.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.lb_tempHalle.Size = new System.Drawing.Size(135, 50);
            this.lb_tempHalle.TabIndex = 13;
            this.lb_tempHalle.Text = "Temperatur Halle:";
            this.lb_tempHalle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_tempAuto
            // 
            this.lb_tempAuto.AutoSize = true;
            this.lb_tempAuto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_tempAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tempAuto.Location = new System.Drawing.Point(3, 53);
            this.lb_tempAuto.Name = "lb_tempAuto";
            this.lb_tempAuto.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.lb_tempAuto.Size = new System.Drawing.Size(133, 50);
            this.lb_tempAuto.TabIndex = 12;
            this.lb_tempAuto.Text = "Temperatur Auto:";
            this.lb_tempAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_einheitDruck
            // 
            this.lb_einheitDruck.AutoSize = true;
            this.lb_einheitDruck.Location = new System.Drawing.Point(394, 21);
            this.lb_einheitDruck.Name = "lb_einheitDruck";
            this.lb_einheitDruck.Size = new System.Drawing.Size(28, 16);
            this.lb_einheitDruck.TabIndex = 11;
            this.lb_einheitDruck.Text = "bar";
            // 
            // lb_Druck
            // 
            this.lb_Druck.AutoSize = true;
            this.lb_Druck.BackColor = System.Drawing.Color.Transparent;
            this.lb_Druck.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Druck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Druck.Location = new System.Drawing.Point(3, 3);
            this.lb_Druck.Name = "lb_Druck";
            this.lb_Druck.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.lb_Druck.Size = new System.Drawing.Size(55, 50);
            this.lb_Druck.TabIndex = 10;
            this.lb_Druck.Text = "Druck:";
            this.lb_Druck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // p_Druck
            // 
            this.p_Druck.BackColor = System.Drawing.Color.Red;
            this.p_Druck.Location = new System.Drawing.Point(175, 8);
            this.p_Druck.Name = "p_Druck";
            this.p_Druck.Size = new System.Drawing.Size(190, 50);
            this.p_Druck.TabIndex = 43;
            this.p_Druck.Visible = false;
            // 
            // p_TempA
            // 
            this.p_TempA.BackColor = System.Drawing.Color.Red;
            this.p_TempA.Location = new System.Drawing.Point(175, 58);
            this.p_TempA.Name = "p_TempA";
            this.p_TempA.Size = new System.Drawing.Size(190, 50);
            this.p_TempA.TabIndex = 44;
            this.p_TempA.Visible = false;
            // 
            // pB_TempAuto
            // 
            this.pB_TempAuto.Location = new System.Drawing.Point(180, 113);
            this.pB_TempAuto.Name = "pB_TempAuto";
            this.pB_TempAuto.Size = new System.Drawing.Size(180, 40);
            this.pB_TempAuto.TabIndex = 31;
            // 
            // p_TempH
            // 
            this.p_TempH.BackColor = System.Drawing.Color.Red;
            this.p_TempH.Location = new System.Drawing.Point(175, 108);
            this.p_TempH.Name = "p_TempH";
            this.p_TempH.Size = new System.Drawing.Size(190, 50);
            this.p_TempH.TabIndex = 45;
            this.p_TempH.Visible = false;
            // 
            // tabSeite2
            // 
            this.tabSeite2.BackColor = System.Drawing.SystemColors.Control;
            this.tabSeite2.Controls.Add(this.lb_Datum2);
            this.tabSeite2.Controls.Add(this.bt_AswTan);
            this.tabSeite2.Controls.Add(this.bt_AswTah);
            this.tabSeite2.Controls.Add(this.bt_AswThn);
            this.tabSeite2.Controls.Add(this.bt_AswThh);
            this.tabSeite2.Controls.Add(this.bt_AswDn);
            this.tabSeite2.Controls.Add(this.bt_AswDh);
            this.tabSeite2.Controls.Add(this.tb_AswTempAuto);
            this.tabSeite2.Controls.Add(this.tb_AswTempHalle);
            this.tabSeite2.Controls.Add(this.tb_AswDruck);
            this.tabSeite2.Controls.Add(this.label5);
            this.tabSeite2.Controls.Add(this.label2);
            this.tabSeite2.Controls.Add(this.label6);
            this.tabSeite2.Controls.Add(this.label1);
            this.tabSeite2.Controls.Add(this.label3);
            this.tabSeite2.Controls.Add(this.label4);
            this.tabSeite2.Location = new System.Drawing.Point(4, 25);
            this.tabSeite2.Name = "tabSeite2";
            this.tabSeite2.Padding = new System.Windows.Forms.Padding(3);
            this.tabSeite2.Size = new System.Drawing.Size(526, 353);
            this.tabSeite2.TabIndex = 1;
            this.tabSeite2.Text = "Alarmschwellen";
            // 
            // lb_Datum2
            // 
            this.lb_Datum2.AutoSize = true;
            this.lb_Datum2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lb_Datum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Datum2.Location = new System.Drawing.Point(3, 334);
            this.lb_Datum2.Name = "lb_Datum2";
            this.lb_Datum2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lb_Datum2.Size = new System.Drawing.Size(95, 16);
            this.lb_Datum2.TabIndex = 33;
            this.lb_Datum2.Text = "Datum_Uhrzeit";
            this.lb_Datum2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_AswTan
            // 
            this.bt_AswTan.Enabled = false;
            this.bt_AswTan.Location = new System.Drawing.Point(247, 128);
            this.bt_AswTan.Name = "bt_AswTan";
            this.bt_AswTan.Size = new System.Drawing.Size(30, 30);
            this.bt_AswTan.TabIndex = 32;
            this.bt_AswTan.Text = "-";
            this.bt_AswTan.UseVisualStyleBackColor = true;
            this.bt_AswTan.Click += new System.EventHandler(this.bt_AswTan_Click);
            // 
            // bt_AswTah
            // 
            this.bt_AswTah.Enabled = false;
            this.bt_AswTah.Location = new System.Drawing.Point(247, 92);
            this.bt_AswTah.Name = "bt_AswTah";
            this.bt_AswTah.Size = new System.Drawing.Size(30, 30);
            this.bt_AswTah.TabIndex = 31;
            this.bt_AswTah.Text = "+";
            this.bt_AswTah.UseVisualStyleBackColor = true;
            this.bt_AswTah.Click += new System.EventHandler(this.bt_AswTah_Click);
            // 
            // bt_AswThn
            // 
            this.bt_AswThn.Enabled = false;
            this.bt_AswThn.Location = new System.Drawing.Point(247, 216);
            this.bt_AswThn.Name = "bt_AswThn";
            this.bt_AswThn.Size = new System.Drawing.Size(30, 30);
            this.bt_AswThn.TabIndex = 30;
            this.bt_AswThn.Text = "-";
            this.bt_AswThn.UseVisualStyleBackColor = true;
            this.bt_AswThn.Click += new System.EventHandler(this.bt_AswThn_Click);
            // 
            // bt_AswThh
            // 
            this.bt_AswThh.Enabled = false;
            this.bt_AswThh.Location = new System.Drawing.Point(247, 180);
            this.bt_AswThh.Name = "bt_AswThh";
            this.bt_AswThh.Size = new System.Drawing.Size(30, 30);
            this.bt_AswThh.TabIndex = 29;
            this.bt_AswThh.Text = "+";
            this.bt_AswThh.UseVisualStyleBackColor = true;
            this.bt_AswThh.Click += new System.EventHandler(this.bt_AswThh_Click);
            // 
            // bt_AswDn
            // 
            this.bt_AswDn.Enabled = false;
            this.bt_AswDn.Location = new System.Drawing.Point(247, 42);
            this.bt_AswDn.Name = "bt_AswDn";
            this.bt_AswDn.Size = new System.Drawing.Size(30, 30);
            this.bt_AswDn.TabIndex = 28;
            this.bt_AswDn.Text = "-";
            this.bt_AswDn.UseVisualStyleBackColor = true;
            this.bt_AswDn.Click += new System.EventHandler(this.bt_AswDn_Click);
            // 
            // bt_AswDh
            // 
            this.bt_AswDh.Enabled = false;
            this.bt_AswDh.Location = new System.Drawing.Point(247, 6);
            this.bt_AswDh.Name = "bt_AswDh";
            this.bt_AswDh.Size = new System.Drawing.Size(30, 30);
            this.bt_AswDh.TabIndex = 27;
            this.bt_AswDh.Text = "+";
            this.bt_AswDh.UseVisualStyleBackColor = true;
            this.bt_AswDh.Click += new System.EventHandler(this.bt_AswDh_Click);
            // 
            // tb_AswTempAuto
            // 
            this.tb_AswTempAuto.Enabled = false;
            this.tb_AswTempAuto.Location = new System.Drawing.Point(144, 106);
            this.tb_AswTempAuto.Name = "tb_AswTempAuto";
            this.tb_AswTempAuto.Size = new System.Drawing.Size(63, 22);
            this.tb_AswTempAuto.TabIndex = 26;
            this.tb_AswTempAuto.Text = "0";
            this.tb_AswTempAuto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_AswTempAuto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_AswTempAuto_KeyDown);
            // 
            // tb_AswTempHalle
            // 
            this.tb_AswTempHalle.Enabled = false;
            this.tb_AswTempHalle.Location = new System.Drawing.Point(144, 200);
            this.tb_AswTempHalle.Name = "tb_AswTempHalle";
            this.tb_AswTempHalle.Size = new System.Drawing.Size(63, 22);
            this.tb_AswTempHalle.TabIndex = 25;
            this.tb_AswTempHalle.Text = "0";
            this.tb_AswTempHalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_AswTempHalle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_AswTempHalle_KeyDown);
            // 
            // tb_AswDruck
            // 
            this.tb_AswDruck.Enabled = false;
            this.tb_AswDruck.Location = new System.Drawing.Point(144, 33);
            this.tb_AswDruck.Name = "tb_AswDruck";
            this.tb_AswDruck.Size = new System.Drawing.Size(63, 22);
            this.tb_AswDruck.TabIndex = 24;
            this.tb_AswDruck.Text = "0";
            this.tb_AswDruck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_AswDruck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_AswDruck_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "°C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "°C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Druck <";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "bar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Temperatur Halle <";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Temperatur Auto <";
            // 
            // T_DatumUhrzeit
            // 
            this.T_DatumUhrzeit.Enabled = true;
            this.T_DatumUhrzeit.Interval = 500;
            this.T_DatumUhrzeit.Tick += new System.EventHandler(this.T_DatumUhrzeit_Tick);
            // 
            // T_VerbindungPruefen
            // 
            this.T_VerbindungPruefen.Enabled = true;
            this.T_VerbindungPruefen.Interval = 10000;
            this.T_VerbindungPruefen.Tick += new System.EventHandler(this.T_VerbindungPruefen_Tick);
            // 
            // T_AktualisiereWerte
            // 
            this.T_AktualisiereWerte.Enabled = true;
            this.T_AktualisiereWerte.Interval = 5000;
            this.T_AktualisiereWerte.Tick += new System.EventHandler(this.AktualisiereWerte_Tick);
            // 
            // T_SamstagsMail
            // 
            this.T_SamstagsMail.Enabled = true;
            this.T_SamstagsMail.Interval = 60000;
            this.T_SamstagsMail.Tick += new System.EventHandler(this.T_SamstagsMail_Tick);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 406);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(550, 445);
            this.Name = "main";
            this.Text = "FF-7Hirten RFL 2000";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.tabSeite1.ResumeLayout(false);
            this.tabSeite1.PerformLayout();
            this.tabSeite2.ResumeLayout(false);
            this.tabSeite2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benutzerToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabSeite2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabSeite1;
        private System.Windows.Forms.TextBox tb_wertTAuto;
        private System.Windows.Forms.TextBox tb_wertTHalle;
        private System.Windows.Forms.TextBox tb_wertDruck;
        private System.Windows.Forms.Label lb_einheitTAuto;
        private System.Windows.Forms.Label lb_einheitTHalle;
        private System.Windows.Forms.Label lb_tempHalle;
        private System.Windows.Forms.Label lb_tempAuto;
        private System.Windows.Forms.Label lb_einheitDruck;
        private System.Windows.Forms.Label lb_Druck;
        private System.Windows.Forms.TextBox tb_AswTempAuto;
        private System.Windows.Forms.TextBox tb_AswTempHalle;
        private System.Windows.Forms.TextBox tb_AswDruck;
        private System.Windows.Forms.Label lb_Datum1;
        private System.Windows.Forms.Timer T_DatumUhrzeit;
        private System.Windows.Forms.ProgressBar pB_Druck;
        private System.Windows.Forms.ProgressBar pB_TempAuto;
        private System.Windows.Forms.ProgressBar pB_TempHalle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_AswDn;
        private System.Windows.Forms.Button bt_AswDh;
        private System.Windows.Forms.Button bt_AswThn;
        private System.Windows.Forms.Button bt_AswThh;
        private System.Windows.Forms.Button bt_AswTan;
        private System.Windows.Forms.Button bt_AswTah;
        private System.Windows.Forms.Button bt_Trend;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_DbVerbunden;
        private System.Windows.Forms.Label lb_FahrzeugVerbunden;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer T_VerbindungPruefen;
        private System.Windows.Forms.Timer T_AktualisiereWerte;
        private System.Windows.Forms.Label lb_Datum2;
        private System.Windows.Forms.Panel p_Druck;
        private System.Windows.Forms.Timer T_SamstagsMail;
        private System.Windows.Forms.Panel p_TempA;
        private System.Windows.Forms.Panel p_TempH;
    }
}

