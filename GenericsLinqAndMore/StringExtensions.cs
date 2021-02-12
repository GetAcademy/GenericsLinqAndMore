using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsLinqAndMore
{
    static class StringExtensions
    {
        public static bool IsTerje(
            this string name)
        {
            return name == "Terje";
        }
    }
}
