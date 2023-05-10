using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jatek
{
    class Megjelenites_factory
    {
        public Random r = new Random();

        public Ilathato Create()
        {
            int x = r.Next(5);

            switch (x)
            {
                case 0:
                    return new urleny("Albatroz", "közepes_szint", "Nagyon_csunya", 4);
                case 1:
                    return new urleny("Dzsokijuing", "magas_szint", "Nagyon_csunya", 9);
                case 2:
                    return new urleny("baba_tunde", "alacsony_szint", "Kicsit_csunya", 2);
                case 3:
                    return new urleny("Kang", "közepes_szint", "Közepesen_csunya", 6);
                default:
                    return new urleny("Grincs", "magas_szint", "Nagyon_csunya", 9);


            }
        }


            
        }


    }

