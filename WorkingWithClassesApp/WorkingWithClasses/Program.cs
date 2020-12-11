using System;

namespace WorkingWithClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();
            stopwatch.Initiate();

            // StackOverflow Question

            var post = new Post();

            Console.WriteLine("Input a Title for your Post: ");
            post.Title = Console.ReadLine();

            Console.WriteLine("Description: ");
            post.Description = Console.ReadLine();
            post.CreationTime = DateTime.Now;

            post.DisplayPost();

            Console.WriteLine();

            post.UpvotePost();
            post.DownvotePost();
            post.UpvotePost();
            post.UpvotePost();

            post.DisplayPost();

        }
    }
}
