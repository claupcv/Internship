using LoggingLibrary.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LoggingLibrary
{
  public static class ApplicationLog
  {
    private static readonly Dictionary<LoggerType, LoggerFactory> loggerFactoriesCache = new Dictionary<LoggerType, LoggerFactory>();

    private static LoggerFactory currentFactory;

    static ApplicationLog()
    {
      ApplicationLog.AutoDetectLoggerFactories();
    }

    private static void AutoDetectLoggerFactories()
    {
      var assembly = Assembly.GetAssembly(typeof(LoggerFactory));
      if (assembly == null)
      {
        return;
      }

      var allFactoryTypes = assembly
                                 .GetTypes()
                                 .Where(t => t.IsClass &&
                                             (!t.IsAbstract) &&
                                             t.IsSubclassOf(typeof(LoggerFactory)))
                                 .ToArray();

      if (allFactoryTypes == null)
      {
        return;
      }

      foreach (var factoryType in allFactoryTypes)
      {
        var factoryInstance = Activator.CreateInstance(factoryType) as LoggerFactory;
        if (factoryInstance != null)
        {
          ApplicationLog.loggerFactoriesCache[factoryInstance.LoggerType] = factoryInstance;
        }
      }
    }

    public static void Initialize(LoggerType loggerType)
    {
      ApplicationLog.loggerFactoriesCache.TryGetValue(loggerType, out ApplicationLog.currentFactory);
    }

    public static void WriteLog(LogLevel level, Exception e)
    {
      if (ApplicationLog.currentFactory != null)
      {
        var logger = ApplicationLog.currentFactory.CreateLogger();

        if (logger != null)
        {
          logger.Write(level, e);
        }
      }
    }
  }
}
