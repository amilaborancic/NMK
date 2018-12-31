using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NekaBibliotekaLol;

namespace NMK
{
    public class HitniPacijent : Pacijent
    {
        private string pruzenaHitnaPomoc;
        private DateTime datumSmrti;
        public HitniPacijent() { }
        public HitniPacijent(string i, string p, spol sp, string adr, string jmbg, bracnoStanje st, DateTime dat_ro, DateTime dat, string pomoc)
            : base(i, p, sp, adr, jmbg, st, dat_ro, dat)
        {
            pruzenaHitnaPomoc = pomoc;
        }
        public DateTime DatumSmrti
        {
            get{return datumSmrti; }
            set
            {
                do {  datumSmrti = value; }
                while (!TestoviIspravnosti.IspravnostDatuma(datumSmrti));
            } 
        }
    }
}
