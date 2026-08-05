using ISP;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using CommandParser;
using Commandi;

namespace BatchRunneri
{
    public class BatchRunner
    {
        private readonly ICommandLogger _logger;
        private readonly CommendParser _parser;
        private int _succeeded = 0;
        private int _failed = 0;
        private int _unparseable = 0;
        public BatchRunner(ICommandLogger logger)
        {
            _logger = logger;
            _parser = new CommendParser();
        }
        public void Run(List<string> rawLines)
        {
            foreach (string line in rawLines)
            {
                try
                {
                    Commend command = _parser.Parse(line);
                    bool success = command.Execute();
                    if (success)
                    {
                        _succeeded++;
                    }
                    else
                    {
                        _failed++;
                    }
                    _logger.LogResult(command, success);
                }
                catch(CommandParseException)
                {
                    _unparseable++;
                    Console.WriteLine($"line failed to perse {line}");
                }
            }

        }

        public RunSummary GetSummary()
        {
            return new RunSummary(_succeeded, _failed, _unparseable);
        }
    }
    //class RunSummary
    //{
    //    public int Succeeded { get; }
    //    public int Failed { get; }
    //    public int Unparseable { get; }

    //}
}
