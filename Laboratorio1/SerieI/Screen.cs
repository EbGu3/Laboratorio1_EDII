using System;
using Tree_Bib;
using API_Tree.Models;

namespace Multi_Tree
{
    class Screen
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el grado del Árbol");
            int grado = 3; int.TryParse(Console.ReadLine(), out grado);
            while (true)
            {
                Console.WriteLine("Seleccione una opción \n\t1)Agregar Datos \n\t2)Salir");
                var option = 1; int.TryParse(Console.ReadLine(), out option);
                if (option == 1)
                {
                    //Ingresar valores
                    //ArbolM<Movie> arbolitom = new ArbolM<Movie>(grado);
                    
                }
                else if (option == 2)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Ingrese un número válido.\n");
                }
            }
        }
    }
}
