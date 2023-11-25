using MonoGameLib.Shapes;

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
