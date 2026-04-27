using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Day_5
{
    class Delegates
    {
        
        delegate int MathOperation(int a, int b);

        
        public static int Add(int a, int b)
        {
            return a + b;
        }

        
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
