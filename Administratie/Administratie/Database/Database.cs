using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administratie.Database
{
    public class Database
    {
        //database connectie met MICROSOFT SQL SERVER.
        //LET OP DIE VAN JOU KAN ANDERS ZIJN!
        public SqlConnection GetConnection()
        {
            try
            {
                SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=CRUD;Integrated Security=True");
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
