namespace To_Do
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskmanager = new TaskManager();
            Display display = new Display();
            int selectedList = 0;
            int selectedTask = 0;
            int itemCount = 0;
            int state = (int)State.Lists;
            bool running = true;
            display.AppName = "To-Do";
            
            while (running)
            {
                switch (state)
                {
                    case (int)State.Lists:
                        display.Context = "Tasklists";
                        display.Help = "Keys: q: quit, a: add list, <Enter>: view list, u/d: Change selection";
                        List<TaskList> lists = taskmanager.GetLists();
                        itemCount = lists.Count;
                        display.RenderLists(lists);
                        display.DrawScreen(selectedList);
                        break;

                    case (int)State.Tasks:
                        TaskList list = taskmanager.GetTaskList(selectedList);
                        itemCount = list.Tasks.Count;
                        display.Context = $"Tasks in {list.Name}";
                        display.Help = "Keys: q: quit, a: add task, <Enter>: view list, u/d: Change selection";
                        display.RenderTasks(list);
                        display.DrawScreen(selectedTask);
                        break;
                }
                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'q':
                        running = false;
                        break;
                    case 'a':
                        if (state == (int)State.Lists)
                        {
                            display.ShowAddListMessage();
                            string input = Console.ReadLine();
                            if (!String.IsNullOrEmpty(input))
                            {
                                taskmanager.AddTaskList(input);
                            }
                        }
                        else if (state == (int)State.Tasks)
                        {
                            display.ShowAddTaskMessage();
                            string input = Console.ReadLine();
                            if (!String.IsNullOrEmpty(input))
                            {
                                taskmanager.AddTask(input, selectedList);
                            }
                        }
                        break;
                    case (char)13: //enter
                        state = (int)State.Tasks;
                        break;
                    case 'u':
                        if (itemCount > 0)
                        {
                            if (state == (int)State.Lists)
                            {
                                selectedList = (selectedList == 0) ? itemCount - 1 : selectedList - 1;
                            }
                            else if (state == (int)State.Tasks)
                            {
                                selectedTask = (selectedTask == 0) ? itemCount - 1 : selectedTask - 1;
                            }
                        }
                        break;
                    case 'd':
                        if (itemCount > 0)
                        {
                            if (state == (int)State.Lists)
                            {
                                selectedList = (selectedList == itemCount -1) ? 0 : selectedList + 1;
                            }
                            else if (state == (int)State.Tasks)
                            {
                                selectedTask = (selectedTask == itemCount -1) ? 0 : selectedTask + 1;
                            }
                        }
                        break;
                }
            }
        }
        public enum State
        {
            Lists = 1,
            Tasks = 2,
            Edit = 64,
            Delete = 128
        }
    }

}