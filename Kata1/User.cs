using System;
namespace Kata1
{
    public class User
    {
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public void greetUser()
        {
            Console.WriteLine($"Hi~{Name}. It's lovely to see you!!");
        }

        public void CheckUserName()
        {
            string[] mentors = { "Jay", "Thi" };
            if (Array.Exists(mentors, e => e == Name))
            {
                greetUser();
            }
            else
            {
                Console.WriteLine("Nah");
            }
        }

        public static User GetUserName()
        {
            Console.WriteLine("What's your name?");
            User currenUser = new User(Console.ReadLine());
            return currenUser;
        }

    }
}
