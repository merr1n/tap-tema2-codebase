using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema2Console.Loggers;
using Tema2Console.Pricers;

namespace Tema2Console.OrderFactories
{
    public class OrderFactory : IOrderFactory
    {
        public ILogger _logger;
        public OrderFactory(ILogger logger)
        {
            _logger = logger;
        }

        public Pricer Create(Order order)
        {
            switch (order.Type)
            {
                case OrderType.Room:
                    return new RoomOrderPricer(_logger);

                case OrderType.Product:
                    return new ProductOrderPricer(_logger);

                case OrderType.Breakfast:
                    return new BreakfastOrderPricer(_logger);

                default:
                    return new UnknownOrderPricer(_logger);
            }
        }
    }
}
