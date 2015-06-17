using coffeeshop.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeshop.DataBL
{
    public class CoffeeShopBL
    {
        public DTO DTO { get; set; }
        private int coffeePrice = 1;

        public CoffeeShopBL(DTO dto)
        {
            this.DTO = dto;
        }

        public void orderCoffee(int coffeeCount)
        {
            DTO.Order.TotalPrice = getTotalPrice(coffeeCount);
            CoffeeShopDataAccess.OrderCoffee(DTO.User.Id, DTO.User.Username, coffeeCount, DTO.Order.TotalPrice);
        }

        private int getTotalPrice(int coffeeCount)
        {
            return coffeeCount * coffeePrice;
        }

        public string getReceipt()
        {
            string receipt = string.Empty;
            CoffeeShopDataAccess.getReceipt();

            return receipt;
        }
    }
}
