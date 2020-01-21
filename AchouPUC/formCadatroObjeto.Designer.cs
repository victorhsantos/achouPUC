namespace AchouPUC
{
    partial class formCadatroObjeto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadatroObjeto));
            this.gb_Ident = new System.Windows.Forms.GroupBox();
            this.tb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.tb_Identidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_TipoCadastro = new System.Windows.Forms.ComboBox();
            this.tb_DescObj = new System.Windows.Forms.RichTextBox();
            this.tb_CorObj = new System.Windows.Forms.TextBox();
            this.tb_NomeObj = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_Sala = new System.Windows.Forms.MaskedTextBox();
            this.tb_Predio = new System.Windows.Forms.MaskedTextBox();
            this.cb_Unidade = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_Complemento = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_Salvar = new System.Windows.Forms.Button();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            this.bt_Baixa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gb_Ident.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Ident
            // 
            this.gb_Ident.Controls.Add(this.pictureBox1);
            this.gb_Ident.Controls.Add(this.tb_Telefone);
            this.gb_Ident.Controls.Add(this.tb_Nome);
            this.gb_Ident.Controls.Add(this.tb_Identidade);
            this.gb_Ident.Controls.Add(this.label9);
            this.gb_Ident.Controls.Add(this.label10);
            this.gb_Ident.Controls.Add(this.label11);
            this.gb_Ident.Location = new System.Drawing.Point(12, 12);
            this.gb_Ident.Name = "gb_Ident";
            this.gb_Ident.Size = new System.Drawing.Size(533, 108);
            this.gb_Ident.TabIndex = 1;
            this.gb_Ident.TabStop = false;
            this.gb_Ident.Text = "Informações do Identificador";
            // 
            // tb_Telefone
            // 
            this.tb_Telefone.Location = new System.Drawing.Point(394, 59);
            this.tb_Telefone.Mask = "(99) 00000-0000";
            this.tb_Telefone.Name = "tb_Telefone";
            this.tb_Telefone.Size = new System.Drawing.Size(127, 26);
            this.tb_Telefone.TabIndex = 4;
            this.tb_Telefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(233, 59);
            this.tb_Nome.MaxLength = 50;
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(155, 26);
            this.tb_Nome.TabIndex = 3;
            // 
            // tb_Identidade
            // 
            this.tb_Identidade.Location = new System.Drawing.Point(20, 59);
            this.tb_Identidade.MaxLength = 20;
            this.tb_Identidade.Name = "tb_Identidade";
            this.tb_Identidade.Size = new System.Drawing.Size(207, 26);
            this.tb_Identidade.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(391, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Telefone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(230, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nome:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "Identidade:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cb_TipoCadastro);
            this.groupBox1.Controls.Add(this.tb_DescObj);
            this.groupBox1.Controls.Add(this.tb_CorObj);
            this.groupBox1.Controls.Add(this.tb_NomeObj);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 189);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações do Objeto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Cadastro:";
            // 
            // cb_TipoCadastro
            // 
            this.cb_TipoCadastro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TipoCadastro.FormattingEnabled = true;
            this.cb_TipoCadastro.Items.AddRange(new object[] {
            "Objeto Perdido",
            "Objeto Encontrado"});
            this.cb_TipoCadastro.Location = new System.Drawing.Point(19, 70);
            this.cb_TipoCadastro.Name = "cb_TipoCadastro";
            this.cb_TipoCadastro.Size = new System.Drawing.Size(208, 26);
            this.cb_TipoCadastro.TabIndex = 1;
            this.cb_TipoCadastro.SelectedIndexChanged += new System.EventHandler(this.cb_TipoCadastro_SelectedIndexChanged);
            // 
            // tb_DescObj
            // 
            this.tb_DescObj.Location = new System.Drawing.Point(19, 120);
            this.tb_DescObj.MaxLength = 500;
            this.tb_DescObj.Name = "tb_DescObj";
            this.tb_DescObj.Size = new System.Drawing.Size(502, 57);
            this.tb_DescObj.TabIndex = 8;
            this.tb_DescObj.Text = "";
            // 
            // tb_CorObj
            // 
            this.tb_CorObj.Location = new System.Drawing.Point(394, 70);
            this.tb_CorObj.Name = "tb_CorObj";
            this.tb_CorObj.Size = new System.Drawing.Size(127, 26);
            this.tb_CorObj.TabIndex = 7;
            // 
            // tb_NomeObj
            // 
            this.tb_NomeObj.Location = new System.Drawing.Point(233, 70);
            this.tb_NomeObj.Name = "tb_NomeObj";
            this.tb_NomeObj.Size = new System.Drawing.Size(155, 26);
            this.tb_NomeObj.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Descrição:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cor Predominante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome Objeto:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.tb_Sala);
            this.groupBox2.Controls.Add(this.tb_Predio);
            this.groupBox2.Controls.Add(this.cb_Unidade);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_Complemento);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(12, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 189);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações do Local";
            // 
            // tb_Sala
            // 
            this.tb_Sala.Location = new System.Drawing.Point(394, 58);
            this.tb_Sala.Mask = "000";
            this.tb_Sala.Name = "tb_Sala";
            this.tb_Sala.Size = new System.Drawing.Size(127, 26);
            this.tb_Sala.TabIndex = 12;
            this.tb_Sala.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Predio
            // 
            this.tb_Predio.Location = new System.Drawing.Point(233, 58);
            this.tb_Predio.Mask = "00";
            this.tb_Predio.Name = "tb_Predio";
            this.tb_Predio.Size = new System.Drawing.Size(157, 26);
            this.tb_Predio.TabIndex = 11;
            this.tb_Predio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cb_Unidade
            // 
            this.cb_Unidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Unidade.FormattingEnabled = true;
            this.cb_Unidade.Items.AddRange(new object[] {
            "PUC Barreiro",
            "PUC Betim",
            "PUC Contagem",
            "PUC Coração Eucaristico",
            "PUC Praça Liberdade",
            ""});
            this.cb_Unidade.Location = new System.Drawing.Point(21, 58);
            this.cb_Unidade.Name = "cb_Unidade";
            this.cb_Unidade.Size = new System.Drawing.Size(206, 26);
            this.cb_Unidade.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Sala:";
            // 
            // tb_Complemento
            // 
            this.tb_Complemento.Location = new System.Drawing.Point(20, 118);
            this.tb_Complemento.MaxLength = 500;
            this.tb_Complemento.Name = "tb_Complemento";
            this.tb_Complemento.Size = new System.Drawing.Size(501, 57);
            this.tb_Complemento.TabIndex = 13;
            this.tb_Complemento.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Complemento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Prédio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Unidade PUC:";
            // 
            // bt_Salvar
            // 
            this.bt_Salvar.Location = new System.Drawing.Point(422, 516);
            this.bt_Salvar.Name = "bt_Salvar";
            this.bt_Salvar.Size = new System.Drawing.Size(123, 34);
            this.bt_Salvar.TabIndex = 15;
            this.bt_Salvar.Text = "Salvar";
            this.bt_Salvar.UseVisualStyleBackColor = true;
            this.bt_Salvar.Click += new System.EventHandler(this.bt_Salvar_Click);
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.Location = new System.Drawing.Point(293, 516);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(123, 34);
            this.bt_Cancelar.TabIndex = 14;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            this.bt_Cancelar.Click += new System.EventHandler(this.bt_Cancelar_Click);
            // 
            // bt_Baixa
            // 
            this.bt_Baixa.Location = new System.Drawing.Point(422, 516);
            this.bt_Baixa.Name = "bt_Baixa";
            this.bt_Baixa.Size = new System.Drawing.Size(123, 34);
            this.bt_Baixa.TabIndex = 16;
            this.bt_Baixa.Text = "Retirar";
            this.bt_Baixa.UseVisualStyleBackColor = true;
            this.bt_Baixa.Click += new System.EventHandler(this.bt_Baixa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(210, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(169, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(159, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // formCadatroObjeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 558);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.gb_Ident);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.bt_Baixa);
            this.Controls.Add(this.bt_Salvar);
            this.Font = new System.Drawing.Font("Arial", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "formCadatroObjeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Objeto";
            this.Load += new System.EventHandler(this.formCadatroObjeto_Load);
            this.gb_Ident.ResumeLayout(false);
            this.gb_Ident.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Ident;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.TextBox tb_Identidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox tb_DescObj;
        private System.Windows.Forms.TextBox tb_CorObj;
        private System.Windows.Forms.TextBox tb_NomeObj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_Unidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox tb_Complemento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bt_Salvar;
        private System.Windows.Forms.Button bt_Cancelar;
        private System.Windows.Forms.Button bt_Baixa;
        private System.Windows.Forms.MaskedTextBox tb_Telefone;
        private System.Windows.Forms.MaskedTextBox tb_Sala;
        private System.Windows.Forms.MaskedTextBox tb_Predio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_TipoCadastro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}