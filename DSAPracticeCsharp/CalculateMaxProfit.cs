// See https://aka.ms/new-console-template for more information

using System;



 
int calculateMaxProfit(List<int> prices)
        {
            int minTillNow = int.MaxValue;
            int maxProfit = 0;
            prices.ForEach(delegate(int i)
            {
                if (i < minTillNow)
                {
                    minTillNow = i;
                }

                if (i - minTillNow > maxProfit)
                {
                    maxProfit = i - minTillNow;
                }
            });
            return maxProfit;
        }


Console.WriteLine(calculateMaxProfit(new List<int> { 310, 315, 275, 295, 260, 270, 290, 230, 255, 250 }));