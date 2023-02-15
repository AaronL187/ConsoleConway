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
        public int Rows { get;private set ; }
        public int Cells { get;private set; }
        bool[,] area;
        public PlayArea(int columns, int rows, int cells)
        {
            Columns = columns;
            Rows = rows;
            Cells = cells;
            area = new bool[Columns, Rows];

        }
        private void Randomize()
        {

        }
        public void Draw()
        {


        }
    }
}
