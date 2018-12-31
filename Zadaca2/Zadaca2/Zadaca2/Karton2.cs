using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca2
{
    public sealed partial class Karton
    {
        public void dodajPrijasnjuTerapiju(Terapija nova)
        {
            prijasnjeTerapije.Add(nova);
        }
        public void dodajAlergiju(string nova)
        {
            sadasnjeAlergije.Add(nova);  //doda na kraj
        }
        public void dodajBolest(string nova)
        {
            sadasnjeBolesti.Add(nova);   //doda na kraj
        }
        public void obrisiAlergiju(string al)
        {
            prijasnjeAlergije.Add(al); //prebacujemo u prijasnje
            sadasnjeAlergije.Remove(al); //TREBA DODATI PROVJERU IMA LI OVOG CUDA U LISTI
        }
        public void obrisiBolest(string bol)
        {
            prijasnjeBolesti.Add(bol);
            sadasnjeBolesti.Remove(bol); //TREBA DODATI PROVJERU
        }
        public void dodajTerapiju(Terapija nova)
        {
            trenutne.Add(nova);
        }
    }
}
