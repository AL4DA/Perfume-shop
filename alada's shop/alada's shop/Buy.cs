using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;

namespace alada_s_shop
{
    public class Buy
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public void buysystem(List<Person> users, List<Products> products,List<Buy> buys)
        {
            
            bool found = false;
            while (!found)
            {
                try
                {
                    Console.WriteLine("Enter User Name: ");
                    string userName = Console.ReadLine();

                    var user = users.FirstOrDefault(u => u.UserName.ToLower() == userName.ToLower());

                    if (user != null)
                    {
                        Console.WriteLine("Enter Product Name: ");
                        string productname = Console.ReadLine();

                        var selectedProduct = products.FirstOrDefault(product => product.Name == productname);

                        if (selectedProduct != null)
                        {
                            Console.WriteLine("Enter Quantity: ");
                            int quantity = int.Parse(Console.ReadLine());

                            if (quantity <= selectedProduct.Quantity)
                            {
                                buys.Add(new Buy
                                {
                                    Name = selectedProduct.Name,
                                    Price = selectedProduct.Price,
                                    Quantity = quantity
                                });

                                selectedProduct.Quantity -= quantity;
                                found = true;
                                Console.WriteLine("Product sold successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient quantity available.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Product not found.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("User not found.");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public void TotalPrice(List<Buy> buys)
        {
            bool found = false;
            string name;

            while (!found)
            {
                Console.WriteLine("Enter Product Name: ");
                name = Console.ReadLine();

                var product = buys.FirstOrDefault(b => b.Name.ToLower() == name.ToLower());

                if (product != null)
                {
                    var total = product.Price * product.Quantity;
                    found = true;
                    Console.WriteLine("Total Price: " + total);
                }
                else
                {
                    Console.WriteLine("Product not found. Please try again.");
                }
            }
        }

    }
}
