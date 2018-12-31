using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    public class Uprava : IZaposlenikKlinike
    {
        private double plata;
        private string md5sifra;
        private string username;
        private string ime;
        private string prezime;
        public double ObracunajPlatu
        {
            get { return plata; }
            set { plata = value; }
        }
        public Uprava()
        {
            md5sifra = "uprava";
        }
        public Uprava(string i, string p)
        {
            ime = i;
            prezime = p;
            username = i + " " + p;
            md5sifra = "uprava";
        }
        public double GlavninaPlate { set { plata = value; } }

        public string Md5sifra { get => md5sifra; }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Username { get => username;  }

    }
}
