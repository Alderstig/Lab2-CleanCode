using ITHS_CC_Labb2;

//Skapa ny orderservice beroende på vilket interface/orderprioritet den implementerar
//INormalSpeedProcessor normalOrderProcess = new OrderService();

IOrderService orderService = new OrderService();

Order normalOrder = new Order
{
    ID = Guid.NewGuid(),
    Email = "normalEmail@example.com",
    Priority = OrderStatus.Normal,
    TotalPrice = 100,
};

//normalOrderProcess.(normalOrder);
orderService.ProcessOrder(normalOrder);  