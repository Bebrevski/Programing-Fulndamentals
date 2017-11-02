using System;
using System.Collections.Generic;
using System.Linq;

namespace Portal
{
    class Portal
    {
        static void Main()
        {
            int sizeOfMatrix = int.Parse(Console.ReadLine());
            var matrix = new char[sizeOfMatrix][];

            int[] startPos = new int[2];
            for (int curRow = 0; curRow < sizeOfMatrix; curRow++)
            {
                List<char> lineCols = Console.ReadLine().ToCharArray().ToList();
                if (lineCols.Count < sizeOfMatrix)
                {
                    int remaindSize = sizeOfMatrix - lineCols.Count;
                    for (int empty = 0; empty < remaindSize; empty++)
                        lineCols.Add('N');
                }

                if (lineCols.Contains('S'))
                {
                    string str = string.Join("", lineCols);
                    int indexCol = str.IndexOf('S');
                    startPos[0] = curRow;
                    startPos[1] = indexCol;
                }

                matrix[curRow] = string.Format("{0}", string.Join("", lineCols)).ToCharArray();
            }

            int row = startPos[0];
            int col = startPos[1];
            char[] commands = Console.ReadLine().ToCharArray();

            for (int pos = 0; pos < commands.Length; pos++)
            {
                if (commands[pos].Equals('D'))
                {
                    row++;

                    if (row >= sizeOfMatrix)
                        row = 0;
                }
                else if (commands[pos].Equals('U'))
                {
                    row--;

                    if (row < 0)
                        row = sizeOfMatrix - 1;
                }
                else if (commands[pos].Equals('L'))
                {
                    col--;

                    if (col < 0)
                        col = sizeOfMatrix - 1;
                }
                else if (commands[pos].Equals('R'))
                {
                    col++;

                    if (col >= sizeOfMatrix)
                        col = 0;
                }

                if (matrix[row][col].Equals('N'))
                {
                    pos--;
                    continue;
                }
                else if (matrix[row][col].Equals('E'))
                {
                    Console.WriteLine("Experiment successful. {0} turns required.", pos + 1);
                    break;
                }

                if (pos.Equals(commands.Length - 1))
                {
                    Console.WriteLine("Robot stuck at {0} {1}. Experiment failed.", row, col);
                }
            }
        }
    }
}