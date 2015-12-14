using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Correios.Net;
using DevExpress.XtraSplashScreen;
using Windows.Users_Constrols;

namespace Windows
{
    public partial class ucNovaSolicitacao : UserControl
    {



        public TabSystem.System tabsystem = new TabSystem.System();
        public ucNovaSolicitacao()
        {
            InitializeComponent();
            
            Classes.Contas conta = new Classes.Contas();
            conta.Usuario = frmLogin.tspUsuario_logado;
            conta.getContaAtributo(); //Pega os atributos
            label2.Text = DateTime.Now.ToShortDateString();
            lblSolicitado_nome.Text = conta.Nome; 




        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Address address = BuscaCep.GetAddress(mtbCEP.Text);

                txtLogradouro.Text = address.Street;
                txtBairro.Text = address.District;
                txtCidade.Text = address.City;
                txtEstado.Text = address.State;

            }
            catch (Exception ex)
            {
                lblErroCep.Text = ex.Message;
                lblErroCep.Visible = true;
            }
        }

        private void cboLote_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ucConsultaUsuario teste = new ucConsultaUsuario();
            tabsystem.subIndexTab(teste);
        }

        private void dtpData_Solicitada_ValueChanged(object sender, EventArgs e)
        {

            var dtp = sender as DateTimePicker;

            var selectedDate = dtp.Value;

            if (!(selectedDate.DayOfWeek == DayOfWeek.Saturday || selectedDate.DayOfWeek == DayOfWeek.Sunday))
            {

                var offset = (int)DayOfWeek.Saturday - (int)selectedDate.DayOfWeek;

                var saturday = selectedDate + TimeSpan.FromDays(offset);

                dtp.Value = saturday;
                
                lblErro_data.Visible = true;
                lblErro_data.Text = "Selecione Sábado ou Domingo";

            }
            else
            {

                lblErro_data.Visible = false;

            }

        }

        private void officeNavigationBar1_Click(object sender, EventArgs e)
        {

        }

        private void gpbNovaSolicitacao_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(ucCarregando));

            Classes.Solicitacao solicitacao = new Classes.Solicitacao();

            solicitacao.Data_solicitacao = dtpData_Solicitada.Text;
            solicitacao.Cliente_frota = txtCliente_Frota.Text;
            solicitacao.Rua = txtLogradouro.Text;
            solicitacao.Qtde_solicitada = int.Parse(txtQuantidade_Solicitada.Text);

            if (solicitacao.addsolicitacao()) //Adiciona a solicitação
            {
                Funcoes.Funcoes funcoes = new Funcoes.Funcoes();
                SplashScreenManager.CloseForm();
                MessageBox.Show("Usuário cadastrado com sucesso! Um e-mail de Boas Vindas foi enviado para");
                funcoes.Limpar(this);
            }
            else
            {
                SplashScreenManager.CloseForm();
                MessageBox.Show("Não foi possível cadastrar a solicitação");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }

}
