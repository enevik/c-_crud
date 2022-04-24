using Administratie.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Administratie.Database
{
    public class UserDatabaseConnection
    {
        private DatabaseConnection db = new DatabaseConnection();

        public List<UserController> GetUsers() {

            var userList = new List<UserController>();

            SqlConnection con = db.GetConnection();

            SqlCommand query = new SqlCommand("SELECT * FROM [User]");

            try
            {
                query.Connection = con;

                con.Open();

                SqlDataReader reader = query.ExecuteReader();

                while (reader.Read()) {
                    UserController users = new UserController(
                         reader.GetString(0),
                         reader.GetString(1),
                         reader.GetString(2),
                         reader.GetInt32(3),
                         reader.GetString(4));

                    userList.Add(users);
                
                }

            } catch (SqlException e)
            {
                MessageBox.Show("Error " + e.Message);
                return null;
            }
            finally
            {
                con.Close();
            }

            return userList;
        }

        public String InsertData(String Email, String Name, String Surename, int PhoneNumber, String Postalcode) { 

            SqlConnection con = db.GetConnection();

            SqlCommand query = new SqlCommand("INSERT INTO [User] VALUES ('" + Email + "','" + Name + "','" + Surename + "','" + PhoneNumber + "','" + Postalcode + "')");

            try
            {
                query.Connection = con;

                con.Open();

                query.ExecuteNonQuery();

                return query.ToString();
            } catch(SqlException e)
            {
                MessageBox.Show("Error " + e.Message);
                return null;
            } finally
            {
                con.Close();
            }
            
        }

        public String deleteData(String Email) { 

            SqlConnection con = db.GetConnection();

            SqlCommand query = new SqlCommand("DELETE FROM [User] WHERE Email='" + Email + "'");

            try
            {
                //er moet een connectie komen met sql connectie anders een fout melding
                query.Connection = con;
                //open de con van de databased
                con.Open();

                query.ExecuteNonQuery();

                return query.ToString();
            }
            catch (SqlException e)
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
    }
}
