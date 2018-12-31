using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NekaBibliotekaLol
{
    public class Doktor : IZaposlenikKlinike
    {
        private string ime;
        private string prezime;
        private double plata;
        private double dodatakNaPlatu = 0.1;
        public double ObracunajPlatu
        {
            get { return plata + plata * dodatakNaPlatu; }
            set { plata = value; }
        }
        public double GlavninaPlate{set{plata = value;} }
        public string Ime { get { return ime; } set { ime = value; } }
        public string Prezime { get { return prezime; } set { prezime = value; } }
        public Doktor() { }
        public Doktor(string i, string p) { ime = i; prezime = p; }
        public Doktor(Doktor d) : this(d.ime, d.prezime) { }
    }
}
