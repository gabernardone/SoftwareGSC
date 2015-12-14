using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Classes
{
    public class Conexao
    {
        public Object QueryScalar(string Command)
        {
            return DatabaseFactory.CreateDatabase("Windows.Properties.Settings.stringConexao").ExecuteScalar(CommandType.Text, Command);

        }

        public void QueryNon(string Command)
        {
            DatabaseFactory.CreateDatabase("Windows.Properties.Settings.dboSoftwareWindowsConnectionString").ExecuteNonQuery(CommandType.Text, Command);
        }

        public System.Data.DataSet QueryDataset(string Command)
        {
            return DatabaseFactory.CreateDatabase("Windows.Properties.Settings.dboSoftwareWindowsConnectionString").ExecuteDataSet(CommandType.Text, Command);
        }
    }
}
