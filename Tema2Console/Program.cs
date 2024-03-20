using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Tema2Console.Loggers;
using Tema2Console.OrderSerializer;
using Tema2Console.OrderFactories;
using Tema2Console.FileSources;

namespace Tema2Console;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting Client...");

        var logger = new Logger();
        var hotelReception = new HotelReception(logger, new FileSource(), new OrderFactory(logger), new OrdersSerializer());
        hotelReception.ProcessOrder();

        if (hotelReception.FinalPrice == 0)
        {
            Console.WriteLine("No order was processed.");
        }
        else
        {
            Console.WriteLine($"Final price for you order: {hotelReception.FinalPrice} RON");
        }
    }
}
