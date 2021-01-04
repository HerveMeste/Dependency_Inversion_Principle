using System;
using System.Collections.Generic;
using System.Text;

namespace Dependency_Inversion_Principle
{
    public class Execute
    {
        public void ExecuteCommand(Command command)
        {
            try
            {
                command.Launch();
                if (command.Output.Length > 0)
                {
                    Console.WriteLine(command.Output);
                }
            }
            catch (InvalidOperationException exception)
            {
                Console.Error.WriteLine("{0}: path not found", command);
            }
        }
    }
}
