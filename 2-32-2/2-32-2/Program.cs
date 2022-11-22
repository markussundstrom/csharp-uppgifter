namespace _2_32_2
{
    internal class Program
    {
        static void Main(string[] args) {
            string command = "Database command";
            try {
                var dbcomm1 = new DbCommand(null, "");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }

            try {
                var dbcomm2 = new DbCommand(new OracleConnection(""), command);
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            }

            var dbcomm3 = new DbCommand(new SqlConnection("SQL connection"), command);
            dbcomm3.Execute();
        }
    }
}