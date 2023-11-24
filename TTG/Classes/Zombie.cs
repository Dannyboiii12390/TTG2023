using Microsoft.Xna.Framework;
using MonoGameLib.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
