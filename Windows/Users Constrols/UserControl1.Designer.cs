namespace Windows
{
    partial class ucAnaliseSolicitacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAnaliseSolicitacao));
            this.button1 = new System.Windows.Forms.Button();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.cboSetor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.tsbCadastrar = new System.Windows.Forms.ToolStrip();
            this.tspAprovarSolicitacao = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.tsbCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(739, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtBusca
            // 
            this.txtBusca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBusca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBusca.Location = new System.Drawing.Point(344, 118);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(231, 20);
            this.txtBusca.TabIndex = 47;
            // 
            // cboCargo
            // 
            this.cboCargo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCargo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Items.AddRange(new object[] {
            "Analista de Call Center",
            "Supervisor(a)",
            "Gerente",
            "Líder"});
            this.cboCargo.Location = new System.Drawing.Point(344, 117);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(231, 21);
            this.cboCargo.TabIndex = 50;
            // 
            // cboSetor
            // 
            this.cboSetor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cboSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSetor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboSetor.FormattingEnabled = true;
            this.cboSetor.Items.AddRange(new object[] {
            "Gestão Transacional PJ",
            "Televendas",
            "Técnica",
            "SAC"});
            this.cboSetor.Location = new System.Drawing.Point(344, 117);
            this.cboSetor.Name = "cboSetor";
            this.cboSetor.Size = new System.Drawing.Size(231, 21);
            this.cboSetor.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 9.5F);
            this.label1.Location = new System.Drawing.Point(197, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Filtrar por:";
            // 
            // cboFiltro
            // 
            this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Items.AddRange(new object[] {
            "Nome",
            "Analista",
            "Setor",
            "CPF/CNPJ",
            "Data"});
            this.cboFiltro.Location = new System.Drawing.Point(200, 117);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(138, 21);
            this.cboFiltro.TabIndex = 45;
            // 
            // tsbCadastrar
            // 
            this.tsbCadastrar.AutoSize = false;
            this.tsbCadastrar.BackColor = System.Drawing.Color.White;
            this.tsbCadastrar.BackgroundImage = global::Windows.Properties.Resources.white_gradient_2;
            this.tsbCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbCadastrar.Dock = System.Windows.Forms.DockStyle.None;
            this.tsbCadastrar.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCadastrar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsbCadastrar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tspAprovarSolicitacao,
            this.toolStripSeparator1,
            this.toolStripButton5});
            this.tsbCadastrar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.tsbCadastrar.Location = new System.Drawing.Point(0, 0);
            this.tsbCadastrar.Name = "tsbCadastrar";
            this.tsbCadastrar.Size = new System.Drawing.Size(818, 63);
            this.tsbCadastrar.TabIndex = 51;
            // 
            // tspAprovarSolicitacao
            // 
            this.tspAprovarSolicitacao.Image = global::Windows.Properties.Resources.ok_check_yes_tick_accept_success_32;
            this.tspAprovarSolicitacao.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tspAprovarSolicitacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspAprovarSolicitacao.Margin = new System.Windows.Forms.Padding(1, 1, 6, 2);
            this.tspAprovarSolicitacao.Name = "tspAprovarSolicitacao";
            this.tspAprovarSolicitacao.Size = new System.Drawing.Size(115, 60);
            this.tspAprovarSolicitacao.Text = "Aprovar Solicitação";
            this.tspAprovarSolicitacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 63);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Margin = new System.Windows.Forms.Padding(1, 1, 6, 2);
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(115, 60);
            this.toolStripButton5.Text = "Recusar Solicitação";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // picBuscar
            // 
            this.picBuscar.BackColor = System.Drawing.Color.Transparent;
            this.picBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBuscar.Image = ((System.Drawing.Image)(resources.GetObject("picBuscar.Image")));
            this.picBuscar.Location = new System.Drawing.Point(555, 120);
            this.picBuscar.Name = "picBuscar";
            this.picBuscar.Size = new System.Drawing.Size(17, 16);
            this.picBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBuscar.TabIndex = 48;
            this.picBuscar.TabStop = false;
            // 
            // ucAnaliseSolicitacao
            // 
            this.AccessibleName = "Analise de Solicitação";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tsbCadastrar);
            this.Controls.Add(this.picBuscar);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.cboSetor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboFiltro);
            this.Controls.Add(this.button1);
            this.Name = "ucAnaliseSolicitacao";
            this.Size = new System.Drawing.Size(817, 453);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.tsbCadastrar.ResumeLayout(false);
            this.tsbCadastrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        internal System.Windows.Forms.PictureBox picBuscar;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.ComboBox cboSetor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboFiltro;
        internal System.Windows.Forms.ToolStrip tsbCadastrar;
        private System.Windows.Forms.ToolStripButton tspAprovarSolicitacao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;

    }
}
