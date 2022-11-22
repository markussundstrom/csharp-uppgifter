namespace _2_39_1
{
    public class WorkflowEngine
    {
        private readonly Workflow _activities;

        public WorkflowEngine(Workflow activities) {
            _activities = activities;
        }

        public void Run() {
            foreach (var activity in _activities) {
                activity.Execute();
            }
        }
    }
}