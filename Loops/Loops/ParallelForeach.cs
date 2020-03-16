using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Loops.Service;


namespace Loops.Loops
{
    public class ParallelForEach
    {
        public static long Test(List<int> someList)
        {
            var recorder = Stopwatch.StartNew();
            Parallel.ForEach(someList, SomeService.ServiceTwo);
            recorder.Stop();
            return recorder.ElapsedMilliseconds;
        }
    }
}