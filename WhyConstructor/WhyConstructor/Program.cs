using System;

namespace WhyConstructor
{

    class First
    {
        public int x = 100;

    }
    class Second
    {
        public int x;
        public Second(int x)
        {
            this.x = x;
        }
    }
    class Test
    {
      static void Main(string[] args)
        {
            First obj1 = new First();
            First obj2 = new First();
            First obj3 = new First();
            Console.WriteLine(obj1.x +" "+ obj2.x +" "+ obj3.x); // Same value will be returned, as implicit constructor is used.

            Second obj4 = new Second(20);
            Second obj5 = new Second(30);
            Second obj6 = new Second(40);
            Console.WriteLine(obj4.x + " " + obj5.x + " " + obj6.x); // Different value will be returned, as implicit constructor is used.

        }
    }
}
