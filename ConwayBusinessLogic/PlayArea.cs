using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwayBusinessLogic
{
    public class PlayArea
    {
        public int Columns { get; private set; }
        public int Rows { get; private set; }
        public int Cells { get; private set; }
        bool[,] area;
        public PlayArea(int columns, int rows, int cells)
        {
            Columns = columns;
            Rows = rows;
            Cells = cells;
            area = new bool[Columns, Rows];

        }
        public void Randomize()
        {
            var rnd = new Random();
            var elements = Enumerable.Range(0, Columns * Rows).ToHashSet();
            var item = rnd.Next(0, elements.Count());
            elements.Remove(item);
            var itemCol = item / Columns;
            var itemRow = item % Rows;
        }
        public void Draw()
        {
            Console.Clear();
            for (int c = 0; c < Columns; c++)
            {
                for (int r = 0; r < Rows; r++)
                {
                    Console.SetCursorPosition(c, r);
                    if (area[c, r])
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    char blackSquare = (char)9632;
                    Console.Write(blackSquare);
                }
            }
            Console.SetCursorPosition(0, 0);

        }
        public void ApplyRules()
        {
            var tempArea= new bool[Columns, Rows];
            for (int c = 0; c < Columns; c++)
            {
                for (int r = 0; r < Rows; r++)
                {
                  var neighbors = getNeighborCount(c,r);
                }
            }
        }
        private int getNeighborCount(int[,] matrix, int r, int c)
        {
            int count = 0;

            // iterate through the neighboring elements
            for (int i = Math.Max(r - 1, 0); i <= Math.Min(r + 1, matrix.GetLength(0) - 1); i++)
            {
                for (int j = Math.Max(c - 1, 0); j <= Math.Min(c + 1, matrix.GetLength(1) - 1); j++)
                {
                    // check if the neighboring element is not the current element
                    if (i != r || j != c)
                    {
                        // increment the count for each neighboring element
                        count++;
                    }
                }
            }

            return count;
        }

    }
}
