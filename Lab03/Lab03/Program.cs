using System;
namespace LAB03
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, lastname;
            Console.Write("Please enter Name : ");
            name = Console.ReadLine();
            Console.Write("Please enter Lastname : ");
            lastname = Console.ReadLine();
            Console.Write("Please enter ID : ");
            double var1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter GPA : ");
            double var2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("*********************");
            Console.WriteLine("Name : {0}", name);
            Console.WriteLine("Lastname : {0}", lastname);
            Console.WriteLine("ID : {0}", var1);
            Console.WriteLine("GPA : {0}", var2);
        }
    }
}
