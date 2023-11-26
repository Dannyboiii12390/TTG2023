using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGameLib.Shapes;
using TTG.Helpers;

namespace TTG.Classes
{
    public class Option
    {
        public Text text { get; private set; }
        public float Cost { get; private set; }
        public Vector2 Position { get { return Hitbox.position; } }
        public Square Hitbox { get; private set; }
        public float Width { get { return Hitbox.width; } }
        public float Height { get { return Hitbox.height; } }


        public Option(Text pText, Square hitbox, float pCost = 1)
        {
            Hitbox = hitbox;
            text = pText;
            Cost = pCost;
        }
        public void Draw(SpriteBatch spriteBatcher)
        {
            spriteBatcher.Draw(text);
        }
        public bool isInside(Vector2 pos)
        {
            return Hitbox.isInside(pos);
        }
    }
}
