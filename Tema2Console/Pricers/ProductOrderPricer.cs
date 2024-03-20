using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Tema2Console.Loggers;

namespace Tema2Console.Pricers
{
    public class ProductOrderPricer : Pricer
    {
        public ProductOrderPricer(ILogger logger) : base(logger) { }

        public override decimal ProcessOrder(Order order)
        {
            _logger.Log("Processing Product order...");

            _logger.Log("Validating order parameters...");

            if (string.IsNullOrEmpty(order.Name))
            {
                _logger.Log("-Product order must specify Name");
                return 0;
            }

            if (order.Quantity == 0)
            {
                _logger.Log("-Product order must specify Quantity");
                return 0;
            }

            if (order.Price == 0)
            {
                _logger.Log("-Product order must specify Price");
                return 0;
            }

            var price = order.Quantity * order.Price;
            if (order.Name == "Fanta")
            {
                price *= 0.75m;
            }

            return price;
        }
    }
}
