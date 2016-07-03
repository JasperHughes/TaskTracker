using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Tracker.DAO
{
    class SQLServerDeveloperDAO : AbstractDAO, DeveloperDAO
    {
        public List<Developer> GetDevelopers()
        {
            return DataContext.Developers.ToList();
        }

        public Developer GetDeveloper(int id)
        {
            return DataContext.Developers.Single(developer => developer.ID == id);
        }

        public void AddDeveloper(Developer developer)
        {
            DataContext.Developers.InsertOnSubmit(developer);
            SubmitChanges();
        }

        public void UpdateDeveloper(Developer toUpdate)
        {
            TaskTrackerDataContext dataContext = this.DataContext;
            Developer d = dataContext.Developers.Single(developer => developer.ID == toUpdate.ID);
            d.Active = toUpdate.Active;
            d.ContactNumber = toUpdate.ContactNumber;
            d.DeveloperIterationTasks = toUpdate.DeveloperIterationTasks;
            d.Email = toUpdate.Email;
            d.FamilyName = toUpdate.FamilyName;
            d.GivenNames = toUpdate.GivenNames;
            d.Notes = toUpdate.Notes;

            SubmitChanges();

        }

        public void DeleteDeveloper(Developer toDelete)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            DataContext.Developers.DeleteOnSubmit(toDelete);
            SubmitChanges();
        }
    }
}
