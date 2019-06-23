using Microsoft.Extensions.Logging;

namespace NetCoreLib
{
    public class NetCoreType
    {
        private readonly ILogger _logger;

        public NetCoreType(ILogger logger)
        {
            _logger = logger;
        }

        public void DoSomething()
        {
            _logger.LogInformation("Oops... I did something from NetCoreType.");
        }
    }
}