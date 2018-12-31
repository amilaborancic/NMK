using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Zadaca2
{
    public interface IZaposlenikKlinike
    {
        double ObracunajPlatu { get; set; }
        double GlavninaPlate { set; }
    }
    public static class Program1
    {
        public static String GetMD5Hash(String TextToHash)
        {
            if ((TextToHash == null) || (TextToHash.Length == 0)) return String.Empty;

            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] textToHash = Encoding.Default.GetBytes(TextToHash);
            byte[] result = md5.ComputeHash(textToHash);
            return System.BitConverter.ToString(result);
        }

    }
}
