using System;
namespace Kata1
{
    public class NumbersRelated
    {
        public static int Step4()
        {
            int input = RequireUserInput();
            return PrintSum(input);
        }

        public static int Step5()
        {
            int input = RequireUserInput();
            return SumDivisorOf3or5(input);
        }

        private static int PrintSum(int input)
        {
            int sum = 0;
            for (int i = 1; i <= input; i++){
                sum += i;
            }
            return sum;
        }

        private static int SumDivisorOf3or5(int input)
        {
            int sum = 0;
            for (int i = 1; i <= input; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        private static int RequireUserInput()
        {
            Console.WriteLine("Please enter a number");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
