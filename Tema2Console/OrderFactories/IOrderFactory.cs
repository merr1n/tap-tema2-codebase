using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema2Console.Pricers;

namespace Tema2Console.OrderFactories
{
    public interface IOrderFactory
    {
        Pricer Create(Order order);
    }
}
