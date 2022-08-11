using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartCesitleri
{
    public class KisiyeOzelFizikselKart : PhysicalCard
    {
        public KisiyeOzelFizikselKart(string No,KartTipi tip, string Ad, string Soyad, string TCKN) : base(No, tip)
        {
            Name = Ad;
            Surname = Soyad;
            ID = TCKN;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ID { get; set; }
    }
}
