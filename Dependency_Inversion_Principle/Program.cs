using System.Collections.Generic;
using System.Text;

namespace Dependency_Inversion_Principle
{
    public class Program
    {
        public static void Main()
        {
            Terminal terminal = new Terminal();
            while (!terminal.Exited)
            {
                Command command = terminal.PromptCommand();
                terminal.ExecuteCommand(command);
            }
        }
    }
}
