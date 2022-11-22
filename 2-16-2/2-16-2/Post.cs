namespace _2_16_2
{
    public class Post
    {
        public String Title { get; set; }
        public String Description { get; set; }
        public readonly DateTime CreatedDate = DateTime.Now;
        public int Votes { get; private set; }

        public Post(string createdtitle) {
            Title = createdtitle;
        }

        public void VoteUp() {
            Votes++;
        }
        public void VoteDown() {
            Votes--;
        }
    }
}