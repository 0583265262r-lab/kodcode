using CommandParser;
using ISP;
using System;
namespace Commandi
{

    public abstract class Commend
    {
        public string RawLine { get; }
        public string Target { get; }
        public Commend(string rawLine, string target)
        {
            if (string.IsNullOrWhiteSpace(target))
            {
                throw new ArgumentException("Target cannot be null or empty.");
            }
            RawLine = rawLine;
            Target = target;
        }
        public abstract bool Execute();
        
        

    }
    class CreateFileCommand : Commend , IUndoable
    {
        public CreateFileCommand(string rawLine, string fileName)
            : base(rawLine, fileName) { }
        public override bool Execute()
        {
            throw new NotImplementedException();
        }
        public void Undo()
        { }
    }
    public class SandEmailCommand: Commend
    {
        public SandEmailCommand(string rawLine, string emailAddress)
            : base(rawLine, emailAddress) { }
        public override bool Execute()
        {
            throw new NotImplementedException();
        }

    }
    public class BackupCommand: Commend, IUndoable, IRetryable
    {
        public BackupCommand(string rawLine, string datasetName)
            : base(rawLine, datasetName) { }
        public override bool Execute()
        {
            throw new NotImplementedException();
        }
        public void Undo()
        {

        }
        public void Retry() { }
    }



}