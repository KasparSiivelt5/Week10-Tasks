using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Login");
            string UserLogin = Console.ReadLine();
            Console.WriteLine("Password");
            string UserPassword = Console.ReadLine();

            if (UserLogin != "admin" || UserPassword != "admin1234")
            {
                Console.WriteLine("The login is incorrect");
            }
            else
            {
                Console.WriteLine("Success");
            }    
        
        }

    }
}
