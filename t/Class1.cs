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
        public static T FindMax<T>(T a, T b) where T : IComparable<T>
        {
            if (a.CompareTo(b) > 0)
                return a;
            else
                return b;
        }

    }
}
