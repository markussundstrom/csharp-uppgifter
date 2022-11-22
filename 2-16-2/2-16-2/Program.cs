namespace _2_16_2
{
    internal class Program
    {
        static void Main(string[] args) {
            bool running = true;
            Console.WriteLine("Type post title");
            Post myPost = new Post(Console.ReadLine());
            Console.WriteLine("Type post text");
            myPost.Description = Console.ReadLine();
            while (running) {
                Console.Clear();
                Console.WriteLine("---=({0})=---", myPost.Title);
                Console.WriteLine(myPost.Description);
                Console.WriteLine("Rating: {0}\tPosted: {1}", myPost.Votes, myPost.CreatedDate.ToString());
                Console.WriteLine("u: Voteup, d: Votedown, q: Quit");
                switch (Console.ReadKey(true).KeyChar) {
                    case 'u':
                        myPost.VoteUp();
                        break;
                    case 'd':
                        myPost.VoteDown();
                        break;
                    case 'q':
                        running = false;
                        break;
                    default:
                        break;
                }
            }

                    


        }
    }
}