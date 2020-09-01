using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace SerieI
{
    public class Nodo<T> where T : IComparable<T>
    {


        protected List<T> Values { get; set; }
        protected T[] Children { get; set; }

        public Nodo(int grado)
        {

            Values = new List<T>();
            Children = new T[grado];
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
                Nodo.Values.Add(Valor);
                Nodo.Values.Sort();
                return Nodo;
            }
            else
            {

            }


            return Nodo;
        }

        public Nodo<T> EntreNodo(T ValorActual, Nodo<T> Nodo)
        {
            var i = 0;

            if (Nodo.Values[i] != null)
            {
                //-1 Significa que esta el valor
                if(Nodo.Values[i].CompareTo(ValorActual) == -1)
                {
                    
             
                    
                }
            }
            else
            {

            }

            return Nodo;

        }

        public int CompareTo([AllowNull] T other)
        {
            throw new NotImplementedException();
        }
    }
}
