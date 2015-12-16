using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Windows
{
    public partial class TelaPrincipal : Form
    {
        public TabSystem.System tabsystem = new TabSystem.System();
        Classes.Contas conta = new Classes.Contas();


        public TelaPrincipal()
        {
            InitializeComponent();
            
        }

        
        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            tabsystem.btnClose = btnClose;
            tabsystem.tabControl_Receptor = tabPrincipal;

            conta.Usuario = frmLogin.tspUsuario_logado;
            conta.getContaAtributo(); //Pega os atributos da conta logada

            //Itens do menu superior esquerdo
            tspInformacoes_logado.Text = conta.Nome; //Nome
            tspInformacoes_logado.DropDownItems[0].Text = "Usuário: " + conta.Usuario; //Usuário
            tspInformacoes_logado.DropDownItems[1].Text = "Email: " + conta.Email; //Email
        }

        private void TelaPrincipal_Shown(object sender, EventArgs e)
        {

            //Se for administrador aparece a aba admin
            if (conta.Administrador)
            {
                if (tabControl1.TabPages[0].Text != "Administrador")
                {
                    tabControl1.TabPages.Insert(0, tbpAdministrador);
                }
            }
            else
            {
                tabControl1.TabPages.RemoveAt(0);
            }
        }


        private void lblData_Click(object sender, EventArgs e)
        {
            lblData_Hora.Text = DateTime.Now.ToString();
        }


        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmSobre sobre = new frmSobre();
            sobre.ShowDialog();

        }

        private void tspNovaSolicitacao_Click_1(object sender, EventArgs e)
        {
            ucNovaSolicitacao solicitacao = new ucNovaSolicitacao();
            tabsystem.addTab(solicitacao);
        }

        private void tspSolicitacoesAprovadas_Click(object sender, EventArgs e)
        {
            ucSolicitacoesAprovadas aprovada = new ucSolicitacoesAprovadas();
            tabsystem.addTab(aprovada);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ucAddUser novousuario = new ucAddUser();
            tabsystem.addTab(novousuario);

        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime data_hora;
            data_hora = DateTime.Now;
            lblData_Hora.Text = string.Format("Data: {0}           Hora:  {1}", 
                                    data_hora.ToLongDateString(), 
                                    data_hora.ToLongTimeString());
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void trocarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Visible=false;
            frmLogin deslogar = new frmLogin();
            deslogar.ShowDialog();
            
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void tosConsultaUsuario_Click(object sender, EventArgs e)
        {
            ucConsultaUsuario consulta = new ucConsultaUsuario();
            tabsystem.addTab(consulta);

        }
   

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            ucAnaliseSolicitacao teste = new ucAnaliseSolicitacao();
            tabsystem.addTab(teste);

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ucAnaliseSolicitacao analise = new ucAnaliseSolicitacao();
            tabsystem.addTab(analise);

        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {


        }

               
    }

}

