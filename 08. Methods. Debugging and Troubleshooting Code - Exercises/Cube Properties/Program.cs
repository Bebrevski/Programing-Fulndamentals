using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double cubeLenght = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            double result;
            if (command.Equals("face"))
            {
                result = GetFaceDiagonal(cubeLenght);
            }
            else if (command.Equals("space"))
            {
                result = GetSpaceDiagonal(cubeLenght);
            }
            else if (command.Equals("volume"))
            {
                result = GetVolume(cubeLenght);
            }
            else 
            {
                result = GetSurfaceArea(cubeLenght);
            }

            Console.WriteLine("{0:f2}", result);
        }
        private static double GetFaceDiagonal(double cubeLenght)
        {
            return Math.Sqrt(2 * cubeLenght * cubeLenght);
        }
        private static double GetSpaceDiagonal(double cubeLenght)
        {
            return Math.Sqrt(3 * cubeLenght * cubeLenght);
        }
        private static double GetVolume(double cubeLenght)
        {
            return Math.Pow(cubeLenght, 3);
        }
        private static double GetSurfaceArea(double cubeLenght)
        {
            return 6 * (cubeLenght * cubeLenght);
        }
    }
}
