using System;

namespace Dependency_Inversion_Principle
{
    internal class MyConsole : Consolable
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void Write(string command)
        {
            Console.WriteLine(command);
        }
    }
}