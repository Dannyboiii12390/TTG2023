using Microsoft.Xna.Framework;
using MonoGameLib.Shapes;

namespace TTG.Classes
{


    public class Bullet : Entity
    {
        public Bullet(Circle pCircle, float pDamage) : base(pCircle, new Vector2(-10, 0), pDamage, 0)
        {

        }
    }
}
