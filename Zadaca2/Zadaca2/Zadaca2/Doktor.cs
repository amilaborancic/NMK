using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Zadaca2
{

    public class Doktor : IZaposlenikKlinike
    {
        private string ime;
        private string prezime;
        private double plata;
        private double dodatakNaPlatu = 0.1;
        private string md5sifra;
        private string username;
        public double ObracunajPlatu
        {
            get { return plata + plata * dodatakNaPlatu; }
            set { plata = value; }
        }
        public double GlavninaPlate { set { plata = value; } }
        public string Ime { get { return ime; } set { ime = value; } }
        public string Prezime { get { return prezime; } set { prezime = value; } }

        public string Md5sifra { get => md5sifra; }
        public string Username { get => username; }

        public Doktor() { }
        public Doktor(string i, string p)
        {
            ime = i;
            prezime = p;
            md5sifra = Program1.GetMD5Hash("doktor");
            username = ime + " " + prezime;
        }
    }
}
