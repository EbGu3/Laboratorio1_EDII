using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_Tree.Models;

namespace API_Tree.Helper
{
    public class Data
    {
        private static Data _instance = null;
        public static Data Instance
        {
            get
            {
                if (_instance == null) _instance = new Data();
                return _instance;
            }
        }
        //Add structures
    }
}
