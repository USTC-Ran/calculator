using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public double Add(double leftArg, double rightArg)
        {
            return leftArg + rightArg;
        }

        public double Subtract(double leftArg, double rightArg)
        {
            return leftArg - rightArg;
        }

        public double Multiply(double leftArg, double rightArg)
        {
            return leftArg * rightArg;
        }

        public double Divide(double leftArg, double rightArg)
        {
            if (Math.Abs(rightArg) < 10e-9)
                throw new DivideByZeroException(("Error: Division by zero was performed!"));
            return leftArg / rightArg;
        }
    }
}
