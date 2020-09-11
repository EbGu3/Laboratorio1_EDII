using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tree_Bib;
using API_Tree.Helper;

namespace API_Tree.Models
{
    public class Traversal
    {
        public List<Nodo<Movie>> Recorrido(string tipo)
        {
            List<Nodo<Movie>> valor_Recorrido = new List<Nodo<Movie>>();
            var nodoActu = Data.Instance.full_Tree.Raiz;
            switch (tipo)
            {
                case "postorden":
                    valor_Recorrido = Post_Orden(Data.Instance.full_Tree.Raiz);
                    break;
                case "preorden":
                    valor_Recorrido = Pre_Orden(Data.Instance.full_Tree.Raiz);
                    break;
                case "inorden":
                    valor_Recorrido = In_Orden(Data.Instance.full_Tree.Raiz);
                    break;
            }
            return valor_Recorrido;
        }
        private List<Nodo<Movie>> Post_Orden(Nodo<Movie> Node)
        {//Izquierda-Derecha-Raiz
            List<Nodo<Movie>> valor_Recorrido = new List<Nodo<Movie>>();
            if (Node != null)
            {

            }
            return valor_Recorrido;
        }
        private List<Nodo<Movie>> In_Orden(Nodo<Movie> Node)
        {//Izquierda-Raiz-Derecha
            List<Nodo<Movie>> valor_Recorrido = new List<Nodo<Movie>>();
            if (Node != null)
            {

            }
            return valor_Recorrido;
        }
        private List<Nodo<Movie>> Pre_Orden(Nodo<Movie> Node)
        {//Raiz-Izquierda-Derecha
            List<Nodo<Movie>> valor_Recorrido = new List<Nodo<Movie>>();
            if (Node != null)
            {

            }
            return valor_Recorrido;
        }
    }
}
