using System;
using CommandPattern.Interfaces;

namespace CommandPattern.Domain
{
    public class DiveCommand : ICommand, ICommandFactory
    {
        public int NumberOfMetres { get; set; }

        public string CommandName
        {
            get { return "Dive"; }
        }

        public string Description
        {
            get { return "Dive [NumberOfMetres]"; }
        }

        public void Execute()
        {
            Console.WriteLine("Diving to {0} metres...", NumberOfMetres);
        }

        public ICommand MakeCommand(string[] arguments)
        {
            return new DiveCommand
            {
                NumberOfMetres = int.Parse(arguments[1])
            };
        }
    }
}