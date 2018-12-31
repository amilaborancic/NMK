using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Zadaca2
{
    public sealed partial class Karton
    {
        private string JMBG;
        private List<string> prijasnjeAlergije;
        private List<string> prijasnjeBolesti;
        private List<Terapija> prijasnjeTerapije;
        private List<Terapija> trenutne;
        private List<string> sadasnjeAlergije;
        private List<string> sadasnjeBolesti;
        private List<string> bolestiUPorodici;
        private List<string> pregledi;  //pregledi koje naknadno doktor zadaje
        private List<string> zakljucciDoktora;

        public List<string> Pregledi
        {
            get { return pregledi; }
            set { pregledi = value; }
        }
        public string DajMaticni
        {
            get { return JMBG; }
            set { JMBG = value; }
        }

        public string JMBG1 { get => JMBG; set => JMBG = value; }
        public List<string> PrijasnjeAlergije { get => prijasnjeAlergije; set => prijasnjeAlergije = value; }
        public List<string> PrijasnjeBolesti { get => prijasnjeBolesti; set => prijasnjeBolesti = value; }
        public List<Terapija> PrijasnjeTerapije { get => prijasnjeTerapije; set => prijasnjeTerapije = value; }
        public List<Terapija> Trenutne { get => trenutne; set => trenutne = value; }
        public List<string> SadasnjeAlergije { get => sadasnjeAlergije; set => sadasnjeAlergije = value; }
        public List<string> SadasnjeBolesti { get => sadasnjeBolesti; set => sadasnjeBolesti = value; }
        public List<string> BolestiUPorodici { get => bolestiUPorodici; set => bolestiUPorodici = value; }
        public List<string> ZakljucciDoktora { get => zakljucciDoktora; set => zakljucciDoktora = value; }

        public void dodajPrijasnjuAlergiju(string nova)
        {
            prijasnjeAlergije.Add(nova);
        }
        public void dodajPrijasnjuBolest(string nova)
        {
            prijasnjeBolesti.Add(nova);
        }

        public void obrisiTerapiju(Terapija ter)
        {
            prijasnjeTerapije.Add(ter);
            trenutne.Remove(ter);  //DODAJ PROVJERU ISPRAVNOSTI
        }

        public void dodajBolestUPorodici(string bup)
        {
            bolestiUPorodici.Add(bup);  //DODAJ PROVJERU ISPRAVNOSTI
        }

        public Karton()
        {
            prijasnjeAlergije = new List<string>();
            prijasnjeBolesti = new List<string>();
            prijasnjeTerapije = new List<Terapija>();
            trenutne = new List<Terapija>();
            sadasnjeAlergije = new List<string>();
            sadasnjeBolesti = new List<string>();
            bolestiUPorodici = new List<string>();
            pregledi = new List<string>();
            zakljucciDoktora = new List<string>();
        }
        public Karton(string maticni)
        {
            JMBG = maticni; prijasnjeAlergije = new List<string>();
            prijasnjeBolesti = new List<string>();
            prijasnjeTerapije = new List<Terapija>();
            trenutne = new List<Terapija>();
            sadasnjeAlergije = new List<string>();
            sadasnjeBolesti = new List<string>();
            bolestiUPorodici = new List<string>();
            pregledi = new List<string>();
            zakljucciDoktora = new List<string>();
        }
        public void Ispisi()
        {
            Console.WriteLine("Bolesti u porodici:\n");
            foreach (string s in bolestiUPorodici)
            {
                Console.WriteLine("{0}\n", s);
            }
            Console.WriteLine("Historija bolesti:\n");
            foreach (string s in prijasnjeBolesti)
            {
                Console.WriteLine("{0}\n", s);
            }
            Console.WriteLine("Historija alergija:\n");
            foreach (string s in prijasnjeAlergije)
            {
                Console.WriteLine("{0}\n", s);
            }
            Console.WriteLine("Historija terapija:\n");
            foreach (Terapija t in prijasnjeTerapije)
            {
                Console.WriteLine("{0}\n", t.OpisTerapije);
            }
            Console.WriteLine("Sadasnje bolesti:\n");
            foreach (string s in sadasnjeBolesti)
            {
                Console.WriteLine("{0}\n", s);
            }
            Console.WriteLine("Sadasnje alergije:\n");
            foreach (string s in sadasnjeAlergije)
            {
                Console.WriteLine("{0}\n", s);
            }
            Console.WriteLine("Sadasnje terapije:\n");
            foreach (Terapija t in trenutne)
            {
                Console.WriteLine("{0}\n", t.OpisTerapije);
            }
            Console.WriteLine("Zakljucci doktora:\n");
            foreach (string s in zakljucciDoktora)
            {
                Console.WriteLine("{0}\n", s);
            }

        }

    }
}
