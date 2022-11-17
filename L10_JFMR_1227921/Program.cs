using System;

namespace L10_JFMR_1227921
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = "";
            string password = "";
            int cont = 1;


            while (cont <= 3)
            {
                Console.WriteLine("Login: intento# " + cont);
                Console.WriteLine("\nIntroduzca el nombre de Usuario");
                user = Console.ReadLine();
                Console.WriteLine("Ingrese su contraseña establecida");
                password = Console.ReadLine();

                if (Login(user, password) == false)
                {
                    cont++;
                    Console.WriteLine("\n Usuario y/o contraseña incorrectos");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Bienvenido!");
                    Console.ReadLine();
                    Environment.Exit(0);
                }


            }

          
        }

        public static bool Login(string user, string password)
        {
            if ((user == "usuario1") && (password == "asdasd"))
            {
                return true;
            }
            return false;
        } 
    }
}
