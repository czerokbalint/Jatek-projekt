using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jatek
{
    class urleny : Ilathato
    {
        public string Nev { get; }
        public string Szint { get; }
        public string Csunyasag { get; }
        public int Sebzes { get; }
        public char Megjelenites { get; }



        public urleny(string nev, string szint, string csunyasag, int sebzes,char megjelenites)
        {
            Nev = nev;
            Szint = szint;
            Csunyasag = csunyasag;
            Sebzes = sebzes;
            Megjelenites = megjelenites;

        }
        public urleny(string Nev,string Szint,string Csunyasag, int Sebzes)
        {
            this.Nev = Nev;
            this.Szint = Szint;
            this.Csunyasag = Csunyasag;
            this.Sebzes = Sebzes;
        }




        public override string ToString()
        {
            return $"URleny: {Nev}, szint: {Szint}, Csunyasaga: {Csunyasag}, Sebzese: {Sebzes}, Megjelenítés: {Megjelenites}";
        }
    }
}
