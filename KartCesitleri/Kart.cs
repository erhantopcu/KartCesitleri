using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartCesitleri
{
    public abstract class Kart
    {
        public string KartNo { get; set; }
        public KartTipi Tip { get; set; }
        public decimal Bakiye { get; set; }


        public Kart(string No, KartTipi kartTipi)
        {
            KartNo = No;
            Tip = kartTipi;
            Bakiye = 0; //Bakiyenin ilk oluştururken sıfır olması gerek
        }

        public void ParaCek(decimal ucret) 
        {
            if(Tip == KartTipi.Normal)
            {
                Bakiye -= ucret;
            }
            else if (Tip == KartTipi.Ogrenci)
            {
                Bakiye -= (ucret*0.25M);
            }
            else if (Tip == KartTipi.Personel)
            {
                Bakiye -= (ucret * 0.75M);
            }
            else if (Tip == KartTipi.Yasli)
            {
                Bakiye -= (ucret * 0.40M);
            }

        }

        public void ParaYatır(decimal miktar)
        {
            Bakiye += miktar; 
        }
    }
}
