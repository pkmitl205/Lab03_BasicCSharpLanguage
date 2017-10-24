
using System;
namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please enter Number : ");
            int var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number : {0}", var1);
            Random random = new Random();
            int randomNumber = random.Next(0, 9);
            Console.WriteLine("RandomNumber : {0}", randomNumber);

            bool a = (var1 < randomNumber);
            Console.WriteLine("{1} < {2} = {0}", a, var1, randomNumber);
        }
    }
}
