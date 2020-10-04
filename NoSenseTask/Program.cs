using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace NoSenseTask
{
    class Program
    {   
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //If there are extra spaces between integers, Trim is needed 
            var list = input.Split(",")
                            .Select(i => int.Parse(i.Trim()));

            var list1 = list.Where(i => i % 2 == 1);
            Test(list1, 1);

            var list2 = list.Where(i => i % 2 == 0);
            Test(list2, 2);
            
            List<int> list3 = null;
            Test(list3, 3);


        }

        static void Test(IEnumerable<int> list, int testcase)
        {
            Console.WriteLine($"Test Case N{testcase}:");
            if (list != null)
            {
                foreach (var i in list)
                    Console.Write($"{i} ");
            }

            try
            {
                var rv = list.ThisDoesntMakeAnySense(p => p % 2 == 1, () => 777);
                Console.WriteLine($"=> {rv}");
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
