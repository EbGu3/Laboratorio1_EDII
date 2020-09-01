using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio1.Models
{
    public class Value : IComparable
    {
        public string name { get; set; }
        public int year { get; set; }
        public string directed_by { get; set; }
        public string stars { get; set; }
        public bool genere { get; set; }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
