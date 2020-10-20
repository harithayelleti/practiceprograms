﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare the array of 5 elements
            int[][] jaggedarray = new int[5][];

            jaggedarray[0] = new int[4] { 3, 4, 5, 6 };
            jaggedarray[1] = new int[4] { 4, 5, 6, 7 };
            jaggedarray[2] = new int[2] { 5, 6 };
            jaggedarray[3] = new int[6] { 1, 9, 3, 4, 5, 6 };
            jaggedarray[4] = new int[5] { 7, 6, 2, 1, 78 };

            for (int i = 0; i < jaggedarray.Length; i++)
            {
                Console.WriteLine("Elements of ({0}):", i);
                for (int j = 0; j < jaggedarray[i].Length; j++)
                {
                    Console.WriteLine(jaggedarray[i][j] + "\t");
                }

            }
            Console.ReadLine();



        }
    }
}

