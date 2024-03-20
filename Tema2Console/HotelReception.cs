using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Tema2Console.FileSources;
using Tema2Console.Loggers;
using Tema2Console.OrderFactories;
using Tema2Console.OrderSerializer;

namespace Tema2Console
{
    public class HotelReception
    {
        private ILogger _logger;
        private IFileSource _fileSource;
        private IOrderSerializer _orderSerializer;
        private IOrderFactory _orderFactory;

        public HotelReception(ILogger logger, IFileSource fileSource, IOrderFactory orderFactory, IOrderSerializer orderSerializer)
        {
            _logger = logger;
            _fileSource = fileSource;
            _orderSerializer = orderSerializer;
            _orderFactory = orderFactory;
        }

        public decimal FinalPrice { get; set;}

        public void ProcessOrder()
        {   
            _logger.Log("Start processing...");

            _logger.Log("Loading order from file...");
            var dataJson = _fileSource.GetOrdersSource();

            _logger.Log("Deserializing Order object from json data...");
            var order = _orderSerializer.DeserializeFromJsonString(dataJson);

            if (order == null)
            {
                _logger.Log("Order type not parsed successfully.");
                return;
            }

            var pricer = _orderFactory.Create(order);
            FinalPrice = pricer.ProcessOrder(order);

            _logger.Log("Rating completed.");
        }
    }
}
