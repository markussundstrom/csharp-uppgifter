namespace To_Do
{
    public class Task
    {
        public string Title { get; set; }
        public bool Completed { get; set; }
        public int Priority { get; set; }

        public Task()
        {
            //Priority = 3;
        }

        public Task(string title, bool completed)
        {
            Title = title;
            Completed = completed;
            Priority = 3;
        }

        public Task(string title, bool completed, int priority) : this(title, completed)
        {
            Priority = priority;
        }

        public void SetPriority(int pri)
        {
            if (pri < 1 || pri > 3)
            {
                throw new ArgumentOutOfRangeException();
            }
            Priority = pri;
        }
    }
}