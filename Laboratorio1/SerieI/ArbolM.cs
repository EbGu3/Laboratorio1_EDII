using System;
namespace SerieI
{
    public class ArbolM<T>
    {
        public int Grado { get; set; }
        public Nodo<int> Raiz { get; set; }

        public ArbolM(int grado)
        {
            this.Grado = grado;
            Raiz = null;
        }

        public void Insertar(int valor)
        {
            if(Raiz == null)
            {
                Raiz = new Nodo<int>(Grado);
                Raiz.CrearNodo(Grado, Raiz, valor);
                Console.WriteLine("Hola");
            }
        }
            

      

    }
}
