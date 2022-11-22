namespace _2_32_1
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string cs) : base(cs) {}

        public override void Open() {
            Console.WriteLine("Opening SQL connection with {0}", ConnectionString);
        }

        public override void Close() {
            Console.WriteLine("Closing SQL connection with {0}", ConnectionString);
        }
    }
}