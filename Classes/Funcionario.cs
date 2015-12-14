using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Classes
{
    public class Funcionario
    {
        private int _id_funcionario;

        public int Id_funcionario
        {
            get { return _id_funcionario; }
            set { _id_funcionario = value; }
        }
        private int _cargo;

        public int Cargo
        {
            get { return _cargo; }
            set { _cargo = value; }
        }
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        private int _setor;

        public int Setor
        {
            get { return _setor; }
            set { _setor = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public bool addFuncionario()
        {
            //Comandos
            string Query;
            Query = "Insert into dbo.Funcionario";
            Query += "(nome,email,cargo,setor)";
            Query += "Values ";
            Query += "('" + Nome + "','" + Email + "'," + Cargo.ToString() + "," + Setor.ToString() + ")";

            Conexao Connection = new Conexao(); //Instancia a classe conexao
            Connection.QueryNon(Query); //Executa o comando e salva o resultado em 'ret'

            Query = " SELECT id_funcionario FROM dbo.Funcionario WHERE nome = '" + Nome + "' AND email = '" + Email + "'";
            Id_funcionario = (int)Connection.QueryScalar(Query);

            return (Id_funcionario != 0); //se nao tiver nada, retorna 0 [vira false]
        }

        public void listFuncionario()
        {
            throw new System.NotImplementedException();
        }

        public void getFuncionario()
        {
            getAtributos(Id_funcionario);
        }

        public void setFuncionario()
        {
            throw new System.NotImplementedException();
        }

        private string getAtributoStr(string atributo)
        {
            String Query = "SELECT " + atributo + " FROM dbo.Funcionario WHERE id_funcionario = " + Id_funcionario; //Comando

            Conexao Connection = new Conexao(); //Instancia a classe conexao
            return (string)Connection.QueryScalar(Query); //Executa o comando e retorna
        }
        private int getAtributoInt(string atributo)
        {
            String Query = "SELECT " + atributo + " FROM dbo.Funcionario WHERE id_funcionario = " + Id_funcionario; //Comando

            Conexao Connection = new Conexao(); //Instancia a classe conexao
            return (int)Connection.QueryScalar(Query); //Executa o comando e retorna
        }

        private void getAtributos(int id_funcionario)
        {
            Nome = getAtributoStr("nome");
            Setor = getAtributoInt("setor");
            Email = getAtributoStr("email");
            Cargo = getAtributoInt("cargo");
        }


    }
}
