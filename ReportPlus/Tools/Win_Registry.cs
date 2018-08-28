﻿
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System;

namespace ReportPlus.Tools
{
    public class Win_Registry
    {
        static string regPath = @"SOFTWARE\Report Plus\", regPathComplemento = string.Empty;
        static string regPathCredentials = @"SOFTWARE\Microsoft\Data\";
        static RegistryKey reg = Registry.LocalMachine.OpenSubKey(regPath);


        //static string pathdb = @"SOFTWARE\Report Plus\Data\";
        //static string pathCredentials = @"SOFTWARE\\Microsoft\Data\";
        static string picpath = string.Empty;
        

        //server Adress
        public static void gravar_server_adress(string adress)
        {
            regPathComplemento = @"Data\";
            RegistryKey reg = Registry.LocalMachine.CreateSubKey(regPath + regPathComplemento);
            reg.SetValue(@"adress", adress);
            reg.Close();
        }
        public static string gravar_ler_server_adress()
        {
            regPathComplemento = @"Data\";
            reg = Registry.LocalMachine.CreateSubKey(regPath + regPathComplemento);
            reg = Registry.LocalMachine.OpenSubKey(regPath+regPathComplemento, true);

            string adress = string.Empty;
            if (reg.GetValue(@"adress") != null)
            {

                adress = reg.GetValue(@"adress").ToString();
                reg.Close();
            }
            else
            {
                reg = Registry.LocalMachine.CreateSubKey(regPath+regPathComplemento);
                reg.SetValue(@"adress", "input adress here");
                

                reg = Registry.LocalMachine.OpenSubKey(regPath + regPathComplemento);
                adress = reg.GetValue(@"adress").ToString();
                reg.Close();
            }
            return adress;
        }

        //Server Port
        public static void gravar_server_port(string port)
        {
            regPathComplemento = @"Data\";
            RegistryKey reg = Registry.LocalMachine.CreateSubKey(regPath + regPathComplemento);
            reg.SetValue(@"port", port);
            reg.Close();
        }
        public static string gravar_ler_server_port()
        {
            regPathComplemento = @"Data\";
            reg = Registry.LocalMachine.CreateSubKey(regPath + regPathComplemento);
            reg = Registry.LocalMachine.OpenSubKey(regPath + regPathComplemento, true);

            string port = string.Empty;            
            if (reg.GetValue(@"port") != null)
            {

                port = Convert.ToString(reg.GetValue(@"port"));
                reg.Close();
            }
            else
            {
                reg = Registry.LocalMachine.CreateSubKey(regPath + regPathComplemento);
                reg.SetValue(@"port", "1433");
                

                reg = Registry.LocalMachine.OpenSubKey(regPath + regPathComplemento);
                port = Convert.ToString(reg.GetValue(@"port"));
                reg.Close();
            }
            return port;
        }

        //Database
        public static void gravar_database(string database)
        {
            regPathComplemento = @"Data\";
            RegistryKey reg = Registry.LocalMachine.CreateSubKey(regPath + regPathComplemento);
            reg.SetValue(@"database", database);
            reg.Close();
        }
        public static string gravar_ler_database()
        {
            regPathComplemento = @"Data\";
            reg = Registry.LocalMachine.CreateSubKey(regPath + regPathComplemento);
            reg = Registry.LocalMachine.OpenSubKey(regPath + regPathComplemento, true);
                        
            string database = string.Empty;
            if (reg.GetValue(@"database") != null)
            {

                database = Convert.ToString(reg.GetValue(@"database"));
                reg.Close();
            }
            else
            {
                reg = Registry.LocalMachine.CreateSubKey(regPath + regPathComplemento);
                reg.SetValue(@"database", "DELIVERY");

                reg = Registry.LocalMachine.OpenSubKey(regPath + regPathComplemento);
                database = Convert.ToString(reg.GetValue(@"database"));
                reg.Close();
            }
            return database;
        }

        // ### User & PassWord
        //User
        public static void gravar_bd_user(string user)
        {
            RegistryKey reg = Registry.LocalMachine.CreateSubKey(regPathCredentials);
            reg.SetValue(@"user", user);
            reg.Close();
        }
        public static string gravar_ler_bd_user()
        {
            reg = Registry.LocalMachine.CreateSubKey(regPathCredentials);
            reg = Registry.LocalMachine.OpenSubKey(regPathCredentials, true);

            string user = string.Empty;            
            if (reg.GetValue(@"user") != null)
            {

                user = Convert.ToString(reg.GetValue(@"user"));
                reg.Close();
            }
            else
            {
                reg = Registry.LocalMachine.CreateSubKey(regPathCredentials);
                reg.SetValue(@"user", "c2E=");
                

                reg = Registry.LocalMachine.OpenSubKey(regPathCredentials);
                user = Convert.ToString(reg.GetValue(@"user"));
                reg.Close();
            }
            return user;
        }
        //Password
        public static void gravar_bd_password(string password)
        {

            RegistryKey reg = Registry.LocalMachine.CreateSubKey(regPathCredentials);
            reg.SetValue("password", password);
            reg.Close();
        }
        public static string gravar_ler_bd_password()
        {
            reg = Registry.LocalMachine.CreateSubKey(regPathCredentials);
            reg = Registry.LocalMachine.OpenSubKey(regPathCredentials, true);

            string password = string.Empty;
            if (reg.GetValue(@"password") != null)
            {

                password = Convert.ToString(reg.GetValue(@"password"));
                reg.Close();
            }
            else
            {
                reg = Registry.LocalMachine.CreateSubKey(regPathCredentials);
                reg.SetValue(@"password", "n/a");

                reg = Registry.LocalMachine.OpenSubKey(regPathCredentials);
                password = Convert.ToString(reg.GetValue(@"password"));
                reg.Close();
            }
            return password;
        }


        //PicPath
        public static void gravar_pic_path(string pic_path)
        {
            regPathComplemento = @"Parameters";
            reg = Registry.LocalMachine.CreateSubKey(regPath+regPathComplemento);
            reg.SetValue(@"picPath", pic_path);
            reg.Close();
        }
        public static string gravar_ler_pic_path()
        {
            regPathComplemento = @"Parameters";
            reg = Registry.LocalMachine.CreateSubKey(regPath + regPathComplemento);
            reg = Registry.LocalMachine.OpenSubKey(regPath + regPathComplemento, true);

            string pic_path = string.Empty;
            if (reg.GetValue(@"picPath") != null)
            {

                pic_path = Convert.ToString(reg.GetValue(@"picPath"));
                reg.Close();
            }
            else
            {
                reg = Registry.LocalMachine.CreateSubKey(regPath + regPathComplemento);
                reg.SetValue(@"picPath", "n/a");

                reg = Registry.LocalMachine.OpenSubKey(regPath + regPathComplemento);
                pic_path = Convert.ToString(reg.GetValue(@"picPath"));
                reg.Close();
            }
            return pic_path;
        }



        public static void ValidarGradeDeRegistros()
        {
            try
            {
                gravar_ler_server_adress();
                gravar_ler_server_port();
                gravar_ler_database();
                gravar_ler_bd_user();
                gravar_ler_bd_password();
                gravar_ler_pic_path();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}