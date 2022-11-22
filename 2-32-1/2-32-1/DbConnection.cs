using Microsoft.VisualBasic;
using System.Dynamic;

namespace _2_32_1
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string cs) {
            if (String.IsNullOrEmpty(cs)) {
                throw new ArgumentNullException("DB Connection string can't be empty");
            } else {
                ConnectionString = cs;
            }
        }

        public abstract void Open();
        public abstract void Close();
    }
}