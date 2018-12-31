using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NekaBibliotekaLol;

namespace NMK
{
    public abstract class Ordinacija
    {
        private string nazivOrdinacije;
        private double cijenaPregleda;
        private int brojPacijenata;
        private Queue<int> redniBrojevi;  
        private int brojPosjeta;
        private Doktor dezurni;
        public Queue<int> RedniBroj { get { return redniBrojevi; } set { redniBrojevi = value; } }
        public Pacijent Pregledaj(Pacijent p)
        {
            brojPosjeta++;
            redniBrojevi.Dequeue();
            p.Raspored.Remove(this);
            return p;
        }
        public int DajBrojPosjeta { get { return brojPosjeta; } }
        public double CijenaPregleda
        {
            get { return cijenaPregleda; }
        }

        public string Naziv
        {
            get { return nazivOrdinacije; }
        }
        public int BrojPacijenata { get => brojPacijenata; set => brojPacijenata = value; }
        public void DodajPacijenta()
        {
            brojPacijenata++;
            redniBrojevi.Enqueue(brojPacijenata);  //na raspored cekanja dodamo novog pacijenta
        }
        
        public Ordinacija(double cijena, Doktor dez)
        {
            cijenaPregleda = cijena; 
            dezurni = dez; brojPacijenata = 0; brojPosjeta = 0;
        }
    }
}
