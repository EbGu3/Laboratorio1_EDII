using System;
using System.Text;

namespace SerieI
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
