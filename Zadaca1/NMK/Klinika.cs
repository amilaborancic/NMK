using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMK
{
    public class Klinika
    {
        private List<Pacijent> RegistrovaniPacijenti = new List<Pacijent>();
        private List<Karton> Kartoni = new List<Karton>();
        private List<Ordinacija> Ordinacije = new List<Ordinacija>();
        private Dictionary<Pacijent, string> PreminuliPacijenti = new Dictionary<Pacijent, string>();
        
        public Dictionary<Pacijent, string> ListaPreminulih
        {
            get { return PreminuliPacijenti; }
            set { PreminuliPacijenti = value; }
        }
        public Karton PretraziListuKartona(string jmbg)
        {
            return Kartoni.Find(x => x.DajMaticni == jmbg);  //MOZE BACIT IZUZETAK
            
        }
        public Pacijent PretraziListuPacijenata(string jmbg)
        {
            foreach (Pacijent p in RegistrovaniPacijenti)
            {
                if (p.DajMaticni == jmbg) return p;
            }
            return new Pacijent();
        }
        public void ObrisiPacijenta(string maticni_broj)
        {
            Pacijent p = PretraziListuPacijenata(maticni_broj);
            if (p.DajMaticni == "") throw new Exception("Pacijent s maticnim brojem " + maticni_broj + " nije registrovan!\n");
            RegistrovaniPacijenti.Remove(p);
            
        }
        public List<Pacijent> DajListuPacijenata
        {
            get{ return RegistrovaniPacijenti; }
            set{ RegistrovaniPacijenti = value; }
        }
        public List<Karton> DajKartone
        {
            get { return Kartoni; }
            set { Kartoni = value; }
        }

        public Klinika() { }
        
        public List<Ordinacija> OrdinacijeKlinike
        {
            get { return Ordinacije; }
            set { Ordinacije = value; }
        }
        public Ordinacija PretraziOrdinacije(string s)
        {
            foreach (Ordinacija o in Ordinacije)
            {
                if (s == o.Naziv) return o;
            }
            throw new Exception();
        }
    }

}
