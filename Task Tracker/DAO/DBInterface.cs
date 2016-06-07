using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Task_Tracker.DAO.Tables;
using System.Data;
using System.Data.Linq;

namespace Task_Tracker.DAO
{
    static class DBInterface
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["Task_Tracker.Properties.Settings.TaskTrackerConnectionString"].ConnectionString;

        public enum Table
        {
            CLIENTS,
            DEVELOPERS,
            ITERATIONS,
            ITERATION_TASKS,
            PROJECTS,
            TASKS
        }

        private static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        //Select All of a specific table
        public static object SelectAll(Table table)
        {            
            switch (table)
            {
                case Table.CLIENTS:
                    return GetClients();
                case Table.ITERATIONS:
                    return GetIterations();
                case Table.ITERATION_TASKS:
                    return GetIterationTasks();
                case Table.PROJECTS:
                    return GetProjects();
                case Table.TASKS:
                    return GetTasks();
                default:
                    return null;
            }
        }

        //Select a single item from a specific table (not iteration tasks)
        public static object SelectOne(Table table, int id)
        {
            switch (table)
            {
                case Table.CLIENTS:
                    return GetClient(id);
                case Table.ITERATIONS:
                    return GetIteration(id);
                case Table.PROJECTS:
                    return GetProject(id);
                case Table.TASKS:
                    return GetTask(id);
                default:
                    return null;
            }
        }

        //Add an item to the database
        public static void Add(object o)
        {
            if(o is Client)
            {
                AddClient((Client)o);
            }
            if(o is Iteration)
            {
                AddIteration((Iteration)o);
            }
            if(o is IterationTask)
            {
                AddIterationTask((IterationTask)o);
            }
            if(o is Project)
            {
                AddProject((Project)o);
            }
            if(o is Task)
            {
                AddTask((Task)o);
            }
        }

        //update an item in the database
        public static void Update(object o)
        {
            if (o is Client)
            {
                UpdateClient((Client)o);
            }
            if (o is Iteration)
            {
                UpdateIteration((Iteration)o);
            }
            if (o is IterationTask)
            {
                UpdateIterationTask((IterationTask)o);
            }
            if (o is Project)
            {
                UpdateProject((Project)o);
            }
            if (o is Task)
            {
                UpdateTask((Task)o);
            }
        }

        //delete an item in the database
        public static void Delete(object o)
        {
            if (o is Client)
            {
                DeleteClient((Client)o);
            }
            if (o is Iteration)
            {
                DeleteIteration((Iteration)o);
            }
            if (o is IterationTask)
            {
                DeleteIterationTask((IterationTask)o);
            }
            if (o is Project)
            {
                DeleteProject((Project)o);
            }
            if (o is Task)
            {
                DeleteTask((Task)o);
            }
        }


        private static List<Client> GetClients()
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            return dataContext.Clients.ToList();
        }

        private static Client GetClient(int id)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            return dataContext.Clients.Single(client => client.ID == id);            
        }

        private static void AddClient(Client client)
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

        private static void UpdateClient(Client toUpdate)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            Client c = dataContext.Clients.Single(client => client.ID == toUpdate.ID);
            //TODO change appropriate values in client oject

            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        private static void DeleteClient(Client toDelete)
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

        private static List<Iteration> GetIterations()
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            return dataContext.Iterations.ToList();
        }

        private static Iteration GetIteration(int id)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            return dataContext.Iterations.Single(iteration => iteration.ID == id);
        }

        private static void AddIteration(Iteration iteration)
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

        private static void UpdateIteration(Iteration toUpdate)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            Iteration i = dataContext.Iterations.Single(iteration => iteration.ID == toUpdate.ID);
            //TODO update iteration with input value;

            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        private static void DeleteIteration(Iteration toDelete)
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

        private static List<Project> GetProjects()
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            return dataContext.Projects.ToList();
        }

        private static Project GetProject(int id)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            return dataContext.Projects.Single(project => project.ID == id);
        }

        private static void AddProject(Project project)
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

        private static void UpdateProject(Project toUpdate)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            Project p = dataContext.Projects.Single(project => project.ID == toUpdate.ID);
            //TODO change prject variables
            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        private static void DeleteProject(Project toDelete)
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

        private static List<Task> GetTasks()
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            return dataContext.Tasks.ToList();
        }

        private static Task GetTask(int id)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            return dataContext.Tasks.Single(task => task.ID == id);
        }

        private static void AddTask(Task task)
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

        private static void UpdateTask(Task toUpdate)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            Task t = dataContext.Tasks.Single(task => task.ID == toUpdate.ID);
            //TODO task update code
            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        private static void DeleteTask(Task toDelete)
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

        private static List<IterationTask> GetIterationTasks()
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            return dataContext.IterationTasks.ToList();
        }

        public static IterationTask GetIterationTask(int iterationID, int taskID)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            return dataContext.IterationTasks.Single(iterationTask => iterationTask.IterationID == iterationID && iterationTask.TaskID == taskID);
        }
                
        public static List<IterationTask> GetTasksForIteration(int id)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            return (from it in dataContext.IterationTasks where it.IterationID == id select it).ToList();
        }

        private static void AddIterationTask(IterationTask iterationTask)
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

        private static void UpdateIterationTask(IterationTask toUpdate)
        {
            TaskTrackerDataContext dataContext = new TaskTrackerDataContext(GetConnection());
            IterationTask it = dataContext.IterationTasks.Single(iterationTask => iterationTask.IterationID == toUpdate.IterationID && iterationTask.TaskID == toUpdate.TaskID);
            //TODO update variables

            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        private static void DeleteIterationTask(IterationTask toDelete)
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
