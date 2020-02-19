using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evennumbers
{
    class Program
    {
        public static void even(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;

                }
            }
                Console.WriteLine(sum);
            
        }
        static void Main(string[] args)
        {
           
            int[] value= new int[100];
            Console.WriteLine("enter the numbers");
            for (int i = 0; i < 5; i++)
            {
                value[i] = int.Parse(Console.ReadLine());

            }
            even(value);
        }
    }
}
