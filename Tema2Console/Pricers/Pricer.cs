using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema2Console.Loggers;

namespace Tema2Console.Pricers
{
    public abstract class Pricer
    {
        protected ILogger _logger;

        public Pricer(ILogger logger)
        {
            _logger = logger;
        }

        public abstract decimal ProcessOrder(Order order);
    }
}
