using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using DevExpress.XtraSplashScreen;
using Windows.Users_Constrols;
using System.Net;
using System.Net.NetworkInformation;



namespace Windows
{

    public partial class frmLogin : Form
    {
        int X = 0;
        int Y = 0;
        public static string tspUsuario_logado;

        public bool IsOnline()
        {
            try
            {
                System.Net.IPHostEntry dummy = System.Net.Dns.GetHostEntry("www.google.com"); //using System.Net;
                return true;
            }
            catch (System.Net.Sockets.SocketException ex)
            {
                return false;
            }
        }

        public void TimerConexao_Tick(System.Object sender, System.EventArgs e)
        {

            if (IsOnline())
            {
                lblStatus1.Text = "Conectado!";
                picStatusConexao.Image = Windows.Properties.Resources.status_online;
            }
            else
            {
                picStatusConexao.Image = Windows.Properties.Resources.status_busy;
                lblStatus1.Text = "Desconectado! Verifique se há conexões existentes.";
            }
        }

        
        private void frmLogin_Load(Object sender, EventArgs e)
        {
            Thread.Sleep(4000);
        }
        public frmLogin()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(frmLogin_MouseDown);
            this.MouseMove += new MouseEventHandler(frmLogin_MouseMove);
            txtSenha.GotFocus += txtSenha_GotFocus;
            txtUsuario.GotFocus += txtUsuario_GotFocus;


        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.ShowDialog();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtSenha.Clear();

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        public static string Sanatization(string str)
        {
            //Função simples para evitar ataques de injeção SQL
            if (str == string.Empty || str == "")
                return str;

            string sValue = str;

            //Valores a serem substituidos
            sValue = sValue.Replace("'", String.Empty);
            sValue = sValue.Replace("--", String.Empty);
            sValue = sValue.Replace("/*", String.Empty);
            sValue = sValue.Replace("*/", String.Empty);
            sValue = sValue.Replace(" or ", String.Empty);
            sValue = sValue.Replace(" and ", String.Empty);
            sValue = sValue.Replace("update", String.Empty);
            sValue = sValue.Replace("-shutdown", String.Empty);
            sValue = sValue.Replace("--", String.Empty);
            sValue = sValue.Replace("'or'1'='1'", String.Empty);
            sValue = sValue.Replace("insert", String.Empty);
            sValue = sValue.Replace("drop", String.Empty);
            sValue = sValue.Replace("delete", String.Empty);
            sValue = sValue.Replace("xp_", String.Empty);
            sValue = sValue.Replace("sp_", String.Empty);
            sValue = sValue.Replace("select", String.Empty);
            sValue = sValue.Replace("1 union select", String.Empty);
            sValue = sValue.Replace("p_datacadastro =", String.Empty);

            //Retorna o valor com as devidas alterações

            return sValue;

        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {

            SplashScreenManager.ShowForm(typeof(ucCarregando));
            txtUsuario.Text = Sanatization(txtUsuario.Text);
            txtSenha.Text = Sanatization(txtSenha.Text);
            tspUsuario_logado = txtUsuario.Text;
            Classes.Contas Account = new Classes.Contas();

            if (Account.UsuarioExiste(txtUsuario.Text, txtSenha.Text))
            {
                    retsUsuario.Visible = false;
                    retsSenha.Visible = false;
                    this.Dispose();
                    SplashScreenManager.CloseForm();
                    TelaPrincipal FormBuffer = new TelaPrincipal();
                    FormBuffer.ShowDialog();         
            }
            else
            {
                SplashScreenManager.CloseForm();

                //Muda posição do botão caso o usuário esta incorreto
                retsUsuario.Visible = true;
                retsSenha.Visible = true;
                panErro.Visible = true;
                lblErro.Text = "Usuário ou senha não autenticados";
                var pointentrar = new Point(236, 132);
                this.btnEntrar.Location = pointentrar;
                var pointcancelar = new Point(106, 132);
                this.btnCancelar.Location = pointcancelar;
            }
        }

        private void txtSenha_GotFocus(object sender, EventArgs e)
        {
            if (panErro.Visible == true)
            {
                panErro.Visible = false;
                //Entrar
                var pointentrar_original = new Point(236, 114);
                this.btnEntrar.Location = pointentrar_original;

                //Cancelar
                var pointcancelar_original = new Point(106, 114);
                this.btnCancelar.Location = pointcancelar_original;

            }
        }


        private void txtUsuario_GotFocus(object sender, EventArgs e)
        {

            if (panErro.Visible == true)
            {
                panErro.Visible = false;
                //Entrar
                var pointentrar_original = new Point(236, 114);
                this.btnEntrar.Location = pointentrar_original;

                //Cancelar
                var pointcancelar_original = new Point(106, 114);
                this.btnCancelar.Location = pointcancelar_original;
            }

        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.PerformClick(); //Simula um clique no btnEntrar
            }


        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            X = this.Left - MousePosition.X;
            Y = this.Top - MousePosition.Y;
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = X + MousePosition.X;
            this.Top = Y + MousePosition.Y;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperar_Senha recuperar = new frmRecuperar_Senha();
            recuperar.ShowDialog();
        }

    }
}


