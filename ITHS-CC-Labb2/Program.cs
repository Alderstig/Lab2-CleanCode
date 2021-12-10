using ITHS_CC_Labb2;

IOrderService orderService = new OrderService( new EmailService(new Logger()));

Order normalOrder = new Order
{
    ID = Guid.NewGuid(),
    Email = "normalEmail@example.com",
    Processor = new NormalOrderProcessor(),
    TotalPrice = 100,
};

orderService.ProcessOrder(normalOrder);  