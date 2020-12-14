using System;

namespace WorkingWithPolymorphismApp
{
    internal class SqlConnection : DbConnection
    {
        // pass through the connection string to the base class
        public SqlConnection(string connectionString, TimeSpan? timeout = null)
            : base (connectionString, timeout)
        {}
        
        public override void OpenConnection()
        {
            // if timeout is zero, dont worry about timeout.
            // if trying to open connection after timeout has passed,
            // not allowed to connect.
            if (IsConnected)
            {
                Console.WriteLine("Sorry, you're already connected.");
            }
            else if (Timeout != TimeSpan.Zero && (DateTime.Now - TimeCreated > Timeout))
            {
                Console.WriteLine("Sorry, you did not connect in time.");
            }
            else
            {
                // would usually use SQL's API to open, but for simplicity:
                Console.WriteLine("Opened Connection to SQL Database: " + ConnectionString);
                IsConnected = true;
            }
        }
        
        public override void CloseConnection()
        {
            if (IsConnected == false)
            {
                Console.WriteLine("You are not connected!");
            }
            else
            {
                // would usually use SQL's API to close, but for simplicity:
                Console.WriteLine("Closed Connection to SQL Database: " + ConnectionString);
                IsConnected = false;
            }
        }
    }
}
