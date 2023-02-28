using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using System;
namespace OperatorExercise
{
    public class Program
    {


        public static double Area(double radius)
        {
            return Math.PI * radius * radius;
        }
        static void Main(string[] args)
        {
           

            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            }

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            Console.WriteLine($"The area of the circle with radius {radius} is {Area(radius)}");
      
        }
    }
}





