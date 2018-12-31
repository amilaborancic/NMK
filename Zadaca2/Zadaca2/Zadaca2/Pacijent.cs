using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Zadaca2
{
    public class Pacijent
    {
        private string ime;
        private string prezime;
        private string username;
        private string md5sifra;
        private bool JelZensko;
        private Dictionary<Ordinacija, int> raspored;
        private string adresa;
        private string JMBG;
        private bool JelUBraku;
        private string slika;
        private DateTime datumRegistracije;
        private DateTime datumRodjenja;
        private int br_dolazaka = 0;
        private DateTime datumSmrti;
        private DateTime datumObdukcije;
        Karton karton;
        Racun racun;
        public Racun DajRacun
        {
            get { return racun; }
            set { racun = value; }
        }
        
        public bool DaLiJeRedovan()
        {
            if (br_dolazaka > 3) return true;
            return false;
        }
        public Dictionary<Ordinacija, int> Raspored
        {
            get { return raspored; }
            set { raspored = value; }
        }
        public Pacijent(string i, string p, bool sp, string adr, string jmbg, bool st, DateTime dat_ro, DateTime dat)
        {
            Ime = i; Prezime = p; JelZensko = sp; adresa = adr;  JelUBraku = st; datumRegistracije = dat; datumRodjenja = dat_ro;
            raspored = new Dictionary<Ordinacija, int>(); karton = new Karton();
            JMBG = jmbg;
            md5sifra = Program.GetMD5Hash("pacijent");
            username = ime + " " + prezime;
        }
        public Pacijent() { JMBG = ""; raspored = new Dictionary<Ordinacija, int>(); karton = new Karton();
            md5sifra = Program.GetMD5Hash("pacijent");
        }
        public string DajMaticni
        {
            get { return JMBG; }
            set { JMBG = value; }
        }
        public Karton DajKarton
        {
            get { return karton; }
            set { karton = value; }
        }
        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Slika { get => slika; set => slika = value; }
        public bool jelUBraku { get => JelUBraku; set => JelUBraku = value; }
        public bool jelZensko { get => JelZensko; set => JelZensko = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public DateTime DatumRegistracije { get => datumRegistracije; set => datumRegistracije = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }
        public DateTime DatumSmrti { get => datumSmrti; set => datumSmrti = value; }
        public DateTime DatumObdukcije { get => datumObdukcije; set => datumObdukcije = value; }
        public string Username { get => username; }
        public int Br_dolazaka { get => br_dolazaka; set => br_dolazaka = value; }
    }
}
