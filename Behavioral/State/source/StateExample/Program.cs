using StateExample.Order;

var order = new Order();
Console.WriteLine(order.Status);

order.Pay();
Console.WriteLine(order.Status);

order.Ship();
Console.WriteLine(order.Status);

