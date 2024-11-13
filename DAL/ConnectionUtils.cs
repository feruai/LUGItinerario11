            using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConnectionUtils
    {
       public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["PartidosDb"].ConnectionString;
        }
    }
}
