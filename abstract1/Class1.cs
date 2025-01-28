using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACT1.abstract1
{
    internal abstract class Class_Maths
    {
        public decimal parameter1 { get; set; }
        public decimal parameter2 { get; set; }
        public abstract decimal Add(int parameter1, int parameter2);
        public abstract decimal Subtract(int parameter1, int parameter2);
        public abstract decimal Multiply(int parameter1, int parameter2);
        public abstract decimal Divide(int parameter1, int parameter2);
    }
    class Calculator_maths : Class_Maths
    {
        public override decimal Add(int parameter1, int parameter2)
        {
           return  parameter1+parameter2;
        }

        public override decimal Divide(int parameter1, int parameter2)
        {
            return parameter1 / parameter2;
        }

        public override decimal Multiply(int parameter1, int parameter2)
        {
            return parameter1 * parameter2;
        }

        public override decimal Subtract(int parameter1, int parameter2)
        {
            return -parameter1 - parameter2;
        }
    }
    static class Math1
    {
        public static decimal parameter1 { get; set; }
        public static decimal parameter2 { get; set; }
        public static decimal Add(int parameter1, int parameter2)
        {
            return parameter1 + parameter2;
        }
        public static decimal Subtract(int parameter1, int parameter2)
        {
            return parameter1 - parameter2;
        }
        public static decimal Multiply(int parameter1, int parameter2)
        {
            return parameter1 * parameter2;
        }
        public static decimal Divide(int parameter1, int parameter2)
        {
            return parameter1 / parameter2;
        }

    }
}
