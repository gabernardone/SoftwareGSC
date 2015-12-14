namespace Windows
{
    partial class ucEditar_Usuario
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Component Designer

        /// <summary> 
        /// Método necessário para o suporte do Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucEditar_Usuario));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserCadastro_detalhe = new System.Windows.Forms.TextBox();
            this.chkAdm_consulta = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cboCargo_detalhe = new System.Windows.Forms.ComboBox();
            this.txtNome_detalhe = new System.Windows.Forms.TextBox();
            this.txtEmail_detalhe = new System.Windows.Forms.TextBox();
            this.lblSetor = new System.Windows.Forms.Label();
            this.cboSetor_detalhe = new System.Windows.Forms.ComboBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tsbEditarUsuario = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tsbEditarUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblUserName);
            this.groupBox2.Controls.Add(this.txtUserCadastro_detalhe);
            this.groupBox2.Controls.Add(this.chkAdm_consulta);
            this.groupBox2.Location = new System.Drawing.Point(3, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 71);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações e Login";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(42, 19);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(50, 15);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Usuário:";
            // 
            // txtUserCadastro_detalhe
            // 
            this.txtUserCadastro_detalhe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserCadastro_detalhe.Enabled = false;
            this.txtUserCadastro_detalhe.Location = new System.Drawing.Point(45, 37);
            this.txtUserCadastro_detalhe.Name = "txtUserCadastro_detalhe";
            this.txtUserCadastro_detalhe.Size = new System.Drawing.Size(180, 20);
            this.txtUserCadastro_detalhe.TabIndex = 4;
            // 
            // chkAdm_consulta
            // 
            this.chkAdm_consulta.AutoSize = true;
            this.chkAdm_consulta.Enabled = false;
            this.chkAdm_consulta.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdm_consulta.Location = new System.Drawing.Point(234, 37);
            this.chkAdm_consulta.Name = "chkAdm_consulta";
            this.chkAdm_consulta.Size = new System.Drawing.Size(100, 19);
            this.chkAdm_consulta.TabIndex = 6;
            this.chkAdm_consulta.Text = "Administrador";
            this.chkAdm_consulta.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.lblCargo);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.cboCargo_detalhe);
            this.groupBox1.Controls.Add(this.txtNome_detalhe);
            this.groupBox1.Controls.Add(this.txtEmail_detalhe);
            this.groupBox1.Controls.Add(this.lblSetor);
            this.groupBox1.Controls.Add(this.cboSetor_detalhe);
            this.groupBox1.Location = new System.Drawing.Point(3, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 130);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionário";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(42, 17);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 15);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(536, 17);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(40, 15);
            this.lblCargo.TabIndex = 24;
            this.lblCargo.Text = "Cargo:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(42, 72);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 15);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email:";
            // 
            // cboCargo_detalhe
            // 
            this.cboCargo_detalhe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboCargo_detalhe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCargo_detalhe.Enabled = false;
            this.cboCargo_detalhe.FormattingEnabled = true;
            this.cboCargo_detalhe.Items.AddRange(new object[] {
            "Analista de Call Center",
            "Supervisor(a)",
            "Gerente",
            "Líder"});
            this.cboCargo_detalhe.Location = new System.Drawing.Point(539, 35);
            this.cboCargo_detalhe.Name = "cboCargo_detalhe";
            this.cboCargo_detalhe.Size = new System.Drawing.Size(161, 21);
            this.cboCargo_detalhe.TabIndex = 23;
            // 
            // txtNome_detalhe
            // 
            this.txtNome_detalhe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNome_detalhe.Enabled = false;
            this.txtNome_detalhe.ForeColor = System.Drawing.Color.Silver;
            this.txtNome_detalhe.Location = new System.Drawing.Point(45, 35);
            this.txtNome_detalhe.Name = "txtNome_detalhe";
            this.txtNome_detalhe.Size = new System.Drawing.Size(284, 20);
            this.txtNome_detalhe.TabIndex = 1;
            // 
            // txtEmail_detalhe
            // 
            this.txtEmail_detalhe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail_detalhe.Enabled = false;
            this.txtEmail_detalhe.Location = new System.Drawing.Point(45, 90);
            this.txtEmail_detalhe.Name = "txtEmail_detalhe";
            this.txtEmail_detalhe.Size = new System.Drawing.Size(251, 20);
            this.txtEmail_detalhe.TabIndex = 3;
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetor.Location = new System.Drawing.Point(353, 17);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(37, 15);
            this.lblSetor.TabIndex = 10;
            this.lblSetor.Text = "Setor:";
            // 
            // cboSetor_detalhe
            // 
            this.cboSetor_detalhe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboSetor_detalhe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSetor_detalhe.Enabled = false;
            this.cboSetor_detalhe.FormattingEnabled = true;
            this.cboSetor_detalhe.Items.AddRange(new object[] {
            "Gestão Transacional PJ",
            "Televendas",
            "Técnica",
            "SAC"});
            this.cboSetor_detalhe.Location = new System.Drawing.Point(356, 35);
            this.cboSetor_detalhe.Name = "cboSetor_detalhe";
            this.cboSetor_detalhe.Size = new System.Drawing.Size(157, 21);
            this.cboSetor_detalhe.TabIndex = 2;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1219, 512);
            this.shapeContainer1.TabIndex = 48;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 4;
            this.lineShape1.X2 = 813;
            this.lineShape1.Y1 = 62;
            this.lineShape1.Y2 = 62;
            // 
            // tsbEditarUsuario
            // 
            this.tsbEditarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tsbEditarUsuario.AutoSize = false;
            this.tsbEditarUsuario.BackColor = System.Drawing.Color.White;
            this.tsbEditarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbEditarUsuario.BackgroundImage")));
            this.tsbEditarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbEditarUsuario.Dock = System.Windows.Forms.DockStyle.None;
            this.tsbEditarUsuario.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbEditarUsuario.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsbEditarUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.toolStripButton3,
            this.toolStripButton5,
            this.toolStripButton2,
            this.toolStripSeparator5});
            this.tsbEditarUsuario.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsbEditarUsuario.Location = new System.Drawing.Point(6, 7);
            this.tsbEditarUsuario.Name = "tsbEditarUsuario";
            this.tsbEditarUsuario.Size = new System.Drawing.Size(1208, 62);
            this.tsbEditarUsuario.TabIndex = 50;
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButton4.Image = global::Windows.Properties.Resources.Delete_32x32;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Margin = new System.Windows.Forms.Padding(1, 1, 6, 2);
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(55, 55);
            this.toolStripButton4.Text = "Deletar";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButton3.Image = global::Windows.Properties.Resources.Save_32x32;
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Margin = new System.Windows.Forms.Padding(1, 1, 6, 2);
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(55, 55);
            this.toolStripButton3.Text = "Salvar";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.AutoSize = false;
            this.toolStripButton5.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButton5.Image = global::Windows.Properties.Resources.Edit_32x32;
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Margin = new System.Windows.Forms.Padding(1, 1, 6, 2);
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(55, 55);
            this.toolStripButton5.Text = "Editar";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripButton2.Image = global::Windows.Properties.Resources.Refresh_32x32;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(1, 1, 6, 2);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(90, 60);
            this.toolStripButton2.Text = "Redefinir Senha";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 62);
            // 
            // ucEditar_Usuario
            // 
            this.AccessibleName = "Informações do Usuário";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tsbEditarUsuario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "ucEditar_Usuario";
            this.Size = new System.Drawing.Size(1219, 512);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tsbEditarUsuario.ResumeLayout(false);
            this.tsbEditarUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserCadastro_detalhe;
        private System.Windows.Forms.CheckBox chkAdm_consulta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cboCargo_detalhe;
        private System.Windows.Forms.TextBox txtNome_detalhe;
        private System.Windows.Forms.TextBox txtEmail_detalhe;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.ComboBox cboSetor_detalhe;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        internal System.Windows.Forms.ToolStrip tsbEditarUsuario;
        internal System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        internal System.Windows.Forms.ToolStripButton toolStripButton4;
        internal System.Windows.Forms.ToolStripButton toolStripButton3;
        internal System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}
