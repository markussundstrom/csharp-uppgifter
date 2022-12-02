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
                        display.Help = "Keys: a: add task, x: delete task, t: edit list title, <Enter>: view list, j/k: Change selection, b: go back";
                        display.DrawScreen();
                        display.RenderTasks(list, selectedTask);
                        break;

                    case (int)State.Taskview:
                        Task task = taskmanager.GetTask(selectedList, selectedTask);
                        display.Context = $"Viewing task \"{task.Title}\"";
                        display.Help = "Keys: t: edit title, c: toggle complete, p: change priority, b: go back";
                        display.DrawScreen();
                        display.RenderTaskview(task);
                        break;
                }

                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'q':
                        if (state == (int)State.Lists)
                        {
                            display.InputRequest("Do you want to quit? (y/n)");
                            if (GetConfirmation())
                            {
                                running = false;
                            }
                        }
                        break;

                    case 'a':
                        string input = "";
                        if (state == (int)State.Lists)
                        {
                            display.InputRequest("Enter name of new list:");
                            input = Console.ReadLine();
                            if (!String.IsNullOrEmpty(input))
                            {
                                taskmanager.AddTaskList(input);
                            }
                        }
                        else if (state == (int)State.Tasks)
                        {
                            display.InputRequest("Enter name of new task:");
                            input = Console.ReadLine();
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
                            if (GetConfirmation())
                            {
                                taskmanager.DeleteTaskList(selectedList);
                            } 
                        }
                        else if (state == (int)State.Tasks)
                        {
                            display.InputRequest("Delete selected task? (y/n)");
                            if (GetConfirmation())
                            {
                                taskmanager.DeleteTask(selectedList, selectedTask);
                            }
                        }
                        break;

                    case (char)13: //enter
                        if (state < 4)
                        {
                            state <<= 1;
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
                        string editing = "";
                        if (state == (int)State.Tasks)
                        {
                            editing = "list";
                        }
                        else if (state == (int)State.Taskview)
                        {
                            editing = "task";
                        }
                        else
                        {
                            break;
                        }
                        display.InputRequest($"Enter new title of {editing}. Leave empty to cancel edit");
                        string titleInput = Console.ReadLine();
                        if (!String.IsNullOrEmpty(titleInput))
                        {
                            display.InputRequest($"Change title of {editing} to {titleInput}? (y/n)");
                            if (GetConfirmation())
                            {
                                if (state == (int)State.Tasks)
                                {
                                    taskmanager.SetListTitle(selectedList, titleInput);
                                }
                                else if (state == (int)State.Taskview)
                                {
                                    taskmanager.SetTaskTitle(selectedList, selectedTask, titleInput);
                                }
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
                                string prioInput = Console.ReadLine();
                                if (String.IsNullOrEmpty(prioInput))
                                {
                                    break;
                                }
                                try
                                {
                                    taskmanager.SetTaskPriority(selectedList, selectedTask, Int32.Parse(prioInput));
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

        public static bool GetConfirmation()
        {
            Console.CursorVisible = false;
            while (true)
            {
                char choice = (Console.ReadKey(true).KeyChar);
                if (choice == 'y')
                {
                    return true;
                }
                else if (choice == 'n')
                {
                    return false;
                }
            }
        }
    }

}