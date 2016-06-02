using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Tracker.DAO.Tables
{
    class Developer
    {
        public int ID { get; set; }
        public string FamilyName { get; set; }
        public string GivenNames { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public bool Active { get; set; }
        public string Notes { get; set; }

        public Developer()
        {
            Active = true;
        }

        public string ActiveYesNo()
        {
            return Active ? "Yes" : "No";
        }
    }
}
