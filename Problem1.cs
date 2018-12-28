//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            int num = 1000;
            int count=0;
            for(int i=0;i<1000;i++)
            {
                if (i%3==0 || i%5==0)
                {
                    count+=i;
                    System.Console.WriteLine(i);
                }
                
            }
            System.Console.WriteLine(count);
        }
    }
}