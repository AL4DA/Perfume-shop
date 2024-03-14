using System;
namespace alada_s_shop
{
	public class Person
	{
		public string UserName { get; set; }
		public string Password { get; set; }
		public int UserID { get; set; }
		public string UserType { get; set; }

        public override string ToString()
        {
            return $"UserID: {UserID} -UserName: {UserName} - Password: {Password} - UserType: {UserType}";
        }

		public void RegisterUser(List<Person> users)
		{
			Person person = null;
			string Username;
			string password;
			int defid;
			while (person == null)
			{
				try
				{
					Console.Write("Enter UserName: ");
					Username = Console.ReadLine();
                    Console.Write("Enter Password: ");
					password = Console.ReadLine();

					defid = users.Count > 0 ? users.Max(p => p.UserID) + 1 : 1;

					if (person == null)
					{
						person = new Person()
						{
							UserName = Username,
							Password = password,
							UserID = defid,
							UserType = "Regular"
						};
						Console.WriteLine("Succses");
						users.Add(person);
					}
					else if (person != null)
						throw new Exception("Something Wrong!");
					Console.WriteLine(person);
                }
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
		}
		public void RegisterAdmin(List<Person> Admins)
		{
            Person person = null;
            string Username;
            string password;
            int defid;
            while (person == null)
            {
                try
                {
                    Console.Write("Enter UserName: ");
                    Username = Console.ReadLine();
                    Console.Write("Enter Password: ");
                    password = Console.ReadLine();

                    defid = Admins.Count > 0 ? Admins.Max(p => p.UserID) + 1 : 1;

                    if (person == null)
                    {
                        person = new Person()
                        {
                            UserName = Username,
                            Password = password,
                            UserID = defid,
                            UserType = "Admin"
                        };
                        Console.WriteLine("Succses");
                        Admins.Add(person);
                    }
                    else if (person != null)
                        throw new Exception("Something Wrong!");
                    Console.WriteLine(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

		public void Login(List<Person> people1,List<Products> productsList,List<Buy> buys)
		{
			Person person = null;
			User user1 = new User();
			Admin admin1 = new Admin();
			string username;
			string password;
				try
				{
					Console.Write("Enter Username: ");
					username = Console.ReadLine();
					Console.Write("Enter Password: ");
					password = Console.ReadLine();

					var found = people1.FirstOrDefault(p => p.UserName.ToLower() == username.ToLower() && p.Password.ToLower() == password.ToLower());

				if (found != null)
				{
					if (found.UserType == "Regular")
						user1.UserMenu(productsList,people1,buys);
					if (found.UserType == "Admin")
						admin1.AdminMenu(productsList);
					person = found;
				}
				else
					Console.WriteLine("Not Founded!");
				}
				catch (NullReferenceException ex)
				{
					Console.WriteLine(ex.Message);
				}
		}
    }
}

