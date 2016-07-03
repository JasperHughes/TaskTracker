using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Tracker.DAO
{
    public interface DeveloperDAO
    {
        List<Developer> GetDevelopers();
        Developer GetDeveloper(int id);
        void AddDeveloper(Developer developer);
        void UpdateDeveloper(Developer toUpdate);
        void DeleteDeveloper(Developer toDelete);
    }
}
