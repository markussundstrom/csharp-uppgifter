namespace _2_32_1
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string cs) : base(cs) {}
        public override void Open() {
            Console.WriteLine("Opening Oracle connection with {0}", ConnectionString);
        }

        public override void Close() {
            Console.WriteLine("Closing Oracle connnection with {0}", ConnectionString);
        }

    }
}