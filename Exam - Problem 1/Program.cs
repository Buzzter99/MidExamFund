using System;

namespace Exam___Problem_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int numberOfCities = int.Parse(Console.ReadLine());
            decimal result = 0;
            for (int i = 1; i <= numberOfCities; i++)
            {
                decimal currentProfit = 0;
                string cityName = Console.ReadLine();
                decimal ownerIncome = decimal.Parse(Console.ReadLine());
                decimal ownerExpense = decimal.Parse(Console.ReadLine());
                decimal incomeDecimal = ownerIncome;
                decimal expenseDecimal = ownerExpense;
                if (i % 3 == 0 && i % 5 == 0)
                {
                    currentProfit = incomeDecimal - (expenseDecimal / 2.0m);
                    currentProfit = (incomeDecimal * 0.90m) - expenseDecimal;
                }
                else if (i % 3 == 0)
                {
                    currentProfit = incomeDecimal - (expenseDecimal / 2.0m + expenseDecimal);
                }
                else if (i % 5 == 0)
                {
                    currentProfit = (incomeDecimal * 0.90m) - expenseDecimal;
                }
                else
                {
                    currentProfit = incomeDecimal - expenseDecimal;
                }
                result += currentProfit;
                Console.WriteLine($"In {cityName} Burger Bus earned {currentProfit:f2} leva.");
            }

            Console.WriteLine($"Burger Bus total profit: {result:f2} leva.");
        }
    }
}

// using System;
//
// namespace Exam___Problem_1
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             // Console.WriteLine("Hello World!");
//             int numberOfCities = int.Parse(Console.ReadLine());
//             decimal result = 0;
//
//             for (int i = 1; i <= numberOfCities; i++)
//             {
//                 decimal currentProfit = 0;
//                 string cityName = Console.ReadLine();
//                 decimal ownerIncome = decimal.Parse(Console.ReadLine());
//                 decimal ownerExpense = decimal.Parse(Console.ReadLine());
//                 decimal incomeDecimal = ownerIncome;
//                 decimal expenseDecimal = ownerExpense;
//                 if (i % 3 == 0)
//                 {
//                     expenseDecimal += expenseDecimal / 2.0m;
//                 }
//                 if (i % 5 == 0)
//                 {
//                     incomeDecimal = incomeDecimal - (incomeDecimal * (10 / 100m));
//
//
//                 }
//
//                 currentProfit = incomeDecimal - expenseDecimal;
//                 decimal.Round(currentProfit, 2, MidpointRounding.AwayFromZero);
//                 currentProfit = Math.Round(currentProfit, 2);
//
//                 Console.WriteLine($"In {cityName} Burger Bus earned {currentProfit:f2} leva.");
//                 result += incomeDecimal - expenseDecimal;
//
//
//
//
//
//             }
//
//             Console.WriteLine($"Burger Bus total profit: {result:f2} leva.");
//         }
//     }
// }
