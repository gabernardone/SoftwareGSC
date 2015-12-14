namespace Windows
{
    partial class ucAddUser
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2213:DisposableFieldsShouldBeDisposed", MessageId = "Email")]
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAddUser));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblConfirmaSenha = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtUserCadastro = new System.Windows.Forms.TextBox();
            this.txtConfirmaSenha = new System.Windows.Forms.TextBox();
            this.txtSenhaCadastro = new System.Windows.Forms.TextBox();
            this.lblSetor = new System.Windows.Forms.Label();
            this.cboSetor = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail2 = new System.Windows.Forms.Label();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAdm = new DevExpress.XtraEditors.ToggleSwitch();
            this.lblAdm = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tsbCadastrar = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Windows.Users_Constrols.ucCarregando), true, true, DevExpress.XtraSplashScreen.ParentType.UserControl, true);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkAdm.Properties)).BeginInit();
            this.tsbCadastrar.SuspendLayout();
            this.SuspendLayout();
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
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(42, 75);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(42, 15);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";
            // 
            // lblConfirmaSenha
            // 
            this.lblConfirmaSenha.AutoSize = true;
            this.lblConfirmaSenha.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmaSenha.Location = new System.Drawing.Point(264, 75);
            this.lblConfirmaSenha.Name = "lblConfirmaSenha";
            this.lblConfirmaSenha.Size = new System.Drawing.Size(97, 15);
            this.lblConfirmaSenha.TabIndex = 3;
            this.lblConfirmaSenha.Text = "Confirmar Senha:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(42, 28);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(50, 15);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Usuário:";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNome.ForeColor = System.Drawing.Color.Silver;
            this.txtNome.Location = new System.Drawing.Point(45, 35);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(401, 23);
            this.txtNome.TabIndex = 1;
            // 
            // txtUserCadastro
            // 
            this.txtUserCadastro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserCadastro.Enabled = false;
            this.txtUserCadastro.Location = new System.Drawing.Point(45, 46);
            this.txtUserCadastro.Name = "txtUserCadastro";
            this.txtUserCadastro.Size = new System.Drawing.Size(267, 23);
            this.txtUserCadastro.TabIndex = 4;
            // 
            // txtConfirmaSenha
            // 
            this.txtConfirmaSenha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtConfirmaSenha.Location = new System.Drawing.Point(267, 94);
            this.txtConfirmaSenha.Name = "txtConfirmaSenha";
            this.txtConfirmaSenha.ShortcutsEnabled = false;
            this.txtConfirmaSenha.Size = new System.Drawing.Size(126, 23);
            this.txtConfirmaSenha.TabIndex = 8;
            this.txtConfirmaSenha.UseSystemPasswordChar = true;
            // 
            // txtSenhaCadastro
            // 
            this.txtSenhaCadastro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSenhaCadastro.Location = new System.Drawing.Point(45, 94);
            this.txtSenhaCadastro.Name = "txtSenhaCadastro";
            this.txtSenhaCadastro.ShortcutsEnabled = false;
            this.txtSenhaCadastro.Size = new System.Drawing.Size(126, 23);
            this.txtSenhaCadastro.TabIndex = 7;
            this.txtSenhaCadastro.UseSystemPasswordChar = true;
            // 
            // lblSetor
            // 
            this.lblSetor.AutoSize = true;
            this.lblSetor.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetor.Location = new System.Drawing.Point(533, 17);
            this.lblSetor.Name = "lblSetor";
            this.lblSetor.Size = new System.Drawing.Size(37, 15);
            this.lblSetor.TabIndex = 10;
            this.lblSetor.Text = "Setor:";
            // 
            // cboSetor
            // 
            this.cboSetor.BackColor = System.Drawing.Color.White;
            this.cboSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSetor.FormattingEnabled = true;
            this.cboSetor.Items.AddRange(new object[] {
            "Gestão Transacional PJ",
            "Televendas",
            "Técnica",
            "SAC"});
            this.cboSetor.Location = new System.Drawing.Point(536, 35);
            this.cboSetor.Name = "cboSetor";
            this.cboSetor.Size = new System.Drawing.Size(157, 23);
            this.cboSetor.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Location = new System.Drawing.Point(45, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 23);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblEmail2
            // 
            this.lblEmail2.AutoSize = true;
            this.lblEmail2.Location = new System.Drawing.Point(231, 94);
            this.lblEmail2.Name = "lblEmail2";
            this.lblEmail2.Size = new System.Drawing.Size(125, 15);
            this.lblEmail2.TabIndex = 12;
            this.lblEmail2.Text = "@grupotracker.com.br";
            // 
            // cboCargo
            // 
            this.cboCargo.BackColor = System.Drawing.Color.White;
            this.cboCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Items.AddRange(new object[] {
            "Analista de Call Center",
            "Supervisor(a)",
            "Gerente",
            "Líder"});
            this.cboCargo.Location = new System.Drawing.Point(719, 35);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(161, 23);
            this.cboCargo.TabIndex = 23;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(716, 17);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(40, 15);
            this.lblCargo.TabIndex = 24;
            this.lblCargo.Text = "Cargo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.lblCargo);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.cboCargo);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblSetor);
            this.groupBox1.Controls.Add(this.cboSetor);
            this.groupBox1.Controls.Add(this.lblEmail2);
            this.groupBox1.Location = new System.Drawing.Point(3, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1200, 125);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionário";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.chkAdm);
            this.groupBox2.Controls.Add(this.lblAdm);
            this.groupBox2.Controls.Add(this.lblUserName);
            this.groupBox2.Controls.Add(this.lblSenha);
            this.groupBox2.Controls.Add(this.lblConfirmaSenha);
            this.groupBox2.Controls.Add(this.txtUserCadastro);
            this.groupBox2.Controls.Add(this.txtConfirmaSenha);
            this.groupBox2.Controls.Add(this.txtSenhaCadastro);
            this.groupBox2.Location = new System.Drawing.Point(3, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1200, 177);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações e Login";
            // 
            // chkAdm
            // 
            this.chkAdm.Location = new System.Drawing.Point(45, 152);
            this.chkAdm.Name = "chkAdm";
            this.chkAdm.Properties.LookAndFeel.SkinName = "Office 2013 Dark Gray";
            this.chkAdm.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.chkAdm.Properties.OffText = "Não";
            this.chkAdm.Properties.OnText = "Sim";
            this.chkAdm.Size = new System.Drawing.Size(95, 24);
            this.chkAdm.TabIndex = 11;
            // 
            // lblAdm
            // 
            this.lblAdm.AutoSize = true;
            this.lblAdm.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdm.Location = new System.Drawing.Point(42, 132);
            this.lblAdm.Name = "lblAdm";
            this.lblAdm.Size = new System.Drawing.Size(84, 15);
            this.lblAdm.TabIndex = 10;
            this.lblAdm.Text = "Administrador:";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // tsbCadastrar
            // 
            this.tsbCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tsbCadastrar.AutoSize = false;
            this.tsbCadastrar.BackColor = System.Drawing.Color.White;
            this.tsbCadastrar.BackgroundImage = global::Windows.Properties.Resources.white_gradient_2;
            this.tsbCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbCadastrar.Dock = System.Windows.Forms.DockStyle.None;
            this.tsbCadastrar.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCadastrar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsbCadastrar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1});
            this.tsbCadastrar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsbCadastrar.Location = new System.Drawing.Point(3, 3);
            this.tsbCadastrar.Name = "tsbCadastrar";
            this.tsbCadastrar.Size = new System.Drawing.Size(1200, 62);
            this.tsbCadastrar.TabIndex = 48;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(1, 1, 6, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(62, 59);
            this.toolStripButton1.Text = "Cadastrar";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 62);
            // 
            // ucAddUser
            // 
            this.AccessibleName = "Cadastro de Usuário";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tsbCadastrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ucAddUser";
            this.Size = new System.Drawing.Size(1206, 495);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkAdm.Properties)).EndInit();
            this.tsbCadastrar.ResumeLayout(false);
            this.tsbCadastrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblConfirmaSenha;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtUserCadastro;
        private System.Windows.Forms.TextBox txtConfirmaSenha;
        private System.Windows.Forms.TextBox txtSenhaCadastro;
        private System.Windows.Forms.Label lblSetor;
        private System.Windows.Forms.ComboBox cboSetor;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail2;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.ToolStrip tsbCadastrar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label lblAdm;
        private DevExpress.XtraEditors.ToggleSwitch chkAdm;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}
