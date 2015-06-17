using coffeeshop.DataBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeeshop
{
    public partial class Login : Form
    {
        private LoginBL loginBL;
        private DTO dto = null;

        private EventHandler ButtonNumberClicK = null;

        private void OnButtonNumberClick(object sender, EventArgs e)
        {
            if (ButtonNumberClicK != null)
            {
                ButtonNumberClicK(sender, e);
            }
        }

        public Login()
        {
            InitializeComponent();
            loginBL = new LoginBL();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dto = loginBL.login(tbCopyCode.Text);

            if (dto != null)
            {
                MessageBox.Show("Benutzer: '" + dto.User.Username + "' erfolgreich eingeloggt!");

                ClientForm clientform = new ClientForm(dto);
                clientform.Show();
                this.Hide();
            }
        }


        #region keypad_click

        private void ButtonNumberClick(object sender, EventArgs e)
        {
            tbCopyCode.Text = tbCopyCode.Text + ((Button)sender).Name[((Button)sender).Name.Length - 1];
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            tbCopyCode.Text = string.Empty;
        }

        #endregion

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (tbCopyCode.Text.Length > 1)
            {
                tbCopyCode.Text = tbCopyCode.Text.Remove(tbCopyCode.Text.Length - 1, 1);
            }
        }

        private void tbCopyCode_TextChanged(object sender, EventArgs e)
        {
            if (tbCopyCode.Text.Length == 5)
            {
                
            }
        }
    }
    }

