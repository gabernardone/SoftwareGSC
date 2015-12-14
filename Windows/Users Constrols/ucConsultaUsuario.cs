﻿using System;
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

            gridPrincipal.DataSource = conta.listContasReduzido().Tables[0];
            gridPrincipal.ReadOnly = true; 
            configuraDataGridView();


        }

        private void tsbAdicionar_Click(object sender, EventArgs e)
        {
           

        }

        private void tsbDeletar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Tem certeza que deseja deletar ? " + (string)gridPrincipal.Rows[gridPrincipal.CurrentCell.RowIndex].Cells["nome"].Value, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                Classes.Contas conta = new Classes.Contas();
                conta.Nome = (string)gridPrincipal.Rows[gridPrincipal.CurrentCell.RowIndex].Cells["nome"].Value;
                conta.Usuario = (string)gridPrincipal.Rows[gridPrincipal.CurrentCell.RowIndex].Cells["usuario"].Value;
                conta.delConta();

                MessageBox.Show("O Usuário " + (string)gridPrincipal.Rows[gridPrincipal.CurrentCell.RowIndex].Cells["nome"].Value, " foi removido!");
                gridPrincipal.DataSource = conta.listContasReduzido().Tables[0];

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Classes.Contas conta = new Classes.Contas();
            switch (cboFiltro.SelectedIndex)
            {
                case 0:
                    gridPrincipal.DataSource = conta.getContas("nome", txtBusca.Text).Tables[0];
                    break;

                case 1:
                    gridPrincipal.DataSource = conta.getContas("usuario", txtBusca.Text).Tables[0];
                    break;

            }

        }

        private void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            gridPrincipal.Columns[0].HeaderText = "Nome";
            gridPrincipal.Columns[1].HeaderText = "Usuário";
            gridPrincipal.Columns[2].HeaderText = "Email";

            //Define tamanho da coluna
            gridPrincipal.Columns[0].Width = 300;
            gridPrincipal.Columns[1].Width = 200;
            gridPrincipal.Columns[2].Width = 300;

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
    }
}
