﻿using System;
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
    public partial class createUser : Form
    {
        private DataBaseConnection db = new DataBaseConnection();
        private userController user = new userController();

        public createUser()
        {
            InitializeComponent();
        }

        private void createUser_Load(object sender, EventArgs e)
        {
            db.GetConnection();
        }

        private void createButton_Click(object sender, EventArgs e)
        {

        }
    }
}
