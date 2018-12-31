using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NekaBibliotekaLol;
namespace NMK
{
    public class Pacijent
    {
        private string ime;
        private string prezime;
        private spol pol;   
        private Dictionary<Ordinacija, int> raspored;
        private string adresa;
        private string JMBG;  
        private bracnoStanje Stanje; 
        private DateTime datumRegistracije; 
        private DateTime datumRodjenja;  
        private int br_dolazaka = 0;
        private DateTime datumSmrti;
        Karton karton;
        Racun racun;
        public DateTime DatumSmrti { get { return datumSmrti; } set { datumSmrti=value; } }

        public Racun DajRacun
        {
            get { return racun; }
        }

        public double ObracunajTrosak()
        {
            string n = racun.NacinPlacanja;
            double uplata = 0D;
            foreach (Ordinacija o in raspored.Keys)
            {
                uplata += o.CijenaPregleda;
            }
            if ((n == "R" || n == "r") && br_dolazaka > 3 || br_dolazaka < 3 && (n == "g" || n == "G")) { return uplata; }
            else if ((n == "R" || n == "r") && br_dolazaka < 3) { return 1.15 * uplata; }
            else { return 0.99 * uplata; }
        }

        public void IspisiRacun()
        {
            Console.WriteLine("Fiskalni racun:\n");
            foreach (Ordinacija o in raspored.Keys)
            {
                Console.WriteLine("{0}: {1}\n", o.Naziv, o.CijenaPregleda);
            }
            Console.WriteLine("Datum uplate: {0}\n", DateTime.Today);
            Console.WriteLine("Iznos uplate: {0}\n", this.ObracunajTrosak());
        }
        public bool DaLiJeRedovan()
        {
            if (br_dolazaka > 3) return true;
            return false;
        }
        
        public bool DaLiJeIspravanJMBG(string jmbg, DateTime dat)
        {
            string helpme = dat.ToString();

            if (jmbg.Length != 13) return false;


            return true;
        }
        public void SortirajRaspored()
        {
            raspored.OrderBy(kljuc => kljuc.Value).Select(kljuc => kljuc.Key);
        }
        public void IspisiRaspored()
        {
            SortirajRaspored();
            Console.WriteLine("Raspored:\n");
            foreach (var nesto in raspored.Keys)
            {
                Console.WriteLine("{0}: {1}\n", nesto, raspored[nesto]);  //ispisujemo sortiranu mapu I guess
            }
        }
        public Dictionary<Ordinacija,int> Raspored
        {
            get { return raspored; }
        }
        public void PovecajBrojDolazaka() { br_dolazaka++;}

        public Pacijent(string i, string p, spol sp, string adr, string jmbg, bracnoStanje st, DateTime dat_ro, DateTime dat) {
            ime = i; prezime = p; pol = sp; adresa = adr; Stanje = st; datumRegistracije = dat; datumRodjenja = dat_ro;
            raspored = new Dictionary<Ordinacija, int>(); karton = new Karton();
            JMBG = jmbg;
        }
       
        public void KreirajKarton()
        {
            karton = new Karton(JMBG);
        }
        public string DajMaticni
        {
            get { return JMBG; }
        }
        public Karton DajKarton
        {
            get { return karton; }
        }
        public Pacijent() { JMBG = ""; raspored = new Dictionary<Ordinacija, int>(); karton = new Karton(); }
        public void IspisiKarton()
        {
            Console.WriteLine("Pacijent: {0} {1}\n", ime, prezime);
            if (pol == spol.Musko) Console.WriteLine("Spol: Muski\n");
            else Console.WriteLine("Spol: Zenski\n");
            Console.WriteLine("Datum rodjenja: {0}\n", datumRodjenja.ToString("DD/MM/YYYY"));
            Console.WriteLine("Adresa: {0}\n", adresa);
            Console.WriteLine("JMBG: {0}\n", JMBG);
            karton.Ispisi();
        }
    }
}
