using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Threading;
using DevExpress.XtraSplashScreen;
using Windows.Users_Constrols;


namespace Windows
{
    public partial class frmRecuperar_Senha : Form
    {
        Funcoes.Funcoes funcoes = new Funcoes.Funcoes();
        private MailMessage Email;
        Stopwatch Stop = new Stopwatch();

        public frmRecuperar_Senha()
        {
            InitializeComponent();
        }

        #region Encaminhar e-mail


        private void btnRecuperar_enviar_Click(object sender, EventArgs e)
        {

            if (txtEmail_recuperacao.Text == txtConf_email.Text)
            {
                SplashScreenManager.ShowForm(typeof(ucCarregando));
                Classes.Contas conta = new Classes.Contas();
                conta.Usuario = txtLogin_recuperacao.Text;
                conta.getContaAtributo();

                if (txtEmail_recuperacao.Text == conta.Email)
                {
                    Email = new MailMessage();
                    Email.To.Add(new MailAddress(conta.Email)); //Destinatário
                    Email.To.Add(new MailAddress("gabrielbernardone@gmail.com"));
                    Email.To.Add(new MailAddress("david@programador.bl.ee"));

                    //Para.
                    Email.From = (new MailAddress(txtEmail_recuperacao.Text));

                    //Assunto.
                    Email.Subject = "Recuperação de Senha - Windows";

                    using (StreamReader objReader = new StreamReader("Recuperacao_senha.html"))
                    {
                            // Lê todo o arquivo e o joga em uma variável
                            Email.Body = objReader.ReadToEnd();
                            Email.Body = Email.Body.Replace("#NOME", conta.Nome);
                            Email.Body = Email.Body.Replace("#USUARIO", conta.Usuario);
                            Email.Body = Email.Body.Replace("#SENHA", conta.getSenha(conta.Usuario));

                    }

                    //Confuguraçoes
                    Email.IsBodyHtml = true;
                    Email.Priority = MailPriority.High;
                    Email.BodyEncoding = System.Text.Encoding.GetEncoding("utf-8");
                    Email.SubjectEncoding = System.Text.Encoding.GetEncoding("utf-8");


                    using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.EnableSsl = true; //Gmail requer SSL
                        smtp.Port = 587; //Porta SSL
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network; //modo de envio
                        smtp.UseDefaultCredentials = false; //Utiliza credencial especifica

                        //Usuário e Senha para autenticação
                        smtp.Credentials = new NetworkCredential("gabrielbernardone@gmail.com", "85245677a");
                        try
                        {
                            
                            smtp.Send(Email);
                            SplashScreenManager.CloseForm();
                            MessageBox.Show("Seu usuário e senha foram enviados com sucesso para " + conta.Email + ". Verifique sua caixa de mensagens.");
                            funcoes.Limpar(this);
                            SplashScreenManager.CloseForm();
                        }
                        catch (Exception Erro)
                        {
                            SplashScreenManager.CloseForm();
                            MessageBox.Show("Ocorreram problemas no envio do e-mail. Erro = " + Erro.ToString());
                        }
                    }
                }
                else
                {
                    SplashScreenManager.CloseForm();
                    MessageBox.Show("O e-mail digitado não coincide com o cadastrado. Por favor, digite corretamente seu e-mail.", "Erro ao conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                SplashScreenManager.CloseForm();
                MessageBox.Show("Os e-mails digitados não coincidem. Digite o mesmo e-mail em ambas caixas de texto.", "Erro ao conectar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        private void btnCancelar_recuperar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;

        }

    }
}

