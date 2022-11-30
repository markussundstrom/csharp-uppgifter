namespace To_Do
{
    public class TaskList
    {
        public string Name { get; set; }
        public List<Task> Tasks { get; set; }

        public TaskList()
        {
        }

        public TaskList(string name, List<Task> tasks)
        {
            Name = name;
            Tasks = tasks;
        }
    }
}