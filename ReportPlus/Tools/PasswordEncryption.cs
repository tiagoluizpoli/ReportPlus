using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportPlus.Tools
{
    public class PasswordEncryption
    {
        public static string Encrypt(ref string pass)
        {
            Byte[] a = Encoding.ASCII.GetBytes(pass);
            string d = Convert.ToBase64String(a);
            return d;
        }

        public static string Decrypt(ref string pass)
        {
            byte[] b = Convert.FromBase64String(pass);
            string a = Encoding.ASCII.GetString(b);
            return a;
        }
    }
}
