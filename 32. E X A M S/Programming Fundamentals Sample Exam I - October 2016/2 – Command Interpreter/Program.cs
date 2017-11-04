using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Command_Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се коригира с List и да се оптимизират сметките!

            string[] arr = Console.ReadLine()
                .Split(new[]{' '},StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string input;
            while (!(input = Console.ReadLine()).Equals("end"))
            {
                string[] tokens = input.Split().ToArray();

                string command = tokens[0];

                if (command.Equals("reverse"))
                {
                    int startIndex = int.Parse(tokens[2]);
                    int count = int.Parse(tokens[4]);

                    if (startIndex < 0 || startIndex >= arr.Length || 
                        startIndex + count > arr.Length || count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }

                    ReverseSection(arr, startIndex, count);
                }
                else if (command.Equals("sort"))
                {
                    int startIndex = int.Parse(tokens[2]);
                    int count = int.Parse(tokens[4]);

                    if (startIndex < 0 || startIndex >= arr.Length || 
                        startIndex + count > arr.Length || count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }

                    SortArray(arr, startIndex, count);
                }
                else if (command.Equals("rollLeft"))
                {
                    int count = int.Parse(tokens[1]);

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }

                    RollArrayLeft(arr, count);
                }
                else if (command.Equals("rollRight"))
                {
                    int count = int.Parse(tokens[1]);

                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                        continue;
                    }

                    RollArrayRight(arr, count);
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }

        private static void RollArrayRight(string[] arr, int count)
        {
            for (int i = 0; i < count; i++)
            {
                string temp = arr[arr.Length - 1];
                for (int ar = arr.Length - 1; ar > 0; ar--)
                {
                    arr[ar] = arr[ar - 1];
                }
                arr[0] = temp;
            }
        }

        private static void RollArrayLeft(string[] arr, int count)
        {
            for (int i = 0; i < count; i++)
            {
                string temp = arr[0];
                for (int ar = 0; ar < arr.Length - 1; ar++)
                {
                    arr[ar] = arr[ar + 1];
                }
                arr[arr.Length - 1] = temp;
            }

            //for (int i = 0; i < count % input.Count; i++)
            //{
            //    string element = input[0];
            //    input.RemoveAt(0);
            //    input.Add(element);
            //}
        }

        private static void SortArray(string[] arr, int startIndex, int count)
        {
            List<string> tempArray = new List<string>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                tempArray.Add(arr[i]);
            }
            tempArray.Sort();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                arr[i] = tempArray[i - startIndex];
            }
        }

        private static void ReverseSection(string[] arr, int startIndex, int count)
        {
            for (int i = 0; i < count / 2; i++)
            {
                string temp = arr[startIndex + i];
                arr[startIndex + i] = arr[startIndex + count - 1 - i];
                arr[startIndex + count - 1 - i] = temp;
            }
        }
    }
}
