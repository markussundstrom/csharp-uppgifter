namespace _2_32_2
{
    public class DbCommand
    {
        private DbConnection _dbConnection;
        private string _command;

        public DbCommand(DbConnection dbc, string commandstring) {
            if (dbc == null) {
                throw new ArgumentNullException("DbConnection object needed");
            } else if (String.IsNullOrEmpty(commandstring)) {
                throw new ArgumentNullException("DB Command needed");
            } else {
                _dbConnection = dbc;
                _command = commandstring;
            }
        }

        public void Execute() {
            _dbConnection.Open();
            Console.WriteLine("Command: {0}", _command);
            _dbConnection.Close();
        }



    }
}