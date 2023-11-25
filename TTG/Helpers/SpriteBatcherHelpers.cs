using Microsoft.Xna.Framework.Graphics;
using MonoGameLib.Shapes;

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
