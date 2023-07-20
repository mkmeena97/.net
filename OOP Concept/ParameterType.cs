using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concept
{
    internal class ParameterType
    {
        public int OptionalParameter(int a,int b,int c=9)
        {
            return a*b*c;
        }

        public int NamedParameter(int a , int b,int c)
        { return a*b*c; }

        public int ParamMultiply(params int [] arr)
        {
            int mul = 1;
            foreach(int i in arr)
                mul *= i;
            return mul;
        }
    }
}
