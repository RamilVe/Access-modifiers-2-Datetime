using System;

namespace Access_modifiers_2__Datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string option;
            bool check;

            User[] users = new User[0];
            do
            {
                check = false;
                Console.WriteLine("1. User elave et");
                Console.WriteLine("2. Userlara bax");
                Console.WriteLine("3. Userlar uzre axtaris et");

                option = Console.ReadLine();
                User user = new User("Ramilv");

                if (option == "1")
                {
                    try
                    {

                        Console.WriteLine("Username: ");
                        user.UserName = Console.ReadLine();

                        Console.WriteLine("Password: ");
                        user.Password = Console.ReadLine();

                        Array.Resize(ref users, users.Length + 1);
                        users[users.Length - 1] = user;

                    }
                    catch (RangeException e)
                    {

                        Console.WriteLine(e.Message);
                    }
                }
                else if (option == "2")
                {
                    for (int i = 0; i < users.Length; i++)
                    {
                        Console.WriteLine(users[i].ShowInfo());
                    }
                }
                else if (option == "3")
                {
                    Console.WriteLine("Axtaris edin: ");
                    string search = Console.ReadLine();

                    for (int i = 0; i < users.Length; i++)
                    {
                        if (users[i].UserName.ToLower().Contains(search.ToLower()))
                        {
                            Console.WriteLine(users[i].ShowInfo());
                        }
                    }
                }

            } while (!check);
        }
    }
}
