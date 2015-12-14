using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;


namespace Classes
{
    public class Solicitacao
    {
        private int _id_solicitacao;

        public int Id_solicitacao
        {
            get { return _id_solicitacao; }
            set { _id_solicitacao = value; }
        }
        private bool _servico;

        public bool Servico
        {
            get { return _servico; }
            set { _servico = value; }
        }
        private string _produto;

        public string Produto
        {
            get { return _produto; }
            set { _produto = value; }
        }
        private int _qtde_solicitada;

        public int Qtde_solicitada
        {
            get { return _qtde_solicitada; }
            set { _qtde_solicitada = value; }
        }
        private DateTime _data_servico;

        public DateTime Data_servico
        {
            get { return _data_servico; }
            set { _data_servico = value; }
        }
        private int _id_analista;
        public int Id_analista
        {
            get { return _id_analista; }
            set { _id_analista = value; }
        }
        private int _id_lider;

        public int Id_lider
        {
            get { return _id_lider; }
            set { _id_lider = value; }
        }
        private string _observacao;

        public string Observacao
        {
            get { return _observacao; }
            set { _observacao = value; }
        }
        private string _projeto;

        public string Projeto
        {
            get { return _projeto; }
            set { _projeto = value; }
        }

        public Contas Contas
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        private int _periodo_solicitado;
        private bool _status;

        private String _data_solicitacao;
        public String Data_solicitacao
        {
            get { return _data_solicitacao; }
            set { _data_solicitacao = value; }
        }
        private DateTime _data_resposta;

        public DateTime Data_resposta
        {
            get { return _data_resposta; }
            set { _data_resposta = value; }
        }
        private int id_cnpj_cpf;
        private String _cliente_frota;

        public string Cliente_frota
        {
            get { return _cliente_frota; }
            set { _cliente_frota = value; }
        }

        private string _bairro;

        public string Bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }

        private int _cep;

        public int Cep
        {
            get { return _cep; }
            set { _cep = value; }
        }

        private string _cidade;

        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }

        private string _complemento;

        public string Complemento
        {
            get { return _complemento; }
            set { _complemento = value; }
        }

        private int _numero;

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        private string _rua;

        public string Rua
        {
            get { return _rua; }
            set { _rua = value; }
        }

        private string _uf;

        public string Uf
        {
            get { return _uf; }
            set { _uf = value; }
        }
        private int _periodo_autorizado;

        public int Periodo_autorizado
        {
            get { return _periodo_autorizado; }
            set { _periodo_autorizado = value; }
        }

        public bool addsolicitacao()
        {

            string Query;
            try
            {
                Query = "INSERT INTO dbo.Solicitacao";
                Query += ("(data_solicitacao,cliente_frota,qtde_solicitada,rua)");
                Query += "Values ";
                Query += ("('" + Cliente_frota + "'," + Qtde_solicitada.ToString() + ",'" + Rua + "')");
                Query += ("('" + Data_solicitacao.ToString() + "','" + Cliente_frota + "'," + Qtde_solicitada.ToString() + ",'" + Rua + "')");


                Conexao Connection = new Conexao();
                Connection.QueryNon(Query);

                Query = "SELECT cliente FROM dbo.Solicitacao WHERE cliente = '" + Cliente_frota + "'";
                //return (typeof(int) != Connection.QueryScalar(Query).GetType());
                return (typeof(int) != Connection.QueryScalar(Query).GetType());

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro"+ex);
                return false;
            }


        }



    }
}
