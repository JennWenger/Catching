﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catching
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("AN AVERAGE PROGRAM");
            Console.WriteLine("Instructions:");
            Console.WriteLine("1. Enter one number per line.");
            Console.WriteLine("2. Enter a blank line to average the numbers.");

            int count = 0;
            double sum = 0.0;
            string input = String.Empty;

            do
            {
                Console.Write("> ");
                input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                {
                    sum += Double.Parse(input);
                    count++;
                }

            } while (!String.IsNullOrWhiteSpace(input));

            double average = sum / count;
            Console.WriteLine("Average: {0}", average);
        }
    }
}