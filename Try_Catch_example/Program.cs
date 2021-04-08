﻿using System;

namespace Try_Catch_example
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    int[] myNumbers = { 1, 2, 3 };
            //    Console.WriteLine(myNumbers[10]);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }
        }
    }
}
