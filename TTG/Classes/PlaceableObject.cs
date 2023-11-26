using MonoGameLib.Shapes;
using TTG.Helpers;

namespace TTG.Classes
{
    public class PlaceableObject
    {
        public string name { get; private set; }
        public Circle Hitbox { get; private set; }
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
