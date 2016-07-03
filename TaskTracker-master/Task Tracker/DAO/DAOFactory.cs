using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Tracker.DAO
{
    class DAOFactory
    {
        public static DeveloperDAO getDeveloperDAO()
        {
            return new SQLServerDeveloperDAO();
        }
    }
}
