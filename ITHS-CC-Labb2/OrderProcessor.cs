using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public class OrderProcessor : IOrderService
    {
        private readonly INormalOrderProcessor _normalOrderProcessor;
        private readonly IQuickOrderProcessor _quickOrderProcessor;
        private readonly ILightningSpeedOrderProcessor _lightningSpeedOrderProcessor;

        public OrderProcessor(INormalOrderProcessor normalOrderProcessor, IQuickOrderProcessor quickOrderProcessor, ILightningSpeedOrderProcessor lightningSpeedOrderProcessor)
        {
            _normalOrderProcessor = normalOrderProcessor;
            _quickOrderProcessor = quickOrderProcessor;
            _lightningSpeedOrderProcessor = lightningSpeedOrderProcessor;
        }

        public void ProcessOrder(Order order)
        {
            bool processPriority = false;

            LogMessage("Attempting to process order with ID " + order.ID);
            if (order.Priority == OrderStatus.Normal)
            {
                processPriority = _normalOrderProcessor.ProcessOrderNormally(order);
                logMessageAndSendEmail(order);
            }
            else if (order.Priority == OrderStatus.Quick)
            {
                processPriority = _quickOrderProcessor.ProcessOrderQuickly(order);
                logMessageAndSendEmail(order);
            }
            else if (order.Priority == OrderStatus.LightningSpeed)
            {
                processPriority = _lightningSpeedOrderProcessor.ProcessOrderInLightningSpeed(order);
                logMessageAndSendEmail(order);
            }
            else
            {
                processPriority = false;
            }

            if (!processPriority)
            {
                LogMessage("FAILED ORDER: Could not ship order with ID " + order.ID);
            }
        }
        private void SendEmailNotification(string email, Guid ID)
        {
            // Some email sending logic we don't care about
            LogMessage($"Notification sent to email {email} for order {ID}");
        }
        private void LogMessage(string message)
        {
            Console.WriteLine($"{DateTime.Now}: {message}");
        }
        private void logMessageAndSendEmail(Order order)
        {
            LogMessage("Succesfully processed order with ID " + order.ID);
            SendEmailNotification(order.Email, order.ID);
        }
    }
}
