using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Administratie.Database
{
    public class DatabaseConnection
    {
        //database connectie met MICROSOFT SQL SERVER.
        //LET OP DIE VAN JOU KAN ANDERS ZIJN!
        public SqlConnection GetConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Administratie;Integrated Security=True");
                return connection;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error " + e.Message);
                return null;
            }
        }
    }
}
