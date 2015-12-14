using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;
using System.Windows.Forms;


namespace Classes
{

    public class Contas
    {
        //Properties e fields

        public string Senha { get; set; }

        public string Usuario { get; set; }

        public bool Administrador { get; set; }
        public string Cargo { get; set; }

        public string Nome { get; set; }

        public string Setor { get; set; }

        public string Email { get; set; }




        public bool UsuarioExiste(string user, string senha)
        {
            bool ret = false;
            SqlConnection con = BancoDados.Criarconexao();

            con.Open();

            var query = "SELECT COUNT(*) FROM GSCUsuarios WHERE usuario = @usuario and senha= @senha";

            SqlCommand cmd = new SqlCommand(query, con);
              
            cmd.Parameters.AddWithValue("@usuario", user);
            cmd.Parameters.AddWithValue("@senha", senha);
                
            if (int.Parse(cmd.ExecuteScalar().ToString()) == 1)
            {
                ret = true;
            }

            cmd.Dispose();
            con.Close();
            con.Dispose();
               
            return ret;
        }



        public String getSenha(string user)
        {
            String Query = "SELECT senha FROM dbo.Login WHERE usuario = '" + user + "'"; //Comando

            Conexao Connection = new Conexao(); //Instancia a classe conexao
            object ret = Connection.QueryScalar(Query); //Executa o comando e salva o resultado em 'ret'

            if (ret.GetType() == typeof(int))
                return null;
            else
                return (string)ret;
        }

        public object getContaAtributo()
        {
            try {
                SqlConnection con = BancoDados.Criarconexao();
                SqlDataReader reader;
                con.Open();

                var query = "SELECT nome, setor, email, cargo,administrador FROM GSCUsuarios WHERE usuario = @usuario";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@usuario", Usuario);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Nome = reader.GetString(0);
                    Setor = reader.GetString(1);
                    Email = reader.GetString(2);
                    Cargo = reader.GetString(3);
                    Administrador = reader.GetBoolean(4);
                }

                reader.Close();
                reader.Dispose();
                cmd.Dispose();
                //Fecha a conexão ao final pois ela não é mais necessária
                con.Close();
                con.Dispose();

                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
        }

        public void getLogin()
        {
        }

        public bool isAdmin()
        {
            String Query = "SELECT administrador FROM dbo.Login WHERE usuario = '" + Usuario + "'";
            Conexao Connection = new Conexao();

            return (bool)Connection.QueryScalar(Query);
        }

        public bool addConta(/*string usuario, string senha, bool adm, string email, string cargo, string setor, string nome*/)
        {
            
            try
            {
                int adm;
                if (Administrador == false)
                    adm = 0;     
                else
                    adm = 1;

                var query = new StringBuilder();
                query.Append("INSERT INTO GSCUsuarios (usuario,senha,administrador,email,cargo,setor,nome");
                query.Append("VALUES(@usuario, @senha, @administrador, @email, @cargo, @setor, @nome)"); 

                SqlConnection con = BancoDados.Criarconexao();

                con.Open();

                SqlCommand cmd = new SqlCommand(query.ToString(), con);
                cmd.Parameters.AddWithValue("@usuario", Usuario);
                cmd.Parameters.AddWithValue("@senha", Senha);
                cmd.Parameters.AddWithValue("@administrador", adm);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@cargo", Cargo);
                cmd.Parameters.AddWithValue("@setor", Setor);
                cmd.Parameters.AddWithValue("@nome", Nome);

                cmd.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();
                con.Dispose();

                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void delConta()
        {
            string Query; //Cria a variável que vai guardar os comandos

            //Comandos
            Query = "Delete dbo.Login ";
            Query += "Where usuario = '" + Usuario + "'";


            Conexao Connection = new Conexao(); //Instancia a classe conexao
            Connection.QueryNon(Query); //Executa o comando e salva o resultado em 'ret'
        }

        public void setSenha()
        {
        }

        public System.Data.DataSet getContas(string atributo, string conteudo)
        {
            String Query = "SELECT usuario,nome FROM dbo.Login WHERE " + atributo + " LIKE '%" + conteudo + "%'"; //Comando

            Conexao Connection = new Conexao(); //Instancia a classe conexao
            return Connection.QueryDataset(Query); //Executa o comando e RETORNA
        }

        public System.Data.DataSet getContas(string atributo, int conteudo)
        {
            String Query = "SELECT usuario,nome FROM dbo.Login WHERE " + atributo + " LIKE '%" + conteudo.ToString() + "%'"; //Comando

            Conexao Connection = new Conexao(); //Instancia a classe conexao
            return Connection.QueryDataset(Query); //Executa o comando e RETORNA
        }

        public System.Data.DataSet listContas()
        {
            String Query = "SELECT * FROM dbo.Login"; //Comando

            Conexao Connection = new Conexao(); //Instancia a classe conexao
            return Connection.QueryDataset(Query); //Executa o comando e salva o resultado em 'ret'
        }

        public System.Data.DataSet listContasReduzido()
        {
            String Query = "SELECT nome,usuario,email FROM dbo.Login"; //Comando

            Conexao Connection = new Conexao(); //Instancia a classe conexao
            return Connection.QueryDataset(Query); //Executa o comando e salva o resultado em 'ret'
        }

        private string getAtributoStr(string atributo)
        {
            String Query = "SELECT " + atributo + " FROM dbo.Login WHERE usuario = '" + Usuario + "'"; //Comando

            Conexao Connection = new Conexao(); //Instancia a classe conexao
            return (string)Connection.QueryScalar(Query); //Executa o comando e retorna
        }
        private int getAtributoInt(string atributo)
        {
            String Query = "SELECT " + atributo + " FROM dbo.Login WHERE usuario = '" + Usuario + "'"; //Comando

            Conexao Connection = new Conexao(); //Instancia a classe conexao
            return (int)Connection.QueryScalar(Query); //Executa o comando e retorna
        }



    }
}
