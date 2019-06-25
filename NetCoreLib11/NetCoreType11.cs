using Microsoft.Extensions.Logging;

namespace NetCoreLib11
{
    public class NetCoreType11
    {
        private readonly ILogger _logger;

        public NetCoreType11(ILogger logger)
        {
            _logger = logger;
        }

        public void DoSomething()
        {
            _logger.LogInformation("Oops... I did something from NetCoreType11.");
        }
    }
}