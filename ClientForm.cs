using System;
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
        CoffeeShopBL coffeeShopBL = null;
        private int currentCoffeeCount = 1;

        public ClientForm()
        {
            InitializeComponent();
        }

        public ClientForm(DTO dto)
        {
            InitializeComponent();

            this.coffeeShopBL = new CoffeeShopBL(dto);
            tbCoffeeCount.Text = currentCoffeeCount.ToString();

            if(dto != null)
            {
                if(dto.User != null)
                {
                    lbUserName.Text = dto.User.Username;
                    tbReceipt.Text = coffeeShopBL.getReceipt();
                }
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (currentCoffeeCount != 1)
            {
                currentCoffeeCount = currentCoffeeCount - 1;
                tbCoffeeCount.Text = currentCoffeeCount.ToString();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            currentCoffeeCount = currentCoffeeCount + 1;
            tbCoffeeCount.Text = currentCoffeeCount.ToString();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
           coffeeShopBL.orderCoffee(currentCoffeeCount);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
