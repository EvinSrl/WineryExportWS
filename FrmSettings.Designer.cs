namespace WineryExportWS
{
    partial class FrmSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CartellaExport = new System.Windows.Forms.TextBox();
            this.CodiceAzienda = new System.Windows.Forms.TextBox();
            this.PartitaIva = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalva = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SecondiIntervallo = new System.Windows.Forms.NumericUpDown();
            this.IndirizooWs = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AbilitaEsportazione = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondiIntervallo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AbilitaEsportazione);
            this.groupBox1.Controls.Add(this.IndirizooWs);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.SecondiIntervallo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.CartellaExport);
            this.groupBox1.Controls.Add(this.CodiceAzienda);
            this.groupBox1.Controls.Add(this.PartitaIva);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.Username);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(751, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Impostazioni";
            // 
            // CartellaExport
            // 
            this.CartellaExport.Location = new System.Drawing.Point(190, 183);
            this.CartellaExport.Name = "CartellaExport";
            this.CartellaExport.Size = new System.Drawing.Size(307, 22);
            this.CartellaExport.TabIndex = 9;
            // 
            // CodiceAzienda
            // 
            this.CodiceAzienda.Location = new System.Drawing.Point(190, 144);
            this.CodiceAzienda.Name = "CodiceAzienda";
            this.CodiceAzienda.Size = new System.Drawing.Size(307, 22);
            this.CodiceAzienda.TabIndex = 8;
            // 
            // PartitaIva
            // 
            this.PartitaIva.Location = new System.Drawing.Point(190, 105);
            this.PartitaIva.Name = "PartitaIva";
            this.PartitaIva.Size = new System.Drawing.Size(178, 22);
            this.PartitaIva.TabIndex = 7;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(190, 66);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(178, 22);
            this.Password.TabIndex = 6;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(190, 27);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(178, 22);
            this.Username.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 187);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cartella Export:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Codice Azienda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Partita IVA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(625, 411);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(126, 43);
            this.btnSalva.TabIndex = 1;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 246);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "Intervallo in secondi:";
            // 
            // SecondiIntervallo
            // 
            this.SecondiIntervallo.Location = new System.Drawing.Point(191, 243);
            this.SecondiIntervallo.Name = "SecondiIntervallo";
            this.SecondiIntervallo.Size = new System.Drawing.Size(235, 22);
            this.SecondiIntervallo.TabIndex = 11;
            // 
            // IndirizooWs
            // 
            this.IndirizooWs.Location = new System.Drawing.Point(190, 282);
            this.IndirizooWs.Name = "IndirizooWs";
            this.IndirizooWs.Size = new System.Drawing.Size(307, 22);
            this.IndirizooWs.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 286);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "Indirizzo WS";
            // 
            // AbilitaEsportazione
            // 
            this.AbilitaEsportazione.AutoSize = true;
            this.AbilitaEsportazione.Location = new System.Drawing.Point(191, 326);
            this.AbilitaEsportazione.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AbilitaEsportazione.Name = "AbilitaEsportazione";
            this.AbilitaEsportazione.Size = new System.Drawing.Size(195, 18);
            this.AbilitaEsportazione.TabIndex = 14;
            this.AbilitaEsportazione.Text = "Abilita Esportazione Analisi";
            this.AbilitaEsportazione.UseVisualStyleBackColor = true;
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 468);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmSettings";
            this.Text = "Impostazioni";
            this.Load += new System.EventHandler(this.FrmSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondiIntervallo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CartellaExport;
        private System.Windows.Forms.TextBox CodiceAzienda;
        private System.Windows.Forms.TextBox PartitaIva;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.NumericUpDown SecondiIntervallo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IndirizooWs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox AbilitaEsportazione;
    }
}