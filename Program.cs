using System;
using System.Collections.Generic;
using System.Linq;

namespace MarkAndToys
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            //int[] prices = Array.ConvertAll(Console.ReadLine().TrimEnd().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp));

            List<int> prices = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(pricesTemp => Convert.ToInt32(pricesTemp)).ToList();

            int result = maximumToys(prices, k);

            Console.WriteLine(result);
        }

        private static int maximumToys(List<int> prices, int k)
        {
            prices.Sort();
            int maxCount = 0;
            var spendedMoney = 0;
            foreach (var item in prices)
            {
                spendedMoney += item;
                if (spendedMoney <= k)
                {
                    maxCount++;
                }
                else
                {
                    break;
                }

            }
            return maxCount;
        }
    }
}
