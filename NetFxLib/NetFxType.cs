using Microsoft.Extensions.Logging;

namespace NetFxLib
{
    public class NetFxType
    {
        private readonly ILogger _logger;

        public NetFxType(ILogger logger)
        {
            _logger = logger;
        }
        
        public void DoSomething()
        {
            _logger.LogInformation("Oops... I did something from NetFxType.");
        }
    }
}