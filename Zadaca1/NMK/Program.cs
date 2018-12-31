using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NekaBibliotekaLol;

namespace NMK
{ 
    public enum bracnoStanje { UBraku, Razveden, Singel }
    public enum spol { Musko, Zensko }
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Pacijent pacijent_17934 = new Pacijent();
            Klinika klinika_17934 = new Klinika();
            klinika_17934.DajListuPacijenata = new List<Pacijent> { new Pacijent("Pinky", "Buturovic", spol.Zensko, "Bolnicka bb", "1402997172843", bracnoStanje.Singel, new DateTime(1997,02,14), DateTime.Today),
                new Pacijent("Jana","Mondelezic", spol.Musko, "Semira Fraste 35", "3001998675432", bracnoStanje.Razveden, new DateTime(1998, 01, 30), DateTime.Today), 
                new Pacijent("Naida","Pastelna", spol.Zensko, "0703997765432", "", bracnoStanje.UBraku, new DateTime(1997,03,07), DateTime.Today)
                    };
            klinika_17934.ListaPreminulih = new Dictionary<Pacijent, string>{
                {new Pacijent("Rose", "Smith", spol.Zensko, "Bratislava bb", "1303991122843", bracnoStanje.Singel, new DateTime(1991, 03, 13), new DateTime(2016, 11, 11)), "Bacila se pod auto"},
                {new Pacijent("Johnny", "Simpson", spol.Musko, "Zoomin Street", "1512987176843", bracnoStanje.Razveden, new DateTime(1987, 12, 11), new DateTime(2011,09,11)), "Nagutao se dima"},
                {new Pacijent("Kerim","Superic", spol.Musko, "Superovic bb","2607999987654", bracnoStanje.Singel, new DateTime(1997,07,26), new DateTime(2017,07,07)), "Pojeo otrovnu lignju"} };
            klinika_17934.DajKartone = new List<Karton>
            {
                klinika_17934.PretraziListuPacijenata("3001998675432").DajKarton,
                klinika_17934.PretraziListuPacijenata("0703997765432").DajKarton,
                klinika_17934.PretraziListuPacijenata("1402997172843").DajKarton
            };
            klinika_17934.DajKartone[0].dodajAlergiju("jagode");
            klinika_17934.DajKartone[0].dodajBolest("dijabetes tipa II");
            klinika_17934.DajKartone[0].dodajPrijasnjuBolest("leukemija");
            klinika_17934.DajKartone[0].dodajTerapiju(new Terapija("Kemoterapija"));
            klinika_17934.DajKartone[1].dodajBolestUPorodici("dijabetes");
            klinika_17934.DajKartone[1].dodajPrijasnjuBolest("mozdani udar");
            klinika_17934.DajKartone[2].dodajPrijasnjuAlergiju("polen");
            Doktor doktor_17934_1 = new Doktor("Mirza","Basic");
            Doktor doktor_17934_2 = new Doktor("Mirela", "Fening");
            Doktor doktor_17934_3 = new Doktor("Esma", "Celik");
            doktor_17934_1.GlavninaPlate = 1200;
            doktor_17934_2.GlavninaPlate = 1500;
            doktor_17934_3.GlavninaPlate = 1300;
            klinika_17934.OrdinacijeKlinike = new List<Ordinacija> { new OpstaMedicina(40, doktor_17934_2), 
                new Hirurgija(100, doktor_17934_3), new Dermatologija(50, doktor_17934_1)};

