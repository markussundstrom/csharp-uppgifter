namespace To_Do
{
    public class Task
    {
        public Task()
        {
        }

        public Task(string title, bool completed)
        {
            Title = title;
            Completed = completed;
        }

        public string Title { get; set; }
        public bool Completed { get; set; }
    }
}