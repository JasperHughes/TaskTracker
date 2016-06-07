using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Tracker.DAO
{

    public class AbstractDAO
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["Task_Tracker.Properties.Settings.TaskTrackerConnectionString"].ConnectionString;

        private TaskTrackerDataContext _dataContext;
        public TaskTrackerDataContext DataContext
        {
            get
            {
                if (_dataContext == null)
                {
                    _dataContext = new TaskTrackerDataContext(GetConnection());
                }
                return _dataContext;
            }
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public void SubmitChanges()
        {

            try
            {
                DataContext.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw e;
            }
        }
    }
}
