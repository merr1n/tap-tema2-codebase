using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Console.FileSources
{
    public class FileSource : IFileSource
    {
        public string GetOrdersSource()
        {
            return File.ReadAllText("orders.json");
        }
    }
}
