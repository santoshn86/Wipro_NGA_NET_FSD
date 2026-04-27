using System;

public class Delegates

{
    delegate int MathOperation(int a, int b);

    
    static int Add(int a, int b)
    {
        return a + b;
    }

   
    static int Subtract(int a, int b)
    {
        return a - b;
    }

    
    static int Multiply(int a, int b)
    {
        return a * b;
    }
    static void Main()
    {
        
        MathOperation op = Add;

        // 4. Invoke delegate
        int result1 = op(10, 5);
        Console.WriteLine("Addition Result: " + result1);

        // 5. Change delegate to Subtract
        op = Subtract;

        int result2 = op(10, 5);
        Console.WriteLine("Subtraction Result: " + result2);

        // (Extra) You can also test Multiply
        op = Multiply;

        int result3 = op(10, 5);
        Console.WriteLine("Multiplication Result: " + result3);
    }
}
