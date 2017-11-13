namespace ff_visio
{
    partial class benutzer
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
            if (disposing && (components != null))
            {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(benutzer));
            this.dgv_benutzer = new System.Windows.Forms.DataGridView();
            this.bt_schliessen = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bt_aktualisieren = new System.Windows.Forms.ToolStripButton();
            this.bt_hinzufuegen = new System.Windows.Forms.ToolStripButton();
            this.bt_loeschen = new System.Windows.Forms.ToolStripButton();
            this.bt_testMail = new System.Windows.Forms.Button();
            this.lb_DbVerbunden = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.T_VerbindungPruefen = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_benutzer)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_benutzer
            // 
            this.dgv_benutzer.AllowUserToAddRows = false;
            this.dgv_benutzer.AllowUserToDeleteRows = false;
            this.dgv_benutzer.AllowUserToOrderColumns = true;
            this.dgv_benutzer.AllowUserToResizeRows = false;
            this.dgv_benutzer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_benutzer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_benutzer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_benutzer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_benutzer.Location = new System.Drawing.Point(0, 28);
            this.dgv_benutzer.Name = "dgv_benutzer";
            this.dgv_benutzer.RowHeadersWidth = 50;
            this.dgv_benutzer.Size = new System.Drawing.Size(674, 275);
            this.dgv_benutzer.TabIndex = 0;
            this.dgv_benutzer.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_benutzer_CellValueChanged);
            // 
            // bt_schliessen
            // 
            this.bt_schliessen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_schliessen.Location = new System.Drawing.Point(587, 309);
            this.bt_schliessen.Name = "bt_schliessen";
            this.bt_schliessen.Size = new System.Drawing.Size(75, 23);
            this.bt_schliessen.TabIndex = 3;
            this.bt_schliessen.Text = "Schließen";
            this.bt_schliessen.UseVisualStyleBackColor = true;
            this.bt_schliessen.Click += new System.EventHandler(this.bt_schliessen_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_aktualisieren,
            this.bt_hinzufuegen,
            this.bt_loeschen});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(674, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bt_aktualisieren
            // 
            this.bt_aktualisieren.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_aktualisieren.Image = ((System.Drawing.Image)(resources.GetObject("bt_aktualisieren.Image")));
            this.bt_aktualisieren.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_aktualisieren.Name = "bt_aktualisieren";
            this.bt_aktualisieren.Size = new System.Drawing.Size(23, 22);
            this.bt_aktualisieren.Text = "Aktualisieren";
            this.bt_aktualisieren.Click += new System.EventHandler(this.aktualisierenToolStripButton_Click);
            // 
            // bt_hinzufuegen
            // 
            this.bt_hinzufuegen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_hinzufuegen.Image = ((System.Drawing.Image)(resources.GetObject("bt_hinzufuegen.Image")));
            this.bt_hinzufuegen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_hinzufuegen.Name = "bt_hinzufuegen";
            this.bt_hinzufuegen.Size = new System.Drawing.Size(23, 22);
            this.bt_hinzufuegen.Text = "Neu";
            this.bt_hinzufuegen.Click += new System.EventHandler(this.hinzufuegen_Click);
            // 
            // bt_loeschen
            // 
            this.bt_loeschen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bt_loeschen.Image = ((System.Drawing.Image)(resources.GetObject("bt_loeschen.Image")));
            this.bt_loeschen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_loeschen.Name = "bt_loeschen";
            this.bt_loeschen.Size = new System.Drawing.Size(23, 22);
            this.bt_loeschen.Text = "Löschen";
            this.bt_loeschen.ToolTipText = "Löschen";
            this.bt_loeschen.Click += new System.EventHandler(this.bt_loeschen_Click);
            // 
            // bt_testMail
            // 
            this.bt_testMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_testMail.Location = new System.Drawing.Point(206, 309);
            this.bt_testMail.Name = "bt_testMail";
            this.bt_testMail.Size = new System.Drawing.Size(101, 23);
            this.bt_testMail.TabIndex = 5;
            this.bt_testMail.Text = "Test Mail";
            this.bt_testMail.UseVisualStyleBackColor = true;
            this.bt_testMail.Click += new System.EventHandler(this.bt_testMail_Click);
            // 
            // lb_DbVerbunden
            // 
            this.lb_DbVerbunden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_DbVerbunden.AutoSize = true;
            this.lb_DbVerbunden.BackColor = System.Drawing.SystemColors.Control;
            this.lb_DbVerbunden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DbVerbunden.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_DbVerbunden.Location = new System.Drawing.Point(135, 309);
            this.lb_DbVerbunden.Name = "lb_DbVerbunden";
            this.lb_DbVerbunden.Size = new System.Drawing.Size(38, 24);
            this.lb_DbVerbunden.TabIndex = 44;
            this.lb_DbVerbunden.Text = "XX";
            this.lb_DbVerbunden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 314);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Datenbank verbunden:";
            // 
            // T_VerbindungPruefen
            // 
            this.T_VerbindungPruefen.Enabled = true;
            this.T_VerbindungPruefen.Interval = 5000;
            this.T_VerbindungPruefen.Tick += new System.EventHandler(this.T_VerbindungPruefen_Tick);
            // 
            // benutzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 364);
            this.ControlBox = false;
            this.Controls.Add(this.lb_DbVerbunden);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.bt_testMail);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.bt_schliessen);
            this.Controls.Add(this.dgv_benutzer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(690, 380);
            this.Name = "benutzer";
            this.ShowInTaskbar = false;
            this.Text = "Benutzer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.benutzer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_benutzer)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_benutzer;
        private System.Windows.Forms.Button bt_schliessen;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bt_aktualisieren;
        private System.Windows.Forms.ToolStripButton bt_hinzufuegen;
        private System.Windows.Forms.ToolStripButton bt_loeschen;
        private System.Windows.Forms.Button bt_testMail;
        private System.Windows.Forms.Label lb_DbVerbunden;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer T_VerbindungPruefen;
    }
}