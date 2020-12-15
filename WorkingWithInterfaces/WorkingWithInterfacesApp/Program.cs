using System;

namespace WorkingWithInterfacesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();
            workflow.AddActivity(new EmailActivity());
            workflow.AddActivity(new SmsActivity());
            
            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);
            
        }
    }
}