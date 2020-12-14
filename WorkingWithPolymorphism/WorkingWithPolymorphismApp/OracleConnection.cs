using System;

namespace WorkingWithPolymorphismApp
{
    internal class OracleConnection : DbConnection
    {
        // pass through the connection string to the base class
        public OracleConnection(string connectionString, TimeSpan? timeout = null)
            : base (connectionString, timeout)
        {}
        
        public override void OpenConnection()
        {
            // if timeout is zero, dont worry about timeout.
            // if trying to open connection after timeout has passed,
            // not allowed to connect.
            if (IsConnected)
            {
                Console.WriteLine("You are already connected.");
            }
            else if (Timeout != TimeSpan.Zero && (DateTime.Now - TimeCreated > Timeout))
            {
                Console.WriteLine("Sorry, you did not connect in time.");
            }
            else
            {
                // would usually use Oracle's API to open, but for simplicity:
                Console.WriteLine("Opened Connection to Oracle Database: " + ConnectionString);
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
                // would usually use Oracle's API to close, but for simplicity:
                Console.WriteLine("Closed Connection to Oracle Database: " + ConnectionString);
                IsConnected = false;
            }
        }
    }
}
