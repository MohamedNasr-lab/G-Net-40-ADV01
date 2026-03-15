using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace t
{
    public class pair<TKey,Tvalue>
    {
        public static void swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;

        }

    }
}
