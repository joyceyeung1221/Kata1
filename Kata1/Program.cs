using System;

namespace Kata1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose between Step 1 to Step 9");
            int input = Convert.ToInt32(Console.ReadLine());
            User currentUser;
            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello World!");
                    break;
                case 2:
                    currentUser = greeting();
                    currentUser.greetUser();
                    break;
                case 3:
                    currentUser = greeting();
                    string[] mentors = { "Jay", "Thi" };
                    if (Array.Exists(mentors, e => e == currentUser.Name))
                    {
                        currentUser.greetUser();
                    }
                    else
                    {
                        Console.WriteLine("Nah");
                    }
                    break;
                case 4:
                    Console.WriteLine(NumbersRelated.Step4());
                    break;
                case 5:
                    Console.WriteLine(NumbersRelated.Step5());
                    break;
                case 6:
                    Console.WriteLine(NumbersRelated.Step6());
                    break;
                case 7:
                    NumbersRelated.Step7();
                    break;
                default:
                    break;
            }
        }

        static User greeting()
        {
            Console.WriteLine("What's your name?");
            User currenUser = new User(Console.ReadLine());
            return currenUser;
        }

    }
}
