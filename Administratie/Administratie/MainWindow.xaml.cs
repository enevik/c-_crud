using Administratie.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Administratie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DatabaseConnection db = new DatabaseConnection();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db.GetConnection();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            //maakt connectie
            SqlConnection con = db.GetConnection();
            //voert query uit en kijkt of het match
            SqlDataAdapter query = new SqlDataAdapter("SELECT COUNT(*) FROM [Login] WHERE Email='" + userTextBox.Text + "' AND Password='" + passwordTextBox.Password + "'", con);
            //open connectie
            con.Open();
            //virtuele database
            DataTable dt = new DataTable();
            //vul de data
            query.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                //maakt object
                MainMenu menu = new MainMenu();
                //verstop huidege form
                this.Hide();
                //laat nieuw form zien
                menu.ShowDialog();
                //sluit huidge form
                this.Close();
            }
            else
            {
                MessageBox.Show("Ongeldig gebruiksnaam of wachtwoord");
            }
        }
    }
}
