using System;

namespace Pacijenti
{
    public class TestoviIspravnosti
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
            int god;
            int ostgod = Convert.ToInt32(jmbg.Substring(4, 6));
            if (ostgod <= 999) god = 1000 + ostgod;
            else god = 2000 + ostgod;
            string datum = jmbg.Substring(0, 1) + "/" + jmbg.Substring(2, 3) + "/" + god.ToString();
            return IspravnostDatuma(Convert.ToDateTime(datum));
        }
        public static bool IspravnostJMBG(string jmbg, DateTime dat)
        {
            if (jmbg.Length != 13) return false;
            string god;
            if (Convert.ToInt32(jmbg.Substring(4, 6)) <= 999) god = "1000";
            else god = "2000";

            if (!IspravnostDatuma(dat)) return false;
            if (dat.Day.ToString() != jmbg.Substring(0, 1) || dat.Month.ToString() != jmbg.Substring(2, 3)
                || Convert.ToInt32(god) + Convert.ToInt32(jmbg.Substring(4, 6)) != dat.Year)
                return false;
            return true;
        }
    }
}
