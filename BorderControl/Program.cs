using System;
using System.Collections.Generic;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            var list = new List<string>();

            while(input[0] != "End")
            {
                if(input.Length == 2)
                {
                    list.Add(input[1]);
                }
                else
                {
                    list.Add(input[2]);
                }

                input = Console.ReadLine().Split();
            }
            string finalId = Console.ReadLine();
            list = list.FindAll(x => x.EndsWith(finalId));

            foreach (var el  in list)
            {
                Console.WriteLine(el);
            }
            


        }
    }
}
