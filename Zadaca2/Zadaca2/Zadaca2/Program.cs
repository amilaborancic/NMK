using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace Zadaca2
{
    
    static class Program
    {
        public static String GetMD5Hash(String TextToHash)
        {
            if ((TextToHash == null) || (TextToHash.Length == 0)) return String.Empty;

            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] textToHash = System.Text.Encoding.Default.GetBytes(TextToHash);
            byte[] result = md5.ComputeHash(textToHash);
            return System.BitConverter.ToString(result);
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Klinika.DajListuPacijenata=new List<Pacijent> { new Pacijent("Pinky", "Buturovic", true, "Bolnicka bb", "1402997172843", false, new DateTime(1997,02,14), DateTime.Today),
                new Pacijent("Jana","Mondelezic", true, "Semira Fraste 35", "3001998675432", false, new DateTime(1998, 01, 30), DateTime.Today),
                new Pacijent("Naida","Pastelna", true, "Ulica lol", "0703997765432", true, new DateTime(1997,03,07), DateTime.Today)
                    };
            Klinika.ListaPreminulih = new Dictionary<Pacijent, string>{
                {new Pacijent("Rose", "Smith", true, "Bratislava bb", "1303991122843", false, new DateTime(1991, 03, 13), new DateTime(2016, 11, 11)), "Bacila se pod auto"},
                {new Pacijent("Johnny", "Simpson", false, "Zoomin Street", "1512987176843", false, new DateTime(1987, 12, 11), new DateTime(2011,09,11)), "Nagutao se dima"},
                {new Pacijent("Kerim","Superic", false, "Superovic bb","2607999987654", false, new DateTime(1997,07,26), new DateTime(2017,07,07)), "Pojeo otrovnu lignju"} };
            Klinika.DajKartone = new List<Karton>
            {
                Klinika.PretraziListuPacijenata("3001998675432").DajKarton,
                Klinika.PretraziListuPacijenata("0703997765432").DajKarton,
                Klinika.PretraziListuPacijenata("1402997172843").DajKarton
            };
            
            Klinika.DajKartone[0].Pregledi = new List<string> {"Hirurgija","Opsta medicina"};
            Klinika.DajKartone[0].dodajAlergiju("jagode");
            Klinika.DajKartone[0].dodajBolest("dijabetes tipa II");
            Klinika.DajKartone[0].dodajPrijasnjuBolest("leukemija");
            Klinika.DajKartone[0].dodajTerapiju(new Terapija("Kemoterapija"));
            Klinika.DajKartone[1].dodajBolestUPorodici("dijabetes");
            Klinika.DajKartone[1].dodajPrijasnjuBolest("mozdani udar");
            Klinika.DajKartone[2].dodajPrijasnjuAlergiju("polen");
            Doktor doktor_17934_1 = new Doktor("Mirza", "Basic");
            Doktor doktor_17934_2 = new Doktor("Mirela", "Fening");
            Doktor doktor_17934_3 = new Doktor("Esma", "Celik");
            Doktor doktor_17934_4 = new Doktor("Petra", "Usunovic");
            Doktor doktor_17934_5 = new Doktor("Dusko", "Dugousko");
            doktor_17934_1.GlavninaPlate = 1200;
            doktor_17934_2.GlavninaPlate = 1500;
            doktor_17934_3.GlavninaPlate = 1300;
            doktor_17934_4.GlavninaPlate = 1500;
            doktor_17934_5.GlavninaPlate = 2000;
            Klinika.OrdinacijeKlinike = new List<Ordinacija> { new OpstaMedicina(40, doktor_17934_2),
                new Hirurgija(100, doktor_17934_3), new Dermatologija(50, doktor_17934_1),
                new Hitna(90, doktor_17934_4), new Kardiologija(150,doktor_17934_5)};

            Klinika.DajListuPacijenata[1].Raspored = new Dictionary<Ordinacija, int> {
                { Klinika.OrdinacijeKlinike[0], Klinika.OrdinacijeKlinike[0].BrojPacijenata },
                { Klinika.OrdinacijeKlinike[1], Klinika.OrdinacijeKlinike[1].BrojPacijenata }
            };
            Klinika.Doktori = new List<Doktor>{doktor_17934_1, doktor_17934_2, doktor_17934_3, doktor_17934_4, doktor_17934_5 };
            Klinika.Tehnicari = new List<Tehnicar> {new Tehnicar("Tiffany","Lopez"), new Tehnicar("Richard","Cooper"), new Tehnicar("Scott","Cook")};
            Klinika.Uprava = new List<Uprava> { new Uprava("Sara", "James"), new Uprava("Peter", "Clark"), new Uprava("Gregory", "Ross")};
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
