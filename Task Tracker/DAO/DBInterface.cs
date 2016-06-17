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

//hey hey hey XD

namespace Task_Tracker.DAO
{
    static class DBInterface
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["Task_Tracker.Properties.Settings.TaskTrackerConnectionString"].ConnectionString;
        private static TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());

        private static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        //internal methods for retrieving data
        public static List<Developer> GetDevelopers()
        {
            
            return dataContext.Developers.ToList();            
        }

        public static Developer GetDeveloper(int id)
        {
            
            return dataContext.Developers.Single(developer => developer.ID == id);           
        }

        public static void Add(Developer developer)
        {
            
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

        public static List<DeveloperIterationView> GetDeveloperIterationView(int id)
        {
            // Get the list of Iterations for a developer, sorted by Iteration.StartDate
            
            return (from developerIterationView in dataContext.DeveloperIterationViews 
                   where developerIterationView.DeveloperID == id orderby developerIterationView.StartDate 
                   select developerIterationView).ToList();
        }

        public static List<Client> GetClients()
        {
            
            return dataContext.Clients.ToList();
        }

        public static Client GetClient(int id)
        {
            
            return dataContext.Clients.Single(client => client.ID == id);            
        }

        public static void Add(Client client)
        {
            
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
            
            return dataContext.Iterations.ToList();
        }

        public static Iteration GetIteration(int id)
        {
            
            return dataContext.Iterations.Single(iteration => iteration.ID == id);
        }

        public static void Add(Iteration iteration)
        {
            
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
            
            return dataContext.Projects.ToList();
        }

        public static Project GetProject(int id)
        {
            
            return dataContext.Projects.Single(project => project.ID == id);
        }

        public static void Add(Project project)
        {
            
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
            
            return dataContext.Tasks.ToList();
        }

        public static Task GetTask(int id)
        {
            
            Task returnTask = dataContext.Tasks.Single(task => task.ID == id);
            return returnTask;
        }

        public static void Add(Task task)
        {
            
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
            
            return dataContext.IterationTasks.ToList();
        }

        //iteration tasks have seperate methods due to complexity of queries (not simply getting everything or one from a single ID)
        public static IterationTask GetIterationTask(int iterationID, int taskID)
        {
            
            return dataContext.IterationTasks.Single(iterationTask => iterationTask.IterationID == iterationID && iterationTask.TaskID == taskID);

        }
                
        public static List<IterationTask> GetTasksForIteration(int id)
        {
            
            return (from t in dataContext.IterationTasks where t.IterationID == id orderby t.PlannedStartDate ascending select t).ToList();
        }

        public static void Add(IterationTask iterationTask)
        {
            
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

        public static DeveloperIterationTask GetDeveloperIterationTask(int developerID, int iterationID, int taskID)
        {

            return dataContext.DeveloperIterationTasks.Single(developerIterationTask => developerIterationTask.DeveloperID == developerID && developerIterationTask.IterationID == iterationID && developerIterationTask.TaskID == taskID);

        }

        public static void Add(DeveloperIterationTask developerIterationTask)
        {
            dataContext.DeveloperIterationTasks.InsertOnSubmit(developerIterationTask);

            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Exception ex = e;
                while (ex.InnerException != null)
                {
                    ex = ex.InnerException;
                }
                Console.WriteLine(ex.InnerException);
                throw;
            }
        }

        public static void Delete(DeveloperIterationTask toDelete)
        {

            dataContext.DeveloperIterationTasks.DeleteOnSubmit(toDelete);

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
