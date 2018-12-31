using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Zadaca2
{
    public class Hirurgija : Ordinacija
    {
        public Hirurgija(double c, Doktor d) : base("Hirurgija",c, d)
        {
        }
        
    }
}
