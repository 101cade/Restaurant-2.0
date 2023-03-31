using System;
using System.Collections.Generic;

namespace Menu
{
    public class Program
    {
        public static void Main()
            {
                DateTime now = DateTime.Now;
                Console.WriteLine(now.ToString());

                Menu menu = new Menu ();

                MenuItem item1 = new MenuItem
                {
                     Name = "Rolls",
                     Price = 8.00,
                    Description = "6 Homemade garlic infused bread rolls",
                    Category = "Appetizer: ",
                    IsNew = true 

                };

                MenuItem item2 = new MenuItem
                {
                    Name = "Chicken Alfredo",
                    Price = 13.50,
                    Description = "Creamy Alfredo sauce mixed in with homemade noodles and grilled chicken breast",
                    Category = "Main Dishes: ",
                    IsNew = false
                };
          
                MenuItem item3 = new MenuItem
                {
                    Name = "Gelato",
                    Price = 5.25,
                    Description = "ya know, Ice cream but Italian. Comes in 3 flavors, raspberry, strawberry, and Kiwi",
                    IsNew = true
                };




           
           menu.AddItem(item1); 
           menu.AddItem(item2);
           menu.AddItem(item3);
        }


    }
}

