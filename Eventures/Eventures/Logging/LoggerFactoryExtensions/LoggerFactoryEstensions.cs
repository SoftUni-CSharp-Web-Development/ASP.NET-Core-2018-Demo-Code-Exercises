using System;
using Eventures.Data;
using Eventures.Logging;
using Microsoft.Extensions.Logging;

public static class DBLoggerExtensions
{
    public static ILoggerFactory AddContext(
        this ILoggerFactory factory,
        EventuresDbContext dbContext,
        Func<string, LogLevel, bool> filter = null)
    {
        factory.AddProvider(new DbLoggerProvider(filter, dbContext));
        return factory;
    }

    public static ILoggerFactory AddContext(
        this ILoggerFactory factory,
        LogLevel minLevel,
        EventuresDbContext dbContext)
    {
        return AddContext(
            factory,
            dbContext,
            (_, logLevel) => logLevel >= minLevel);
    }
}