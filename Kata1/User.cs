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
    }
}
