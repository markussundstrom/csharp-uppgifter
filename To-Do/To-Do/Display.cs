namespace To_Do
{
    public class Display
    {
        public string AppName { get; set; }
        public string Context { get; set; }
        public string Message { get; set; }
        public string Help {get; set; }
        private List<string> _items = new List<string>();



        public void DrawScreen(int selected) 
        {
            Console.Clear();
            Console.WriteLine($"{AppName}: {Context}");
            for (int i = 0; i < _items.Count; i++) 
            {
                if (i == selected)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(_items[i]);
                Console.ResetColor();
            }
            Console.WriteLine(Message);
            Console.WriteLine(Help);
        }

        public void RenderLists(List<TaskList> lists) 
        {
            _items.Clear();
            foreach (var list in lists)
            {
                _items.Add(list.Name);
            }
        }

        public void RenderTasks(TaskList list)
        {
            _items.Clear();
            foreach (var task in list.Tasks)
            {
                _items.Add(task.Completed.ToString() + "1" + task.Title);
            }
        }

        public void ShowAddListMessage()
        {
            Console.CursorLeft = 0;
            Console.CursorTop = 10;
            Console.Write("Enter title of new list:");
            Console.CursorTop++;
        }

        public void ShowAddTaskMessage()
        {
            Console.CursorLeft = 0;
            Console.CursorTop = 10;
            Console.Write("Enter title of new task:");
            Console.CursorTop++;
        }
    }
}