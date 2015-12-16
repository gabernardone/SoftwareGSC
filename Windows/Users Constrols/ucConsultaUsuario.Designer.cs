namespace Windows
{
    partial class ucConsultaUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucConsultaUsuario));
            this.label1 = new System.Windows.Forms.Label();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.gridConsultaUsuario = new System.Windows.Forms.DataGridView();
            this.cboSetor = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboCargo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cboFiltro = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnPesquisar = new DevExpress.XtraEditors.SimpleButton();
            this.btnVerTodos = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.txtBusca = new DevExpress.XtraEditors.TextEdit();
            this.tsbConsulta = new System.Windows.Forms.ToolStrip();
            this.tsbDeletar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ttpPesquisa = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSetor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCargo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFiltro.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusca.Properties)).BeginInit();
            this.tsbConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9.5F);
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtrar por:";
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackColor = System.Drawing.Color.White;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(68, 21);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.miniToolStrip.Size = new System.Drawing.Size(815, 62);
            this.miniToolStrip.TabIndex = 47;
            // 
            // gridConsultaUsuario
            // 
            this.gridConsultaUsuario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridConsultaUsuario.Location = new System.Drawing.Point(3, 303);
            this.gridConsultaUsuario.Name = "gridConsultaUsuario";
            this.gridConsultaUsuario.Size = new System.Drawing.Size(1209, 170);
            this.gridConsultaUsuario.TabIndex = 50;
            this.gridConsultaUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPrincipal_CellContentClick);
            this.gridConsultaUsuario.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridPrincipal_CellMouseDoubleClick);
            this.gridConsultaUsuario.DoubleClick += new System.EventHandler(this.gridPrincipal_DoubleClick);
            // 
            // cboSetor
            // 
            this.cboSetor.Location = new System.Drawing.Point(141, 57);
            this.cboSetor.Name = "cboSetor";
            this.cboSetor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSetor.Properties.Items.AddRange(new object[] {
            "Gestão Transacional PJ",
            "SAC",
            "Televendas",
            "Técnica"});
            this.cboSetor.Properties.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.cboSetor.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cboSetor.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboSetor.Size = new System.Drawing.Size(238, 20);
            this.cboSetor.TabIndex = 53;
            // 
            // cboCargo
            // 
            this.cboCargo.Location = new System.Drawing.Point(141, 57);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCargo.Properties.Items.AddRange(new object[] {
            "Analista de Call Center",
            "Supervisor(a)",
            "Gerente",
            "Líder"});
            this.cboCargo.Properties.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.cboCargo.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cboCargo.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboCargo.Size = new System.Drawing.Size(238, 20);
            this.cboCargo.TabIndex = 54;
            // 
            // cboFiltro
            // 
            this.cboFiltro.Location = new System.Drawing.Point(9, 57);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboFiltro.Properties.Items.AddRange(new object[] {
            "Nome",
            "Usuário",
            "Cargo",
            "Setor"});
            this.cboFiltro.Properties.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.cboFiltro.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cboFiltro.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboFiltro.Size = new System.Drawing.Size(111, 20);
            this.cboFiltro.TabIndex = 55;
            this.cboFiltro.SelectedIndexChanged += new System.EventHandler(this.cboFiltro_SelectedIndexChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(464, 274);
            this.btnPesquisar.LookAndFeel.SkinName = "Office 2013 Light Gray";
            this.btnPesquisar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 56;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.Location = new System.Drawing.Point(563, 274);
            this.btnVerTodos.LookAndFeel.SkinName = "Office 2013 Light Gray";
            this.btnVerTodos.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(151, 23);
            this.btnVerTodos.TabIndex = 57;
            this.btnVerTodos.Text = "Buscar todos Usuários";
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picBuscar);
            this.groupBox1.Controls.Add(this.txtBusca);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboFiltro);
            this.groupBox1.Controls.Add(this.cboSetor);
            this.groupBox1.Controls.Add(this.cboCargo);
            this.groupBox1.Location = new System.Drawing.Point(385, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 88);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa de Cadastros";
            // 
            // picBuscar
            // 
            this.picBuscar.BackColor = System.Drawing.Color.Transparent;
            this.picBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBuscar.Image = global::Windows.Properties.Resources.search_20;
            this.picBuscar.Location = new System.Drawing.Point(359, 59);
            this.picBuscar.Name = "picBuscar";
            this.picBuscar.Size = new System.Drawing.Size(17, 16);
            this.picBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBuscar.TabIndex = 42;
            this.picBuscar.TabStop = false;
            // 
            // txtBusca
            // 
            this.txtBusca.Enabled = false;
            this.txtBusca.Location = new System.Drawing.Point(141, 57);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Properties.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.txtBusca.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtBusca.Size = new System.Drawing.Size(238, 20);
            this.txtBusca.TabIndex = 56;
            this.txtBusca.ToolTip = "Selecione o tipo de filtro para pesquisa.";
            this.ttpPesquisa.SetToolTip(this.txtBusca, "Selecione o tipo de filtro para pesquisa.");
            this.txtBusca.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Exclamation;
            this.txtBusca.ToolTipTitle = "Atenção";
            this.txtBusca.EditValueChanged += new System.EventHandler(this.txtBusca_EditValueChanged);
            // 
            // tsbConsulta
            // 
            this.tsbConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tsbConsulta.AutoSize = false;
            this.tsbConsulta.BackColor = System.Drawing.Color.White;
            this.tsbConsulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsbConsulta.BackgroundImage")));
            this.tsbConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbConsulta.Dock = System.Windows.Forms.DockStyle.None;
            this.tsbConsulta.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbConsulta.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsbConsulta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbDeletar,
            this.toolStripSeparator1});
            this.tsbConsulta.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsbConsulta.Location = new System.Drawing.Point(6, 7);
            this.tsbConsulta.Name = "tsbConsulta";
            this.tsbConsulta.Size = new System.Drawing.Size(1208, 62);
            this.tsbConsulta.TabIndex = 49;
            // 
            // tsbDeletar
            // 
            this.tsbDeletar.AutoSize = false;
            this.tsbDeletar.BackColor = System.Drawing.Color.Transparent;
            this.tsbDeletar.Image = global::Windows.Properties.Resources.Delete_32x32;
            this.tsbDeletar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDeletar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeletar.Margin = new System.Windows.Forms.Padding(1, 1, 6, 2);
            this.tsbDeletar.Name = "tsbDeletar";
            this.tsbDeletar.Size = new System.Drawing.Size(55, 55);
            this.tsbDeletar.Text = "Deletar";
            this.tsbDeletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDeletar.Click += new System.EventHandler(this.tsbDeletar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 62);
            // 
            // ttpPesquisa
            // 
            this.ttpPesquisa.AutomaticDelay = 200;
            this.ttpPesquisa.IsBalloon = true;
            this.ttpPesquisa.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.ttpPesquisa.ToolTipTitle = "Atenção";
            // 
            // ucConsultaUsuario
            // 
            this.AccessibleName = "Consulta de Usuário";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVerTodos);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.gridConsultaUsuario);
            this.Controls.Add(this.tsbConsulta);
            this.Name = "ucConsultaUsuario";
            this.Size = new System.Drawing.Size(1219, 512);
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultaUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSetor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCargo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboFiltro.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBusca.Properties)).EndInit();
            this.tsbConsulta.ResumeLayout(false);
            this.tsbConsulta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        internal System.Windows.Forms.ToolStrip tsbConsulta;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton tsbDeletar;
        private DevExpress.XtraEditors.ComboBoxEdit cboSetor;
        private DevExpress.XtraEditors.ComboBoxEdit cboCargo;
        private DevExpress.XtraEditors.ComboBoxEdit cboFiltro;
        private DevExpress.XtraEditors.SimpleButton btnPesquisar;
        private DevExpress.XtraEditors.SimpleButton btnVerTodos;
        internal System.Windows.Forms.PictureBox picBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.DataGridView gridConsultaUsuario;
        private DevExpress.XtraEditors.TextEdit txtBusca;
        private System.Windows.Forms.ToolTip ttpPesquisa;
    }
}
