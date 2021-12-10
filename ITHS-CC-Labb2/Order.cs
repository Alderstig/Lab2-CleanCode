using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public enum OrderStatus
    {
        Normal,
        Quick,
        LightningSpeed
    }
    public class Order
    {
        public Guid ID { get; set; }
        public int TotalPrice { get; set; }
        public IOrderProcessor Processor { get; set; }
        public string Email { get; set; }
    }
}
