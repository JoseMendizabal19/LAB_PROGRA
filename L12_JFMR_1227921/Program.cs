using System;

namespace L12_JFMR_1227921
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LAb_12!");

            pruebaVector pv = new pruebaVector();

            pv.Cargar();
            pv.Imprimir();
        }

        class pruebaVector
        {
            private int[] notas;
            public int suma = 0;
            public void Cargar()
            {
                notas = new int[15];
                for (int f=0; f<15; f++)

                {
                    Console.WriteLine("Ingresa una nota");
                    string linea;
                    linea = Console.ReadLine();
                    notas[f] = int.Parse(linea);
                    suma = suma + notas[f];
                }
            }
            
           public void Imprimir()
            {
                for (int f=0; f<15; f++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Se ingreso ");
                    Console.WriteLine(notas[f]);
                }
                Console.WriteLine("La suma es  : "+ suma);
                Console.ReadKey();
            }




        }







































    }
}
