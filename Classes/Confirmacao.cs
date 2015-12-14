using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Confirmacao
    {
        private int _id_confirmacao;
        private int _id_solicitacao;
        private DateTime _data_resposta;
        private int _cancelado;
        private DateTime _data_cancelamento;
        private int _placa;
        private int _chassi;
        private int _marca;
        private int _modelo;
        private int _produto;
        private int _observacao;
        private int _telefone;
        private int _corretor;
        private int _vendedor;

        public Relatorio_final_semana Relatorio_final_semana
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Solicitado_confirmacao Solicitado_confirmacao
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Autorizado_confirmacao Autorizado_confirmacao
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Confirmado_cliente Confirmado_cliente
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
