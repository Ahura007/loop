using System.Collections.Generic;
using System.Diagnostics;
using Loops.Service;

namespace Loops.Loops
{
    public class While
    {
        public static long Property(List<int> someList)
        {
            var recorder = Stopwatch.StartNew();
            int counter = 0;

            while (counter < someList.Count)
            {
                counter++;
                SomeService.ServiceOne();
            }
            recorder.Stop();
            return recorder.ElapsedMilliseconds;
        }

        public static long Variable(int count)
        {
            var recorder = Stopwatch.StartNew();
            int counter = 0;

            while (counter < count)
            {
                counter++;
                SomeService.ServiceOne();
            }
            recorder.Stop();
            return recorder.ElapsedMilliseconds;
        }
    }
}