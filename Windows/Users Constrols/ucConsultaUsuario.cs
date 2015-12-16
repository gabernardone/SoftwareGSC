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
    public partial class ucConsultaUsuario : UserControl
    {

        TabSystem.System tabsystem = new TabSystem.System(); //Instanciando o sistema de abas

        public ucConsultaUsuario()
        {
            InitializeComponent();
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            Classes.Contas conta = new Classes.Contas();
            cboFiltro.SelectedIndex = -1;

            //gridConsultaUsuario.DataSource = conta.listContasReduzido().Tables[0];
            //gridConsultaUsuario.ReadOnly = true;

            conta.getAllUsuarios(gridConsultaUsuario);
            configuraDataGridView();


        }

        private void tsbAdicionar_Click(object sender, EventArgs e)
        {


        }

        private void tsbDeletar_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show(string.Format("Tem certeza que deseja deletar ? {0}",
            (string)gridConsultaUsuario.Rows[gridConsultaUsuario.CurrentCell.RowIndex].Cells["nome"].Value),
            "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr.ToString() == "Yes")
            {

                Classes.Contas conta = new Classes.Contas();

                string userDeletado = (string)gridConsultaUsuario.Rows[gridConsultaUsuario.CurrentCell.RowIndex].Cells["usuario"].Value;
                string nomeDeletado = (string)gridConsultaUsuario.Rows[gridConsultaUsuario.CurrentCell.RowIndex].Cells["nome"].Value;

                conta.delConta(userDeletado);

                MessageBox.Show(string.Format("O Usuário {0} foi removido!", nomeDeletado), "Confirmação de Exclusão");

                conta.getAllUsuarios(gridConsultaUsuario);
                gridConsultaUsuario.Refresh();

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Classes.Contas conta = new Classes.Contas();
            switch (cboFiltro.SelectedIndex)
            {
                case 0:
                    conta.getLikeConta("nome", txtBusca.Text, gridConsultaUsuario);
                    configuraDataGridView();
                    break;

                case 1:
                    conta.getLikeConta("usuario", txtBusca.Text, gridConsultaUsuario);
                    configuraDataGridView();
                    break;

                case 2:
                    conta.getLikeConta("cargo", cboCargo.SelectedItem.ToString(), gridConsultaUsuario);
                    configuraDataGridView();
                    break;
                case 3:
                    conta.getLikeConta("setor", cboSetor.SelectedItem.ToString(), gridConsultaUsuario);
                    configuraDataGridView();
                    break;
                default:
                    break;

            }

        }

        private void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboFiltro.SelectedIndex < 0)
            {
                txtBusca.Enabled = false;
            }
            else
            {
                txtBusca.Enabled = true;
            }

            switch (cboFiltro.SelectedIndex)
            {
                case 2:
                    cboSetor.Visible = false;
                    cboCargo.Visible = true;
                    txtBusca.Visible = false;
                    picBuscar.Visible = false;
                    break;

                case 3:
                    cboSetor.Visible = true;
                    cboCargo.Visible = false;
                    txtBusca.Visible = false;
                    picBuscar.Visible = false;
                    break;

                default:
                    cboSetor.Visible = false;
                    cboCargo.Visible = false;
                    txtBusca.Visible = true;
                    picBuscar.Visible = true;
                    break;
            }
        }


        public void configuraDataGridView()
        {
            //Edita nome da coluna
            gridConsultaUsuario.Columns[0].HeaderText = "Nome";
            gridConsultaUsuario.Columns[1].HeaderText = "Usuário";
            gridConsultaUsuario.Columns[2].HeaderText = "Email";
            gridConsultaUsuario.Columns[3].HeaderText = "Administrador";

            //Define tamanho da coluna
            gridConsultaUsuario.Columns[0].Width = 300;
            gridConsultaUsuario.Columns[1].Width = 200;
            gridConsultaUsuario.Columns[2].Width = 300;
            gridConsultaUsuario.Columns[3].Width = 300;

        }

        private void gridPrincipal_DoubleClick(object sender, EventArgs e)
        {



        }

        private void gridPrincipal_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TelaPrincipal tela = new TelaPrincipal();
            ucEditar_Usuario editarUsuario = new ucEditar_Usuario();
            tabsystem.tabControl_Receptor = tela.tabPrincipal;
            //tabsystem.addTab(editarUsuario);
            tabsystem.subIndexTab(editarUsuario);


        }

        private void gridPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBusca_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}

