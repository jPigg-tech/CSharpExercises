using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {

        }        

        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated.");
        }
    }
}
