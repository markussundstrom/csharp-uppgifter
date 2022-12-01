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
                        List<TaskList> lists = taskmanager.GetLists();
                        itemCount = lists.Count;
                        if (selectedList >= itemCount)
                        {
                            selectedList = itemCount - 1;
                        }
                        display.Context = "Tasklists";
                        display.Help = "Keys: q: quit, a: add list, x: delete list, <Enter>: view list, j/k: Change selection";
                        display.DrawScreen();
                        display.RenderLists(lists, selectedList);
                        break;

                    case (int)State.Tasks:
                        TaskList list = taskmanager.GetTaskList(selectedList);
                        itemCount = list.Tasks.Count;
                        if (selectedTask >= itemCount)
                        {
                            selectedTask = itemCount - 1;
                        }
                        display.Context = $"Tasks in {list.Title}";
                        display.Help = "Keys: q: quit, a: add task, x: delete task, t: edit list title <Enter>: view list, j/k: Change selection b: go back";
                        display.DrawScreen();
                        display.RenderTasks(list, selectedTask);
                        break;

                    case (int)State.Taskview:
                        Task task = taskmanager.GetTask(selectedList, selectedTask);
                        display.Context = $"Viewing task \"{task.Title}\"";
                        display.Help = "Keys: q: quit, t: edit title c: toggle complete b: go back";
                        display.DrawScreen();
                        display.RenderTaskview(task);
                        break;
                }

                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'q':
                        display.InputRequest("Do you want to quit? (y/n)");
                        while (true)
                        {
                            char choice = (Console.ReadKey(true).KeyChar);
                            if (choice == 'y')
                            {
                                running = false;
                                break;
                            }
                            else if (choice == 'n')
                            {
                                break;
                            }
                        }
                        break;

                    case 'a':
                        if (state == (int)State.Lists)
                        {
                            display.InputRequest("Enter name of new list:");
                            string input = Console.ReadLine();
                            if (!String.IsNullOrEmpty(input))
                            {
                                taskmanager.AddTaskList(input);
                            }
                        }
                        else if (state == (int)State.Tasks)
                        {
                            display.InputRequest("Enter name of new task:");
                            string input = Console.ReadLine();
                            if (!String.IsNullOrEmpty(input))
                            {
                                taskmanager.AddTask(input, selectedList);
                            }
                        }
                        break;

                    case 'x':
                        if (state == (int)State.Lists)
                        {
                            display.InputRequest("Delete selected list? (y/n)");
                            switch (Console.ReadKey().KeyChar)
                            {
                                case 'y':
                                    taskmanager.DeleteTaskList(selectedList);
                                    break;
                                case 'n':
                                    break;
                            }
                        }
                        else if (state == (int)State.Tasks)
                        {
                            display.InputRequest("Delete selected task? (y/n)");
                            switch (Console.ReadKey().KeyChar)
                            {
                                case 'y':
                                    taskmanager.DeleteTask(selectedList, selectedTask);
                                    break;
                                case 'n':
                                    break;
                            }
                        }
                        break;

                    case (char)13: //enter
                        if (state == (int)State.Lists)
                        {
                            state = (int)State.Tasks;
                        }
                        else if (state == (int)State.Tasks)
                        {
                            state = (int)State.Taskview;
                        }
                        break;

                    case 'k':
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
                    case 'j':
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
                    case 't':
                        if (state == (int)State.Tasks)
                        {
                            display.InputRequest("Enter new title of list. Leave empty to cancel edit");
                            string input = Console.ReadLine();
                            if (!String.IsNullOrEmpty(input))
                            {
                                taskmanager.SetListTitle(selectedList, input);
                            }
                        }
                        if (state == (int)State.Taskview)
                        {
                            display.InputRequest("Enter new title of task. Leave empty to cancel edit");
                            string input = Console.ReadLine();
                            if (!String.IsNullOrEmpty(input))
                            {
                                taskmanager.SetTaskTitle(selectedList, selectedTask, input);
                            } 
                        }
                        break;
                    case 'c':
                        if (state == (int)State.Taskview)
                        {
                            taskmanager.ToggleTaskComplete(selectedList, selectedTask);
                        }
                        break;

                    case 'p':
                        if (state == (int)State.Taskview)
                        {
                            display.InputRequest("Enter new priority (1-3), leave empty to cancel:");
                            while (true)
                            {
                                string input = Console.ReadLine();
                                if (String.IsNullOrEmpty(input))
                                {
                                    break;
                                }
                                try
                                {
                                    taskmanager.SetTaskPriority(selectedList, selectedTask, Int32.Parse(input));
                                    break;
                                }
                                catch
                                {
                                    display.InputRequest("Priority needs to be within range 1-3");
                                }
                            }
                        }
                        break;

                    case 'b':
                        if (state > 1)
                        {
                            state >>= 1;
                        }
                        break;
                }
                taskmanager.ShutdownTaskManager();
            }
        }
        public enum State
        {
            Lists = 1,
            Tasks = 2,
            Taskview = 4,
        }
    }

}