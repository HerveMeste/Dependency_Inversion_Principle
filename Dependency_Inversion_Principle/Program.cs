using System.Collections.Generic;
using System.Text;

namespace Dependency_Inversion_Principle
{
    public class Program
    {
        public static void Main()
        {
            Consolable console = new MyConsole();
            Execute execute = new Execute();
            Prompt prompt = new Prompt(console);
            Terminal terminal = new Terminal(execute, prompt);
            while (!terminal.Exited)
            {
                Command command = prompt.PromptCommand();
                execute.ExecuteCommand(command);
            }
        }
    }
}
