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
        public TKey Key { get; set; }
        public Tvalue Value { get; set; }
        public pair(TKey _key, Tvalue _value)
        {
            Key = _key;
            Value = _value;
        }

    }
}
