namespace Task_Tracker
{
    partial class Client
    {
    }

    partial class Project
    {
    }

    partial class Task
    {
        public override string ToString()
        {
            return this.TaskName;
        }
    }

    partial class DeveloperIterationTask
    {
    }

    partial class Iteration
    {

    }

    partial class IterationTask
    {
    }

    partial class Developer
    {
        public override string ToString()
        {
            return this.GivenNames + " " + this.FamilyName;
        }

        public string ActiveString
        {
            get { return Active ? "Yes" : "No"; }
        }
    }
}