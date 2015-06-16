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
    public partial class Login : Form
    {
        private LoginBL loginBL;
        private UserBL userBL;
        
        private EventHandler ButtonNumberClicK;
        
            private void OnButtonNumberClick(object sender, EventArgs e)
            {
                if(ButtonNumberClicK != null)
                {
                    ButtonNumberClicK(sender, e);
                }
            }
            
        public Login()
        {
            InitializeComponent();
            loginBL = new LoginBL();
            userBL = new UserBL();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userBL.Username = loginBL.login("1234");

            if (userBL.Username != string.Empty)
            {
                MessageBox.Show("Benutzer: '" + userBL.Username + "' erfolgreich eingeloggt!");
            }
        }


        #region keypad_click

        private void ButtonNumberClick(object sender, EventArgs e)
        {
            tbCopyCode.Text = tbCopyCode.Text + ((Button)sender).Name[((Button)sender).Name.Length -1];
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tbCopyCode.Text = string.Empty;
        }

#endregion
}
    }

