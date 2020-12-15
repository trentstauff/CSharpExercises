using System;

namespace WorkingWithInterfacesApp
{
    internal class SmsActivity : IWorkflowActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending SMS...");
        }
    }
}