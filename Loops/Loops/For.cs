using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using Loops.Service;

namespace Loops.Loops
{
    public static class For
    {
        public static long Property(List<int> someList)
        {
            var recorder = Stopwatch.StartNew();
            for (int i = 0; i < someList.Count; i++)
            {
                SomeService.ServiceOne();
            }

            recorder.Stop();
            return recorder.ElapsedMilliseconds;
        }

        public static long Variable(int count)
        {
            var recorder = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                SomeService.ServiceOne();
            }
            recorder.Stop();
            return recorder.ElapsedMilliseconds;
        }
    }
}