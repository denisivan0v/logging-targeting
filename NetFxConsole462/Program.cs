using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace NetFxConsole462
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var loggerFactory = new NLogLoggerFactory();
            var logger = loggerFactory.CreateLogger<Program>();
            
            var instance = new NetCoreLib11.NetCoreType11(logger);
            instance.DoSomething();
        }
    }
}