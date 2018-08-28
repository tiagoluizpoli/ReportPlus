using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportPlus.Tools
{
    public class StringBuilding
    {
        public static string MontarConnectionString(string serverIP, string serverPort, string database, string user, string password)
        {
            string connectionString_ready = @"Server="+serverIP+","+serverPort+";Database="+database+";User Id="+user+";Password = "+password+";";
            return connectionString_ready;
        }
    }
}
