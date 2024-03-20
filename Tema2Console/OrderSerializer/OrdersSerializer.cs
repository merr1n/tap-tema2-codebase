using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Console.OrderSerializer
{
    public class OrdersSerializer : IOrderSerializer
    {
        public Order DeserializeFromJsonString(string dataJson)
        {
            return JsonConvert.DeserializeObject<Order>(dataJson, new StringEnumConverter());
        }
    }
}
