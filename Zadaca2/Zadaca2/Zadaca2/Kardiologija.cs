using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Zadaca2
{
    public class Kardiologija:Ordinacija
    {
        public Kardiologija(double c, Doktor d) : base("Kardiologija",c, d)
        {
        }
    }
}
