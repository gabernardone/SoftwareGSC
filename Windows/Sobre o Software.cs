using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Deployment.Application;
using System.Deployment;
using System.Reflection;

namespace Windows
{


    public partial class frmSobre : Form
    {

        public string PublishVersion
        {
            get
            {
                if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                {
                    Version ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
                    return string.Format("{0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision);
                }
                else
                    return "Not Published";
            }
        }

        public frmSobre()
        {
            InitializeComponent();

        }

        private void frmSobre_Load(object sender, EventArgs e)
        {

            this.lblVersion.Text = PublishVersion.ToString();

            //this.lblVersion.Text = Application.ProductVersion.ToString();

        }
    }
}