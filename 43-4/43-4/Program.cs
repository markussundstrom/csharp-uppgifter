using Microsoft.VisualBasic.FileIO;

namespace _43_4
{
    internal class Program
    {
        static void Main(string[] args) {
            string input;
            int speed, spdlimit, demerit;
            Console.WriteLine("Enter speed limit");
            input = Console.ReadLine();
            spdlimit = Int32.Parse(input);
            Console.WriteLine("Enter speed");
            input = Console.ReadLine();
            speed = Int32.Parse(input);
            if (speed < spdlimit) {
                Console.WriteLine("Ok");
            } else {
                demerit = (speed - spdlimit) / 5;
                if (demerit >= 12) {
                    Console.WriteLine("License suspended");
                } else {
                    Console.WriteLine("{0} demerit points", demerit);
                }
            }
        }
    }
}