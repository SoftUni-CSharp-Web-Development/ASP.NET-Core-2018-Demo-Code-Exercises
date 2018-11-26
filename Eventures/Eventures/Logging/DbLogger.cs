using System;
using Eventures.Data;
using Eventures.Models;
using Microsoft.Extensions.Logging;

namespace Eventures.Logging
{
    public class DbLogger : ILogger
    {
        private string categoryName;
        private Func<string, LogLevel, bool> filter;
        private EventuresDbContext context;

        public DbLogger(
            string categoryName,
            Func<string, LogLevel, bool> filter,
            EventuresDbContext dbContext)
        {
            this.categoryName = categoryName;
            this.filter = filter;
            this.context = dbContext;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(
            LogLevel logLevel,
            EventId eventId,
            TState state,
            Exception exception,
            Func<TState, Exception, string> formatter)
        {   
            //if (logLevel == LogLevel.Error)
            //{
            //    this.context.Logs.Add(new CustomLog());
            //    this.context.SaveChanges();
            //}
        }
    }
}
