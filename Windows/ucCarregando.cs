using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraWaitForm;
using DevExpress.Skins;
using DevExpress.XtraSplashForm;
using DevExpress.LookAndFeel;
using Windows.Properties;


namespace Windows.Users_Constrols
{
    public partial class ucCarregando : WaitForm
    {
        public ucCarregando()
        {
            InitializeComponent();
            ChangeLoadingPicture();
            this.pgbCarregando.AutoHeight = true;

        }

        private void ChangeLoadingPicture()
        {
            Skin commonSkin = CommonSkins.GetSkin(UserLookAndFeel.Default.ActiveLookAndFeel);
            SkinElement loadingBig = commonSkin["LoadingBig"];
            loadingBig.Image.SetImage(Resources.LoadingBig, Color.Empty);
            
        }


        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.pgbCarregando.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.pgbCarregando.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum WaitFormCommand
        {
        }

        private void pgbCarregando_Click(object sender, EventArgs e)
        {

        }
    }
}