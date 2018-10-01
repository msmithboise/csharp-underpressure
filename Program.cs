using System;
using csunderpressure.Models;

namespace csunderpressure
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine(Utils.DoubleInteger(5));
            System.Console.WriteLine(Utils.IsNumberEven(10));
            System.Console.WriteLine(Utils.FileExtension("3.txt"));

            int[] ints = new int[5] { 3, 5, 48, 158, 2 };
            System.Console.WriteLine(Utils.SumAllInts(ints));

            string[] testStr = "the quick brown fox jumped over the slow lazy dog".Split(" ");
            System.Console.WriteLine(Utils.LongestString(testStr));









        }


    }
}

