using ITHS_CC_Labb2;

IOrderService orderService = new OrderService( new EmailService(new Logger()));

List<Order> orders = new List<Order>()
{
    new Order()
    {
        ID = Guid.NewGuid(),
        Email = "normalEmail@example.com",
        Processor = new NormalOrderProcessor(),
        TotalPrice = 100,
    },
    new Order()
    {
        ID = Guid.NewGuid(),
        Email = "quickEmail@example.com",
        Processor = new QuickOrderProcessor(),
        TotalPrice = 200,
    },
    new Order()
    {
        ID = Guid.NewGuid(),
        Email = "lightningSpeedEmail@example.com",
        Processor = new LightningSpeedOrderProcessor(),
        TotalPrice = 400,
    }

};

orderService.ProcessOrder(orders);