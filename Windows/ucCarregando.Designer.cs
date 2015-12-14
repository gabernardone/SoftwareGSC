namespace Windows.Users_Constrols
{
    partial class ucCarregando
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
            this.pgbCarregando = new DevExpress.XtraWaitForm.ProgressPanel();
            this.tblCarregando = new System.Windows.Forms.TableLayoutPanel();
            this.tblCarregando.SuspendLayout();
            this.SuspendLayout();
            // 
            // pgbCarregando
            // 
            this.pgbCarregando.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pgbCarregando.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.pgbCarregando.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.pgbCarregando.Appearance.Options.UseBackColor = true;
            this.pgbCarregando.Appearance.Options.UseBorderColor = true;
            this.pgbCarregando.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pgbCarregando.AppearanceCaption.ForeColor = System.Drawing.Color.Black;
            this.pgbCarregando.AppearanceCaption.Options.UseFont = true;
            this.pgbCarregando.AppearanceCaption.Options.UseForeColor = true;
            this.pgbCarregando.AppearanceDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pgbCarregando.AppearanceDescription.ForeColor = System.Drawing.Color.Black;
            this.pgbCarregando.AppearanceDescription.Options.UseFont = true;
            this.pgbCarregando.AppearanceDescription.Options.UseForeColor = true;
            this.pgbCarregando.Caption = "Carregando";
            this.pgbCarregando.Description = "Por favor aguarde";
            this.pgbCarregando.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgbCarregando.ImageHorzOffset = 20;
            this.pgbCarregando.Location = new System.Drawing.Point(0, 17);
            this.pgbCarregando.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pgbCarregando.Name = "pgbCarregando";
            this.pgbCarregando.Size = new System.Drawing.Size(246, 39);
            this.pgbCarregando.TabIndex = 0;
            this.pgbCarregando.Text = "progressPanel1";
            this.pgbCarregando.UseWaitCursor = true;
            this.pgbCarregando.Click += new System.EventHandler(this.pgbCarregando_Click);
            // 
            // tblCarregando
            // 
            this.tblCarregando.AutoSize = true;
            this.tblCarregando.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblCarregando.BackColor = System.Drawing.Color.Transparent;
            this.tblCarregando.ColumnCount = 1;
            this.tblCarregando.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCarregando.Controls.Add(this.pgbCarregando, 0, 0);
            this.tblCarregando.Location = new System.Drawing.Point(0, 0);
            this.tblCarregando.Name = "tblCarregando";
            this.tblCarregando.Padding = new System.Windows.Forms.Padding(0, 14, 0, 14);
            this.tblCarregando.RowCount = 1;
            this.tblCarregando.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCarregando.Size = new System.Drawing.Size(246, 73);
            this.tblCarregando.TabIndex = 1;
            this.tblCarregando.UseWaitCursor = true;
            // 
            // ucCarregando
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(214, 66);
            this.Controls.Add(this.tblCarregando);
            this.DoubleBuffered = true;
            this.Name = "ucCarregando";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "Form1";
            this.UseWaitCursor = true;
            this.tblCarregando.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraWaitForm.ProgressPanel pgbCarregando;
        private System.Windows.Forms.TableLayoutPanel tblCarregando;

    }
}
