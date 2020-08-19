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
            string[] mentors = { "Jay", "Thi" };

            if(Array.Exists(mentors, e => e == currenUser.Name))
            {
                currenUser.greetUser();
            }
            else
            {
                Console.WriteLine("Nah");
            }


        }
    }
}
