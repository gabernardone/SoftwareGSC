using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows
{
    public partial class ucEditar_Usuario : UserControl
    {
        public ucEditar_Usuario()
        {
            InitializeComponent();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            txtNome_detalhe.Enabled = true;
            txtEmail_detalhe.Enabled = true;
            txtUserCadastro_detalhe.Enabled = true;
            chkAdm_consulta.Enabled = true;

        }
    }
}
