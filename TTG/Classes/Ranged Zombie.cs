using Microsoft.Xna.Framework;
using MonoGameLib.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTG.Classes
{
    public class RangedZombie : Zombie
    {
        public RangedZombie(Circle pCircle) : base(pCircle, 10, 75)
        {

        }


        public Bullet Shoot()
        {
            return new Bullet(new Circle(new Vector2(Position.X-Hitbox._radius, Position.Y), 1, Color.Black), damage);
        }
        public RangedZombie ToRangedZombie()
        {
            return (RangedZombie)this;
        }
    }
}
