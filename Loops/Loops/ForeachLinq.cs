
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Loops.Service;


namespace Loops.Loops
{
    public class ForeachLinq
    {

        public static long Test(List<int> someList)
        {
            var recorder = Stopwatch.StartNew();
            someList.ForEach(SomeService.ServiceTwo);
            recorder.Stop();
            return recorder.ElapsedMilliseconds;
        }




        public static long BasicForEach(List<int> action)
        {
            var recorder = Stopwatch.StartNew();
            for (int index = 0; index < action.Count; index++)
            {
                int item = action[index];
                SomeService.ServiceOne();
            }
            recorder.Stop();
            return recorder.ElapsedMilliseconds;
        }


    }
}