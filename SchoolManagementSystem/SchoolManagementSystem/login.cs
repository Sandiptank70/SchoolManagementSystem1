﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
       
        private void login_Load(object sender, EventArgs e)
        {
            
           
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {  
            Mdi md = new Mdi();
            md.Show();
            this.Hide();
            

        }

        private void cancleBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
