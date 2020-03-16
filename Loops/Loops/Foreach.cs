using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Loops.CustomForEach;
using Loops.Service;

namespace Loops.Loops
{
    public static class Foreach
    {
        public static long Test(List<int> someList)
        {
            var recorder = Stopwatch.StartNew();
            foreach (int item in someList)
            {
                SomeService.ServiceOne();
            }
            recorder.Stop();
            return recorder.ElapsedMilliseconds;
        }


        public static long BasicTestOne(List<int> someList)
        {
            var recorder = Stopwatch.StartNew();
            using (var enumerable = someList.GetEnumerator())
            {
                while (enumerable.MoveNext())
                {
                    int item = enumerable.Current;
                    SomeService.ServiceOne();
                }
            }
            recorder.Stop();
            return recorder.ElapsedMilliseconds;
        }


        public static long BasicTestTwo(List<int> someList)
        {
            var recorder = Stopwatch.StartNew();
            var enumerator = someList.GetEnumerator();
            using (var enumerable = enumerator)
            {
                while (enumerable.MoveNext())
                {
                    var item = enumerable.Current;
                    SomeService.ServiceOne();
                }
            }
            recorder.Stop();
            return recorder.ElapsedMilliseconds;
        }


    }


 

 
   
    }
 