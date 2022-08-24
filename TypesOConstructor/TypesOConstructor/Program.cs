using System;

namespace TypesOConstructor
{
    class ParameterizedCons
    {
        int x; //no constructor for this variable, so implicitly a constructor will initialize its value to 0.

        public void Test()
        {
            Console.WriteLine("Implicit/Default Constructor is called->" + x);
        }


        public ParameterizedCons(int i) // Parameterized Constructor
        {
            x = i; // to aassign the value to x// this way Parameterized Constructor is used to, initialize the class variable, if we forget assign its value.
        }
       
       
    }
}
