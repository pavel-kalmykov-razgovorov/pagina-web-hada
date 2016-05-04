using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace Constants_namespace
{
    public class Constants
    {
        //public const string nombreConexion = "data source=.\\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=|DataDirectory|\\BBDD.mdf;User Instance=true";
        public static string nombreConexion = ConfigurationManager.ConnectionStrings["ConexionBBDD"].ToString();
        public Constants() { }

        public static void Main() { }
    }
}
