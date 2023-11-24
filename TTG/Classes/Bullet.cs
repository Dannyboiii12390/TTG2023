using Microsoft.Xna.Framework;
using MonoGameLib.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTG.Classes
{


    public class Bullet : Entity
    {
        public Bullet(Circle pCircle, float pDamage) : base(pCircle, new Vector2(-10,0), pDamage, 0)
        {

        }
    }
}
