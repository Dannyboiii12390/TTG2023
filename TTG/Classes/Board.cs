using Microsoft.Xna.Framework;
using MonoGameLib.Shapes;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTG.Helpers;

namespace TTG.Classes
{
    public class Board
    {
        public List<List<Square>> Cells { get; private set; } = new List<List<Square>>();

        public int cellsWide = 8;
        public int cellsHigh = 6;
        public float cellWidth;
        public float cellHeight;

        public Vector2 offset = new Vector2(160,0);

        public Board(int ScreenWidth, int screenHeight)
        {
            cellWidth = 80;
            cellHeight = 80;

            for (int i = 0; i < cellsHigh; i++) 
            { 
                List<Square> list = new List<Square>();
                for (int j = 0; j < cellsWide; j++)
                {
                    Color color;
                    if ((i + j) % 2 == 0) // is even
                    {
                        color = Color.Green;
                    }
                    else
                    {
                        color = Color.DarkGreen;
                    }
                    list.Add(new Square(j * cellWidth + offset.X, i * cellHeight + offset.Y, cellWidth, cellHeight, color));
                }
                Cells.Add(list);
            }



        }

        public Square GetCell(int i, int j)
        {

            return Cells[i][j];
        }
        public void Draw(ShapeBatcher shapeBatcher)
        {
            foreach(List<Square> list in Cells)
            {
                foreach(Square square in list)
                {
                    shapeBatcher.HelperDrawSquare(square);
                }
            }
        }


    }
}
