using System;

namespace SerieI
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Ingrese el grado del Árbol Multicamino");
            var grado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese Un valor");
            var valor = Convert.ToInt32(Console.ReadLine());

            //Se instacia el arbol y se inserta
            ArbolM<int> arbolitom = new ArbolM<int>(grado);
            arbolitom.Insertar(valor);



        }
    }
}
