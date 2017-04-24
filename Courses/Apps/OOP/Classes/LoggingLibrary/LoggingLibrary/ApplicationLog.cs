using LoggingLibrary.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LoggingLibrary
{
  /// <summary>
  /// Application log class, centralizes all logging logic
  /// </summary>
  public static class ApplicationLog
  {
    /// <summary>
    /// Cache which holds all auto-detected logger factories
    /// </summary>
    private static readonly Dictionary<LoggerType, LoggerFactory> loggerFactoriesCache = new Dictionary<LoggerType, LoggerFactory>();

    /// <summary>
    /// Currently initialized logger factory
    /// </summary>
    private static LoggerFactory currentFactory;

    /// <summary>
    /// Static constructor, auto-detects logger factories
    /// </summary>
    static ApplicationLog()
    {
      ApplicationLog.AutoDetectLoggerFactories();
    }

    /// <summary>
    /// Auto-detects logger factories defined in the current assembly.
    /// Code uses reflection to find all the types that derive from <see cref="LoggerFactory"/>,
    /// fully understanding this code is not strictly required at this level
    /// </summary>
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

    /// <summary>
    /// Initializes the logging infrastructure to use the specified logger type
    /// </summary>
    /// <param name="loggerType">The logger type to use</param>
    public static void Initialize(LoggerType loggerType)
    {
      switch (loggerType)
      {
        case LoggerType.ConsoleWindow:
        case LoggerType.DebugWindow:
        case LoggerType.WindowsEventViewer:
          {
            ApplicationLog.loggerFactoriesCache.TryGetValue(loggerType, out ApplicationLog.currentFactory);
          }
          break;

        case LoggerType.Unspecified:
        default:
          throw new NotSupportedException($"The specified logger type '{loggerType}' is not supported!");
      }
    }

    /// <summary>
    /// Writes a log entry
    /// </summary>
    /// <param name="level">The log level</param>
    /// <param name="e">The exception to write</param>
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
