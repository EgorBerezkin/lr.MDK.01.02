using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDelenie
{
    public class Calculator
    {

       public static double CalculeteDelenie(double a, double b)
       {
            double result = a / b;
            return result;
       }
    }
}
