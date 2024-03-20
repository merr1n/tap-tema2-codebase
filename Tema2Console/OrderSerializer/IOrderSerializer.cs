using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Console.OrderSerializer
{
    public interface IOrderSerializer
    {
        Order DeserializeFromJsonString(string dataJson);
    }
}
