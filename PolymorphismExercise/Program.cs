using System;

namespace CSharpInter
{
    class Oct10
    {
        public abstract class DbConnection
        {
            private string ConnectionString;
            private TimeSpan Timeout;

            public DbConnection(string connectionString)
            {
                if(String.IsNullOrEmpty(connectionString))
                {
                    throw new InvalidOperationException();
                }
                ConnectionString = connectionString;
                
            }
            public abstract void OpeningConnection();
            public abstract void ClosingConnection();

        }

        public class SqlConnection : DbConnection
        {
            public SqlConnection(string connectionString) : base(connectionString)
            {
            }

            public override void ClosingConnection()
            {
                Console.WriteLine("Sql connection has been closed..");
            }

            public override void OpeningConnection()
            {
                Console.WriteLine("Sql connection has been opened..");
            }
        }
        public class OracleConnection : DbConnection
        {
            public OracleConnection(string connectionString) : base(connectionString)
            {
            }

            public override void ClosingConnection()
            {
                Console.WriteLine("Oracle connection has been closed..");
            }

            public override void OpeningConnection()
            {
                Console.WriteLine("Oracle connection has been opened..");
            }
        }



        //-----------------------------------Question 2

        public class DbCommand
        {
            private DbConnection _connection;
            private string _instructions;
            public DbCommand(DbConnection dbConnection, string instructions)
            {
                if (dbConnection == null || String.IsNullOrEmpty(instructions))
                    throw new InvalidOperationException();
                _connection = dbConnection;
                _instructions = instructions;
            }
            public void Execute()
            {
                _connection.OpeningConnection();
                Console.WriteLine("The instructions are running...."+ _instructions);
                _connection.ClosingConnection();

            }
        }

        static void Main(string[] args)
        {
            DbCommand command = new DbCommand(new SqlConnection("connectionString"), "To run my computer..");
            command.Execute();

            Console.WriteLine();
            Console.WriteLine();
            DbCommand command1 = new DbCommand(new OracleConnection("connectionString"), "To run my computer..");
            command1.Execute();
        }
    }
}