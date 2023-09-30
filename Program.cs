using System;

class Program
{
    static void Main(string[] args)
    {
        double a, b, c, x, F = 0;
        
        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        c = double.Parse(Console.ReadLine());
        Console.Write("x = ");
        x = double.Parse(Console.ReadLine());

        // 1 спосіб
        if (x < 0 && b != 0) {
            F = a - x / (10 + b);
        } 
        if (x > 0 && b == 0) {
            F = (x - a) / (x - c);
        }
        if(!(x < 0 && b != 0) && !(x > 0 && b == 0)) {
            F = 3 * x + (2.0 / c);
        }
        Console.WriteLine("1) F = " + F);

        // 2 спосіб
        if (x < 0 && b != 0) {
            F = a - x / (10 + b);
        }
        else
        {
            if (x > 0 && b == 0)
            {
                F = (x - a) / (x - c);
            }
            else
            {
                F = 3 * x + (2.0 / c);
            }
        }

        Console.WriteLine("2) F = " + F);
    }
}