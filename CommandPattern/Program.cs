using System;
using System.Collections.Generic;
using CommandPattern.Domain;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var availableCommands = GetAvailableCommands();

            if (args.Length == 0)
            {
                PrintUsage(availableCommands);
                return;
            }

            var parser = new CommandParser(availableCommands);
            var command = parser.ParseCommand(args);

            command.Execute();
        }

        private static IEnumerable<ICommandFactory> GetAvailableCommands()
        {
            return new ICommandFactory[]
                {
                    new DiveCommand(),
                    new LaunchNukeCommand(),
                    new MakeItSoCommand()
                };
        }

        private static void PrintUsage(IEnumerable<ICommandFactory> availableCommands)
        {
            Console.WriteLine("Usage: CommandPattern CommandName Arguments");
            Console.WriteLine("Commands:");

            foreach (var command in availableCommands)
            {
                Console.WriteLine("  {0}", command.Description);
            }
        }
    }
}
