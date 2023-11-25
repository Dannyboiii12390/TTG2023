using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGameLib.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTG.Helpers
{
    public static class SpriteBatcherHelpers
    {
        public static void Draw(this SpriteBatch sb, Text text)
        {
            sb.Begin();
            sb.DrawString(text.Font, text.text, text._position, text._colour);
            sb.End();
        }



    }
}
