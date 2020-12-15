using System;

namespace WorkingWithInterfacesApp
{
    internal class EmailActivity : IWorkflowActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending Email...");
        }
    }
}