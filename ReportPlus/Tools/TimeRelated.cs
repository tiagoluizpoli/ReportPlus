using MetroFramework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportPlus.Tools
{
    public class TimeRelated
    {
        public static DateTime GetDateTime()
        {
            try
            {
                using (WebResponse response = WebRequest.Create("http://www.microsoft.com").GetResponse()) return DateTime.ParseExact(response.Headers["date"], "ddd, dd MMM yyyy HH:mm:ss 'GMT'", CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.AssumeUniversal);
                // return dateTime;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao validar o dia. Por favor verifique a conexão com a internet.", ex);
            }
            
        }

        public static bool VerificarDataHora()
        {
            try
            {
                DateTime dlocal = DateTime.Now;
                DateTime dinternet = TimeRelated.GetDateTime();
                if ((dlocal > dinternet.AddHours(-2)) && (dlocal < dinternet.AddHours(2)))
                {
                    if (Win_Registry.gravar_ler_Trial() == 1)
                    {
                        string DataReg = string.Empty;
                        if (Win_Registry.gravar_ler_Date_Reg() != string.Empty)
                        {
                            DataReg = Win_Registry.gravar_ler_Date_Reg();
                        }
                        else
                        {
                            string dtnow = DateTime.Now.ToShortDateString();
                            Win_Registry.gravar_date_Reg(PasswordEncryption.Encrypt(ref dtnow));
                            DataReg = Win_Registry.gravar_ler_Date_Reg();

                        }
                        int dia = 0, mes = 0, ano = 0;
                        dia = Convert.ToInt32(PasswordEncryption.Decrypt(ref DataReg).Substring(0, 2));
                        mes = Convert.ToInt32(PasswordEncryption.Decrypt(ref DataReg).Substring(3, 2));
                        ano = Convert.ToInt32(PasswordEncryption.Decrypt(ref DataReg).Substring(6, 4));
                        DateTime DateReg = new DateTime(ano, mes, dia);


                        if (dinternet.Date > DateReg.AddDays(3))
                        {
                            MessageBox.Show("Período de Avaliação Expirado.");
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        return true;
                    }
                    

                }
                else
                {
                    MessageBox.Show("O Horário desse computador está incorreto. Por favor, acerte o relógio para prosseguir com a aplicação.", "Error");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + Environment.NewLine + ex.InnerException.Message);
                return false;
            }
        }
    }
}
