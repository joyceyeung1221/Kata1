using System;
namespace Kata1
{
    public class Menu
    {
        public static void ListAllOptions()
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
                    currentUser = User.GetUserName();
                    currentUser.greetUser();
                    break;
                case 3:
                    currentUser = User.GetUserName();
                    currentUser.CheckUserName();
                    break;
                case 4:
                    NumbersRelated.Step4();
                    break;
                case 5:
                    NumbersRelated.Step5();
                    break;
                case 6:
                    NumbersRelated.Step6();
                    break;
                case 7:
                    NumbersRelated.Step7();
                    break;
                case 8:
                    NumbersRelated.Step8();
                    break;
                case 9:
                    YearsRelated.Step9();
                    break;
                default:
                    break;
            }
        }


    }
}
