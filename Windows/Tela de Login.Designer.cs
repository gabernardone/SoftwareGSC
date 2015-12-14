namespace Windows
{
    partial class frmLogin
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

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Windows.SplashScreen1), true, true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.picLogoWindows = new System.Windows.Forms.PictureBox();
            this.gpbLogin = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEntrar = new DevExpress.XtraEditors.SimpleButton();
            this.panSenha = new System.Windows.Forms.Panel();
            this.picSenha = new System.Windows.Forms.PictureBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.panUsuario = new System.Windows.Forms.Panel();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panErro = new System.Windows.Forms.Panel();
            this.picErro = new System.Windows.Forms.PictureBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.retsUsuario = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.retsSenha = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.picLogoTracker = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblLogin_texto = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.panFormLogin = new System.Windows.Forms.Panel();
            this.picStatusConexao = new System.Windows.Forms.PictureBox();
            this.lblStatus1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.TimerConexao = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoWindows)).BeginInit();
            this.gpbLogin.SuspendLayout();
            this.panSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).BeginInit();
            this.panUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.panErro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoTracker)).BeginInit();
            this.panFormLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatusConexao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogoWindows
            // 
            this.picLogoWindows.BackColor = System.Drawing.Color.Transparent;
            this.picLogoWindows.Image = global::Windows.Properties.Resources.logobig;
            this.picLogoWindows.Location = new System.Drawing.Point(91, 25);
            this.picLogoWindows.Name = "picLogoWindows";
            this.picLogoWindows.Size = new System.Drawing.Size(222, 60);
            this.picLogoWindows.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoWindows.TabIndex = 8;
            this.picLogoWindows.TabStop = false;
            // 
            // gpbLogin
            // 
            this.gpbLogin.BackColor = System.Drawing.Color.Transparent;
            this.gpbLogin.Controls.Add(this.btnCancelar);
            this.gpbLogin.Controls.Add(this.btnEntrar);
            this.gpbLogin.Controls.Add(this.panSenha);
            this.gpbLogin.Controls.Add(this.panUsuario);
            this.gpbLogin.Controls.Add(this.panErro);
            this.gpbLogin.Controls.Add(this.linkLabel1);
            this.gpbLogin.Controls.Add(this.lblSenha);
            this.gpbLogin.Controls.Add(this.lblUsuario);
            this.gpbLogin.Controls.Add(this.shapeContainer1);
            this.gpbLogin.Location = new System.Drawing.Point(11, 182);
            this.gpbLogin.Name = "gpbLogin";
            this.gpbLogin.Size = new System.Drawing.Size(387, 159);
            this.gpbLogin.TabIndex = 9;
            this.gpbLogin.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(100, 115);
            this.btnCancelar.LookAndFeel.SkinName = "Office 2013 Light Gray";
            this.btnCancelar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(236, 114);
            this.btnEntrar.LookAndFeel.SkinName = "Office 2013 Light Gray";
            this.btnEntrar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 21;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // panSenha
            // 
            this.panSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panSenha.Controls.Add(this.picSenha);
            this.panSenha.Controls.Add(this.txtSenha);
            this.panSenha.Location = new System.Drawing.Point(130, 70);
            this.panSenha.Name = "panSenha";
            this.panSenha.Size = new System.Drawing.Size(169, 20);
            this.panSenha.TabIndex = 23;
            // 
            // picSenha
            // 
            this.picSenha.Image = ((System.Drawing.Image)(resources.GetObject("picSenha.Image")));
            this.picSenha.Location = new System.Drawing.Point(2, 1);
            this.picSenha.Name = "picSenha";
            this.picSenha.Size = new System.Drawing.Size(18, 16);
            this.picSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSenha.TabIndex = 20;
            this.picSenha.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(22, 3);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.ShortcutsEnabled = false;
            this.txtSenha.Size = new System.Drawing.Size(144, 13);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // panUsuario
            // 
            this.panUsuario.BackColor = System.Drawing.Color.White;
            this.panUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panUsuario.Controls.Add(this.picUsuario);
            this.panUsuario.Controls.Add(this.txtUsuario);
            this.panUsuario.Location = new System.Drawing.Point(131, 31);
            this.panUsuario.Name = "panUsuario";
            this.panUsuario.Size = new System.Drawing.Size(169, 20);
            this.panUsuario.TabIndex = 22;
            // 
            // picUsuario
            // 
            this.picUsuario.Image = ((System.Drawing.Image)(resources.GetObject("picUsuario.Image")));
            this.picUsuario.Location = new System.Drawing.Point(1, 1);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(19, 16);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUsuario.TabIndex = 21;
            this.picUsuario.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Location = new System.Drawing.Point(22, 3);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(20);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(143, 13);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSenha_KeyDown);
            // 
            // panErro
            // 
            this.panErro.Controls.Add(this.picErro);
            this.panErro.Controls.Add(this.lblErro);
            this.panErro.Location = new System.Drawing.Point(85, 109);
            this.panErro.Name = "panErro";
            this.panErro.Size = new System.Drawing.Size(230, 21);
            this.panErro.TabIndex = 20;
            this.panErro.Visible = false;
            // 
            // picErro
            // 
            this.picErro.Image = ((System.Drawing.Image)(resources.GetObject("picErro.Image")));
            this.picErro.Location = new System.Drawing.Point(15, 2);
            this.picErro.Name = "picErro";
            this.picErro.Size = new System.Drawing.Size(16, 16);
            this.picErro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picErro.TabIndex = 20;
            this.picErro.TabStop = false;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.Location = new System.Drawing.Point(33, 4);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(32, 13);
            this.lblErro.TabIndex = 21;
            this.lblErro.Text = "label1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(127, 96);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Esqueceu sua senha?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Calibri Light", 9.75F);
            this.lblSenha.Location = new System.Drawing.Point(62, 70);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(42, 15);
            this.lblSenha.TabIndex = 11;
            this.lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Calibri Light", 9.75F);
            this.lblUsuario.Location = new System.Drawing.Point(62, 31);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 15);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Usuário:";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.retsUsuario,
            this.retsSenha});
            this.shapeContainer1.Size = new System.Drawing.Size(381, 140);
            this.shapeContainer1.TabIndex = 12;
            this.shapeContainer1.TabStop = false;
            // 
            // retsUsuario
            // 
            this.retsUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.retsUsuario.BorderWidth = 4;
            this.retsUsuario.Location = new System.Drawing.Point(128, 15);
            this.retsUsuario.Name = "retsUsuario";
            this.retsUsuario.Size = new System.Drawing.Size(169, 20);
            this.retsUsuario.Visible = false;
            // 
            // retsSenha
            // 
            this.retsSenha.BackColor = System.Drawing.Color.White;
            this.retsSenha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.retsSenha.BorderWidth = 4;
            this.retsSenha.Location = new System.Drawing.Point(127, 54);
            this.retsSenha.Name = "retsSenha";
            this.retsSenha.Size = new System.Drawing.Size(169, 20);
            this.retsSenha.Visible = false;
            // 
            // picLogoTracker
            // 
            this.picLogoTracker.BackColor = System.Drawing.Color.Transparent;
            this.picLogoTracker.Image = ((System.Drawing.Image)(resources.GetObject("picLogoTracker.Image")));
            this.picLogoTracker.Location = new System.Drawing.Point(177, 344);
            this.picLogoTracker.Name = "picLogoTracker";
            this.picLogoTracker.Size = new System.Drawing.Size(50, 53);
            this.picLogoTracker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoTracker.TabIndex = 10;
            this.picLogoTracker.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.Location = new System.Drawing.Point(355, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 23);
            this.btnMinimize.TabIndex = 12;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(383, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 23);
            this.btnClose.TabIndex = 19;
            this.btnClose.Tag = "";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblLogin_texto
            // 
            this.lblLogin_texto.AutoSize = true;
            this.lblLogin_texto.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin_texto.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin_texto.Location = new System.Drawing.Point(11, 141);
            this.lblLogin_texto.Name = "lblLogin_texto";
            this.lblLogin_texto.Size = new System.Drawing.Size(142, 33);
            this.lblLogin_texto.TabIndex = 20;
            this.lblLogin_texto.Text = "Faça o login";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Size = new System.Drawing.Size(411, 402);
            this.shapeContainer2.TabIndex = 23;
            this.shapeContainer2.TabStop = false;
            // 
            // panFormLogin
            // 
            this.panFormLogin.BackColor = System.Drawing.Color.Transparent;
            this.panFormLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panFormLogin.Controls.Add(this.picStatusConexao);
            this.panFormLogin.Controls.Add(this.lblStatus1);
            this.panFormLogin.Controls.Add(this.lblLogin_texto);
            this.panFormLogin.Controls.Add(this.picLogoTracker);
            this.panFormLogin.Controls.Add(this.pictureBox6);
            this.panFormLogin.Controls.Add(this.gpbLogin);
            this.panFormLogin.Controls.Add(this.btnClose);
            this.panFormLogin.Controls.Add(this.btnMinimize);
            this.panFormLogin.Controls.Add(this.picLogoWindows);
            this.panFormLogin.Controls.Add(this.shapeContainer3);
            this.panFormLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panFormLogin.Location = new System.Drawing.Point(0, 0);
            this.panFormLogin.Name = "panFormLogin";
            this.panFormLogin.Size = new System.Drawing.Size(411, 402);
            this.panFormLogin.TabIndex = 22;
            this.panFormLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseDown);
            this.panFormLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseMove);
            // 
            // picStatusConexao
            // 
            this.picStatusConexao.Image = global::Windows.Properties.Resources.status_busy;
            this.picStatusConexao.Location = new System.Drawing.Point(10, 346);
            this.picStatusConexao.Name = "picStatusConexao";
            this.picStatusConexao.Size = new System.Drawing.Size(17, 16);
            this.picStatusConexao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStatusConexao.TabIndex = 22;
            this.picStatusConexao.TabStop = false;
            // 
            // lblStatus1
            // 
            this.lblStatus1.AutoSize = true;
            this.lblStatus1.Font = new System.Drawing.Font("Calibri Light", 9.75F);
            this.lblStatus1.Location = new System.Drawing.Point(27, 346);
            this.lblStatus1.Name = "lblStatus1";
            this.lblStatus1.Size = new System.Drawing.Size(126, 15);
            this.lblStatus1.TabIndex = 21;
            this.lblStatus1.Text = "Verificando conexão...!";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(3, 90);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(406, 9);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 20;
            this.pictureBox6.TabStop = false;
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer3.Size = new System.Drawing.Size(409, 400);
            this.shapeContainer3.TabIndex = 0;
            this.shapeContainer3.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.Silver;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 6;
            this.lineShape1.X2 = 401;
            this.lineShape1.Y1 = 366;
            this.lineShape1.Y2 = 366;
            // 
            // TimerConexao
            // 
            this.TimerConexao.Enabled = true;
            this.TimerConexao.Interval = 1;
            this.TimerConexao.Tick += new System.EventHandler(this.TimerConexao_Tick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(411, 402);
            this.Controls.Add(this.panFormLogin);
            this.Controls.Add(this.shapeContainer2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - Gestão de Solicitação e Confirmação";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoWindows)).EndInit();
            this.gpbLogin.ResumeLayout(false);
            this.gpbLogin.PerformLayout();
            this.panSenha.ResumeLayout(false);
            this.panSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).EndInit();
            this.panUsuario.ResumeLayout(false);
            this.panUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.panErro.ResumeLayout(false);
            this.panErro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoTracker)).EndInit();
            this.panFormLogin.ResumeLayout(false);
            this.panFormLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStatusConexao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogoWindows;
        private System.Windows.Forms.GroupBox gpbLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox picLogoTracker;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape retsSenha;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape retsUsuario;
        internal System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.LinkLabel linkLabel1;
        internal System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblLogin_texto;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private System.Windows.Forms.Panel panFormLogin;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel panErro;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.PictureBox picSenha;
        private System.Windows.Forms.PictureBox picErro;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel panUsuario;
        private System.Windows.Forms.Panel panSenha;
        private DevExpress.XtraEditors.SimpleButton btnEntrar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblStatus1;
        private System.Windows.Forms.PictureBox picStatusConexao;
        private System.Windows.Forms.Timer TimerConexao;
    }
}

