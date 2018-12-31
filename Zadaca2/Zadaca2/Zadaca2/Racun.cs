using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Zadaca2
{
    public class Racun
    {
        private bool placanje;
        public Racun(bool p) { placanje = p; }
        public Racun() { }
        public bool Placanje { get => placanje; set => placanje = value; }
       
    }
}
