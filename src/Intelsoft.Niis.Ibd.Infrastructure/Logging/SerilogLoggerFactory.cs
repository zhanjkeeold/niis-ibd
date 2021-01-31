﻿using System;
using System.IO;
using Intelsoft.Niis.Ibd.Configuration;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.SystemConsole.Themes;

namespace Intelsoft.Niis.Ibd.Infrastructure.Logging
{
    public class SerilogLoggerFactory
    {
        private readonly NiisIbdSettings _configuration;

        public SerilogLoggerFactory(NiisIbdSettings configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public ILogger CreateLogger()
        {
            return CreateConfiguration(_configuration).CreateLogger();
        }

        private static LoggerConfiguration CreateConfiguration(NiisIbdSettings options)
        {
            var loggerConfiguration = new LoggerConfiguration()
                .Enrich.FromLogContext();

            var currentDirectory = Directory.GetCurrentDirectory();

            var logDirectory = Path.Combine(currentDirectory, options.LogPath);
            if (!Directory.Exists(logDirectory))
            {
                Directory.CreateDirectory(logDirectory);
            }

            var todayDate = DateTime.UtcNow.ToString("yyyyMMdd");

            foreach (var enumValue in Enum.GetValues(typeof(LogEventLevel)))
            {
                if ((LogEventLevel)enumValue == LogEventLevel.Debug)
                {
                    continue;
                }

                loggerConfiguration.WriteTo.File(Path.Combine(logDirectory,
                        $"{todayDate}_{enumValue.ToString().ToLower()}.txt"),
                    (LogEventLevel)enumValue,
                    rollOnFileSizeLimit: true,
                    fileSizeLimitBytes: options.FileSizeLimitMBytes * 1024 * 1024);
            }

            loggerConfiguration.WriteTo.Console(theme: AnsiConsoleTheme.Code);

            return loggerConfiguration;
        }
    }
}
