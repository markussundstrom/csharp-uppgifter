namespace _2_32_1
{
    internal class Program
    {
        static void Main(string[] args) {
            try {
                SqlConnection sqlconn1 = new SqlConnection("");
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            SqlConnection sqlconn = new SqlConnection("SQL connection string");
            sqlconn.Open();
            sqlconn.Close();

            OracleConnection oracleconn = new OracleConnection("Oracle connection string");
            oracleconn.Open();
            oracleconn.Close();
        }
    }
}