using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public class OrderService : IOrderService
    {
        private readonly IEmailService _emailService;

        public OrderService(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void ProcessOrder(Order order)
        {
            order.Processor.Process();
            _emailService.SendEmail(order);
        }
    }
}
