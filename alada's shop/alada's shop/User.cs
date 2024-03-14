using System;
namespace alada_s_shop
{
    public class User : Person
    {
        public List<Person> people { get; set; }

        public void UserMenu(List<Products> productsList,List<Person> users,List<Buy> buys)
        {
            Shop shops = new Shop();
            Buy buy = new Buy();
            int manage = 0;
            while (manage != 3)
            {
                try
                {
                    Console.WriteLine("1.View Product\n2.Buy Product");
                    manage = int.Parse(Console.ReadLine());

                    if (manage == 1)
                        buy.TotalPrice(buys);
                    if (manage == 2)
                        shops.ShopMenu(productsList,users,buys);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

    }
}

