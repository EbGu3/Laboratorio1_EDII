using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace SerieI
{
    public class Nodo<T> where T : IComparable<T>
    {


        public List<T> Values { get; set; }
        public Nodo<T>[] Children { get; set; }

        public Nodo(int grado)
        {

            Values = new List<T>();
            Children = new Nodo<T>[grado];
        }



        public Nodo<T> CrearNodo(int grado, Nodo<T> Nodo, T Valor)
        {

            if (Nodo == null)
            {
                Nodo = new Nodo<T>(grado);
                Nodo.Values.Add(Valor);
                return Nodo;
            }
            else if (Nodo.Values.Count < grado - 1)
            {
                if(Nodo.Values.Count == 0)
                {
                    Nodo.Values.Add(Valor);
                    Nodo.Values.Sort();
                    return Nodo;
                }
                else
                {
                    //Buscar Igualaciones en el nodo
                    //Agregar el nuevo valor al nodo
                    Nodo.Values.Sort();
                    return Nodo;
                }
            }
            else
            {
                EntreNodo(grado,Valor, Nodo);
            }


            return Nodo;
        }

        public Nodo<T> EntreNodo(int grado,T ValorActual, Nodo<T> Nodo)
        {
            int i = 0;

            //Comparar si el dato existe
            while(i < grado -1)
            {
                if (CompareToTamaño(Nodo.Values[i], ValorActual) != 0)
                {
                    if (CompareToTamaño(Nodo.Values[i], ValorActual) == 1)
                    {
                        i++;
                    }
                    else
                    {
                        Nodo<T> NodoH = new Nodo<T>(grado);
                        CrearNodo(grado, NodoH, ValorActual);
                        Nodo.Children[i] = NodoH;
                        return Nodo;
                    }

                }
                else { i++; }
            }
            


            return Nodo;

        }

        public int CompareToTamaño(T ValorNodo, T ValorActual)
        {
            var Resultado = 0;
            // 1 es mayor, -1 es menor, son iguales
            if(Convert.ToInt32(ValorActual) == Convert.ToInt32(ValorNodo))
            {
                Resultado = 0;
            }
            else if(Convert.ToInt32(ValorActual) > Convert.ToInt32(ValorNodo))
            {
                Resultado = 1; 
            }
            else
            {
                Resultado = -1;
            }
            
            return Resultado;

        }

    }
}
