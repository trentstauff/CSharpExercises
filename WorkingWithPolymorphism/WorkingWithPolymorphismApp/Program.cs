using System;

namespace WorkingWithPolymorphismApp
{
    class Program
    {
        static void Main(string[] args)
        {
        
            // Ex. #1
            // Database Connection Question
            
            // Successful connection! You connect before the
            // timespan has passed.
            var timeSpanSql1 = new TimeSpan(0,0, 5);
            var sqlConnection1 = new SqlConnection("10.123.343", timeSpanSql1);
            System.Threading.Thread.Sleep(2000);
            sqlConnection1.OpenConnection();
            sqlConnection1.CloseConnection();

            Console.WriteLine();
            
            // Example of having a timespan of 10 seconds to connect
            // to database before invalid, and we try to connect after
            // 11 seconds. Therefore, you cannot connect.
            var timeSpanOracle1 = new TimeSpan(0,0, 10);
            var oracleConnection1 = new OracleConnection("33.123.52325", timeSpanOracle1);
            System.Threading.Thread.Sleep(11000);
            oracleConnection1.OpenConnection();
            oracleConnection1.CloseConnection();
            
            Console.WriteLine();
            
            // Example of trying to close connection before opening connection.
            var timeSpanSql2 = new TimeSpan(0,0, 0);
            var sqlConnection2 = new SqlConnection("20.542.343", timeSpanSql2);
            sqlConnection2.CloseConnection();
            
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("DbCommand Exercises");
            
            // ---------------------------------------------------------------------
            // Ex. #2
            // DbCommand question
            
            var dbCommandConnectionSql = new SqlConnection("69.341.333", new TimeSpan(0,0,0) );
            var dbCommand = new DbCommand(dbCommandConnectionSql,"SQL Instruction");
            dbCommand.Execute();
            
            Console.WriteLine();
            
            var dbCommandConnectionOracle = new OracleConnection("88.223.179", new TimeSpan(0,0,0));
            var dbCommand2 = new DbCommand(dbCommandConnectionOracle, "Oracle Instruction");
            dbCommand2.Execute();
        }
    }
}
