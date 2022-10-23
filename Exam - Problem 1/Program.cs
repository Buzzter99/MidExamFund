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
// 15
// Rome
// 200
// 5630
// Milan
// 10000
// 2630.52
// Naples
// 689.20
// 569.80
// Turin
// 5698.30
// 562.63
// Palermo
// 568.69
// 5742.20
// Genoa
// 652.20
// 568.95
// Bologna
// 568.41
// 5623.20
// Florence
// 568.20
// 2546.20
// Catania
// 5687.10
// 562.10
// Venice
// 5628.20
// 568.52
// Verona
// 523.62
// 5489.62
// Messina
// 10000
// 100
// Padua
// 6985.20
// 564.20
// Trieste
// 2547.20
// 568.21
// Brescia
// 2569.20
// 2145.30
//
// Brescia Burger Bus earned 166.98 leva.