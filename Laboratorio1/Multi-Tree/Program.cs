﻿using System;

namespace Tree_Bib
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Ingrese el grado del Árbol Multicamino");
            var grado = Convert.ToInt32(Console.ReadLine());
            ArbolM<int> arbolitom = new ArbolM<int>(grado);

            //int[] values = {34, 56, 76, 93, 43, 79, 99, 64, 98, 70, 38, 92, 94, 27, 100, 150 };
            int[] values = { 915, 988, 142, 177, 996, 207, 446, 416, 721, 354, 272, 596, 395, 271, 583, 834, 628, 747, 722, 502, 523, 415, 707, 156, 141, 480, 298, 517, 516, 922, 933, 945, 885, 5, 777, 475, 431, 711, 137, 820, 192, 471, 112, 262, 71, 77, 825, 884, 6, 786 };


             for (int i = 0; i < values.Length; i++)
             {
                 arbolitom.Insertar(values[i]);     
             }
            

            Console.ReadKey();

        }
    }
}
