using Administratie.Database;
using System;
using System.Collections.Generic;
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
using Administratie.Expression;

namespace Administratie
{
    /// <summary>
    /// Interaction logic for UserAddMenu.xaml
    /// </summary>
    public partial class UserAddMenu : Window
    {
        private DatabaseConnection db = new DatabaseConnection();
        private UserDatabaseConnection userdb = new UserDatabaseConnection();

        public UserAddMenu()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            db.GetConnection().Open();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            UserMenu menu = new UserMenu();
            this.Hide();
            menu.Show();
            this.Close();
        }

        private void createButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (RegexExpression.checkForEmail(emailTextBox.Text.ToString())) {
                    if (RegexExpression.checkForPostalCode(postalCodeTextBox.Text.ToString())) {
                        string insert = userdb.InsertData(
                            this.emailTextBox.Text.ToString(),
                            this.nameTextBox.Text.ToString(),
                            this.sureNameTextBox.Text.ToString(),
                            Convert.ToInt32(this.cellPhoneTextBox.Text),
                            this.postalCodeTextBox.Text.ToString()
                        );

                        MessageBox.Show("Gebruiker aangemaakt");

                        this.sureNameTextBox.Clear();
                        this.emailTextBox.Clear();
                        this.nameTextBox.Clear();
                        this.cellPhoneTextBox.Clear();
                        this.postalCodeTextBox.Clear();
                    }
                }

            }catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
    }
}
