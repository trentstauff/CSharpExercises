using System;

namespace WorkingWithClasses
{

    /*

    Exercise 1: Design a StopwatchDesign a class called Stopwatch. 
    --------------------------------------------------------------
    The job of this class is to simulate a stopwatch. 

    It should provide two methods: Start and Stop. 

    We call the start method first, and the stop method next. 

    Then we ask the stopwatch about the duration between start and stop. 
    Duration should be a value in TimeSpan. Display the duration on the console. 
    We should also be able to use a stopwatch multiple times. 
    So we may start and stop it and then start and stop it again. 
    Make sure the duration value each time is calculated properly. 
    We should not be able to start a stopwatch twice in a row 
    (because that may overwrite the initial start time). 
    So the class should throw an InvalidOperationException if its started twice.

    */

    class StopWatch
    {
        // I have decided to take things further.
        // Instead, we instantiate and start a stopwatch upon runtime,
        // allowing a smoother console experience to stop said watch.
        // Since the Start + Stop methods are only called in here,
        // we can make those private.
        // This also allows for a much safer operation, as the user
        // cannot start and stop watches when they are unavailable to do so.

        private DateTime _time;
        private TimeSpan _totalTime;

        public void Initiate()
        {
            Start();

            while (true)
            {
                Console.WriteLine("Type \"stop\" to stop the watch.");
                if (Console.ReadLine() == "stop")
                {
                    Stop();
                    break;
                }
            }
        }

        private void Start()
        {
            _time = DateTime.Now;
        }

        private void Stop()
        {
            _totalTime = DateTime.Now - _time;
            Console.WriteLine("Total time: " + _totalTime);
            _totalTime = TimeSpan.Zero;
        }
    }
}