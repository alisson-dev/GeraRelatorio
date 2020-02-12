namespace UIWindows1
{
    partial class frmAlteraDadosEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlteraDadosEmpresa));
            this.label5 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvAltEmpresa = new System.Windows.Forms.DataGridView();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.mskAltData = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAltCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAltParametro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAltNire = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAltCnpj = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAltEmpresa = new System.Windows.Forms.TextBox();
            this.txtAltRegistro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAltEmpresa)).BeginInit();
            this.gpbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 465);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Informe o nome da empresa:";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(472, 458);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(55, 23);
            this.btnFechar.TabIndex = 15;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(157, 461);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(173, 20);
            this.txtBuscar.TabIndex = 11;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(411, 458);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(55, 23);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(339, 459);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(55, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvAltEmpresa
            // 
            this.dgvAltEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAltEmpresa.Location = new System.Drawing.Point(13, 201);
            this.dgvAltEmpresa.Name = "dgvAltEmpresa";
            this.dgvAltEmpresa.Size = new System.Drawing.Size(514, 252);
            this.dgvAltEmpresa.TabIndex = 16;
            this.dgvAltEmpresa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAltEmpresa_CellDoubleClick);
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.mskAltData);
            this.gpbDados.Controls.Add(this.label2);
            this.gpbDados.Controls.Add(this.txtAltCodigo);
            this.gpbDados.Controls.Add(this.label3);
            this.gpbDados.Controls.Add(this.label8);
            this.gpbDados.Controls.Add(this.label4);
            this.gpbDados.Controls.Add(this.txtAltParametro);
            this.gpbDados.Controls.Add(this.label1);
            this.gpbDados.Controls.Add(this.txtAltNire);
            this.gpbDados.Controls.Add(this.label6);
            this.gpbDados.Controls.Add(this.txtAltCnpj);
            this.gpbDados.Controls.Add(this.label7);
            this.gpbDados.Controls.Add(this.txtAltEmpresa);
            this.gpbDados.Controls.Add(this.txtAltRegistro);
            this.gpbDados.Location = new System.Drawing.Point(13, 12);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(514, 183);
            this.gpbDados.TabIndex = 12;
            this.gpbDados.TabStop = false;
            // 
            // mskAltData
            // 
            this.mskAltData.Location = new System.Drawing.Point(87, 22);
            this.mskAltData.Mask = "00/00/0000";
            this.mskAltData.Name = "mskAltData";
            this.mskAltData.Size = new System.Drawing.Size(75, 20);
            this.mskAltData.TabIndex = 28;
            this.mskAltData.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "DATA:";
            // 
            // txtAltCodigo
            // 
            this.txtAltCodigo.Location = new System.Drawing.Point(438, 22);
            this.txtAltCodigo.Name = "txtAltCodigo";
            this.txtAltCodigo.Size = new System.Drawing.Size(68, 20);
            this.txtAltCodigo.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "EMPRESA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "CÓDIGO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "CNPJ:";
            // 
            // txtAltParametro
            // 
            this.txtAltParametro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAltParametro.Location = new System.Drawing.Point(87, 157);
            this.txtAltParametro.Name = "txtAltParametro";
            this.txtAltParametro.Size = new System.Drawing.Size(180, 20);
            this.txtAltParametro.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "NIRE:";
            // 
            // txtAltNire
            // 
            this.txtAltNire.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAltNire.Location = new System.Drawing.Point(326, 91);
            this.txtAltNire.Name = "txtAltNire";
            this.txtAltNire.Size = new System.Drawing.Size(180, 20);
            this.txtAltNire.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "REGISTRO:";
            // 
            // txtAltCnpj
            // 
            this.txtAltCnpj.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAltCnpj.Location = new System.Drawing.Point(87, 91);
            this.txtAltCnpj.Name = "txtAltCnpj";
            this.txtAltCnpj.Size = new System.Drawing.Size(180, 20);
            this.txtAltCnpj.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "PARÂMETRO:";
            // 
            // txtAltEmpresa
            // 
            this.txtAltEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAltEmpresa.Location = new System.Drawing.Point(87, 57);
            this.txtAltEmpresa.Name = "txtAltEmpresa";
            this.txtAltEmpresa.Size = new System.Drawing.Size(419, 20);
            this.txtAltEmpresa.TabIndex = 29;
            // 
            // txtAltRegistro
            // 
            this.txtAltRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAltRegistro.Location = new System.Drawing.Point(87, 125);
            this.txtAltRegistro.Name = "txtAltRegistro";
            this.txtAltRegistro.Size = new System.Drawing.Size(180, 20);
            this.txtAltRegistro.TabIndex = 32;
            // 
            // frmAlteraDadosEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 495);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvAltEmpresa);
            this.Controls.Add(this.gpbDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(555, 534);
            this.MinimumSize = new System.Drawing.Size(555, 534);
            this.Name = "frmAlteraDadosEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altera Dados Empresa";
            this.Load += new System.EventHandler(this.frmAlteraDadosEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAltEmpresa)).EndInit();
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvAltEmpresa;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.MaskedTextBox mskAltData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAltCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAltParametro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAltNire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAltCnpj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAltEmpresa;
        private System.Windows.Forms.TextBox txtAltRegistro;
    }
}