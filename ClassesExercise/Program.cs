using System;

namespace CSharpInter
{
    public class StopWatch
    {
        private DateTime _start;
        private DateTime _end;
        private bool _isRunning = false;

        public void StartWatch()
        {
            if (_isRunning)
            {
                Console.WriteLine("Clock is already running..");
                return;
            }
             _isRunning = true;
             _start= DateTime.Now;
            
        }
        public TimeSpan EndWatch()
        {
            if(!_isRunning)
            {
                Console.WriteLine("Start the stopwatch first..");
                return TimeSpan.Zero;
            }
            _isRunning= false;
            _end = DateTime.Now;
            return _end - _start;
        }


        public static void Ques1Sol()
        {
            StopWatch watch = new StopWatch();
            while (true)
            {

                Console.WriteLine("Enter start/stop/exit: ");
                string input = Console.ReadLine();

                if (input == "start")
                {
                    watch.StartWatch();
                    continue;
                }
                else if (input == "stop")
                {
                    TimeSpan duration = watch.EndWatch();
                    Console.WriteLine("Duration: " + duration);
                    continue;
                }
                else
                {
                    break;
                }

            }
        }
    }


    public class Post
    {
        private string _title;
        private string _description;
        private DateTime _posted;
        private int _vote;
        public Post(string title, string description, DateTime posted)
        {
            _title= title;
            _description= description;
            _posted = posted;
            _vote = 0;
        }
        public void Upvote()
        {
            Console.WriteLine("Upvoted!!");
            _vote++;
        }
        public void Downvote()
        {
            Console.WriteLine("Downvoted!!");
            _vote--;
        }
        public void getVote()
        {
            Console.WriteLine("Current vote: "+ _vote);
        }
    }
    
    class Oct10
    {
        static void Main(string[] args)
        {
            Post post= new Post("Classes Implemetation.","It comes under object oriented programming.", DateTime.Now);

            while (true)
            {
                Console.WriteLine("Enter upvote/downvote/view: ");
                string input=Console.ReadLine();

                if(input == null || input=="view")
                {
                    post.getVote();
                    break;
                }
                else if(input == "upvote")
                {
                    post.Upvote();
                    continue;
                }
                else
                {
                    post.Downvote();
                    continue;
                }
            }
            
           

        }




    }
}