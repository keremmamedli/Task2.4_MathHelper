using Code_Academy_Task_2._4__MathHelper_;
using System;

namespace Code_Academy_Task_2._4__MathHelper_
{
    public class MathHelper
    {
        public int PrintValue(int a, int b)
        {
            return a + b;
        }

        public int PrintValue(bool a)
        {
            if(a = default)
            {
                return 0;

            }
            else
            {
                return 1;
            }
           
        }

        public void PrintValue(string a, string b)
        {
            Console.WriteLine("Third Condition (Connect strings) is: " + a + b);
        }

        public int PrintValue(int a, int b, int c)
        {
            return a * b * c;
        }
    }
}

internal class Program
    {
        static void Main(string[] args)
        {
        var mathHelper = new MathHelper(); 
        
        
        int res1 = mathHelper.PrintValue(1, 2);
        Console.WriteLine("First Condition (sum of integers) is: " + res1);

        int res2 = mathHelper.PrintValue(true);
        Console.WriteLine("Second Condition (boolean to integer) is: " + res2);

        mathHelper.PrintValue("Donald" , "Trump");

        int res4 = mathHelper.PrintValue(2 ,3 ,4);
        Console.WriteLine("Fourth Condition (Multiply three integer) is: " + res4);
        }
    }

