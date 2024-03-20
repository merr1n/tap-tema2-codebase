using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema2Console.Loggers;

namespace Tema2Console.Pricers
{
    public class BreakfastOrderPricer : Pricer
    {
        public BreakfastOrderPricer(ILogger logger) : base(logger) { }

        public override decimal ProcessOrder(Order order)
        {
            _logger.Log("Processing Breakfast order...");

            _logger.Log("Validating order parameters...");

            if (order.Quantity == 0)
            {
                _logger.Log("-Breakfast order must specify Quantity");
                return 0;
            }

            if (order.Price == 0)
            {
                _logger.Log("-Breakfast order must specify Price");
                return 0;
            }

            if (string.IsNullOrEmpty(order.ServingDate))
            {
                _logger.Log("-Room order must specify Serving Date");
                return 0;
            }

            if (!DateTime.TryParseExact(order.ServingDate, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out var pasedServingDate))
            {
                _logger.Log("-Serving Date must be a valid date");
                return 0;
            }

            if (pasedServingDate < DateTime.Now.AddDays(7))
            {
                return order.Quantity * order.Price;
            }
            else
            {
                return order.Quantity * order.Price * 0.5m;
            }
        }
    }
}
