using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class DataBaseConnection
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
            catch (SqlException e) {
                MessageBox.Show("Error " + e.Message);
                return null;
            }
        }
    }
}
