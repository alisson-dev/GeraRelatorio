namespace UIWindows1
{
    partial class frmExcluiDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExcluiDados));
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscaCnpj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.mskDataEx = new System.Windows.Forms.MaskedTextBox();
            this.txtExCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExParametro = new System.Windows.Forms.TextBox();
            this.txtExNire = new System.Windows.Forms.TextBox();
            this.txtExCnpj = new System.Windows.Forms.TextBox();
            this.txtExEmpresa = new System.Windows.Forms.TextBox();
            this.txtExRegistro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gpbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(393, 232);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(128, 23);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(414, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscaCnpj
            // 
            this.txtBuscaCnpj.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscaCnpj.Location = new System.Drawing.Point(219, 19);
            this.txtBuscaCnpj.Name = "txtBuscaCnpj";
            this.txtBuscaCnpj.Size = new System.Drawing.Size(189, 20);
            this.txtBuscaCnpj.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Informe o CNPJ ou o Nome da Empresa:";
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.mskDataEx);
            this.gpbDados.Controls.Add(this.txtExCodigo);
            this.gpbDados.Controls.Add(this.label8);
            this.gpbDados.Controls.Add(this.txtExParametro);
            this.gpbDados.Controls.Add(this.txtExNire);
            this.gpbDados.Controls.Add(this.txtExCnpj);
            this.gpbDados.Controls.Add(this.txtExEmpresa);
            this.gpbDados.Controls.Add(this.txtExRegistro);
            this.gpbDados.Controls.Add(this.label7);
            this.gpbDados.Controls.Add(this.label6);
            this.gpbDados.Controls.Add(this.label5);
            this.gpbDados.Controls.Add(this.label4);
            this.gpbDados.Controls.Add(this.label3);
            this.gpbDados.Controls.Add(this.label9);
            this.gpbDados.Location = new System.Drawing.Point(-3, 46);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(524, 182);
            this.gpbDados.TabIndex = 28;
            this.gpbDados.TabStop = false;
            // 
            // mskDataEx
            // 
            this.mskDataEx.Location = new System.Drawing.Point(90, 18);
            this.mskDataEx.Mask = "00/00/0000";
            this.mskDataEx.Name = "mskDataEx";
            this.mskDataEx.Size = new System.Drawing.Size(75, 20);
            this.mskDataEx.TabIndex = 3;
            this.mskDataEx.ValidatingType = typeof(System.DateTime);
            // 
            // txtExCodigo
            // 
            this.txtExCodigo.Location = new System.Drawing.Point(441, 18);
            this.txtExCodigo.Name = "txtExCodigo";
            this.txtExCodigo.Size = new System.Drawing.Size(68, 20);
            this.txtExCodigo.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "CÓDIGO:";
            // 
            // txtExParametro
            // 
            this.txtExParametro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExParametro.Location = new System.Drawing.Point(90, 153);
            this.txtExParametro.Name = "txtExParametro";
            this.txtExParametro.Size = new System.Drawing.Size(180, 20);
            this.txtExParametro.TabIndex = 8;
            // 
            // txtExNire
            // 
            this.txtExNire.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExNire.Location = new System.Drawing.Point(329, 87);
            this.txtExNire.Name = "txtExNire";
            this.txtExNire.Size = new System.Drawing.Size(180, 20);
            this.txtExNire.TabIndex = 6;
            // 
            // txtExCnpj
            // 
            this.txtExCnpj.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExCnpj.Location = new System.Drawing.Point(90, 87);
            this.txtExCnpj.Name = "txtExCnpj";
            this.txtExCnpj.Size = new System.Drawing.Size(180, 20);
            this.txtExCnpj.TabIndex = 5;
            // 
            // txtExEmpresa
            // 
            this.txtExEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExEmpresa.Location = new System.Drawing.Point(90, 53);
            this.txtExEmpresa.Name = "txtExEmpresa";
            this.txtExEmpresa.Size = new System.Drawing.Size(419, 20);
            this.txtExEmpresa.TabIndex = 4;
            // 
            // txtExRegistro
            // 
            this.txtExRegistro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExRegistro.Location = new System.Drawing.Point(90, 121);
            this.txtExRegistro.Name = "txtExRegistro";
            this.txtExRegistro.Size = new System.Drawing.Size(180, 20);
            this.txtExRegistro.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "PARÂMETRO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "REGISTRO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "NIRE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "CNPJ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "EMPRESA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "DATA:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(259, 232);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(128, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmExcluiDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 262);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscaCnpj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gpbDados);
            this.Controls.Add(this.btnExcluir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(549, 301);
            this.MinimumSize = new System.Drawing.Size(549, 301);
            this.Name = "frmExcluiDados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exclui Dados";
            this.Load += new System.EventHandler(this.frmExcluiDados_Load);
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscaCnpj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.TextBox txtExCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtExParametro;
        private System.Windows.Forms.TextBox txtExNire;
        private System.Windows.Forms.TextBox txtExCnpj;
        private System.Windows.Forms.TextBox txtExEmpresa;
        private System.Windows.Forms.TextBox txtExRegistro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox mskDataEx;
    }
}