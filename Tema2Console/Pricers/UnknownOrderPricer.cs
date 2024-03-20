using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema2Console.Loggers;

namespace Tema2Console.Pricers
{
    public class UnknownOrderPricer : Pricer
    {
        public UnknownOrderPricer(ILogger logger) : base(logger) { }
        public override decimal ProcessOrder(Order order)
        {
            return 0;
        }
    }
}
