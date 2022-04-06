using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Domain;

namespace WindowsFormsApp1.Database
{
    public class userController
    {
        private DataBaseConnection db = new DataBaseConnection();

        //TODO show list aanmaken 

        //laat alle lijsten zien in userlist.
        public List<User> getUserList()
        {
            var userList = new List<User>();
            //maakt een connectie database
            SqlConnection con = db.GetConnection();
            //open de con van de databased
            con.Open();
            //SQLcommend is nodig om een query uittevoeren
            SqlCommand query = new SqlCommand("SELECT * FROM User");
            
            //try en catch spreken voorzicht
            try
            {

                SqlDataAdapter da = new SqlDataAdapter(query);
                //Leest de data
                SqlDataReader reader = query.ExecuteReader();


                while (reader.Read())
                {
                    //Haalt de gegevens op van Class User 0 is name enzovoort 
                    User users = new User(
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3));
                    //toevoegen in een list
                    userList.Add(users);
                }

            }
            catch (SqlException e)
            {
                // laat de error zien
                MessageBox.Show("Error " + e.Message);
                //sluit de verbinding met database
                con.Close();
                //daarna stuur die null
                return null;
            }

            return userList;
        }


        public void insert()
        {
            SqlConnection con = db.GetConnection();
            con.Open();

            //TODO TOEVOEG EEN INSERT MODEL.
            try
            {

                SqlCommand insert = new SqlCommand();
                insert.ExecuteNonQuery();

            }catch(SqlException e)
            {
                MessageBox.Show("Error " + e.Message);
                con.Close();
            }
        }
    }
}
