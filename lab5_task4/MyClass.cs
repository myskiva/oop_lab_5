using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = MyClass<decimal>.FactoryMethod();
            var y = MyClass<bool>.FactoryMethod();

            Console.WriteLine(x.GetType().Name);
            Console.WriteLine(y.GetType().Name);
        }

    }

    class MyClass<T>
        where T : new()
    {
        public static T FactoryMethod()
        {
            return new T();
        }
    }
}