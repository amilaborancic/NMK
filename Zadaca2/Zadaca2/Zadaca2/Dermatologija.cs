using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Zadaca2
{
    public class Dermatologija : Ordinacija
    {
        public Dermatologija(double cijena, Doktor dez) : base("Dermatologija", cijena, dez) { }
    }
}
