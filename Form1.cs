using coffeeshop.DataBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeeshop
{
    public partial class Form1 : Form
    {
        private LoginBL loginBL;
        public Form1()
        {
            InitializeComponent();
            loginBL = new LoginBL();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool success = loginBL.login("1234");

            if (!success)
            {
                MessageBox.Show("");
            }
        }

    }
}
