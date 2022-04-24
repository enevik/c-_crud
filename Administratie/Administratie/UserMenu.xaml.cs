using Administratie.Database;
using Administratie.Domain;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Administratie
{
    /// <summary>
    /// Interaction logic for UserMenu.xaml
    /// </summary>
    public partial class UserMenu : Window
    {
        private DatabaseConnection db = new DatabaseConnection();
        private UserDatabaseConnection userdb = new UserDatabaseConnection();   
        public UserMenu()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db.GetConnection();
            userDataGrid.ItemsSource = userdb.GetUsers();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MainMenu menu = new MainMenu();
            this.Hide();
            menu.Show();
            this.Close();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            UserAddMenu menu = new UserAddMenu();
            this.Hide();
            menu.Show();
            this.Close();
        }

        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            string rowIndex = userDataGrid.CurrentColumn.ToString();
            int row = Convert.ToInt32(rowIndex);
            
            
            try
            {

                string delete = userdb.deleteData(
                        row.ToString()
                    );

                MessageBox.Show("Gebruiker verwijdert");

                userDataGrid.ItemsSource = userdb.GetUsers();

            }
            catch (Exception error)
            {
                MessageBox.Show("Error " + error.Message);
            }
        }
    }
}
