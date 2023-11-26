using Microsoft.Xna.Framework;
using MonoGameLib.Shapes;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTG.Classes
{
    public class WindMill : PlaceableObject
    {
        public float Damage = 20;
        public float Health = 300;
        public int DamageInterval = 75;
        public int Interval = 0;
        
        
        public WindMill(string pName, Circle pCircle) : base(pName, pCircle)
        {

        }
        public Bullet DealDamage()
        {
            return new Bullet(new Circle(new Vector2(Position.X + Hitbox._radius, Position.Y), 1, Color.LightGray), Damage);
        }
    }
}
