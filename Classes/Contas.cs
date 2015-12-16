using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;
using System.Windows.Forms;
using System.Data;

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
            try
            {
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

        public bool addConta()
        {

            try
            {
                int adm;
                if (Administrador == false)
                    adm = 0;
                else
                    adm = 1;

                var query = new StringBuilder();
                query.Append("INSERT INTO GSCUsuarios (usuario,senha,administrador,email,cargo,setor,nome)");
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

        public void delConta(string userDelete)
        {
            var query = "DELETE FROM GSCUsuarios WHERE usuario = @usuario";

            SqlConnection con = BancoDados.Criarconexao();

            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@usuario", userDelete);

            cmd.ExecuteNonQuery();

            cmd.Dispose();
            con.Close();
            con.Dispose();
        }

        public void setSenha()
        {
        }


        public void getAllUsuarios(DataGridView dataGrid)
        {
            try
            {
                string query = "SELECT nome,usuario,email,administrador FROM GSCUsuarios";
                SqlConnection con = BancoDados.Criarconexao();

                con.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGrid.ReadOnly = true;
                dataGrid.DataSource = ds.Tables[0];

                commandBuilder.Dispose();
                con.Close();
                con.Dispose();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void getLikeConta(string parametroWhere, string parametroCondicao, DataGridView dataGrid)
        {
        
            var query = string.Format("SELECT nome,usuario,email,administrador FROM GSCUsuarios WHERE {0} LIKE @parametroCondicao", parametroWhere);

            SqlConnection con = BancoDados.Criarconexao();

            con.Open();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, con);
            dataAdapter.SelectCommand.Parameters.AddWithValue("parametroCondicao", parametroCondicao + "%");

            DataTable ds = new DataTable();
            dataAdapter.Fill(ds);
            dataGrid.ReadOnly = true;
            dataGrid.DataSource = ds;

            dataAdapter.Dispose();
            con.Close();
            con.Dispose();
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


        private int getAtributoInt(string atributo)
        {
            String Query = "SELECT " + atributo + " FROM dbo.Login WHERE usuario = '" + Usuario + "'"; //Comando

            Conexao Connection = new Conexao(); //Instancia a classe conexao
            return (int)Connection.QueryScalar(Query); //Executa o comando e retorna
        }



    }
}
