using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartCesitleri
{
    public abstract class PhysicalCard : Kart
    {
        public PhysicalCard(string No, KartTipi Tip) : base(No,Tip)
        {
        }
    }
}
