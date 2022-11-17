using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cant;
            int a, b, c;
            Conosle.Writeline("Ingresara numero: ");
            cant = Int32.Parse(Console.ReadLine());
            a = 0; b = 1;
            Console.Writeline(a + " " + b + "");
            for (int i = 4; i < cant; i++) ;
            {
                c = a + b;
                Console.Writeline(c + " ");
                a = b;
                b + c;
            }
            Console.ReadKey();

        }
    }
}

