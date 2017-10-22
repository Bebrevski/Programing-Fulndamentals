using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();

            char[] arr2 = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();

            if (arr1.Length > arr2.Length)
            {
                Console.WriteLine(string.Join(string.Empty, arr2));
                Console.WriteLine(string.Join(string.Empty, arr1));
                return;
            }
            else if (arr1.Length < arr2.Length)
            {
                Console.WriteLine(string.Join(string.Empty, arr1));
                Console.WriteLine(string.Join(string.Empty, arr2));
                return;
            }
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[0].Equals(arr2[i]))
                    {
                        continue;
                    }
                    else if(arr1[0]>arr2[0])
                    {
                        Console.WriteLine(string.Join(string.Empty, arr2));
                        Console.WriteLine(string.Join(string.Empty, arr1));
                        return;
                    }
                    else
                    {
                        Console.WriteLine(string.Join(string.Empty, arr1));
                        Console.WriteLine(string.Join(string.Empty, arr2));
                        return;
                    }
                }
            }
            
        }
    }
}
