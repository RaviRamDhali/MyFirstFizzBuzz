using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //2147483647
            var proc = new FixxBuzz.DoFizzBuzz(200000, "fizz","buzz");
            var myList = proc.Exec();


            foreach (var items in myList)
            {
                Console.WriteLine(items);
            }
            
        }
    }
}
