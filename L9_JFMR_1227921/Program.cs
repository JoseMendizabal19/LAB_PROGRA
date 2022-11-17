using System;

namespace L9_JFMR_1227921
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            double libras,yenes, dolares,euros;
            Console.WriteLine("Ingresar valor de Libras a convertir");
            libras = double.Parse(Console.ReadLine());
            euros = libras * 0.81;
            Console.WriteLine("{0} Libras equivale a {1} euros",libras,euros);
            Console.ReadKey();
            
            Console.WriteLine("Ingresar valor de Yenes a convertir");
            yenes = double.Parse(Console.ReadLine());
            euros = yenes * 111;
            Console.WriteLine("{0} Yenes equivale a {1} euros", yenes, euros);
            Console.ReadKey();

            Console.WriteLine("Ingresar valor de Dolares a convertir");
            dolares = double.Parse(Console.ReadLine());
            euros = dolares * 1.33;
            Console.WriteLine("{0} Dolares equivale a {1} euros", dolares, euros);
            Console.ReadKey();

        }
    }
}
