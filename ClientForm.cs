﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using coffeeshop.DataBL;

namespace coffeeshop
{
    public partial class ClientForm : Form
    {
        private LoginBL loginBL = null;
        public ClientForm()
        {
            InitializeComponent();
            loginBL = new LoginBL();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
        }

        
    }
}