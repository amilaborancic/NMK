using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Zadaca2
{
    public static class Klinika
    {
        private static List<Pacijent> RegistrovaniPacijenti = new List<Pacijent>();
        private static List<Karton> Kartoni = new List<Karton>();
        private static List<Doktor> doktori = new List<Doktor>();
        private static List<Tehnicar> tehnicari = new List<Tehnicar>();
        private static List<Uprava> uprava = new List<Uprava>();
        private static List<Ordinacija> Ordinacije = new List<Ordinacija>();
        private static Dictionary<Pacijent, string> PreminuliPacijenti = new Dictionary<Pacijent, string>();

        public static Dictionary<Pacijent, string> ListaPreminulih
        {
            get { return PreminuliPacijenti; }
            set { PreminuliPacijenti = value; }
        }
        public static Karton PretraziListuKartona(string jmbg)
        {
            return Kartoni.Find(x => x.DajMaticni == jmbg);  //MOZE BACIT IZUZETAK

        }
        public static Pacijent PretraziListuPacijenata(string jmbg)
        {
            foreach (Pacijent p in RegistrovaniPacijenti)
            {
                if (p.DajMaticni == jmbg) return p;
            }
            return new Pacijent();
        }
        public static void ObrisiPacijenta(string maticni_broj)
        {
            Pacijent p = PretraziListuPacijenata(maticni_broj);
            if (p.DajMaticni == "") throw new Exception("Pacijent s maticnim brojem " + maticni_broj + " nije registrovan!\n");
            RegistrovaniPacijenti.Remove(p);

        }
        public static List<Pacijent> DajListuPacijenata
        {
            get { return RegistrovaniPacijenti; }
            set { RegistrovaniPacijenti = value; }
        }
        public static List<Karton> DajKartone
        {
            get { return Kartoni; }
            set { Kartoni = value; }
        }
        

        public static List<Ordinacija> OrdinacijeKlinike
        {
            get { return Ordinacije; }
            set { Ordinacije = value; }
        }

        public static List<Doktor> Doktori { get => doktori; set => doktori = value; }
        public static List<Tehnicar> Tehnicari { get => tehnicari; set => tehnicari = value; }
        public static List<Uprava> Uprava { get => uprava; set => uprava = value; }

        public static Ordinacija PretraziOrdinacije(string s)
        {
            foreach (Ordinacija o in Ordinacije)
            {
                if (s == o.Naziv) return o;
            }
            throw new Exception();
        }
    }

}
