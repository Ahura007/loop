using System.Collections.Generic;
using System.Diagnostics;
using Loops.Service;

namespace Loops.Loops
{
    public class DoWhile
    {
        public static long Property(List<int> someList)
        {
            var recorder = Stopwatch.StartNew();
            int counter = 0;
            do
            {
                counter++;
                SomeService.ServiceOne();
            } while (counter < someList.Count);
            recorder.Stop();
            return recorder.ElapsedMilliseconds;
        }

        public static long Variable(int count )
        {
            var recorder = Stopwatch.StartNew();
            int counter = 0;
            do
            {
                counter++;
                SomeService.ServiceOne();
            } 
            while (counter < count);
            recorder.Stop();
            return recorder.ElapsedMilliseconds;
        }
    }
}