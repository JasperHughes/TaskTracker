using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Tracker.DAO
{
    static class DBInterface
    {
        private static SqlDataAdapter da;
        private static string connectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\\TaskTracker.mdf;Integrated Security=True";

        private static void Initialize()
        {

        }
    }
}
