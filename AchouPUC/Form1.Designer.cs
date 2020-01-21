namespace AchouPUC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.listarObjetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_Listar = new System.Windows.Forms.Button();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.lb_OP_NotFound = new System.Windows.Forms.Label();
            this.bt_OP_OK = new System.Windows.Forms.Button();
            this.dataGrid_OP_SelectPRJ = new System.Windows.Forms.DataGridView();
            this.tb_OP_SelectPRJ = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_OP_SelectPRJ)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.toolStripSeparator1,
            this.listarObjetosToolStripMenuItem,
            this.toolStripSeparator2,
            this.fecharToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.opçõesToolStripMenuItem.Text = "Inicio";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrarToolStripMenuItem.Image")));
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // listarObjetosToolStripMenuItem
            // 
            this.listarObjetosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listarObjetosToolStripMenuItem.Image")));
            this.listarObjetosToolStripMenuItem.Name = "listarObjetosToolStripMenuItem";
            this.listarObjetosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listarObjetosToolStripMenuItem.Text = "Listar";
            this.listarObjetosToolStripMenuItem.Click += new System.EventHandler(this.listarObjetosToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fecharToolStripMenuItem.Image")));
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // bt_Listar
            // 
            this.bt_Listar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Listar.Font = new System.Drawing.Font("Arial", 10F);
            this.bt_Listar.Image = ((System.Drawing.Image)(resources.GetObject("bt_Listar.Image")));
            this.bt_Listar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_Listar.Location = new System.Drawing.Point(6, 162);
            this.bt_Listar.Name = "bt_Listar";
            this.bt_Listar.Size = new System.Drawing.Size(266, 109);
            this.bt_Listar.TabIndex = 2;
            this.bt_Listar.Text = "Listar Todos Objetos";
            this.bt_Listar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_Listar.UseVisualStyleBackColor = true;
            this.bt_Listar.Click += new System.EventHandler(this.bt_Listar_Click);
            // 
            // bt_Cadastrar
            // 
            this.bt_Cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Cadastrar.Font = new System.Drawing.Font("Arial", 10F);
            this.bt_Cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("bt_Cadastrar.Image")));
            this.bt_Cadastrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_Cadastrar.Location = new System.Drawing.Point(6, 47);
            this.bt_Cadastrar.Name = "bt_Cadastrar";
            this.bt_Cadastrar.Size = new System.Drawing.Size(266, 109);
            this.bt_Cadastrar.TabIndex = 1;
            this.bt_Cadastrar.Text = "Cadastrar Objeto";
            this.bt_Cadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_Cadastrar.UseVisualStyleBackColor = true;
            this.bt_Cadastrar.Click += new System.EventHandler(this.bt_Cadastrar_Click);
            // 
            // bt_Sair
            // 
            this.bt_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Sair.Font = new System.Drawing.Font("Arial", 10F);
            this.bt_Sair.Image = ((System.Drawing.Image)(resources.GetObject("bt_Sair.Image")));
            this.bt_Sair.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_Sair.Location = new System.Drawing.Point(6, 277);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(266, 109);
            this.bt_Sair.TabIndex = 3;
            this.bt_Sair.Text = "Sair";
            this.bt_Sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_Sair.UseVisualStyleBackColor = true;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Sair);
            this.groupBox1.Controls.Add(this.bt_Cadastrar);
            this.groupBox1.Controls.Add(this.bt_Listar);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 421);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox12);
            this.groupBox2.Controls.Add(this.lb_OP_NotFound);
            this.groupBox2.Controls.Add(this.bt_OP_OK);
            this.groupBox2.Controls.Add(this.dataGrid_OP_SelectPRJ);
            this.groupBox2.Controls.Add(this.tb_OP_SelectPRJ);
            this.groupBox2.Controls.Add(this.label54);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F);
            this.groupBox2.Location = new System.Drawing.Point(305, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 421);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(233, 25);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(101, 88);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox12.TabIndex = 21;
            this.pictureBox12.TabStop = false;
            // 
            // lb_OP_NotFound
            // 
            this.lb_OP_NotFound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_OP_NotFound.AutoSize = true;
            this.lb_OP_NotFound.BackColor = System.Drawing.SystemColors.Window;
            this.lb_OP_NotFound.Font = new System.Drawing.Font("Arial", 9F);
            this.lb_OP_NotFound.Location = new System.Drawing.Point(190, 279);
            this.lb_OP_NotFound.Name = "lb_OP_NotFound";
            this.lb_OP_NotFound.Size = new System.Drawing.Size(182, 15);
            this.lb_OP_NotFound.TabIndex = 20;
            this.lb_OP_NotFound.Text = "Ops... Objeto não foi encontado!";
            this.lb_OP_NotFound.Visible = false;
            // 
            // bt_OP_OK
            // 
            this.bt_OP_OK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_OP_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_OP_OK.Image = ((System.Drawing.Image)(resources.GetObject("bt_OP_OK.Image")));
            this.bt_OP_OK.Location = new System.Drawing.Point(478, 187);
            this.bt_OP_OK.Name = "bt_OP_OK";
            this.bt_OP_OK.Size = new System.Drawing.Size(32, 26);
            this.bt_OP_OK.TabIndex = 6;
            this.bt_OP_OK.UseVisualStyleBackColor = true;
            this.bt_OP_OK.Click += new System.EventHandler(this.bt_OP_OK_Click);
            // 
            // dataGrid_OP_SelectPRJ
            // 
            this.dataGrid_OP_SelectPRJ.AllowUserToAddRows = false;
            this.dataGrid_OP_SelectPRJ.AllowUserToDeleteRows = false;
            this.dataGrid_OP_SelectPRJ.AllowUserToResizeColumns = false;
            this.dataGrid_OP_SelectPRJ.AllowUserToResizeRows = false;
            this.dataGrid_OP_SelectPRJ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGrid_OP_SelectPRJ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_OP_SelectPRJ.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGrid_OP_SelectPRJ.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_OP_SelectPRJ.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_OP_SelectPRJ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid_OP_SelectPRJ.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_OP_SelectPRJ.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_OP_SelectPRJ.EnableHeadersVisualStyles = false;
            this.dataGrid_OP_SelectPRJ.Location = new System.Drawing.Point(45, 221);
            this.dataGrid_OP_SelectPRJ.Name = "dataGrid_OP_SelectPRJ";
            this.dataGrid_OP_SelectPRJ.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_OP_SelectPRJ.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_OP_SelectPRJ.RowHeadersVisible = false;
            this.dataGrid_OP_SelectPRJ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_OP_SelectPRJ.ShowEditingIcon = false;
            this.dataGrid_OP_SelectPRJ.ShowRowErrors = false;
            this.dataGrid_OP_SelectPRJ.Size = new System.Drawing.Size(465, 165);
            this.dataGrid_OP_SelectPRJ.TabIndex = 7;
            this.dataGrid_OP_SelectPRJ.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_OP_SelectPRJ_CellContentClick);
            // 
            // tb_OP_SelectPRJ
            // 
            this.tb_OP_SelectPRJ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_OP_SelectPRJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_OP_SelectPRJ.Font = new System.Drawing.Font("Arial", 12F);
            this.tb_OP_SelectPRJ.Location = new System.Drawing.Point(45, 187);
            this.tb_OP_SelectPRJ.MaxLength = 11;
            this.tb_OP_SelectPRJ.Name = "tb_OP_SelectPRJ";
            this.tb_OP_SelectPRJ.Size = new System.Drawing.Size(427, 26);
            this.tb_OP_SelectPRJ.TabIndex = 5;
            this.tb_OP_SelectPRJ.TextChanged += new System.EventHandler(this.tb_OP_SelectPRJ_TextChanged);
            // 
            // label54
            // 
            this.label54.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Arial", 12F);
            this.label54.Location = new System.Drawing.Point(42, 161);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(122, 18);
            this.label54.TabIndex = 16;
            this.label54.Text = "Procurar Objeto:";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sobreToolStripMenuItem.Image")));
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(869, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Achei na PUC";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_OP_SelectPRJ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarObjetosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.Button bt_Listar;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Label lb_OP_NotFound;
        private System.Windows.Forms.Button bt_OP_OK;
        private System.Windows.Forms.DataGridView dataGrid_OP_SelectPRJ;
        private System.Windows.Forms.TextBox tb_OP_SelectPRJ;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}

