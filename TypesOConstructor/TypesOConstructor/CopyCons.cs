using System;
using System.Collections.Generic;
using System.Text;

namespace TypesOConstructor
{
    class CopyCons
    {
        int x; //no constructor for this variable, so implicitly a constructor will initialize its value to 0.

        public CopyCons(int i) // Parameterized Constructor
        {
            x = i; // to aassign the value to x// this way Parameterized Constructor is used to, initialize the class variable, if we forget assign its value.
           
        }
        public void Show()
        {
            Console.WriteLine("Copy Constructor is called->" + x);
        }
        //Using Coppy Constructor for the abouve paraeterized constructor

        public CopyCons(CopyCons obj3) // Copy Constructor
        {
            x = obj3.x; 

        }
    }
}
