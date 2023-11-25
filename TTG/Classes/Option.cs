using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGameLib.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using TTG.Helpers;

namespace TTG.Classes
{
    public class Option
    {
        public Text text { get; private set; }
        public float Cost { get; private set; }
        public Vector2 Position { get; private set; }
        public Square Hitbox { get; private set; }
        public float Width { get; private set; }
        public float Height { get; private set; }


        public Option(Text pText, Square hitbox, float pCost = 1)
        {
            Hitbox = hitbox;
            Position = Hitbox.position;
            Width = Hitbox.width;
            Height = Hitbox.height;

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
