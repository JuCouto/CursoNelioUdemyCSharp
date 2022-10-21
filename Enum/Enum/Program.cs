using Enum.Entities.Enum;
using Enum.Entities;



Order order = new Order
{
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayment
};

Console.WriteLine(order);

string txt = OrderStatus.PendingPayment.ToString();//coversão de enum para string

OrderStatus os;
Enum.Entities.Enum.OrderStatus.TryParse("Delivered", out os);

Console.WriteLine(os);
Console.WriteLine(txt);
