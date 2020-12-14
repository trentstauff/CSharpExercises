using System;

namespace WorkingWithPolymorphismApp
{
    // Mocks an execution of an instruction against
    // the database
    
    internal class DbCommand
    {
        
        // Utilizing composition to build a more loosely-coupled assembly
        private DbConnection _connection;
        private string _instruction;
        
        public DbCommand(DbConnection connection, string instruction)
        {
            if(connection == null)
                throw new InvalidOperationException("DbConnection object cannot be null.");
            
            if(string.IsNullOrWhiteSpace(instruction))
                throw new InvalidOperationException("Instruction cannot be null or empty.");
            
            _connection = connection;
            _instruction = instruction;
        }

        public void Execute()
        {
            _connection.OpenConnection();
            Console.WriteLine("Executing instruction: " + _instruction);
            _connection.CloseConnection();
        }
        
    }
}