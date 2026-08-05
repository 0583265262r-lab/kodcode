using Commandi;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandParser
{
    public class CommendParser
    {
        public Commend Parse(string rawLine)
        {
            if ( string.IsNullOrWhiteSpace(rawLine))
            {
                throw new CommandParseException("line is empty");
            }
            string[] parts = rawLine.Split(" ");
            if (parts.Length < 2)
            {
                throw new CommandParseException("");
            }
            string commandType = parts[0];
            string target = parts[1];
            return commandType switch
            {
                "CREATE_FILE" => new CreateFileCommand(rawLine,target),
                "SAND_EMAIL" => new SandEmailCommand(rawLine, target),
                "BECKUP" => new BackupCommand(rawLine,target),
                _ => throw new CommandParseException("")
            };

        }
    }
    public class CommandParseException: Exception
    {
        public CommandParseException(string message) : base(message) { }
    }
}
