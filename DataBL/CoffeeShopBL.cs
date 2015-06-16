﻿using coffeeshop.DataAccess;
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
            DTO.TotalPrice = getTotalPrice(coffeeCount);
            CoffeeShopDataAccess.OrderCoffee(DTO.User.Id, DTO.User.Username, coffeeCount, DTO.TotalPrice);
        }

        private int getTotalPrice(int coffeeCount)
        {
            return coffeeCount * coffeePrice;
        }
       

    }
}