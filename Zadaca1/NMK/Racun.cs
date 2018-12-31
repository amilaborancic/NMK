using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NekaBibliotekaLol;

namespace NMK
{
    public class Racun
    {
        private string placanje;

        public string NacinPlacanja
        {
            get { return placanje; }
            set
            {
                var vrijednost = value;
                while (!TestoviIspravnosti.TestValidnostiPlacanja(vrijednost))
                {
                    Console.WriteLine("Pogresan unos! Pokusajte ponovo.\n");
                    vrijednost = value;
                }
                placanje = vrijednost;
            }
        }
    }
}
