using System;
using System.Collections.Generic;
namespace DoesItBlend
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var b = new Banana();
            var s = new Strawberry();
            var m = new Mango();
            var c = new IceCubes();
            var p = new CellPhone();

            List<IBlendable> fruits = new List<IBlendable>() { b, s, m , c, p};
            Console.WriteLine(b.Blend());
            Console.WriteLine(s.Blend());
            Console.WriteLine(m.Blend());
            foreach(var fruit in fruits)
            {
                Console.WriteLine(fruit.GetType());
                Console.WriteLine(fruit.Blend());
            }
        }
    }
}
