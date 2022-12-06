﻿namespace To_Do
{
    public class Task
    {
        public string Title { get; set; }
        public bool Completed { get; set; }
        public int Priority { get; set; }
        public List<Subtask> Subtasks { get; set; }

        public Task()
        {
            //Priority = 3;
            Subtasks = new List<Subtask>();
        }

        public Task(string title, bool completed)
        {
            Title = title;
            Completed = completed;
            Priority = 3;
            Subtasks = new List<Subtask>();
        }

        public Task(string title, bool completed, int priority) : this(title, completed)
        {
            Priority = priority;
        }

        public void SetPriority(int pri)
        {
            if (1 > pri || pri > 3)
            {
                throw new ArgumentOutOfRangeException();
            }
            Priority = pri;
        }

        public void ToggleCompleted()
        {
            if (Subtasks.Count > 0)
            {
                throw new InvalidOperationException();
            }
            Completed = !Completed;
        }

        public void AddSubtask(string name)
        {
            Subtasks.Add(new Subtask(name));
            Completed = false;
        }

        public void ToggleSubtaskCompleted(int subtaskIndex)
        {
            Subtasks[subtaskIndex].Completed = !Subtasks[subtaskIndex].Completed;
            if (Subtasks.Any(st => !st.Completed))
            {
                Completed = false;
            }
            else
            {
                Completed = true;
            }
        }

    }
}