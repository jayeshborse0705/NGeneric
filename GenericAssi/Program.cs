﻿using System;

namespace GenericAssi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Find Max Number");
            int output = MaximumNumberCheck.MaximumIntegerNumber(11, 22, 45);
            Console.WriteLine(output);
            double output1 = MaximumNumberCheck.MaximumdoubleNumber(12.3, 13.5, 45.4);
            Console.WriteLine(output1);
        }


    }
}