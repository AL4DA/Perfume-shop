using System;
namespace alada_s_shop
{
	public class Products
	{
		public int ProductID { get; set; }  
		public string Manufacturer { get; set; }
		public string Name { get; set; }
		public int Price { get; set; }
		public DateTime QTY { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"ProductID: {ProductID} - Manufacturer: {Manufacturer} - ProductName: {Name} - Price: {Price}$ - QTY: {QTY} - Quantity: {Quantity}";
        }

        public void ViewProduct(List<Products> products)
        {
            products.ForEach(product => Console.WriteLine(product));
        }

        public void AddProduct(List<Products> products)
        {
            Products products1 = new Products();
            string manufacturer;
            string name;
            int price;
            DateTime qty;
            int quantity;
            ProductID = 1;
            try
            {
                Console.Write("Enter Manufacturer: ");
                manufacturer = Console.ReadLine();
                Console.Write("Enter Product Name: ");
                name = Console.ReadLine();
                Console.Write("Enter Product Price: ");
                price = int.Parse(Console.ReadLine());
                Console.Write("date of issue: ");
                qty = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter Quantity: ");
                quantity = int.Parse(Console.ReadLine());

                products1 = new Products()
                {
                    ProductID = ProductID++,
                    Manufacturer = manufacturer,
                    Name = name,
                    Price = price,
                    QTY = qty,
                    Quantity = quantity
                };
                products.Add(products1);
                Console.WriteLine("Product Succses Added!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void DeleteProduct(List<Products> products)
        {
            int productid;
            try
            {
                Console.WriteLine("Enter ID: ");
                productid = int.Parse(Console.ReadLine());

                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].ProductID == productid)
                    {
                        products.RemoveAt(i);
                        Console.WriteLine("Product deleted successfully!");
                    }
                    else
                        Console.WriteLine("Product Not Found!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void EditProduct(List<Products> products)
        {
            Products products1 = new Products();
            int id;
            string manufacturer;
            string name;
            int price;
            DateTime qty;
            int quantity;

            foreach (var product in products)
            {
                try
                {
                    Console.WriteLine("Enter ID: ");
                    id = int.Parse(Console.ReadLine());

                    var updateproduct = products.Find(p => p.ProductID == id);

                    if (updateproduct != null)
                    {
                        Console.Write("Enter Manufacturer: ");
                        manufacturer = Console.ReadLine();
                        Console.Write("Enter Product Name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter Product Price: ");
                        price = int.Parse(Console.ReadLine());
                        Console.Write("date of issue: ");
                        qty = DateTime.Parse(Console.ReadLine());
                        Console.Write("Enter Quantity: ");
                        quantity = int.Parse(Console.ReadLine());

                        product.Manufacturer = manufacturer;
                        product.Name = name;
                        product.Price = price;
                        product.QTY = qty;
                        product.Quantity = quantity;

                        Console.WriteLine("Product updated successfully!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Product not found");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}

