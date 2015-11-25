using System;
using CommandPattern.Interfaces;

namespace CommandPattern.Domain
{
    public class LaunchNukeCommand : ICommand, ICommandFactory
    {
        public int NumberOfNukes { get; set; }

        public string CommandName
        {
            get
            {
                return "LaunchNuke";
            }
        }

        public string Description
        {
            get
            {
                return "LaunchNuke [NumberOfNukes]";
            }
        }

        public void Execute()
        {
            for (int i = 0; i < NumberOfNukes; i++)
            {
                Console.WriteLine("Launching nuke {0}", i + 1);
            }
        }

        public ICommand MakeCommand(string[] arguments)
        {
            return new LaunchNukeCommand
            {
                NumberOfNukes = int.Parse(arguments[1])
            };
        }
    }
}