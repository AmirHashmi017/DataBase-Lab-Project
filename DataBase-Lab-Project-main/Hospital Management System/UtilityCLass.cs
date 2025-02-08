using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMS
{
    public class UtilityCLass
    {
        private static string connectionString = "Data Source=GREY\\SQLEXPRESS;Initial Catalog=Skylines Hospital;Integrated Security=True";


        public static string getConnectionString()
        {
            return connectionString;
        }
    }
}
