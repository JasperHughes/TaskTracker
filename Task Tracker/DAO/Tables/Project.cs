using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Tracker.DAO.Tables
{
    class Project
    {
        public enum Status
        {
            UNDERWAY,
            FINISHED,
            ON_HOLD,
            CANCELLED,
            IN_PREPARATION
        }
    }
}
