using System;
namespace alada_s_shop
{
	public class Shop
	{
        public List<Products> ShowProducts { get; set; }
        public int TotalPrice { get; set; }

		public void ShopMenu(List<Products> products,List<Person> users,List<Buy> buys)
		{
			int manage = 0;
			Buy buy = new Buy();
			while (manage != 3)
			{
				try
				{
					Console.WriteLine("1.Search Product\n2.BuyProduct");
					manage = int.Parse(Console.ReadLine()) ;
					if (manage == 1)
					{
						Search(products);
					}
					if (manage == 2)
					{
						buy.buysystem(users,products,buys);
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
		}
		public void Search(List<Products> products)
		{
			try
			{
                Console.WriteLine("Enter ProductID: ");
                int id = int.Parse(Console.ReadLine());

                products.FirstOrDefault(f => f.ProductID == id);

				products.ForEach(product => Console.WriteLine(product));
            }
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}

