using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wormhole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int counter = 0;
            for (int index = 0; index < nums.Length; index++)
            {
                if (nums[index].Equals(0))
                {
                    counter++;
                    continue;
                }
                else
                {
                    int temp = nums[index];
                    nums[index] = 0;
                    index = temp-1;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
