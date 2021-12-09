using ITHS_CC_Labb2;

IOrderService orderService = new OrderService();

Order normalOrder = new Order
{
    ID = Guid.NewGuid(),
    Email = "normalEmail@example.com",
    Priority = OrderStatus.Normal,
    TotalPrice = 100,
};
orderService.ProcessOrder(normalOrder);  