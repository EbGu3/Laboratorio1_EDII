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
        public List<ArbolM<Movie>> Recorrido(string tipo)
        {
            List<ArbolM<Movie>> valor_Recorrido = new List<ArbolM<Movie>>();
            switch (tipo)
            {
                case "postorden":
                    valor_Recorrido = Post_Orden(Data.Instance.full_Tree);
                    break;
                case "preorden":
                    valor_Recorrido = Pre_Orden(Data.Instance.full_Tree);
                    break;
                case "inorden":
                    valor_Recorrido = In_Orden(Data.Instance.full_Tree);
                    break;
            }
            return valor_Recorrido;
        }
        private List<ArbolM<Movie>> Post_Orden(ArbolM<Movie> root)
        {
            List<ArbolM<Movie>> valor_Recorrido = new List<ArbolM<Movie>>();
            if (root != null)
            {

            }
            return valor_Recorrido;
        }
        private List<ArbolM<Movie>> In_Orden(ArbolM<Movie> root)
        {
            List<ArbolM<Movie>> valor_Recorrido = new List<ArbolM<Movie>>();
            if (root != null)
            {

            }
            return valor_Recorrido;
        }
        private List<ArbolM<Movie>> Pre_Orden(ArbolM<Movie> root)
        {
            List<ArbolM<Movie>> valor_Recorrido = new List<ArbolM<Movie>>();
            if (root != null)
            {

            }
            return valor_Recorrido;
        }
    }
}
