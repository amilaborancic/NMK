using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NekaBibliotekaLol;
namespace NMK
{
    public class Terapija
    {
        private string OpisTerapije;
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
            OpisTerapije = opis; trajanjeTerapije = tr; garancijaDoktora = gar;

        }

        public Terapija(string opis)
        {
            OpisTerapije = opis;
        }
        public string Opis
        {
            get { return OpisTerapije; }
            set { OpisTerapije = value; }
        }
    }
}
