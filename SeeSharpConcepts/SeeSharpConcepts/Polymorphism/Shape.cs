using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Shape
    {
        public virtual  void Draw()
        {
            Console.WriteLine("This will be Overriden by inheriting Classes");
        }
    }
}
