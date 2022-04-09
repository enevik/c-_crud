using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Domain;

namespace WindowsFormsApp1
{
    public class userController
    {
        private DataBaseConnection db = new DataBaseConnection();

        //TODO show list aanmaken 

        //laat alle lijsten zien in userlist.
        public List<User> GetUsers()
        {
            var userList = new List<User>();
            //maakt een connectie database
            SqlConnection con = db.GetConnection();
            //SQLcommend is nodig om een query uittevoeren
            //in c# moet je [] gebruiken als je gegevens wilt ophalen in database
            SqlCommand query = new SqlCommand("SELECT * FROM [User]");
            //try en catch spreken voorzicht
            try
            {
                //er moet een connectie komen met sql connectie anders een fout melding
                query.Connection = con;
                //open de con van de databased
                con.Open();
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
                //daarna stuur die null
                return null;
            }
            finally {
                //sluit de verbinding met database
                con.Close();
            }

            return userList;
        }


        public string updateInsert(String Name, String Email, String PostalCode, String City)
        {
            //maakt een connectie database
            SqlConnection con = db.GetConnection();

            //insert database
            SqlCommand query = new SqlCommand("INSERT INTO [User] VALUES ('" + Name + "', '" + Email + "', '" + PostalCode + "','" + City + "')");

            //TODO TOEVOEG EEN INSERT MODEL.
            try
            {
                //er moet een connectie komen met sql connectie anders een fout melding
                query.Connection = con;
                //open de con van de databased
                con.Open();
                //Voert de query uit!
                query.ExecuteNonQuery();

                return query.ToString();

            } catch (SqlException e)
            {
                // laat de error zien
                MessageBox.Show("Error " + e.Message);
                //daarna stuur die null
                return null;
            }
            finally
            {
                //sluit de verbinding met database
                con.Close();
            }
        }

        //TODO Delete knop maken
        public String deleteData(String Name) 
        {
            //maakt een connectie database
            SqlConnection con = db.GetConnection();
            //sql command delete
            SqlCommand delete = new SqlCommand("DELETE FROM [USER] WHERE ID='" + Name + "'");

            return null;
        }
    }
}
