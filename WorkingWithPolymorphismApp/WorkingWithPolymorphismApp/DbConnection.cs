using System;

namespace WorkingWithPolymorphism
{
    internal abstract class DbConnection
    {
        // this is our base class
        protected readonly string ConnectionString;
        protected bool IsConnected = false;
        protected TimeSpan Timeout;
        protected DateTime TimeCreated = DateTime.Now;

        protected DbConnection(string connectionString, TimeSpan? timeout = null)
        {
            if(string.IsNullOrWhiteSpace(connectionString))
                throw new InvalidOperationException("Connection string must be valid.");
            
            ConnectionString = connectionString;
            if (timeout == null)
            {
                Timeout = TimeSpan.Zero;
            }
            else
            {
                Timeout = (TimeSpan) timeout;
            }
        }
        
        // Since there is different ways to open and close connections,
        // we can make these functions virtual to allow for overriding.
        // Infact, lets force the users hand and make sure they are implemented
        // by making this base class abstract.

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}
