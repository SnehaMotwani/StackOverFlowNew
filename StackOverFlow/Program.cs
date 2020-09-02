using System;

namespace StackOverFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post = new Post();
            post.CreatePost("First Post", "Some Description goes here");
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.UpVote();
            post.DownVote();
            post.DownVote();
            post.UpVote();
            post.DisplayPost();

        }
        public class Post
        {
            private string title;
            private string description;
            private DateTime dateCreated;

            private int upVote;
            private int downVote;

            public void CreatePost(string aTitle, string aDescription)
            {
                Post post = new Post();
                title = aTitle;
                description = aDescription;
                dateCreated = DateTime.Now;
            }
            public void DisplayPost()
            {
                Console.WriteLine("Title: " + title);
                Console.WriteLine("Description: " + description);
                Console.WriteLine("DateCreated: " + dateCreated);
                Console.WriteLine("Total Vote Count: " + GetCurrentVoteCount());
            }
            public void UpVote()
            {
                upVote++;
             
            }
            public void DownVote()
            {
                downVote++;
            }
            public int GetCurrentVoteCount()
            {
                int totalCount = upVote - downVote;
                return totalCount;
            }
        }
    }
    
}
