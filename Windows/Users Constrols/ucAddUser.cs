using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Diagnostics;
using DevExpress.XtraSplashScreen;
using Windows.Users_Constrols;




namespace Windows
{
    public partial class ucAddUser : UserControl
    {
        private MailMessage Email;
        Stopwatch Stop = new Stopwatch();
        public ucAddUser()
        {
            InitializeComponent();
            /////Nome
            txtNome.GotFocus += txtNome_GotFocus;
            txtNome.LostFocus += txtNome_LostFocus;
            txtNome.Text = "Nome Completo";
            txtNome.ForeColor = Color.Silver;

            /////Email
            txtEmail.Text = "nome.sobrenome";
            txtEmail.GotFocus += txtEmail_GotFocus;
            txtEmail.LostFocus += txtEmail_LostFocus;
            txtEmail.ForeColor = Color.Silver;
        }
        #region Exemplo de Texto(GotFocus)
        private void txtNome_GotFocus(object sender, EventArgs e)
        {

            if (txtNome.Text == "Nome Completo")
            {
                txtNome.Clear();
                txtNome.ForeColor = Color.Black;
            }
        }
        public void txtNome_LostFocus(Object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty)
            {
                txtNome.Text = "Nome Completo";
                txtNome.ForeColor = Color.Silver;
            }
        }

        private void txtEmail_GotFocus(object sender, EventArgs e)
        {
            if (txtEmail.Text == "nome.sobrenome")
            {
                txtEmail.Clear();
                txtEmail.ForeColor = Color.Black;
            }
        }
        public void txtEmail_LostFocus(Object sender, EventArgs e)
        {
            if (txtEmail.Text == string.Empty)
            {
                txtEmail.Text = "nome.sobrenome";
                txtEmail.ForeColor = Color.Silver;
            }
        }
        #endregion
        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            SplashScreenManager.ShowForm(typeof(ucCarregando));


            Classes.Contas conta = new Classes.Contas();

            conta.Setor = cboSetor.SelectedItem.ToString();
            conta.Cargo = cboCargo.SelectedItem.ToString();
            conta.Nome = txtNome.Text;
            conta.Email = txtEmail.Text + lblEmail2.Text;
            conta.Usuario = txtUserCadastro.Text;
            conta.Senha = txtSenhaCadastro.Text;

            //Verifica se é adm ou não
            conta.Administrador = chkAdm.IsOn;


            #region Envia e-mail de Boas vindas.
            // Envia e-mail de Boas vindas.
            Email = new MailMessage();
            Email.To.Add(new MailAddress(conta.Email)); //Destinatário
            Email.To.Add(new MailAddress("gabriel.bernardone@gmail.com"));

            //Para
            Email.From = (new MailAddress(txtEmail.Text + lblEmail2.Text));

            //Assunto
            Email.Subject = "Bem Vindo ao GSC";


            using (StreamReader objReader = new StreamReader("Boas_Vindas.html"))
            {
                // Lê todo o arquivo e o joga em uma variável

                cboCargo.SelectedValue = "conta.Cargo";
                Email.Body = objReader.ReadToEnd();
                Email.Body = Email.Body.Replace("#NOME", conta.Nome);
                Email.Body = Email.Body.Replace("#USUARIO", conta.Usuario);
                Email.Body = Email.Body.Replace("#EMAIL", conta.Email);
                Email.Body = Email.Body.Replace("#SETOR", cboSetor.SelectedItem.ToString());
                Email.Body = Email.Body.Replace("#CARGO", cboCargo.SelectedItem.ToString());



            }

            Email.IsBodyHtml = true;
            Email.Priority = MailPriority.High;
            Email.BodyEncoding = System.Text.Encoding.GetEncoding("utf-8");
            Email.SubjectEncoding = System.Text.Encoding.GetEncoding("utf-8");

            var smtp = new SmtpClient("smtp.gmail.com", 587);
            using (smtp)
            {
                smtp.EnableSsl = true; //Gmail requer SSL
                smtp.Port = 587; //Porta SSL
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network; //modo de envio
                smtp.UseDefaultCredentials = false; //Utiliza credencial especifica

                //Usuário e Senha para autenticação
                smtp.Credentials = new NetworkCredential("gabrielbernardone@gmail.com", "56485277a");

                if (conta.addConta()) //Adiciona a conta
                {

                    smtp.Send(Email);
                    Funcoes.Funcoes funcoes = new Funcoes.Funcoes();
                    SplashScreenManager.CloseForm();
                    MessageBox.Show("Usuário cadastrado com sucesso!\nUm e-mail de Boas Vindas foi enviado para " + conta.Email, "Gestão de Solicitação e Confirmação - Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    funcoes.Limpar(this);

                }
                else
                {
                    SplashScreenManager.CloseForm();
                    MessageBox.Show("Não foi possível criar a conta, tente novamente ou contate o Administrador", "Erro de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }

            #endregion


        }



        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if ((txtUserCadastro.Text == "") || (txtEmail.Text != ""))
                txtUserCadastro.Text = txtEmail.Text;
        }


    }
}




