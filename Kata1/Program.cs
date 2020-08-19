using System;

namespace Kata1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What's your name?");
            User currenUser = new User(Console.ReadLine());
            currenUser.greetUser();

        }
    }
}
