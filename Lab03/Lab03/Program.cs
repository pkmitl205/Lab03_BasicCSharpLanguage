using System;
namespace variableProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            const double lightSpeed = 186000d;   // miles per second
            Console.WriteLine("Light speed = {0} Mile Per second", lightSpeed);
            const double mileTokm = 1.609344;
            Console.WriteLine("Light speed = {0} km Per second", lightSpeed * mileTokm);
            Console.WriteLine("");
            double result = Math.Pow(10, -9);
            double value1 = 6.685 * result;
            //Mercury
            const double SunTo_Mercury_Distance = 35983594.61;  // miles
            Console.WriteLine("SunTo_Mercury_Distance = {0} a.u.", SunTo_Mercury_Distance * value1);
            double SunTo_Mercury_TimeOfLight = SunTo_Mercury_Distance / lightSpeed; // miles 
            Console.WriteLine("SunTo_Mercury_TimeOfLight = {0} minutes", SunTo_Mercury_TimeOfLight / 60d);
            Console.WriteLine("");
            //Venus
            const double SunTo_Venus_Distance = 67232342.2;  // miles
            Console.WriteLine("SunTo_Venus_Distance = {0} a.u.", SunTo_Venus_Distance * value1);
            double SunTo_Venus_TimeOfLight = SunTo_Venus_Distance / lightSpeed; // miles
            Console.WriteLine("SunTo_Venus_TimeOfLight = {0} minutes", SunTo_Venus_TimeOfLight / 60d);
            Console.WriteLine("");
            //Earth
            const double SunTo_Earth_Distance = 92957101.6;  // miles
            Console.WriteLine("SunTo_Earth_Distance = {0} a.u.", SunTo_Earth_Distance * value1);
            double SunTo_Earth_TimeOfLight = SunTo_Earth_Distance / lightSpeed;  // miles
            Console.WriteLine("SunTo_Earth_TimeOfLight = {0} minutes", SunTo_Earth_TimeOfLight / 60d);
            Console.WriteLine("");
            //Mars
            const double SunTo_Mars_Distance = 141635305.74;  // miles
            Console.WriteLine("SunTo_Mars_Distance = {0} a.u.", SunTo_Mars_Distance * value1);
            double SunTo_Mars_TimeOfLight = SunTo_Mars_Distance / lightSpeed;  // miles
            Console.WriteLine("SunTo_Mars_TimeOfLight = {0} minutes", SunTo_Mars_TimeOfLight / 60d);
            Console.WriteLine("");
            //Jupiter
            const double SunTo_Jupiter_Distance = 483631690.43;  // miles
            Console.WriteLine("SunTo_Jupiter_Distance = {0} a.u.", SunTo_Jupiter_Distance * value1);
            double SunTo_Jupiter_TimeOfLight = SunTo_Jupiter_Distance / lightSpeed;  // miles
            Console.WriteLine("SunTo_Jupiter_TimeOfLight = {0} minutes", SunTo_Jupiter_TimeOfLight / 60d);
            Console.WriteLine("");
            //Uranus
            const double SunTo_Uranus_Distance = 1785540637.05;  // miles
            Console.WriteLine("SunTo_Uranus_Distance = {0} a.u.", SunTo_Uranus_Distance * value1);
            double SunTo_Uranus_TimeOfLight = SunTo_Uranus_Distance / lightSpeed;  // miles
            Console.WriteLine("SunTo_Uranus_TimeOfLight = {0} minutes", SunTo_Uranus_TimeOfLight / 60d);
            Console.WriteLine("");
            //Neptune
            const double SunTo_Neptune_Distance = 2796790871;  // miles
            Console.WriteLine("SunTo_Neptune_Distance = {0} a.u.", SunTo_Neptune_Distance * value1);
            double SunTo_Neptune_TimeOfLight = SunTo_Neptune_Distance / lightSpeed;  // miles
            Console.WriteLine("SunTo_Neptune_TimeOfLight = {0} minutes", SunTo_Neptune_TimeOfLight / 60d);
            Console.WriteLine("");
            //Pluto
            const double SunTo_Pluto_Distance = 3694609828.9;  // miles
            Console.WriteLine("SunTo_Pluto_Distance = {0} a.u.", SunTo_Pluto_Distance * value1);
            double SunTo_Pluto_TimeOfLight = SunTo_Pluto_Distance / lightSpeed;  // miles
            Console.WriteLine("SunTo_Pluto_TimeOfLight = {0} minutes", SunTo_Pluto_TimeOfLight / 60d);
            Console.WriteLine("");
        }
    }
}
