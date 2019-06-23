using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace NetFxConsole451
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var loggerFactory = new NLogLoggerFactory();
            var logger = loggerFactory.CreateLogger<Program>();
            
            var instance = new NetFxLib.NetFxType(logger);
            instance.DoSomething();
        }
    }
}