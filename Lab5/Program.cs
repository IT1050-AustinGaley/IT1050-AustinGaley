using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab5
{
    class Progam
    {
        static void Main(string[] args) //static
        {
            static double getArea(double height, double width) // getArea is the "method name"      
            {
                return height * width; // return type give the prodcut of "height" and "width"
            }
                                        
        }
    }
}
// scope
// return type is double 
// method body is "return" to "width;"
// parameters are "height" and "width"
// static methods do not depend on contents of any objects. Non Static are assigned to a certain object listed in the class and can change any instance variables in that object
// when using a user-defined method it is more centralized on focusing to solve a small problem while the framework would put togerther each of those individual methods to solve many. Incorporating user defined methods into framework is a part of dividing and conquering
