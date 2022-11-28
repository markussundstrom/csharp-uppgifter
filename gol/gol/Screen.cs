namespace gol
{
    public class Screen
    {
        public void DrawScreen(bool[,] data)
        {
            //Console.Clear();
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < data.GetLength(1); i++)
            {
                string line = "";
                for (int j = 0; j < data.GetLength(0); j++)
                {
                    Console.SetCursorPosition(j, i);
                    if (data[j, i])
                    {
                        //line += "X";
                        //Console.BackgroundColor = ConsoleColor.Green;
                        //Console.Write("X");
                        Console.Write("X");
                    }
                    else
                    {
                        line += " ";
                        //Console.BackgroundColor = ConsoleColor.Black;
                        //Console.Write(" ");
                        Console.Write(" ");
                    }
                }
                //Console.WriteLine(line);
            }
        }
    }
}