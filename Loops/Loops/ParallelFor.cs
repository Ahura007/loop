using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Loops.Service;


namespace Loops.Loops
{
    public class ParallelFor
    {

        public static long Property(List<int> someList)
        {
            var recorder = Stopwatch.StartNew();
            Parallel.For(0, someList.Count,SomeService.ServiceTwo);
            recorder.Stop();
            return recorder.ElapsedMilliseconds;
        }

        public static long Variable(int count)
        {
            var recorder = Stopwatch.StartNew();
            Parallel.For(0, count, SomeService.ServiceTwo);
            recorder.Stop();
            return recorder.ElapsedMilliseconds;
        }
    }
}