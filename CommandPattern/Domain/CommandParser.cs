using System.Collections.Generic;
using System.Linq;
using CommandPattern.Interfaces;

namespace CommandPattern.Domain
{
    public class CommandParser
    {
        private readonly IEnumerable<ICommandFactory> _availableCommands;

        public CommandParser(IEnumerable<ICommandFactory> availableCommands)
        {
            _availableCommands = availableCommands;
        }

        internal ICommand ParseCommand(string[] args)
        {
            var requestedCommandName = args[0];

            var command = FindRequestedCommand(requestedCommandName);

            if (command == null)
            {
                return new NotFoundCommand { Name = requestedCommandName };
            }

            return command.MakeCommand(args);
        }

        private ICommandFactory FindRequestedCommand(string commandName)
        {
            return _availableCommands
                .FirstOrDefault(cmd => cmd.CommandName == commandName);
        }
    }
}