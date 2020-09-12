using System;
using System.Collections.Generic;
using System.Linq;
using Tree_Bib;
using API_Tree.Helper;

namespace API_Tree.Models
{
    public class Traversal : IComparable
    {
        public List<Movie> Recorrido(string tipo)
        {
            List<Movie> valor_Recorrido = new List<Movie>();
            switch (tipo)
            {
                case "postorden":
                    valor_Recorrido = Post_Orden(Data.Instance.full_Tree.Raiz, valor_Recorrido);
                    break;
                case "preorden":
                    valor_Recorrido = Pre_Orden(Data.Instance.full_Tree.Raiz, valor_Recorrido);
                    break;
                case "inorden":
                    valor_Recorrido = In_Orden(Data.Instance.full_Tree.Raiz, valor_Recorrido);
                    break;
            }
            return valor_Recorrido;
        }
        private List<Movie> Post_Orden(Nodo<Movie> Node, List<Movie> valor_Recorrido)
        {//Izquierda-Derecha-Raiz
            if (Node != null)
            {
                for (int i = 0; i < Data.grado - 1; i++)
                {
                    if (Node.Values.Count() > i + 1)
                    {
                        if (Node.Values[i + 1] != null)
                        {
                            if (Node.Values[i].CompareTo(Node.Values[i + 1]) == -1)
                            {
                                Post_Orden(Node.Children[i], valor_Recorrido);
                                //if (!valor_Recorrido.Contains(Node.Values[i]))
                                //{
                                //    valor_Recorrido.AddRange(Node.Values);
                                //}
                                foreach (var item in Node.Values)
                                {
                                    if (!valor_Recorrido.Contains(item))
                                    {
                                        valor_Recorrido.Add(item);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return valor_Recorrido;
        }
        private List<Movie> In_Orden(Nodo<Movie> Node, List<Movie> valor_Recorrido)
        {//Izquierda-Raiz-Derecha
            if (Node != null)
            {
                for (int i = 0; i < Data.grado - 1; i++)
                {
                    if (Node.Values.Count() > i + 1)
                    {
                        if (Node.Values[i + 1] != null)
                        {
                            if (Node.Values[i].CompareTo(Node.Values[i + 1]) == -1)
                            {
                                //if (!valor_Recorrido.Contains(Node.Values[i]))
                                //{
                                //    valor_Recorrido.AddRange(Node.Values);
                                //}
                                foreach (var item in Node.Values)
                                {
                                    if (!valor_Recorrido.Contains(item))
                                    {
                                        valor_Recorrido.Add(item);
                                    }
                                }
                            }
                            In_Orden(Node.Children[i], valor_Recorrido);
                        }
                    }
                }
            }
            return valor_Recorrido;
        }
        private List<Movie> Pre_Orden(Nodo<Movie> Node, List<Movie> valor_Recorrido)
        {//Raiz-Izquierda-Derecha
            if (Node != null)
            {
                for (int i = 0; i < Data.grado - 1; i++)
                {
                    if (Node.Values.Count() > i + 1)
                    {
                        if (Node.Values[i + 1] != null)
                        {
                            if (Node.Values[i].CompareTo(Node.Values[i + 1]) == -1)
                            {
                                Pre_Orden(Node.Children[i], valor_Recorrido);
                                //if (!valor_Recorrido.Contains(Node.Values[i]))
                                //{
                                //    valor_Recorrido.AddRange(Node.Values);
                                //}
                                foreach (var item in Node.Values)
                                {
                                    if (!valor_Recorrido.Contains(item))
                                    {
                                        valor_Recorrido.Add(item);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return valor_Recorrido;
        }
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
