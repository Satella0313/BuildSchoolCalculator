using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mylibrary
{
    public abstract class Math
    {
        public double x { get; set; }
        public double y { get; set; }
        public abstract double GetArea();
    }
    public class Add : Math
    {
        public override double GetArea()
        {
            return x + y;
        }
    }
    public class Minus : Math
    {
        public override double GetArea()
        {
            return x - y;
        }
    }
    public class Multiply : Math
    {
        public override double GetArea()
        {
            return x * y;
        }
    }
    public class Division : Math
    {
        public override double GetArea()
        {
            return x / y;
        }
    }
}
