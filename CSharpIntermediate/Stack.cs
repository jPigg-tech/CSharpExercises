using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    class Stack
    {
        private readonly List<object> objs = new List<object>();


        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new InvalidOperationException();
            }
            objs.Add(obj);

        }

        public object Pop()
        {
            var popObj = new object();
            if (objs.Count == 0)
            {
                throw new InvalidOperationException();
            }

            for (int i = objs.Count - 1; i >= 0; i--)
            {
                popObj = objs[i];
                objs.Remove(objs[i]);
                return popObj;
            }

            return popObj;
        }

        public void Clear()
        {
            if (objs.Count == 0)
            {
                Console.WriteLine("Stack is clear.");
            }

            for (int i = objs.Count - 1; i >= 0; i--)
            {
                objs.Remove(objs[i]);
            }
        }
    }
}
