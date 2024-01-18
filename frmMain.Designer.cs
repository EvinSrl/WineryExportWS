namespace WineryExportWS
{
    partial class frmMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impostazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AbilitaEsportazione = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SecondiIntervallo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cartella = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEsportaconferimenti = new System.Windows.Forms.Button();
            this.CmbCampagna = new System.Windows.Forms.ComboBox();
            this.chkPesate = new System.Windows.Forms.CheckBox();
            this.Chkvarieta = new System.Windows.Forms.CheckBox();
            this.chksoci = new System.Windows.Forms.CheckBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(720, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impostazioniToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // impostazioniToolStripMenuItem
            // 
            this.impostazioniToolStripMenuItem.Name = "impostazioniToolStripMenuItem";
            this.impostazioniToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.impostazioniToolStripMenuItem.Text = "Impostazioni";
            this.impostazioniToolStripMenuItem.Click += new System.EventHandler(this.impostazioniToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AbilitaEsportazione
            // 
            this.AbilitaEsportazione.AutoSize = true;
            this.AbilitaEsportazione.Location = new System.Drawing.Point(88, 71);
            this.AbilitaEsportazione.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AbilitaEsportazione.Name = "AbilitaEsportazione";
            this.AbilitaEsportazione.Size = new System.Drawing.Size(195, 18);
            this.AbilitaEsportazione.TabIndex = 2;
            this.AbilitaEsportazione.Text = "Abilita Esportazione Analisi";
            this.AbilitaEsportazione.UseVisualStyleBackColor = true;
            this.AbilitaEsportazione.CheckedChanged += new System.EventHandler(this.AbilitaEsportazione_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Intervallo:";
            // 
            // SecondiIntervallo
            // 
            this.SecondiIntervallo.Enabled = false;
            this.SecondiIntervallo.Location = new System.Drawing.Point(177, 106);
            this.SecondiIntervallo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SecondiIntervallo.Name = "SecondiIntervallo";
            this.SecondiIntervallo.Size = new System.Drawing.Size(106, 22);
            this.SecondiIntervallo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Secondi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 453);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(720, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(705, 17);
            this.StatusLabel.Spring = true;
            // 
            // cartella
            // 
            this.cartella.Enabled = false;
            this.cartella.Location = new System.Drawing.Point(177, 134);
            this.cartella.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cartella.Name = "cartella";
            this.cartella.Size = new System.Drawing.Size(265, 22);
            this.cartella.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cartella";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEsportaconferimenti);
            this.groupBox1.Controls.Add(this.CmbCampagna);
            this.groupBox1.Controls.Add(this.chkPesate);
            this.groupBox1.Controls.Add(this.Chkvarieta);
            this.groupBox1.Controls.Add(this.chksoci);
            this.groupBox1.Location = new System.Drawing.Point(21, 321);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 119);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "conferimenti";
            // 
            // btnEsportaconferimenti
            // 
            this.btnEsportaconferimenti.Location = new System.Drawing.Point(448, 67);
            this.btnEsportaconferimenti.Name = "btnEsportaconferimenti";
            this.btnEsportaconferimenti.Size = new System.Drawing.Size(157, 37);
            this.btnEsportaconferimenti.TabIndex = 4;
            this.btnEsportaconferimenti.Text = "EsportaConferimenti";
            this.btnEsportaconferimenti.UseVisualStyleBackColor = true;
            this.btnEsportaconferimenti.Click += new System.EventHandler(this.btnEsportaconferimenti_Click);
            // 
            // CmbCampagna
            // 
            this.CmbCampagna.FormattingEnabled = true;
            this.CmbCampagna.Location = new System.Drawing.Point(200, 27);
            this.CmbCampagna.Name = "CmbCampagna";
            this.CmbCampagna.Size = new System.Drawing.Size(208, 22);
            this.CmbCampagna.TabIndex = 3;
            // 
            // chkPesate
            // 
            this.chkPesate.AutoSize = true;
            this.chkPesate.Checked = true;
            this.chkPesate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPesate.Location = new System.Drawing.Point(29, 78);
            this.chkPesate.Name = "chkPesate";
            this.chkPesate.Size = new System.Drawing.Size(70, 18);
            this.chkPesate.TabIndex = 2;
            this.chkPesate.Text = "Pesate";
            this.chkPesate.UseVisualStyleBackColor = true;
            // 
            // Chkvarieta
            // 
            this.Chkvarieta.AutoSize = true;
            this.Chkvarieta.Checked = true;
            this.Chkvarieta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Chkvarieta.Location = new System.Drawing.Point(29, 54);
            this.Chkvarieta.Name = "Chkvarieta";
            this.Chkvarieta.Size = new System.Drawing.Size(70, 18);
            this.Chkvarieta.TabIndex = 1;
            this.Chkvarieta.Text = "Varietà";
            this.Chkvarieta.UseVisualStyleBackColor = true;
            // 
            // chksoci
            // 
            this.chksoci.AutoSize = true;
            this.chksoci.Checked = true;
            this.chksoci.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chksoci.Location = new System.Drawing.Point(29, 30);
            this.chksoci.Name = "chksoci";
            this.chksoci.Size = new System.Drawing.Size(51, 18);
            this.chksoci.TabIndex = 0;
            this.chksoci.Text = "Soci";
            this.chksoci.UseVisualStyleBackColor = true;
            // 
            // btnInvia
            // 
            this.btnInvia.Location = new System.Drawing.Point(47, 245);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(161, 56);
            this.btnInvia.TabIndex = 10;
            this.btnInvia.Text = "Invia file analisi";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "BArcode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 475);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cartella);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SecondiIntervallo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AbilitaEsportazione);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.Text = "Winery Export Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impostazioniToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox AbilitaEsportazione;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SecondiIntervallo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.TextBox cartella;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEsportaconferimenti;
        private System.Windows.Forms.ComboBox CmbCampagna;
        private System.Windows.Forms.CheckBox chkPesate;
        private System.Windows.Forms.CheckBox Chkvarieta;
        private System.Windows.Forms.CheckBox chksoci;
        private System.Windows.Forms.Button btnInvia;
        private System.Windows.Forms.Button button1;
    }
}

