using System.Diagnostics.Contracts;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class MyMath
    {
        public static int Sum(int a, int b)
        {
            // math.abs -> valeur negatif non traitée -->  (-5) = 5
            return Math.Abs(a) + Math.Abs(b);
        }
    }
}
