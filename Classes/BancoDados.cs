using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Classes.Properties;

namespace Classes
{
    public class BancoDados
    {

        public static SqlConnection Criarconexao()
        {

            return new SqlConnection(Settings.Default.stringConexao);
        }



    }
}
