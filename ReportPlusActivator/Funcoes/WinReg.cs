using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportPlusActivator.Funcoes
{
    internal class WinReg
    {
        
        static string regPathCredentials = @"SOFTWARE\Microsoft\Data\";
        static RegistryKey reg = Registry.LocalMachine.OpenSubKey(regPathCredentials);

        internal static string gravar_ler_bd_serveradress()
        {
            reg = Registry.LocalMachine.CreateSubKey(regPathCredentials + @"DBActivation\");
            reg = Registry.LocalMachine.OpenSubKey(regPathCredentials + @"DBActivation\", true);

            string user = string.Empty;
            if (reg.GetValue(@"serveradress") != null)
            {

                user = Convert.ToString(reg.GetValue(@"serveradress"));
                reg.Close();
            }
            else
            {
                reg = Registry.LocalMachine.CreateSubKey(regPathCredentials);
                reg.SetValue(@"serveradress", "127.0.0.1");


                reg = Registry.LocalMachine.OpenSubKey(regPathCredentials);
                user = Convert.ToString(reg.GetValue(@"serveradress"));
                reg.Close();
            }
            return user;
        }

        internal static string gravar_ler_bd_serverport()
        {
            reg = Registry.LocalMachine.CreateSubKey(regPathCredentials + @"DBActivation");
            reg = Registry.LocalMachine.OpenSubKey(regPathCredentials + @"DBActivation", true);

            string user = string.Empty;
            if (reg.GetValue(@"serverport") != null)
            {

                user = Convert.ToString(reg.GetValue(@"serverport"));
                reg.Close();
            }
            else
            {
                reg = Registry.LocalMachine.CreateSubKey(regPathCredentials);
                reg.SetValue(@"serverport", "8085");


                reg = Registry.LocalMachine.OpenSubKey(regPathCredentials);
                user = Convert.ToString(reg.GetValue(@"serverport"));
                reg.Close();
            }
            return user;
        }

        internal static string gravar_ler_bd_user()
        {
            reg = Registry.LocalMachine.CreateSubKey(regPathCredentials + @"DBActivation");
            reg = Registry.LocalMachine.OpenSubKey(regPathCredentials + @"DBActivation", true);

            string user = string.Empty;
            if (reg.GetValue(@"user") != null)
            {

                user = Convert.ToString(reg.GetValue(@"user"));
                reg.Close();
            }
            else
            {
                reg = Registry.LocalMachine.CreateSubKey(regPathCredentials);
                reg.SetValue(@"user", "adm");


                reg = Registry.LocalMachine.OpenSubKey(regPathCredentials);
                user = Convert.ToString(reg.GetValue(@"user"));
                reg.Close();
            }
            return user;
        }

        internal static string gravar_ler_bd_password()
        {
            reg = Registry.LocalMachine.CreateSubKey(regPathCredentials + @"DBActivation");
            reg = Registry.LocalMachine.OpenSubKey(regPathCredentials + @"DBActivation", true);

            string user = string.Empty;
            if (reg.GetValue(@"password") != null)
            {

                user = Convert.ToString(reg.GetValue(@"password"));
                reg.Close();
            }
            else
            {
                reg = Registry.LocalMachine.CreateSubKey(regPathCredentials);
                reg.SetValue(@"password", "seuaciuc@123");


                reg = Registry.LocalMachine.OpenSubKey(regPathCredentials);
                user = Convert.ToString(reg.GetValue(@"password"));
                reg.Close();
            }
            return user;
        }
    }
}
