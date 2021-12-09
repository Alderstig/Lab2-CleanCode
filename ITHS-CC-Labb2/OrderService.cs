using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITHS_CC_Labb2
{
    public class OrderService : IOrderService
    {
        /*
        private readonly NormalOrderProcessor _normalOrderProcessor;
        private readonly QuickOrderProcessor _quickOrderProcessor;
        private readonly LightningSpeedOrderProcessor _lightningSpeedOrderProcessor;

        public OrderService()
        {
            _normalOrderProcessor = new NormalOrderProcessor();
            _quickOrderProcessor = new QuickOrderProcessor();
            _lightningSpeedOrderProcessor = new LightningSpeedOrderProcessor();
        }
        */

        public bool ProcessOrder(Order order)
        {
            bool processPriority = false;

            LogMessage("Attempting to process order with ID " + order.ID);
            if (order.Priority == OrderStatus.Normal)
            {
                NormalOrderProcessor normalOrderProcessor = new();
                processPriority = normalOrderProcessor.ProcessOrder(order);
                logMessageAndSendEmail(order);
                return processPriority;
            }
            else if (order.Priority == OrderStatus.Quick)
            {
                QuickOrderProcessor quickOrderProcessor = new();
                processPriority = quickOrderProcessor.ProcessOrder(order);
                logMessageAndSendEmail(order);
                return processPriority;
            }
            else if (order.Priority == OrderStatus.LightningSpeed)
            {
                LightningSpeedOrderProcessor lightningSpeedOrderProcessor = new();
                processPriority = lightningSpeedOrderProcessor.ProcessOrder(order);
                logMessageAndSendEmail(order);
                return processPriority;
            }
            else
            {
                processPriority = false;
            }

            if (!processPriority)
            {
                LogMessage("FAILED ORDER: Could not ship order with ID " + order.ID);
            }

            return processPriority;
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
