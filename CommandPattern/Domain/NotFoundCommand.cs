using System;
using CommandPattern.Interfaces;

namespace CommandPattern.Domain
{
    public class NotFoundCommand : ICommand
    {
        public string Name { get; set; }

        public void Execute()
        {
            Console.WriteLine("Command not found: " + Name);
        }
    }
}