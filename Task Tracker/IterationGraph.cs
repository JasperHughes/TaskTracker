using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Tracker
{
    public partial class IterationGraph : Form
    {
        private List<GraphPoint> tasksByCompletion;
        private List<GraphPoint> completedTasks;
        public int iterationID;
        public IterationGraph()
        {
            InitializeComponent();
        }


        private void MapGraph(List<IterationTask> tasks)
        {
            iterationChart.Series["Tasks"].Points.Clear();


            completedTasks = new List<GraphPoint>();
            //foreach (IterationTask t in tasks)
            //{
            //    if (!t.Task.CompletionDate.ToString().Equals(""))
            //    {
            //        if (!completedTasks.Contains(new GraphPoint(DateTime.Parse(t.Task.CompletionDate.ToString()), 0)))
            //        {
            //            completedTasks.Add(new GraphPoint(DateTime.Parse(t.Task.CompletionDate.ToString()), 0));
            //        }
            //    }
            //}

            //foreach (GraphPoint gp in completedTasks)
            //{
            //    for (int i = 0; i < tasks.Count; i++)
            //    {
            //        if (tasks[i].Task.CompletionDate.ToString().Equals(gp.date.ToString()))
            //        {
            //            gp.count++;
            //            Console.WriteLine("Task count for: " + gp.date.ToString() + " is: " + gp.count);
            //        }
            //    }
            //}

            completedTasks.Add(new GraphPoint(new DateTime(2012, 5, 5), 2));
            completedTasks.Add(new GraphPoint(new DateTime(2012, 3, 2), 3));
            completedTasks.Add(new GraphPoint(new DateTime(2012, 4, 7), 1));
            completedTasks.Add(new GraphPoint(new DateTime(2012, 12, 10), 0));
            completedTasks.Add(new GraphPoint(new DateTime(2012, 5, 11), 2));
            completedTasks.Add(new GraphPoint(new DateTime(2012, 9, 5), 1));
            completedTasks.Add(new GraphPoint(new DateTime(2012, 3, 2), 4));
            completedTasks = completedTasks.OrderBy(gp => gp.date).ToList();
            for (int i = 0; i < completedTasks.Count; i++)
            {
                iterationChart.Series["Completed Tasks"].Points.AddXY(completedTasks[i].date.ToOADate(), completedTasks[i].count);
            }

            tasksByCompletion = new List<GraphPoint>();
            //foreach (IterationTask t in tasks)
            //{
            //    if (!tasksByCompletion.Contains(new GraphPoint(DateTime.Parse(t.PlannedCompletionDate.ToString()), 0)))
            //    {
            //        tasksByCompletion.Add(new GraphPoint(DateTime.Parse(t.PlannedCompletionDate.ToString()), 0));
            //    }
            //}

            //foreach (GraphPoint gp in tasksByCompletion)
            //{
            //    for (int i = 0; i < tasks.Count; i++)
            //    {
            //        if (tasks[i].PlannedCompletionDate.ToString().Equals(gp.date.ToString()))
            //        {
            //            gp.count++;
            //            Console.WriteLine("Task count for: " + gp.date.ToString() + " is: " + gp.count);
            //        }
            //    }
            //}
            tasksByCompletion.Add(new GraphPoint(new DateTime(2012, 5, 5), 4));
            tasksByCompletion.Add(new GraphPoint(new DateTime(2012, 3, 2), 8));
            tasksByCompletion.Add(new GraphPoint(new DateTime(2012, 4, 7), 5));
            tasksByCompletion.Add(new GraphPoint(new DateTime(2012, 12, 10), 2));
            tasksByCompletion.Add(new GraphPoint(new DateTime(2012, 5, 11), 3));
            tasksByCompletion.Add(new GraphPoint(new DateTime(2012, 9, 5), 1));
            tasksByCompletion.Add(new GraphPoint(new DateTime(2012, 3, 2), 9));
            tasksByCompletion = tasksByCompletion.OrderBy(gp => gp.date).ToList();
            for (int i = 0; i< tasksByCompletion.Count; i++)
            {
                iterationChart.Series["Tasks"].Points.AddXY(tasksByCompletion[i].date.ToOADate(), tasksByCompletion[i].count - completedTasks[i].count);
            }
        }

        private class GraphPoint
        {
            public DateTime date { get; set; }
            public int count { get; set; }
            public GraphPoint(DateTime date, int count)
            {
                this.date = date;
                this.count = count;
            }
        }

        private void IterationGraph_Load(object sender, EventArgs e)
        {
            MapGraph(DAO.DBInterface.GetTasksForIteration(iterationID));
        }
    }
}
