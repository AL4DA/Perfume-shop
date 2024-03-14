using System;
namespace alada_s_shop
{
	public class Admin : Person
	{
		List<Person> people { get; set; }

		public void AdminMenu(List<Products> productsList)
		{
            Products products = new Products();
			int manage = 0;
			while (manage != 5)
			{
                try
                {
                    Console.WriteLine("1.Add Product\n2.Delete\n3.Edit\n4.View Product");
                    manage = int.Parse(Console.ReadLine());

                    if (manage == 1)
                        products.AddProduct(productsList);
                    if (manage == 2)
                        products.DeleteProduct(productsList);
                    if (manage == 3)
                        products.EditProduct(productsList);
                    if (manage == 4)
                        products.ViewProduct(productsList);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
		}
	}
}

