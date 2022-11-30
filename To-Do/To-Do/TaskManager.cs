using System.Text.Json;
using System.Text.Json.Serialization;

namespace To_Do
{
    public class TaskManager
    {
        private List<TaskList> _lists;
        private FileOps _file;

        public TaskManager()
        {
            _file = new FileOps();
            _lists = new List<TaskList>();
            //Console.WriteLine(_file.GetTaskFileContent());
            string json = _file.GetTaskFileContent();
            _lists.AddRange(JsonSerializer.Deserialize<List<TaskList>>(json, 
                            new JsonSerializerOptions() {PropertyNameCaseInsensitive=true, WriteIndented=true }));
            Console.WriteLine(_lists.ToString());
        }

        public List<TaskList> GetLists()
        {
            return (List<TaskList>)_lists;
        }

        public TaskList GetTaskList(int index)
        {
            return _lists[index];
        }

        public void AddTaskList(string name)
        {
            _lists.Add(new TaskList(name, new List<Task>()));
        }

        public void AddTask(string name, int listIndex)
        {
            _lists[listIndex].Tasks.Add(new Task(name, false));
        }

    }

}