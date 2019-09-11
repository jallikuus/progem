using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class DetailedShoppingCart
    {
        List<Food> Items { get; set; }

        List<int> Amounts { get; set; }

        public DetailedShoppingCart()
        {
            Items = new List<Food>();
            Amounts = new List<int>();
        }

        public void AddToCart(Food food, int amont1)
        {
            Items.Add(food);
            Amounts.Add(amont1);
        }

        public void KorvKokku()
        {
            int a = 0;
            foreach (var item in Items)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(Amounts[a]);
                a++;
            }
        }
    }
}
