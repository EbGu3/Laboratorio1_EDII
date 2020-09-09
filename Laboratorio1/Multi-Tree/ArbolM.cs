using System;

namespace Tree_Bib
{
    public class ArbolM<T> where T : IComparable
    {
        public int Grado { get; set; }
        private Nodo<T> Raiz { get; set; }

        public ArbolM(int grado)
        {
            this.Grado = grado;
        }

        public void Insertar(T value)
        {
            if (Raiz == null)
            {
                Raiz = new Nodo<T>(Grado);
                Raiz.CrearNodo(Grado, Raiz, value);
            }
            else
            {
                Raiz.CrearNodo(Grado, Raiz, value);
            }
        }
    }
}
