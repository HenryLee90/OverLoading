using System;

namespace OverLoadingMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            var answer = Add(5, 27);
            Console.WriteLine(answer);
            var decimalA = Add(.45m, .76m);
            Console.WriteLine(decimalA);
            var thirdM = Add(4, 72, true);
            var fourthM = Add(5, 86, false);
            Console.WriteLine(fourthM);
            Console.WriteLine(thirdM);
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;

        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }
        public static string Add(int num1, int num2, bool isDollars)
        {
            int sum = num1 + num2; 
            // return num1 + num2;
            if (isDollars == true)
            {
                string answer = ($"${sum}");
                return answer;
            }
            else
            {
                string answer2 = $"{sum}";
                return answer2;
            }
        }
    }
}
