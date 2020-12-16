using System;
using FizzBuzz;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ////2147483647
            var proc = new DoFizzBuzz(214747, "fizz","buzz");
            var myList = proc.Exec();


            foreach (var items in myList)
            {
                Console.WriteLine(items);
            }
            
        }

    }
}
