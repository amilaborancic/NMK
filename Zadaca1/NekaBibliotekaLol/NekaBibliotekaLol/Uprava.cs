using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NekaBibliotekaLol
{
    public class Uprava : IZaposlenikKlinike
    {
        private double plata;
        public double ObracunajPlatu
        {
            get { return plata; }
            set { plata = value; }
        }
        public double GlavninaPlate { set { plata = value; } }

    }
}
