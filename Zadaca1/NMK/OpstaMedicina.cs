using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NekaBibliotekaLol;
namespace NMK
{
    public class OpstaMedicina:Ordinacija
    {
        private string nazivOrdinacije="Opsta medicina";
        private double cijenaPregleda = 40;
        private Doktor dezurni;

        public OpstaMedicina(double cijena, Doktor dez) : base(cijena, dez)
        {
            BrojPacijenata = 0;
        }
        
    }
}
