using System;
using Eventures.Data;
using Microsoft.Extensions.Logging;

namespace Eventures.Logging
{
    public class DbLoggerProvider : ILoggerProvider
    {
        private Func<string, LogLevel, bool> filter;
        private EventuresDbContext dbContext;

        public DbLoggerProvider(
            Func<string, LogLevel, bool> filter,
            EventuresDbContext dbContext)
        {
            this.filter = filter;
            this.dbContext = dbContext;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return new DbLogger(categoryName, filter, this.dbContext);
        }

        public void Dispose()
        {

        }
    }
}
