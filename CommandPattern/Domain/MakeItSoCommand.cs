using System;
using CommandPattern.Interfaces;

namespace CommandPattern.Domain
{
    public class MakeItSoCommand : ICommand, ICommandFactory
    {
        public string CommandName
        {
            get { return "MakeItSo"; }
        }

        public string Description
        {
            get { return CommandName; }
        }

        public void Execute()
        {
            Console.WriteLine("Made it so!");
        }

        public ICommand MakeCommand(string[] arguments)
        {
            return new MakeItSoCommand();
        }
    }
}