namespace _2_39_1
{
    internal class Program
    {
        static void Main(string[] args) {
            Workflow workflow = new Workflow();
            WorkflowEngine engine = new WorkflowEngine(workflow);

            workflow.Add(new EMailSender());
            workflow.Add(new VideoStatusChanger());
            workflow.Add(new CloudUploader());
            workflow.Add(new WebServiceCaller());

            engine.Run();
        }
    }
}