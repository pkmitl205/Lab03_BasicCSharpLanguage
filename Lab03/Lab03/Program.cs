using System;
public class intergerTest
{
    static void Main(string[] args)
    {
        float a = 10, b = 20, x = 5, y = 2;

        Console.WriteLine("a+b = {0}", a + b);
        Console.WriteLine("x-b = {0}", x - b);
        Console.WriteLine("x*b = {0}", x * b);
        Console.WriteLine("y/a = {0}", y / a);
        Console.WriteLine("b%y = {0}", b % y);
        Console.WriteLine("y+10%x = {0}", y + 10 % x);
        Console.WriteLine("a/3*5 = {0}", a / 3 * 5);
        Console.WriteLine("9/2*a = {0}", 9 / 2 * a);
        Console.WriteLine("y%8 = {0}", y % 8);
        Console.WriteLine("100*x+y%2-a = {0}", 100 * x + y % 2 - a);
    }
}
