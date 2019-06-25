using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace NetCoreConsole451
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var loggerFactory = new NLogLoggerFactory();
            var logger = loggerFactory.CreateLogger<Program>();
            
            var instance = new NetCoreLib11.NetCoreType11(logger);
            instance.DoSomething();
        }
    }
}