using Microsoft.Xna.Framework;
using MonoGameLib.Shapes;

namespace TTG.Classes
{
    public class Cell
    {
        public Square Square { get; private set; }
        public bool Drought { get; set; }
        public PlaceableObject Object { get; set; } = null;

        public Color defaultColour { get; private set; }



        public Cell(Square pSquare)
        {
            Square = pSquare;
            defaultColour = Square.color;
            Drought = false;
        }

        public void placeObject(PlaceableObject pObject)
        {
            Object = pObject;
        }

    }
}
