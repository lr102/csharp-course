using System;
using System.Collections.Generic;
public class OrderService
{
    private readonly List<Order> _processedOrders = new List<Order>();
    private readonly List<string> _logs = new List<string>();

    public record Order(
        string Id,
        int Quantity,
        decimal UnitPrice
    )
    {
        // 3. Compute total
        public decimal Total => Quantity * UnitPrice;
    };

    private List<Order> ListOrders() {
           var orders = new List<Order>
        {
            new Order("A100", 2, 15.50m),
            new Order("B200", 1, 99.99m),
            new Order("C300", 5, 7.25m)
        };
        return orders;
    }

    private void ProcessEachOrder(List<Order> orders){
       foreach (var order in orders)
        {
            if (order.Quantity <= 0)
            {
                _logs.Add($"[{DateTime.UtcNow}] Invalid quantity for order {order.Id}");
                continue;
            }
            if (order.UnitPrice <= 0)
            {
                _logs.Add($"[{DateTime.UtcNow}] Invalid price for order {order.Id}");
                continue;
            }
            _processedOrders.Add(order);


        }
 
    }
    private void BuildReportLines(){
        foreach (var order in _processedOrders){
            var line = $"Order {order.Id}: {order.Quantity} × {order.UnitPrice:C} = {order.Total:C}";
            _logs.Add(line);
        }
    }

    private void SendReport(){

        Console.WriteLine("---- Order Report ----");
        foreach (var log in _logs) Console.WriteLine(log);
    }

    public void ProcessOrders(){

        // 1. Inline order data
        List<Order> orders = ListOrders();

        // 2. Validate each order
        // 4. Add to processed list
        ProcessEachOrder(orders);
        
        // 5. Build report line
        BuildReportLines();

        // 6. “Send” report by printing to console
        SendReport();

        // 7. Clear logs for next run
        _logs.Clear();
    }
}

class Program
{
    private static OrderService servicio = new OrderService();
    static void Main()
    {
        servicio.ProcessOrders();
    }
}
