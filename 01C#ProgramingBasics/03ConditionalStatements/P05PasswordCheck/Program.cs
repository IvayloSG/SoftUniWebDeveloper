using System;

namespace P05PasswordCheck
{
    class Program
    {
        private const string rightPassword = "s3cr3t!P@ssw0rd";
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (password == rightPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
