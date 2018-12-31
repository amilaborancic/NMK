using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    public abstract class Ordinacija
    {
        private string nazivOrdinacije;
        private double cijenaPregleda;
        private int brojPacijenata;  
        private int brojPosjeta;
        private Doktor dezurni;
        public Pacijent Pregledaj(Pacijent p)
        {
            brojPosjeta++;
            brojPacijenata--;
            return p;
        }
        public double CijenaPregleda
        {
            get { return cijenaPregleda; }
            set { cijenaPregleda = value; }
        }

        public string Naziv
        {
            get { return nazivOrdinacije; }
            set { nazivOrdinacije = value; }
        }
        public int BrojPacijenata { get => brojPacijenata; set => brojPacijenata = value; }
        public int BrojPosjeta { get => brojPosjeta; set => brojPosjeta = value; }
        
        public Ordinacija(string naziv, double cijena, Doktor dez)
        {
            cijenaPregleda = cijena;
            dezurni = dez;
            brojPacijenata = 0;
            brojPosjeta = 0;
            nazivOrdinacije = naziv;
        }
    }
}
