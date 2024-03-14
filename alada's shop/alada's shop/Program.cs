namespace alada_s_shop;

class Program
{
    static void Main(string[] args)
    {
        List<Products> products = new List<Products>()
        {
            new Products(){ProductID = 1, Manufacturer = "Dior", Name = "Sauvage",Price = 400,QTY = new DateTime(2020,06,7),Quantity = 200},
        };

        List<Person> people = new List<Person>()
        {
            new Person(){UserID = 1, UserName = "Lasha",Password = "Pianino1", UserType = "Regular"},
            new Admin(){UserID = 2, UserName = "Admin", Password = "Admin", UserType = "Admin"},
        };
        List<Buy> buys = new List<Buy>();
        Menu(people,products,buys);
    }

    static void Menu(List<Person> people,List<Products> products,List<Buy> buys)
    {
        Person person = new Person();
        int manage = 0;

        while (manage != 7)
        {
            try
            {
                Console.WriteLine("1.Register User\n2.Register Admin\n3.Login\n4.Exit");
                manage = int.Parse(Console.ReadLine());

                if (manage == 1)
                {
                    person.RegisterUser(people);
                }
                if (manage == 2)
                {
                    person.RegisterAdmin(people);
                }
                if (manage == 3)
                {
                    person.Login(people,products,buys);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

