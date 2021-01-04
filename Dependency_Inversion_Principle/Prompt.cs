using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Inversion_Principle
{
    public class Prompt
    {
        private string _promptString;
        private Consolable _console;
        public Prompt(Consolable console)
        {
            this._console = console;
        }
        public Command PromptCommand()
        {
            string commandLine = PromptMethod();
            return new Command(commandLine);
        }

        public string PromptMethod()
        {
            _console.Write(_promptString);
            string userCommand = _console.ReadLine();
            return userCommand;
        }


    }
}
