using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
            
        {
            Console.WriteLine("hello github");
            
        }
        public static bool IsOdd(int n)
        {
            return false;
        }
        public static bool IsEven(int n)
        {
            return true;
        }


        //input : float x
        //output : a int that smallest but not smaller than X
        //idea : first change float x int o integer then ++1
        //      if x is a negative number than --1
        //      if x == n then return x
        public static int Ceil(float x)
        {
            int n = (int)x;
            if (x != 0)
            if(x > 0)
                n = n + 1;   
            return n;

        }

        
        public static int FLoor(double x)
        {
            int n = (int)x;
            if (x < 0)
            {
                if ( n != x)
                {
                    n = n - 1;
                }
            }       
            return n;
        }
    }
}
