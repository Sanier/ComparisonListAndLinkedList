using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ComparisonListAndLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText("C:\\Users\\sanie\\Desktop\\Text1.txt");  //изменять туть

            var list = new List<string>();
            var linkedList = new LinkedList<string>();

            var timer = new Stopwatch();
            timer.Start();
            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);
        }
    }
}
