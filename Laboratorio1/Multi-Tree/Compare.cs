using System;
using System.Text;

namespace Tree_Bib
{
    public class Compare
    {
        public int TamañoString(string s)
        {
            var texto = s;
            var u8 = Encoding.UTF8;
            var Result = u8.GetByteCount(texto);
            return Result;
        }
    }
}
