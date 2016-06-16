using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using System.Data.Linq;

namespace Task_Tracker.DAO
{
    static class DBInterface
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["Task_Tracker.Properties.Settings.TaskTrackerConnectionString"].ConnectionString;

        private static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        //internal methods for retrieving data
        public static List<Developer> GetDevelopers()
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            return dataContext.Developers.ToList();            
        }

        public static Developer GetDeveloper(int id)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            return dataContext.Developers.Single(developer => developer.ID == id);           
        }

        public static void Add(Developer developer)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            dataContext.Developers.InsertOnSubmit(developer);

            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static void Update(Developer toUpdate)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            Developer d = dataContext.Developers.Single(developer => developer.ID == toUpdate.ID);
            d.Active = toUpdate.Active;
            d.ContactNumber = toUpdate.ContactNumber;
            d.Email = toUpdate.Email;
            d.FamilyName = toUpdate.FamilyName;
            d.GivenNames = toUpdate.GivenNames;
            d.Notes = toUpdate.Notes;                        
            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void Delete(Developer toDelete)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            dataContext.Developers.DeleteOnSubmit(toDelete);

            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static List<Client> GetClients()
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            return dataContext.Clients.ToList();
        }

        public static Client GetClient(int id)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            return dataContext.Clients.Single(client => client.ID == id);            
        }

        public static void Add(Client client)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            dataContext.Clients.InsertOnSubmit(client);

            try
            {
                dataContext.SubmitChanges();
            }catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static void Update(Client toUpdate)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            Client c = dataContext.Clients.Single(client => client.ID == toUpdate.ID);
            c.FamilyName = toUpdate.FamilyName;
            c.GivenNames = toUpdate.GivenNames;
            c.ABN = toUpdate.ABN;
            c.ContactNumber = toUpdate.ContactNumber;
            c.Email = toUpdate.Email;
            c.Created = toUpdate.Created;
            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static void Delete(Client toDelete)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            Client c = dataContext.Clients.Single(client => client.ID == toDelete.ID);
            dataContext.Clients.DeleteOnSubmit(c);

            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static List<Iteration> GetIterations()
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            return dataContext.Iterations.ToList();
        }

        public static Iteration GetIteration(int id)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            return dataContext.Iterations.Single(iteration => iteration.ID == id);
        }

        public static void Add(Iteration iteration)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            dataContext.Iterations.InsertOnSubmit(iteration);

            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static void Update(Iteration toUpdate)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            Iteration i = dataContext.Iterations.Single(iteration => iteration.ID == toUpdate.ID);
            i.StartDate = toUpdate.StartDate;
            i.EndDate = toUpdate.EndDate;
            i.ProjectID = toUpdate.ProjectID;
            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static void Delete(Iteration toDelete)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            dataContext.Iterations.DeleteOnSubmit(toDelete);

            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static List<Project> GetProjects()
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            return dataContext.Projects.ToList();
        }

        public static Project GetProject(int id)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            return dataContext.Projects.Single(project => project.ID == id);
        }

        public static void Add(Project project)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            dataContext.Projects.InsertOnSubmit(project);

            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static void Update(Project toUpdate)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            Project p = dataContext.Projects.Single(project => project.ID == toUpdate.ID);            
            p.ProjectName = toUpdate.ProjectName;
            p.StartDate = toUpdate.StartDate;
            p.CompletionDate = toUpdate.CompletionDate;
            p.Status = toUpdate.Status;
            p.Description = toUpdate.Description;
            p.ClientID = toUpdate.ClientID;
            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static void Delete(Project toDelete)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            dataContext.Projects.DeleteOnSubmit(toDelete);

            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static List<Task> GetTasks()
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            return dataContext.Tasks.ToList();
        }

        public static Task GetTask(int id)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            return dataContext.Tasks.Single(task => task.ID == id);
        }

        public static void Add(Task task)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            dataContext.Tasks.InsertOnSubmit(task);

            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static void Update(Task toUpdate)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            Task t = dataContext.Tasks.Single(task => task.ID == toUpdate.ID);
            t.TaskName = toUpdate.TaskName;
            t.Description = toUpdate.Description;
            t.Priority = toUpdate.Priority;
            t.CompletionDate = toUpdate.CompletionDate;
            t.ProjectID = toUpdate.ProjectID;
            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static void Delete(Task toDelete)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            dataContext.Tasks.DeleteOnSubmit(toDelete);

            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static List<IterationTask> GetIterationTasks()
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            return dataContext.IterationTasks.ToList();
        }

        //iteration tasks have seperate methods due to complexity of queries (not simply getting everything or one from a single ID)
        public static IterationTask GetIterationTask(int iterationID, int taskID)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            return dataContext.IterationTasks.Single(iterationTask => iterationTask.IterationID == iterationID && iterationTask.TaskID == taskID);

        }
                
        public static List<IterationTask> GetTasksForIteration(int id)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            return (from t in dataContext.IterationTasks where t.IterationID == id orderby t.PlannedStartDate ascending select t).ToList();
        }

        public static void Add(IterationTask iterationTask)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            dataContext.IterationTasks.InsertOnSubmit(iterationTask);

            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static void Update(IterationTask toUpdate)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            IterationTask it = dataContext.IterationTasks.Single(iterationTask => iterationTask.IterationID == toUpdate.IterationID && iterationTask.TaskID == toUpdate.TaskID);
            it.PlannedStartDate = toUpdate.PlannedStartDate;
            it.PlannedCompletionDate = toUpdate.PlannedCompletionDate;
            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static void Delete(IterationTask toDelete)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            dataContext.IterationTasks.DeleteOnSubmit(toDelete);

            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }        
}
