using Microsoft.Xna.Framework;
using MonoGameLib.Shapes;

namespace TTG.Classes
{
    public class Zombie : Entity
    {
        public Zombie(Circle pCircle, float pDamage, float pDamageInterval) : base(pCircle, new Vector2(-1, 0), pDamage, pDamageInterval)
        {

        }
        public Zombie ToZombie()
        {
            return (Zombie)this;
        }
    }
}
