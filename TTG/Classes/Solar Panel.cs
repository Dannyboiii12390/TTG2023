using MonoGameLib.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTG.Classes
{
    public class SolarPanel : PlaceableObject
    {
        float energyGen = .001f;

        public SolarPanel(string pName, Circle pCircle) : base(pName, pCircle)
        {

        }

        public float AddEnergy(float pEnergy)
        {
            return energyGen+pEnergy;
        }
    }
}
