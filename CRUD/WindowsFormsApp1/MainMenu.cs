using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainMenu : Form
    {

        //maak een object aan
        private DataBaseConnection a = new DataBaseConnection();

        public MainMenu()
        {
            InitializeComponent();
        }

        //button
        private void UserButton_Click(object sender, EventArgs e)
        {
            //Maak een object
            UserMenu userMenu = new UserMenu();
            //verberg de correcte form dus MainMenu
            this.Hide();
            //laat de user form zien
            userMenu.ShowDialog();
            //sluit form dus MainMenu wordt gesloten, zo dat processor niet overbelast wordt.
            this.Close();          
        }
    }
}
