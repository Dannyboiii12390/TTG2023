using Microsoft.Xna.Framework;
using MonoGameLib.Shapes;
using TTG.Helpers;

namespace TTG.Classes
{
    public class PlaceableObject
    {
        public string name { get; private set; }
        public Circle Hitbox { get; private set; }
        public Vector2 Position { get { return Hitbox._position; } }
        public PlaceableObject(string pName, Circle pCircle)
        {
            name = pName;
            Hitbox = pCircle;

        }

        public static PlaceableObject CreatePlaceableObject(string name, Circle pCircle)
        {
            return new PlaceableObject(name, pCircle);
        }

        public void Draw(ShapeBatcher shapeBatcher)
        {
            shapeBatcher.Draw(Hitbox);
        }
        
    }

}
