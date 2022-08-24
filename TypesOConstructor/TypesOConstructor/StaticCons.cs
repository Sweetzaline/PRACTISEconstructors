using System;
using System.Collections.Generic;
using System.Text;

namespace TypesOConstructor
{
    class StaticCons
    {
        static StaticCons()//•	It executes first, even before the main method & other class members.
        {
            Console.WriteLine("Static Constructor is called->" );
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Learning Types of Constructor:\n");

            ParameterizedCons obj1 = new ParameterizedCons(10); //create the instance of the class. it is developer's responsibility to explicitly pass the value  
            obj1.Test();
            ParameterizedCons obj2 = new ParameterizedCons(100); //create another instance of the class. it is developer's responsibility to explicitly pass the value  
            obj2.Test();

            CopyCons obj3 = new CopyCons(1000);//Passing same parameter:1000
            obj3.Show();
            CopyCons obj4 = new CopyCons(1000);//Passing same parameter:1000
            obj4.Show();
            //if we want to pass the same parameter for many times, its time-consuming, to overcome this problem we use copy constructor.
            Console.WriteLine("\n");
            CopyCons obj5 = new CopyCons(obj3);//Passing same parameter:1000
            obj5.Show();
        }
    }
}
