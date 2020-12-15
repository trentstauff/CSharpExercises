using System.Collections.Generic;

namespace WorkingWithInterfacesApp
{
    internal class Workflow
    {
        private readonly List<IWorkflowActivity> _activities = new List<IWorkflowActivity>();

        public void AddActivity(IWorkflowActivity activity)
        {
            _activities.Add(activity);
        }

        public IEnumerable<IWorkflowActivity> GetActivities()
        {
            return _activities;
        }
    }
}
