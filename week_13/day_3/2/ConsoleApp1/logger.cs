using System;
using System.Collections.Generic;
using System.Text;
using Commandi;

namespace ISP
{
    
    public interface ICommandLogger
    {
        void LogResult(Commend command, bool success);
    }

    public interface IUndoable
    {
        void Undo();
    }

    public interface IRetryable
    {
        void Retry();
    }

    public class RunSummary
    {
        public int Succeeded { get; }
        public int Failed { get; }
        public int Unparseable { get; }

        public RunSummary(int succeeded, int failed, int unparseable)
        {
            Succeeded = succeeded;
            Failed = failed;
            Unparseable = unparseable;
        }
    }
    public class ConsoleCommandLogger : ICommandLogger
    {
        public void LogResult(Commend command, bool success)
        { }

    }
    public class FileCommandLogger: ICommandLogger
    {
        public FileCommandLogger(string filePath)
        { }
        public void LogResult(Commend command, bool success)
        { }

    }
}
