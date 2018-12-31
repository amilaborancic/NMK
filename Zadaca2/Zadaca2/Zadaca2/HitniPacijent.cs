using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    public class HitniPacijent : Pacijent
    {
        private string pruzenaHitnaPomoc;
        private DateTime datumSmrti;
        public HitniPacijent() { }
        public HitniPacijent(string i, string p, bool sp, string adr, string jmbg, bool st, DateTime dat_ro, DateTime dat, string pomoc)
            : base(i, p, sp, adr, jmbg, st, dat_ro, dat)
        {
            pruzenaHitnaPomoc = pomoc;
        }
    }
}
