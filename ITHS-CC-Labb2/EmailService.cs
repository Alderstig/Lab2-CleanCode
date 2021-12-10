using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    internal class EmailService : IEmailService
    {
        private readonly ILogger _logger;

        public EmailService(ILogger logger)
        {
            _logger = logger;
        }

        public void SendEmail(Order order)
        {
            // Some email sending logic we don't care about
            _logger.LogMessage($"Notification sent to email {order.Email} for order {order.ID}");
        }
    }
}
