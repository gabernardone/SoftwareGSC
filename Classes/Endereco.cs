using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Endereco
    {
        private int _id_endereco;
        private string _rua;
        private string _bairro;
        private int _numero;
        private string _cep;
        private string _cidade;
        private string _uf;
        private string _complemento;
        private int _id_solicitacao;

        public Solicitacao Solicitacao
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }

    public class CopyOfEndereco
    {
        private int _id_endereco;
        private string _rua;
        private string _bairro;
        private int _numero;
        private string _cep;
        private string _cidade;
        private string _uf;
        private string _complemento;

        public Funcionario Funcionario
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Cliente Cliente_Frota
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
