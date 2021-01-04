using Reflexion;
using System;
using System.Reflection;

namespace ReflectionTest
{

    class Program
    {
        static void Main(string[] args)
        {
            var reflected = new ReflectedClass();
            var inspector = new Inspector();
            inspector.GetAllProprerties(reflected);
            inspector.GetAllFiels(reflected);
            inspector.GetAllMethods(reflected);
            inspector.GetAllConstructors(reflected);
        }
    }
}
