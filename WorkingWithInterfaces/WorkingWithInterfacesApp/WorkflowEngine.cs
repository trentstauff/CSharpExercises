namespace WorkingWithInterfacesApp
{
    internal class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            // iterate over each activity in workflow and run it
            foreach (var activity in workflow.GetActivities())
            {
                activity.Execute();
            }
        }
    }
}