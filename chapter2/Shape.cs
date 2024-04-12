using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter2
{
    abstract class Shape
    {
        public string Name { get; set; }

        // non-abstract method
        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a  {Name}");
        }

        public abstract double Area();


    }
}
