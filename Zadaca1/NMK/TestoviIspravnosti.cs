using System;
using NekaBibliotekaLol;
namespace NMK
{
    public abstract class TestoviIspravnosti
    {
        public static bool TestValidnostiPlacanja(string pl)
        {
            if (pl == "R" || pl == "G" || pl == "r" || pl == "g") return true;
            return false;
        }
        public static bool IspravnostDatuma(DateTime dat)
        {

            int[] brojdana = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (dat.Year % 4 == 0 && dat.Year % 100 != 0 || dat.Year % 400 == 0) brojdana[1] = 29;
            int br = dat.Month;
            if (dat.Year < 1 || dat.Month < 1 || dat.Month > 12 || dat.Day < 1 || dat.Day > brojdana[br - 1])
                return false;

            return true;
        }
        public static bool IspravnostJMBG(string jmbg)
        {
            if (jmbg.Length != 13) return false;
            int dan = Convert.ToInt32(jmbg.Substring(0, 2));
            int mjesec = Convert.ToInt32(jmbg.Substring(2, 2));
            int godina;
            if (Convert.ToInt32(jmbg.Substring(4, 3)) <= 999 &&
                Convert.ToInt32(jmbg.Substring(4, 3)) >= 17) godina = 1000 + Convert.ToInt32(jmbg.Substring(4, 3));
            else godina = Convert.ToInt32(jmbg.Substring(4, 3)) + 2000;
            return IspravnostDatuma(new DateTime(godina, mjesec, dan));
        }
        public static bool IspravnostJMBG(string jmbg, DateTime dat)
        {
            if (IspravnostJMBG(jmbg))
            {
                if (IspravnostDatuma(dat))
                {
                    string dan = dat.Day.ToString();
                    string mjesec = dat.Month.ToString();
                    int godina = dat.Year;
                    if (Convert.ToInt32(godina) <= 1999) godina -= 1000;
                    else godina -= 2000;
                    if (dan == jmbg.Substring(0, 2) && mjesec == jmbg.Substring(2, 2) && godina.ToString() == jmbg.Substring(4, 3)) return true;
                    return false;
                }
                return false;
            }
            return false;
        }
    }
}