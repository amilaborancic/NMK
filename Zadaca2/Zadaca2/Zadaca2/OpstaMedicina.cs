using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Zadaca2
{
    public class OpstaMedicina : Ordinacija
    {
        public OpstaMedicina(double cijena, Doktor dez) : base("Opsta medicina",cijena, dez)
        {
           
        }

    }
}
