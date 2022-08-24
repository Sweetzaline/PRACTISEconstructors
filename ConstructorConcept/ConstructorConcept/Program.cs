using System;

namespace ConstructorConcept
{
    class Class1
    {
        int i;              //variable declared //explicit/parameterized constructor will initialize this variable
        string s;
        bool b;
        int a;              //implicit/default constructor will initialize this variable

        public Class1()    //Explicit constructor
        {
            i = 0;         //class variable is initialized.
            s = null;
            b = false;
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("Let's learn about Constructors.\n");

            Class1 obj = new Class1(); ////Explicitly calling the constructor

            Console.WriteLine("Value of i: " + obj.i);      //Implicit constructor called
            Console.WriteLine("Value of a: " + obj.a);      //Explicit constructor called
        }
    }
}
