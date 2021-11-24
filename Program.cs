using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ComparisonListAndLinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            var timer = new Stopwatch();

            timer.Start();
            var list = new List<string>();     
            list.Add(File.ReadAllText("C:\\Users\\sanie\\Desktop\\Text1.txt"));
            timer.Stop();
            Console.WriteLine("List: " + timer.ElapsedMilliseconds);
            timer.Reset();

            timer.Start();
            var linkedList = new LinkedList<string>();
            linkedList.AddFirst(File.ReadAllText("C:\\Users\\sanie\\Desktop\\Text1.txt"));
            timer.Stop();
            Console.WriteLine("LinkedList: " + timer.ElapsedMilliseconds);
            timer.Reset();
        }
    }
}
