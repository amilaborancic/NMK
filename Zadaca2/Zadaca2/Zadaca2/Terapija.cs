using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Zadaca2
{
    public class Terapija
    {
        private string opisTerapije;
        public DateTime pocetakTerapije
        {
            get { return pocetakTerapije; }
            set
            {
                do
                {
                    pocetakTerapije = value;
                }
                while (!TestoviIspravnosti.IspravnostDatuma(pocetakTerapije));
            }
        }
        private int trajanjeTerapije;
        private string garancijaDoktora;
        public Terapija() { OpisTerapije = ""; }
        public Terapija(string opis, DateTime poc, int tr, string gar)
        {
            opisTerapije = opis; trajanjeTerapije = tr; garancijaDoktora = gar;

        }

        public Terapija(string opis)
        {
            opisTerapije = opis;
        }
        public string OpisTerapije
        {
            get { return opisTerapije; }
            set { opisTerapije = value; }
        }
    }
}
