using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            bool proceed = true;
            for (int i = 1; i < 4000000; i++)
            {
                int temp = fib(i);
                if (temp%2 == 0)
                {
                    if (temp < 4000000)
                    {
                        count += temp;
                        Console.WriteLine("Added: " + temp);
                    }
                    else
                        proceed = false;
                    
                }
                if (proceed == false)
                {
                    break;
                }
            }

            
            Console.WriteLine("Answer: "+count);
            
        }

        public static int fib(int n){
            if (n == 1||n==0)
            {
                return 1;
            }
            else
                return fib(n - 1) + fib(n - 2);
        }
    }
}
