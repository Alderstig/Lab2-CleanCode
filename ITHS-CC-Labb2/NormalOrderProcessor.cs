using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public class NormalOrderProcessor : IOrderProcessor
    {
        public bool Process()
        {
            // Some logic we don't care about,
            Console.WriteLine("NormalOrderProcessor started...");
            return true;
        }
    }
}
