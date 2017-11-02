using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Trophon_the_Grumpy_Cat
{
    class Program
    {
        static string leftOrRight = string.Empty;
        static void Main(string[] args)
        {
            int[] prices = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int entryIndex = int.Parse(Console.ReadLine());

            string typeOfItems = Console.ReadLine();
            //cheap-lower price rating than the entry point item
            //expensive -same price rating, or higher

            string typeOfPrice = Console.ReadLine(); //positive>0/neg<0/all

            long sum = GetSum(prices, entryIndex, typeOfItems, typeOfPrice);

            Console.WriteLine("{0} - {1}", leftOrRight, sum);

        }

        private static long GetSum(int[] prices, int entryIndex, string typeOfItems, string typeOfPrice)
        {
            long leftSum = 0;
            for (int i = entryIndex - 1; i >= 0; i--)
            {
                if (typeOfItems.Equals("cheap"))
                {
                    if (typeOfPrice.Equals("positive"))
                    {
                        if (prices[i] < prices[entryIndex] && prices[i] > 0)
                        {
                            leftSum += (long)prices[i];
                        }
                    }
                    else if (typeOfPrice.Equals("negative"))
                    {
                        if (prices[i] < prices[entryIndex] && prices[i] < 0)
                        {
                            leftSum += (long)prices[i];
                        }
                    }
                    else if (typeOfPrice.Equals("all"))
                    {
                        if (prices[i] < prices[entryIndex])
                        {
                            leftSum += (long)prices[i];
                        }
                    }
                }
                else if (typeOfItems.Equals("expensive"))
                {
                    if (typeOfPrice.Equals("positive"))
                    {
                        if (prices[i] >= prices[entryIndex] && prices[i] > 0)
                        {
                            leftSum += (long)prices[i];
                        }
                    }
                    else if (typeOfPrice.Equals("negative"))
                    {
                        if (prices[i] >= prices[entryIndex] && prices[i] < 0)
                        {
                            leftSum += (long)prices[i];
                        }
                    }
                    else if (typeOfPrice.Equals("all"))
                    {
                        if (prices[i] >= prices[entryIndex])
                        {
                            leftSum += (long)prices[i];
                        }
                    }
                }
            }

            long rightSum = 0;
            for (int i = entryIndex + 1; i < prices.Length; i++)
            {
                if (typeOfItems.Equals("cheap"))
                {
                    if (typeOfPrice.Equals("positive"))
                    {
                        if (prices[i] < prices[entryIndex] && prices[i] > 0)
                        {
                            rightSum += (long)prices[i];
                        }
                    }
                    else if (typeOfPrice.Equals("negative"))
                    {
                        if (prices[i] < prices[entryIndex] && prices[i] < 0)
                        {
                            rightSum += (long)prices[i];
                        }
                    }
                    else if (typeOfPrice.Equals("all"))
                    {
                        if (prices[i] < prices[entryIndex])
                        {
                            rightSum += (long)prices[i];
                        }
                    }
                }
                else if (typeOfItems.Equals("expensive"))
                {
                    if (typeOfPrice.Equals("positive"))
                    {
                        if (prices[i] >= prices[entryIndex] && prices[i] > 0)
                        {
                            rightSum += (long)prices[i];
                        }
                    }
                    else if (typeOfPrice.Equals("negative"))
                    {
                        if (prices[i] >= prices[entryIndex] && prices[i] < 0)
                        {
                            rightSum += (long)prices[i];
                        }
                    }
                    else if (typeOfPrice.Equals("all"))
                    {
                        if (prices[i] >= prices[entryIndex])
                        {
                            rightSum += (long)prices[i];
                        }
                    }
                }
            }

            if (leftSum >= rightSum)
            {
                leftOrRight = "Left";
                return leftSum;
            }
            else
            {
                leftOrRight = "Right";
                return rightSum;
            }
        }
    }
}
