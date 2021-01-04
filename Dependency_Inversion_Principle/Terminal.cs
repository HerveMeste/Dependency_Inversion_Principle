using System;

namespace Dependency_Inversion_Principle
{
    public class Terminal
    {
        public bool Exited { get; set; }
        private string _promptString;
        private readonly Execute _execute;
        private readonly Prompt _prompt;


        public Terminal(Execute execute, Prompt prompt)
        {
            _promptString = String.Format("{0}$ ", System.Security.Principal.WindowsIdentity.GetCurrent().Name);
            Exited = false;
            _execute = execute;
            _prompt = prompt;
        }



    }
}
