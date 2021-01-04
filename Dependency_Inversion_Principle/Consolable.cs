using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Inversion_Principle
{
    public interface Consolable
    {
        public string ReadLine();
        public void Write(string command);
        
    }
}
