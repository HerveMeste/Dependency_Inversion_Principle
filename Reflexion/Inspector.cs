using ReflectionTest;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Reflexion
{
    class Inspector
    {
        internal void GetAllProprerties(ReflectedClass reflected)
        {
            Type objectType = reflected.GetType();
            PropertyInfo[] properties = objectType.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine("Properties");
            foreach (var p in properties)
            {
                Console.WriteLine("\t" + p);
            }
        }

        internal void GetAllFiels(ReflectedClass reflected)
        {
            Type objectType = reflected.GetType();
            FieldInfo[] fields = objectType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine("Fields");
            foreach (var f in fields)
            {
                Console.WriteLine("\t" + f);
            }
        }

        internal void GetAllConstructors(ReflectedClass reflected)
        {
            Type objectType = reflected.GetType();
            ConstructorInfo[] constructors = objectType.GetConstructors(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine("Constructors");
            foreach (var c in constructors)
            {
                Console.WriteLine("\t" + c);
            }
        }

        internal void GetAllMethods(ReflectedClass reflected)
        {
            Type objectType = reflected.GetType();
            MethodInfo[] methods = objectType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine("Methods");
            foreach (var m in methods)
            {
                Console.WriteLine("\t" + m);
            }
        }
    }
}
