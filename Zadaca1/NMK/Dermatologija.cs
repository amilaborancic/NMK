using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NekaBibliotekaLol;
namespace NMK
{
    public class Dermatologija:Ordinacija
    {
        private Doktor dezurni;
        private double cijenaPregleda = 50;
        private string nazivOrdinacije = "Dermatologija";

        public Dermatologija(double cijena, Doktor dez) : base(cijena, dez) { BrojPacijenata = 0; }
    }
}
