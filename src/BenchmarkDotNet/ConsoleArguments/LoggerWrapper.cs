﻿using System.IO;
using System.Text;
using BenchmarkDotNet.Loggers;

namespace BenchmarkDotNet.ConsoleArguments
{
    internal class LoggerWrapper : TextWriter
    {
        private readonly ILogger logger;

        public LoggerWrapper(ILogger logger) => this.logger = logger;

        public override Encoding Encoding { get; }

        public override void Write(string value) => logger.WriteLineError(value);
    }
}