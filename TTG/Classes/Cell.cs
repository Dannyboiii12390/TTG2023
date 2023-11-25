using Microsoft.Xna.Framework;
using MonoGameLib.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTG.Classes
{
    public class Cell
    {
        public Square Square { get; private set; }
        public bool Drought {get; set; }  

        public Color defaultColour { get; private set; }
        
        

        public Cell(Square pSquare) 
        { 
            Square = pSquare;
            defaultColour = Square.color;
            Drought = false;    
        }

    }
}
