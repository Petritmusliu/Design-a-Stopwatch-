using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch=new Stopwatch();
            var state = false;

            while (true)
            {
                if (!state)
                    Console.WriteLine("Type s to Start,\nx to Stop\nr to Repeat\ne to Exit\n");

                var input = Console.ReadLine();

                if (input.ToLower().Equals("s"))
                {
                    stopWatch.Start();
                    Console.WriteLine("StopWatch has started'\nx to Stop\nr to Repet\nany other key to Exit\n");
                    state = true;
                }

                if(input.ToLower().Equals("x"))
                {
                    stopWatch.Stop();
                    Console.WriteLine("Time Span was-> "+stopWatch.GetInterval());
                    state = false;
                }

                if (input.ToLower().Equals("r"))
                {
                    state = false;
                    Console.WriteLine("StopWatch has been Restarted");
                 continue;   
                }

                if (!input.ToLower().Equals("s")&&!input.ToLower().Equals("x")&&!input.ToLower().Equals("r"))
                {
                    break;
                }
            }
        }
    }
}
