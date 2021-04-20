using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    class HttpCookie
    {
        // hash table makes searches really fast to look up an item by its key

        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }
        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();                         
        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}
