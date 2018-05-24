using System;

namespace CovarianceOfTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<Base, int> t = new Tuple<Base, int>(new Base(), 1);
            //t.Item1 = new Base(); cannot because Item1 is readonly.
            //t.Item2 = 4; cannot because Item2 is readonly.
            //Tuple<Base, int> t2 = new Tuple<Derived, int>(new Derived(), 1); cannot because ???. (I know it's not covariant, but why it is so?)
        }
    }

    internal class Base
    {

    }

    class Derived : Base
    {
    }

}