            do
            {
                Console.WriteLine("Dobro dosli! Odaberite jednu od opcija:\n" +
                "1. Registruj/Brisi pacijenta\n" +
                "2. Prikazi raspored pregleda pacijenta\n" +
                "3. Kreiranje kartona pacijenta\n" +
                "4. Pretraga kartona pacijenta\n" +
                "5. Registruj novi pregled\n" +
                "6. Analiza sadrzaja\n" +
                "7. Naplata\n" +
                "8. Izlaz\n");
                bool uspjelo = Int32.TryParse(Console.ReadLine(), out i);  
                if (!uspjelo || i <= 0 || i >= 9) Console.WriteLine("Pogresan unos! Molimo odaberite ponovo.\n");
                else break;
            }
            while (true);
            if (i == 1) {
                string op;
                do
                {
                    Console.WriteLine("\nOdaberite opciju:\n" +
                        "1. Registracija\n" +
                        "2. Brisanje\n" +
                        "3. Registracija hitnog pacijenta\n");
                    op = Console.ReadLine();
                    if ( op != "1" && op != "2" && op!="3") Console.WriteLine("Opcija koju ste odabrali ne postoji. Molimo pokusajte ponovo.\n");
                }
                while (op != "1" && op != "2" && op!="3");
                if (op == "1" || op == "3")
                {
                    Console.WriteLine("Unesite licne podatke pacijenta:\n");
                    Console.WriteLine("JMBG: ");
                    string jmbg;
                    do
                    {
                        jmbg = Console.ReadLine();
                    }
                    while (!TestoviIspravnosti.IspravnostJMBG(jmbg));
                    //provjerimo ima li ovog pacijenta u listi

                    if (klinika_17934.PretraziListuPacijenata(jmbg).DajMaticni.Length == 0)  //ovo moze bacit izuzetak
                    {
                        Console.WriteLine("Ime: ");
                        string im = Console.ReadLine();
                        Console.WriteLine("Prezime: ");
                        string p = Console.ReadLine();
                        Console.WriteLine("Adresa stanovanja: ");
                        string adr = Console.ReadLine();

                        Console.WriteLine("Spol (M ili Z):");
                        string s = Console.ReadLine();
                        spol sp = new spol();
                        while (s != "M" && s != "Z" && s != "z" && s != "m")
                        {
                            if (s == "M" || s == "m") { sp = spol.Musko; break; }
                            else if (s == "Z" || s == "z") { sp = spol.Zensko; break; }
                            else { Console.WriteLine("Neispravan unos! Molimo ponovite ga.\n"); }
                            s = Console.ReadLine();
                        }

                        Console.WriteLine("Bracno stanje (UB, R, S): ");
                        string b = Console.ReadLine();
                        bracnoStanje br = new bracnoStanje();
                        while (b != "UB" && b != "R" && b != "S" && b != "s" && b != "r" && b != "ub")
                        {
                            if (b == "UB") { br = bracnoStanje.UBraku; }
                            else if (b == "S") { br = bracnoStanje.Singel; }
                            else if (b == "R") { br = bracnoStanje.Razveden; }
                            else { Console.WriteLine("Neispravan unos! Molimo ponovite ga.\n"); }
                            b = Console.ReadLine();
                        }
                        bool neispravan = false;
                        DateTime dat = new DateTime();
                        do
                        {
                            Console.WriteLine("Datum rodjenja (YYYY/MM/DD): ");
                            neispravan = false;
                            try
                            {
                                dat = Convert.ToDateTime(Console.ReadLine());

                            }
                            catch
                            {
                                neispravan = true;
                                Console.WriteLine("Unijeli ste neispravan datum! Molimo pokusajte ponovo.\n");
                            }
                        }
                        while (neispravan);
                        Console.WriteLine("Da li je u pitanju hitni slucaj (DA/NE)?\n");
                        string dane;
                        do
                        {
                            dane = Console.ReadLine();
                            if (dane != "DA" && dane != "NE" && dane != "da" && dane != "ne" && dane != "Da" && dane != "Ne")
                                Console.WriteLine("Niste unijeli prihvatljiv odgovor. Molimo ponovite unos.\n");
                        }
                        while (dane != "DA" && dane != "NE" && dane != "da" && dane != "ne" && dane != "Da" && dane != "Ne");
                        if (dane == "NE" || dane == "ne" || dane == "Ne")
                        {
                            pacijent_17934 = new Pacijent(im, p, sp, adr, jmbg, br, dat, DateTime.Today);
                            
                        }
                        else
                        {
                            Console.WriteLine("Opisite hitnu pomoc koja je pruzena pacijentu:\n");
                            string pomoc = Console.ReadLine();
                            pacijent_17934 = new HitniPacijent(im, p, sp, adr, jmbg, br, dat, DateTime.Today, pomoc);
                        }
                        klinika_17934.DajListuPacijenata.Add(pacijent_17934); //dodamo ovog novog u listu vec postojecih
                        pacijent_17934.PovecajBrojDolazaka();


                    }
                    Console.WriteLine("Unesite preglede koje pacijent zeli ili treba da obavi (pritisnite 0 za kraj):\n");
                    while (true)
                    {
                        string pregled = Console.ReadLine();
                        if (pregled == "0") break;
                        foreach (Ordinacija o in klinika_17934.OrdinacijeKlinike)
                        {
                            if (o.Naziv == pregled)
                            {
                                pacijent_17934.Raspored.Add(o, o.BrojPacijenata + 1);
                                o.RedniBroj.Enqueue(o.BrojPacijenata + 1);
                            }  
                        }
                    }
                    pacijent_17934.SortirajRaspored();
                    pacijent_17934.IspisiRaspored();
                }
                else  //brisanje
                {
                    string jmbg;

                    do
                    {
                        Console.WriteLine("Unesite JMBG pacijenta kojeg brisete iz sistema: ");
                        jmbg = Console.ReadLine();
                        if (TestoviIspravnosti.IspravnostJMBG(jmbg)) break;
                        Console.WriteLine("Unijeli ste neispravan JMBG pacijenta. Molimo, pokusajte ponovo.\n");
                    }
                    while (true);

                    Console.WriteLine("Da li je pacijent u pitanju preminuo?\n");
                    string odgovor;
                    do {
                        odgovor = Console.ReadLine();
                        if (odgovor != "Da" && odgovor != "Ne" && odgovor != "DA" && odgovor != "NE" && odgovor != "Da" && odgovor != "Ne")
                            Console.WriteLine("Molimo unesite validan odgovor.\n");
                        else break;
                    }
                    while (true);
                    if (odgovor == "DA" || odgovor == "Da" || odgovor == "da")
                    {
                        Console.WriteLine("Molimo unesite datum smrti, te opisite uzrok smrti pacijenta:\n");
                        Console.WriteLine("Datum smrti (DD/MM/YYYY): ");
                        string Datum = Console.ReadLine();
                        do {
                            if (!TestoviIspravnosti.IspravnostDatuma(Convert.ToDateTime(Datum)))
                            {
                                Console.WriteLine("Molimo unesite validan datum.\n");
                                Datum = Console.ReadLine();
                            }
                            else break;
                        }
                        while (true);
                        klinika_17934.PretraziListuPacijenata(jmbg).DatumSmrti = Convert.ToDateTime(Datum);
                        Console.WriteLine("Uzrok smrti: ");
                        string uzrok = Console.ReadLine();
                        klinika_17934.ListaPreminulih.Add(klinika_17934.PretraziListuPacijenata(jmbg), uzrok);
                    }
                    klinika_17934.DajListuPacijenata.Remove(klinika_17934.PretraziListuPacijenata(jmbg));
                    klinika_17934.DajKartone.Remove(klinika_17934.PretraziListuKartona(jmbg));  //obrisemo pacijenta i njegov karton
                }
            }
            else if (i == 2)
            {
                Console.WriteLine("Unesite JMBG pacijenta ciji raspored zelite:\n");
                string maticni = Console.ReadLine();
                while (!TestoviIspravnosti.IspravnostJMBG(maticni))
                {
                    Console.WriteLine("Pogresan maticni broj! Molimo pokusajte ponovo.\n");
                    maticni = Console.ReadLine();
                }
               klinika_17934.PretraziListuPacijenata(maticni).IspisiRaspored();  //valjda treba samo ispisati raspored
            }
            else if (i == 3)
            {
                Console.WriteLine("Isputnite sljedeca polja (pritisnite  ENTER tipku ukoliko pacijent nema nesto od navedenog):\n");
                Console.WriteLine("Prijasnje alergije: ");
                string s;
                while (true)
                {
                    s = Console.ReadLine();
                    if (s == "") break;
                    pacijent_17934.DajKarton.dodajPrijasnjuAlergiju(s);
                }
                Console.WriteLine("Prijasnje bolesti: ");
                while (true)
                {
                    s = Console.ReadLine();
                    if (s == "") break;
                    pacijent_17934.DajKarton.dodajPrijasnjuBolest(s);
                }
                Console.WriteLine("Prijasnje terapije: ");
                while (true)
                {
                    s = Console.ReadLine();
                    if (s == "") break;
                    Terapija t = new Terapija(s);
                    pacijent_17934.DajKarton.dodajPrijasnjuTerapiju(t);
                }
                Console.WriteLine("Bolesti u porodici: ");
                while (true)
                {
                    s = Console.ReadLine();
                    if (s == "") break;
                    pacijent_17934.DajKarton.dodajBolestUPorodici(s);
                }
                Console.WriteLine("Trenutne bolesti i tegobe: ");
                while (true)
                {
                    s = Console.ReadLine();
                    if (s == "") break;
                    pacijent_17934.DajKarton.dodajBolest(s);
                }
                Console.WriteLine("Trenutne alergije: ");
                while (true)
                {
                    s = Console.ReadLine();
                    if (s == "") break;
                    pacijent_17934.DajKarton.dodajAlergiju(s);
                }
                Console.WriteLine("Trenutne terapije: ");
                while (true)
                {
                    s = Console.ReadLine();
                    if (s == "") break;
                    Terapija ter = new Terapija(s);
                    pacijent_17934.DajKarton.dodajTerapiju(ter);
                }
            }
            else if (i == 4)
            {
                string jmbg="";
                while (!TestoviIspravnosti.IspravnostJMBG(jmbg))
                {
                    Console.WriteLine("Unesite JMBG pacijenta ciji karton zelite: ");
                    jmbg = Console.ReadLine();
                    Console.WriteLine("Unijeli ste neispravan maticni broj. Molimo, pokusajte ponovo.\n");
                }
                Karton k = klinika_17934.PretraziListuKartona(jmbg);
                if (k.DajMaticni == "") Console.WriteLine("Trazeni karton ne postoji.\n");
            }
            else if (i == 5)
            {
                Console.WriteLine("Unesite nove preglede (0 za prekid unosa):\n");
                string s;
                while (true)
                {
                    s = Console.ReadLine();
                    if (s == "0") break;
                    try
                    {
                        Ordinacija o = klinika_17934.PretraziOrdinacije(s);
                        o.DodajPacijenta();
                        pacijent_17934.DajKarton.Pregledi.Add(s);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }

            }
            else if (i == 6)
            {
                Console.WriteLine("Odaberite koji sadrzaj zelite analizirati:\n" +
                    "1. Najposjecenija ordinacija 2017. godine\n" +
                    "2. Broj pacijenata registrovanih 2017. godine\n" +
                    "3. Broj preminulih pacijenata 2017. godine\n");
                string odabir;
                do
                {
                    odabir = Console.ReadLine();
                    if (odabir != "1" && odabir != "2" && odabir != "3")
                    {
                        Console.WriteLine("Niste ispravno odabrali opciju. Molimo, ponovite unos.\n");
                    }
                }
                while(odabir != "1" && odabir !="2" && odabir !="3");
                if (odabir =="1")
                {
                    List<int> brojeviPosjeta = new List<int>();
                    foreach (Ordinacija o in klinika_17934.OrdinacijeKlinike)
                    {
                        brojeviPosjeta.Add(o.DajBrojPosjeta);
                    }
                    int najveci = brojeviPosjeta.Max();
                    Console.WriteLine("Najposjecenija ordinacija 2017. godine je ");
                    foreach (Ordinacija o in klinika_17934.OrdinacijeKlinike)
                    {
                        if (o.DajBrojPosjeta == najveci)
                        {
                            Console.WriteLine(o.Naziv);
                            break;
                        }
                        Console.WriteLine(".\n");
                    }
                }
                else if(odabir =="2")
                {
                    Console.WriteLine("Broj registrovanih pacijenata 2017. godine iznosi {0}.\n", klinika_17934.DajListuPacijenata.Count);
                }
                else
                {
                    Console.WriteLine("Broj preminulih pacijenata 2017. godine iznosi {0}.\n", klinika_17934.ListaPreminulih.Count);
                }
            }
            else if (i == 7)
            {
                Console.WriteLine("Unesite JMBG pacijenta kojem vrsite naplatu: ");
                string jadnik = Console.ReadLine();
                Pacijent neki = klinika_17934.PretraziListuPacijenata(jadnik);
                
                Console.WriteLine("Unesite nacin placanja (G za gotovinsko, a R za placanje na rate): ");
                neki.DajRacun.NacinPlacanja = Console.ReadLine();
                neki.IspisiRacun();
            }
            else {
                Environment.Exit(1);
            }
            Console.ReadKey();
        }
      
    }
}
