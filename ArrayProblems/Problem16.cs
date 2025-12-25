using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    public class Problem16
    {
        public void MaxProfitSellingStocksWrapper()
        {
            int[] arr = { 10, 7, 5, 8, 11, 9 };
            MaxProfit(arr);
        }
        private static void MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length < 2)
            {
                Console.WriteLine("Not Enough stocks availble.");
            }
            else
            {

                int minPrice = int.MaxValue;
                int maxProfit = 0;

                foreach (int currentPrice in prices)
                {
                    if (currentPrice < minPrice)
                    {
                        minPrice = currentPrice;
                    }
                    else
                    {
                        int potentialProfit = currentPrice - minPrice;
                        if (potentialProfit > maxProfit)
                        {
                            maxProfit = potentialProfit;
                        }
                    }

                }

                Console.WriteLine("MaxProfit by selling stocks are:"+maxProfit);
            }
        }

    }
}
