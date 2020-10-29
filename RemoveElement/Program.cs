using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] num = { 3, 2, 2, 3 };
            int val = 3;

            int validsize = 0;
            for(int i =0;i < num.Length; i++)
            {
                if(num[i] != val)
                {
                    num[validsize] = num[i];
                    validsize++;
                }
            }
            Console.WriteLine(validsize);
            Console.ReadLine();

        }
    }
}
