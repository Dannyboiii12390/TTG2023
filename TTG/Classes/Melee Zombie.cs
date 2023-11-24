using Microsoft.Xna.Framework;
using MonoGameLib.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTG.Classes
{
    public class MeleeZombie : Zombie
    {
        //load image assets here
        public MeleeZombie(Circle pCircle) : base(pCircle, 30, 150)
        {
        }

        public MeleeZombie ToMeleeZombie()
        {
            return (MeleeZombie)this;
        }
    }
}
