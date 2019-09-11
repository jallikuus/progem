﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class ShoppingCart
    {
        public int Sum { get; set; }


        public ShoppingCart()
        {
            Sum = 0;

        }

        public void AddToCart(Food food, int amount)
        {
            Sum = Sum + food.Price * amount;
        }


    }
}
