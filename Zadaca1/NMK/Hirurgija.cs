using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NekaBibliotekaLol;
namespace NMK
{
    public class Hirurgija:Ordinacija
    {
        string nazivOrdinacije = "Hirurgija";
        public Hirurgija(double c, Doktor d) : base(c, d) { BrojPacijenata = 0; }

    }
}
