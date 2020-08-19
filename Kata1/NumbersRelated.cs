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

        public static string Step6()
        {
            Console.WriteLine("Select 1 for computing the sum or 2 for the product of 1,...,n");
            int selection = Convert.ToInt32(Console.ReadLine());
            int input = RequireUserInput();
            if (selection == 1) return PrintSum(input).ToString();
            else if (selection == 2) return ListAllNumbers(input);
            else return "Not a valid input";
        }

        private static int RequireUserInput()
        {
            Console.WriteLine("Please enter a number");
            return Convert.ToInt32(Console.ReadLine());
        }

        private static int PrintSum(int input)
        {
            int sum = 0;
            for (int i = 1; i <= input; i++)
            {
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

        private static string ListAllNumbers(int input)
        {
            int[] numbers = new int[input];
            int i = 1;
            while (i <= input)
            {
                numbers[i - 1] = i;
                i++;
            }
            return String.Join(", ", numbers);
        }
    }

}
