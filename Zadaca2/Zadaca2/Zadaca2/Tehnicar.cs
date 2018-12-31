using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    public class Tehnicar : IZaposlenikKlinike
    {
        private double glavninaPlate;
        private string md5sifra;
        private string username;
        private string ime;
        private string prezime;
        public double ObracunajPlatu
        {
            get { return glavninaPlate; }
            set { glavninaPlate = value; }
        }
        public double GlavninaPlate { set { glavninaPlate = value; } }

        public string Username { get => username;  }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }

        public Tehnicar()
        { }
        public Tehnicar(string i, string p)
        {
            ime = i; prezime = p;
            md5sifra = Program.GetMD5Hash("tehnicar");
            username = i + " " + p;
        }
    }
}
