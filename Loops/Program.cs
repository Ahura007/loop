using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loops.CustomForEach;
using Loops.Loops;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            var someData = Enumerable.Range(0, 1000000000).ToList();
            StringBuilder sb = new StringBuilder();

            sb.Append("for Property             " + For.Property(someData) + Environment.NewLine);
            sb.Append("for Variable             " + For.Variable(someData.Count) + Environment.NewLine);
                                                
            sb.Append("parallel For Property    " + ParallelFor.Property(someData) + Environment.NewLine);
            sb.Append("parallel For Variable    " + ParallelFor.Variable(someData.Count) + Environment.NewLine);
                                                
            sb.Append("while Variable           " + While.Variable(someData.Count) + Environment.NewLine);
            sb.Append("while Property           " + While.Property(someData) + Environment.NewLine);
                                                
            sb.Append("do While Variable        " + DoWhile.Variable(someData.Count) + Environment.NewLine);
            sb.Append("do While Property        " + DoWhile.Property(someData) + Environment.NewLine);
                                                
            sb.Append("foreach A                " + Foreach.Test(someData) + Environment.NewLine);
            sb.Append("foreach B                " + Foreach.BasicTestOne(someData) + Environment.NewLine);
            sb.Append("foreach C                " + Foreach.BasicTestTwo(someData) + Environment.NewLine);
                                                
            sb.Append("parallel Foreach         " + ParallelForEach.Test(someData) + Environment.NewLine);
                                                
            sb.Append("foreach Linq A           " + ForeachLinq.Test(someData) + Environment.NewLine);
            sb.Append("foreach Linq B           " + ForeachLinq.BasicForEach(someData) + Environment.NewLine);


            System.IO.File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\loop.txt", sb.ToString());



            //set break point in CustomEnumerator method and debug
            var list = new CustomEnumerator();
            foreach (Person item in list)
            {

            }


            Console.ReadLine();
        }
    }
}
