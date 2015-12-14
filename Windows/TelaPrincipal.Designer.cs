namespace Windows
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpAdministrador = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tosNovoUsuario = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tosConsultaUsuario = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tbpSolicitacao = new System.Windows.Forms.TabPage();
            this.tspAnalista = new System.Windows.Forms.ToolStrip();
            this.tspNovaSolicitacao = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tspSolicitacoesAprovadas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tbpAnaliseSolicitacao = new System.Windows.Forms.TabPage();
            this.tspLider = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClose = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblData_Hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blocoDeNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tspInformacoes_logado = new System.Windows.Forms.ToolStripMenuItem();
            this.tspUsuario_logado = new System.Windows.Forms.ToolStripMenuItem();
            this.tspEmail_Logado = new System.Windows.Forms.ToolStripMenuItem();
            this.editarDadosPessoaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabControl1.SuspendLayout();
            this.tbpAdministrador.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tbpSolicitacao.SuspendLayout();
            this.tspAnalista.SuspendLayout();
            this.tbpAnaliseSolicitacao.SuspendLayout();
            this.tspLider.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "service-16 (1).png");
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbpAdministrador);
            this.tabControl1.Controls.Add(this.tbpSolicitacao);
            this.tabControl1.Controls.Add(this.tbpAnaliseSolicitacao);
            this.tabControl1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(12, 34);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(1, 1, 6, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1219, 101);
            this.tabControl1.TabIndex = 4;
            // 
            // tbpAdministrador
            // 
            this.tbpAdministrador.Controls.Add(this.toolStrip1);
            this.tbpAdministrador.Location = new System.Drawing.Point(4, 24);
            this.tbpAdministrador.Name = "tbpAdministrador";
            this.tbpAdministrador.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAdministrador.Size = new System.Drawing.Size(1211, 73);
            this.tbpAdministrador.TabIndex = 2;
            this.tbpAdministrador.Text = "Administrador";
            this.tbpAdministrador.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tosNovoUsuario,
            this.toolStripSeparator2,
            this.tosConsultaUsuario,
            this.toolStripSeparator6,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1205, 67);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip2";
            // 
            // tosNovoUsuario
            // 
            this.tosNovoUsuario.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tosNovoUsuario.Image = global::Windows.Properties.Resources.NewContact_32x32;
            this.tosNovoUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tosNovoUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tosNovoUsuario.Margin = new System.Windows.Forms.Padding(1, 1, 6, 2);
            this.tosNovoUsuario.Name = "tosNovoUsuario";
            this.tosNovoUsuario.Size = new System.Drawing.Size(85, 64);
            this.tosNovoUsuario.Text = "Novo Usuário";
            this.tosNovoUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tosNovoUsuario.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 67);
            // 
            // tosConsultaUsuario
            // 
            this.tosConsultaUsuario.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tosConsultaUsuario.Image = global::Windows.Properties.Resources.ListBullets_32x321;
            this.tosConsultaUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tosConsultaUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tosConsultaUsuario.Margin = new System.Windows.Forms.Padding(1, 1, 6, 2);
            this.tosConsultaUsuario.Name = "tosConsultaUsuario";
            this.tosConsultaUsuario.Size = new System.Drawing.Size(114, 64);
            this.tosConsultaUsuario.Text = "Gerenciar Usuários";
            this.tosConsultaUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tosConsultaUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tosConsultaUsuario.Click += new System.EventHandler(this.tosConsultaUsuario_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 67);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 64);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click_1);
            // 
            // tbpSolicitacao
            // 
            this.tbpSolicitacao.Controls.Add(this.tspAnalista);
            this.tbpSolicitacao.Location = new System.Drawing.Point(4, 24);
            this.tbpSolicitacao.Name = "tbpSolicitacao";
            this.tbpSolicitacao.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSolicitacao.Size = new System.Drawing.Size(1211, 73);
            this.tbpSolicitacao.TabIndex = 0;
            this.tbpSolicitacao.Text = "Solicitação e Confirmação de serviço";
            this.tbpSolicitacao.UseVisualStyleBackColor = true;
            // 
            // tspAnalista
            // 
            this.tspAnalista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tspAnalista.AutoSize = false;
            this.tspAnalista.BackColor = System.Drawing.Color.Transparent;
            this.tspAnalista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tspAnalista.Dock = System.Windows.Forms.DockStyle.None;
            this.tspAnalista.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspAnalista.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspNovaSolicitacao,
            this.toolStripSeparator7,
            this.toolStripButton1,
            this.toolStripSeparator3,
            this.tspSolicitacoesAprovadas,
            this.toolStripSeparator4,
            this.toolStripButton5,
            this.toolStripSeparator5,
            this.toolStripButton2});
            this.tspAnalista.Location = new System.Drawing.Point(3, 3);
            this.tspAnalista.Name = "tspAnalista";
            this.tspAnalista.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tspAnalista.Size = new System.Drawing.Size(1205, 67);
            this.tspAnalista.TabIndex = 4;
            this.tspAnalista.Text = "toolStrip1";
            // 
            // tspNovaSolicitacao
            // 
            this.tspNovaSolicitacao.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspNovaSolicitacao.Image = ((System.Drawing.Image)(resources.GetObject("tspNovaSolicitacao.Image")));
            this.tspNovaSolicitacao.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspNovaSolicitacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspNovaSolicitacao.Margin = new System.Windows.Forms.Padding(1, 1, 6, 2);
            this.tspNovaSolicitacao.Name = "tspNovaSolicitacao";
            this.tspNovaSolicitacao.Size = new System.Drawing.Size(101, 64);
            this.tspNovaSolicitacao.Text = "Nova Solicitação";
            this.tspNovaSolicitacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tspNovaSolicitacao.Click += new System.EventHandler(this.tspNovaSolicitacao_Click_1);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 67);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.toolStripButton1.Image = global::Windows.Properties.Resources.Apply_32x32;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(1, 1, 6, 2);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(87, 64);
            this.toolStripButton1.Text = "Confirmações";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.ToolTipText = "Confirmações";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 67);
            // 
            // tspSolicitacoesAprovadas
            // 
            this.tspSolicitacoesAprovadas.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspSolicitacoesAprovadas.Image = ((System.Drawing.Image)(resources.GetObject("tspSolicitacoesAprovadas.Image")));
            this.tspSolicitacoesAprovadas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspSolicitacoesAprovadas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspSolicitacoesAprovadas.Margin = new System.Windows.Forms.Padding(1, 1, 6, 2);
            this.tspSolicitacoesAprovadas.Name = "tspSolicitacoesAprovadas";
            this.tspSolicitacoesAprovadas.Size = new System.Drawing.Size(135, 64);
            this.tspSolicitacoesAprovadas.Text = "Solicitações Aprovadas";
            this.tspSolicitacoesAprovadas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tspSolicitacoesAprovadas.Click += new System.EventHandler(this.tspSolicitacoesAprovadas_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 67);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Margin = new System.Windows.Forms.Padding(1, 1, 6, 2);
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(135, 64);
            this.toolStripButton5.Text = "Solicitações Recusadas";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 67);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F);
            this.toolStripButton2.Image = global::Windows.Properties.Resources.Circle_Yellow;
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(1, 1, 6, 2);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(140, 64);
            this.toolStripButton2.Text = "Solicitações em Análise";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tbpAnaliseSolicitacao
            // 
            this.tbpAnaliseSolicitacao.Controls.Add(this.tspLider);
            this.tbpAnaliseSolicitacao.Location = new System.Drawing.Point(4, 24);
            this.tbpAnaliseSolicitacao.Name = "tbpAnaliseSolicitacao";
            this.tbpAnaliseSolicitacao.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAnaliseSolicitacao.Size = new System.Drawing.Size(1211, 73);
            this.tbpAnaliseSolicitacao.TabIndex = 1;
            this.tbpAnaliseSolicitacao.Text = "Analise de Solicitação";
            this.tbpAnaliseSolicitacao.UseVisualStyleBackColor = true;
            // 
            // tspLider
            // 
            this.tspLider.BackColor = System.Drawing.Color.Transparent;
            this.tspLider.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tspLider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tspLider.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspLider.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripSeparator8});
            this.tspLider.Location = new System.Drawing.Point(3, 3);
            this.tspLider.Name = "tspLider";
            this.tspLider.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.tspLider.Size = new System.Drawing.Size(1205, 67);
            this.tspLider.TabIndex = 6;
            this.tspLider.Text = "toolStrip2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Margin = new System.Windows.Forms.Padding(1, 1, 6, 2);
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(121, 64);
            this.toolStripButton3.Text = "Analisar Solicitações";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 67);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Image = global::Windows.Properties.Resources._1426032489_basics_22_24;
            this.btnClose.Location = new System.Drawing.Point(1176, 177);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusStrip1.BackgroundImage")));
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblData_Hora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 671);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1237, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblData_Hora
            // 
            this.lblData_Hora.Name = "lblData_Hora";
            this.lblData_Hora.Size = new System.Drawing.Size(0, 17);
            this.lblData_Hora.Click += new System.EventHandler(this.lblData_Click);
            this.lblData_Hora.DisplayStyleChanged += new System.EventHandler(this.TelaPrincipal_Load);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ferramentasToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.tspInformacoes_logado});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1237, 26);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.blocoDeNotasToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calculadoraToolStripMenuItem.Image")));
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // blocoDeNotasToolStripMenuItem
            // 
            this.blocoDeNotasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("blocoDeNotasToolStripMenuItem.Image")));
            this.blocoDeNotasToolStripMenuItem.Name = "blocoDeNotasToolStripMenuItem";
            this.blocoDeNotasToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.blocoDeNotasToolStripMenuItem.Text = "Bloco de Notas";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // tspInformacoes_logado
            // 
            this.tspInformacoes_logado.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tspInformacoes_logado.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspUsuario_logado,
            this.tspEmail_Logado,
            this.editarDadosPessoaisToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem,
            this.trocarUsuárioToolStripMenuItem});
            this.tspInformacoes_logado.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspInformacoes_logado.Image = ((System.Drawing.Image)(resources.GetObject("tspInformacoes_logado.Image")));
            this.tspInformacoes_logado.Name = "tspInformacoes_logado";
            this.tspInformacoes_logado.Size = new System.Drawing.Size(130, 22);
            this.tspInformacoes_logado.Text = "Usuário Logado";
            // 
            // tspUsuario_logado
            // 
            this.tspUsuario_logado.Name = "tspUsuario_logado";
            this.tspUsuario_logado.Size = new System.Drawing.Size(209, 22);
            this.tspUsuario_logado.Text = "Usuário";
            // 
            // tspEmail_Logado
            // 
            this.tspEmail_Logado.Name = "tspEmail_Logado";
            this.tspEmail_Logado.Size = new System.Drawing.Size(209, 22);
            this.tspEmail_Logado.Text = "Email";
            // 
            // editarDadosPessoaisToolStripMenuItem
            // 
            this.editarDadosPessoaisToolStripMenuItem.Name = "editarDadosPessoaisToolStripMenuItem";
            this.editarDadosPessoaisToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.editarDadosPessoaisToolStripMenuItem.Text = "Editar Dados Pessoais";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // trocarUsuárioToolStripMenuItem
            // 
            this.trocarUsuárioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("trocarUsuárioToolStripMenuItem.Image")));
            this.trocarUsuárioToolStripMenuItem.Name = "trocarUsuárioToolStripMenuItem";
            this.trocarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.trocarUsuárioToolStripMenuItem.Text = "Trocar Usuário";
            this.trocarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.trocarUsuárioToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Windows.Properties.Resources.logobig;
            this.pictureBox1.Location = new System.Drawing.Point(473, 351);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(213, 24);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.miniToolStrip.Size = new System.Drawing.Size(1035, 67);
            this.miniToolStrip.TabIndex = 7;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPrincipal.ImageList = this.imageList1;
            this.tabPrincipal.Location = new System.Drawing.Point(12, 140);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(1219, 527);
            this.tabPrincipal.TabIndex = 0;
            this.tabPrincipal.Visible = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1237, 693);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tabPrincipal);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Solicitação e Confirmação";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.Shown += new System.EventHandler(this.TelaPrincipal_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tbpAdministrador.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tbpSolicitacao.ResumeLayout(false);
            this.tspAnalista.ResumeLayout(false);
            this.tspAnalista.PerformLayout();
            this.tbpAnaliseSolicitacao.ResumeLayout(false);
            this.tbpAnaliseSolicitacao.PerformLayout();
            this.tspLider.ResumeLayout(false);
            this.tspLider.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpSolicitacao;
        private System.Windows.Forms.TabPage tbpAnaliseSolicitacao;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblData_Hora;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tspAnalista;
        private System.Windows.Forms.ToolStripButton tspNovaSolicitacao;
        private System.Windows.Forms.ToolStripButton tspSolicitacoesAprovadas;
        private System.Windows.Forms.ToolStrip tspLider;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        internal System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem tspInformacoes_logado;
        private System.Windows.Forms.ToolStripMenuItem tspEmail_Logado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trocarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blocoDeNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarDadosPessoaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tspUsuario_logado;
        private System.Windows.Forms.TabPage tbpAdministrador;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tosNovoUsuario;
        private System.Windows.Forms.ToolStripButton tosConsultaUsuario;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        public System.Windows.Forms.TabControl tabPrincipal;
    }
}