using System;

namespace WorkingWithInterfacesApp
{
    internal class PostActivity : IWorkflowActivity
    {
        public void Execute()
        {
            Console.WriteLine("Creating Post...");
        }
    }
}