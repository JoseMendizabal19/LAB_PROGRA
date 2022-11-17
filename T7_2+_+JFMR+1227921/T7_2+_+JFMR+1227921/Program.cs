using System;

namespace T7_2___JFMR_1227921
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cant;
            int a, b, c;
            Console.WriteLine("Ingresar número: ");
            cant = Int32.Parse(Console.ReadLine());
            a = 0; b = 1;
            Console.Write(a + " " + b + " ");
            for (int k = 3; k <= cant; k++) 
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            Console.ReadKey();
        }
    }
}
