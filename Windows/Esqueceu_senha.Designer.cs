namespace Windows
{
    partial class frmRecuperar_Senha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperar_Senha));
            this.lblRecuperar_senha = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRecuperar_Login = new System.Windows.Forms.Label();
            this.lblRecuperar_Email = new System.Windows.Forms.Label();
            this.lblRecurarar_ConfEmail = new System.Windows.Forms.Label();
            this.txtConf_email = new System.Windows.Forms.TextBox();
            this.txtEmail_recuperacao = new System.Windows.Forms.TextBox();
            this.txtLogin_recuperacao = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.btnRecuperar_enviar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar_recuperar = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnContinuar = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRecuperar_senha
            // 
            this.lblRecuperar_senha.AutoSize = true;
            this.lblRecuperar_senha.BackColor = System.Drawing.Color.Transparent;
            this.lblRecuperar_senha.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperar_senha.Location = new System.Drawing.Point(181, 23);
            this.lblRecuperar_senha.Name = "lblRecuperar_senha";
            this.lblRecuperar_senha.Size = new System.Drawing.Size(215, 30);
            this.lblRecuperar_senha.TabIndex = 0;
            this.lblRecuperar_senha.Text = "Recuperação de Senha";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(465, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblRecuperar_Login
            // 
            this.lblRecuperar_Login.AutoSize = true;
            this.lblRecuperar_Login.BackColor = System.Drawing.Color.Transparent;
            this.lblRecuperar_Login.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperar_Login.Location = new System.Drawing.Point(37, 92);
            this.lblRecuperar_Login.Name = "lblRecuperar_Login";
            this.lblRecuperar_Login.Size = new System.Drawing.Size(101, 14);
            this.lblRecuperar_Login.TabIndex = 2;
            this.lblRecuperar_Login.Text = "Login do usuário:";
            // 
            // lblRecuperar_Email
            // 
            this.lblRecuperar_Email.AutoSize = true;
            this.lblRecuperar_Email.BackColor = System.Drawing.Color.Transparent;
            this.lblRecuperar_Email.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperar_Email.Location = new System.Drawing.Point(37, 118);
            this.lblRecuperar_Email.Name = "lblRecuperar_Email";
            this.lblRecuperar_Email.Size = new System.Drawing.Size(45, 14);
            this.lblRecuperar_Email.TabIndex = 3;
            this.lblRecuperar_Email.Text = "E-mail:";
            // 
            // lblRecurarar_ConfEmail
            // 
            this.lblRecurarar_ConfEmail.AutoSize = true;
            this.lblRecurarar_ConfEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblRecurarar_ConfEmail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecurarar_ConfEmail.Location = new System.Drawing.Point(37, 144);
            this.lblRecurarar_ConfEmail.Name = "lblRecurarar_ConfEmail";
            this.lblRecurarar_ConfEmail.Size = new System.Drawing.Size(100, 14);
            this.lblRecurarar_ConfEmail.TabIndex = 4;
            this.lblRecurarar_ConfEmail.Text = "Confirmar e-mail:";
            // 
            // txtConf_email
            // 
            this.txtConf_email.Location = new System.Drawing.Point(159, 141);
            this.txtConf_email.Name = "txtConf_email";
            this.txtConf_email.Size = new System.Drawing.Size(237, 20);
            this.txtConf_email.TabIndex = 3;
            // 
            // txtEmail_recuperacao
            // 
            this.txtEmail_recuperacao.Location = new System.Drawing.Point(159, 115);
            this.txtEmail_recuperacao.Name = "txtEmail_recuperacao";
            this.txtEmail_recuperacao.Size = new System.Drawing.Size(237, 20);
            this.txtEmail_recuperacao.TabIndex = 2;
            // 
            // txtLogin_recuperacao
            // 
            this.txtLogin_recuperacao.Location = new System.Drawing.Point(159, 92);
            this.txtLogin_recuperacao.Name = "txtLogin_recuperacao";
            this.txtLogin_recuperacao.Size = new System.Drawing.Size(237, 20);
            this.txtLogin_recuperacao.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Windows.Properties.Resources.logo2;
            this.pictureBox2.Location = new System.Drawing.Point(11, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "a76b8372-4dc4-4e8f-8dec-3d00cdbb4f55";
            this.toastNotificationsManager1.ApplicationName = "Windows";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("39282756-8c35-4357-aa5d-7f7768c3f44c", null, "Pellentesque lacinia tellus eget volutpat", "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor i" +
                    "ncididunt ut labore et dolore magna aliqua.", "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor i" +
                    "ncididunt ut labore et dolore magna aliqua.", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Text01)});
            // 
            // btnRecuperar_enviar
            // 
            this.btnRecuperar_enviar.Location = new System.Drawing.Point(321, 182);
            this.btnRecuperar_enviar.LookAndFeel.SkinName = "Office 2013 Light Gray";
            this.btnRecuperar_enviar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnRecuperar_enviar.Name = "btnRecuperar_enviar";
            this.btnRecuperar_enviar.Size = new System.Drawing.Size(75, 23);
            this.btnRecuperar_enviar.TabIndex = 22;
            this.btnRecuperar_enviar.Text = "Finalizar";
            this.btnRecuperar_enviar.Click += new System.EventHandler(this.btnRecuperar_enviar_Click);
            // 
            // btnCancelar_recuperar
            // 
            this.btnCancelar_recuperar.Location = new System.Drawing.Point(211, 182);
            this.btnCancelar_recuperar.LookAndFeel.SkinName = "Office 2013 Light Gray";
            this.btnCancelar_recuperar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnCancelar_recuperar.Name = "btnCancelar_recuperar";
            this.btnCancelar_recuperar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar_recuperar.TabIndex = 23;
            this.btnCancelar_recuperar.Text = "Cancelar";
            this.btnCancelar_recuperar.Click += new System.EventHandler(this.btnCancelar_recuperar_Click);
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
            this.btnClose.Location = new System.Drawing.Point(447, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 23);
            this.btnClose.TabIndex = 25;
            this.btnClose.Tag = "";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.UseVisualStyleBackColor = false;
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
            this.btnMinimize.Location = new System.Drawing.Point(419, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 23);
            this.btnMinimize.TabIndex = 24;
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Windows.Properties.Resources.gplaypattern;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 215);
            this.panel2.TabIndex = 23;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Windows.Properties.Resources.Info_32x32;
            this.pictureBox3.Location = new System.Drawing.Point(3, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Você também pode solicitar ao seu gestor que redefina sua senha para uma padrão.\r" +
    "\nPara prosseguir com a recuperação, clique em continuar.";
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(368, 100);
            this.btnContinuar.LookAndFeel.SkinName = "Office 2013 Light Gray";
            this.btnContinuar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 22;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnContinuar);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 128);
            this.panel1.TabIndex = 11;
            // 
            // frmRecuperar_Senha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Windows.Properties.Resources.gplaypattern;
            this.ClientSize = new System.Drawing.Size(474, 215);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancelar_recuperar);
            this.Controls.Add(this.btnRecuperar_enviar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtLogin_recuperacao);
            this.Controls.Add(this.txtEmail_recuperacao);
            this.Controls.Add(this.txtConf_email);
            this.Controls.Add(this.lblRecurarar_ConfEmail);
            this.Controls.Add(this.lblRecuperar_Email);
            this.Controls.Add(this.lblRecuperar_Login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRecuperar_senha);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRecuperar_Senha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestão de Solicitação e Confirmação";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecuperar_senha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRecuperar_Login;
        private System.Windows.Forms.Label lblRecuperar_Email;
        private System.Windows.Forms.Label lblRecurarar_ConfEmail;
        private System.Windows.Forms.TextBox txtConf_email;
        private System.Windows.Forms.TextBox txtEmail_recuperacao;
        private System.Windows.Forms.TextBox txtLogin_recuperacao;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private DevExpress.XtraEditors.SimpleButton btnRecuperar_enviar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar_recuperar;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnContinuar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
    }
}