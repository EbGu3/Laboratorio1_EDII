using System;

namespace SerieI
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            Console.WriteLine("Ingrese el grado del Árbol Multicamino");
            var grado = Convert.ToInt32(Console.ReadLine());


            var respuesta = 0;
            //Se instacia el arbol y se inserta
            ArbolM<int> arbolitom = new ArbolM<int>(grado);

            int[] values = {34, 56, 76, 93, 43, 79, 99, 64, 98, 70, 38, 92, 94, 27, 100, 150 };

            for (int i = 0; i < values.Length; i++)
            {
                arbolitom.Insertar(values[i]);
                
            }

/*
            while (respuesta != 2)
            {

                Console.WriteLine("Ingrese Un valor");
                var valor = Convert.ToInt32(Console.ReadLine());


                arbolitom.Insertar(valor);

               Console.WriteLine("¿Desea ingresar otro valor?, Si(1), No(2)");
                respuesta = Convert.ToInt32(Console.ReadLine());
            }
*/
        }
    }
}
