using System.Collections.Generic;
using System.Linq;

namespace Quiz
{
    public class Question
    {
        public static List<OrderSummary> GetOrderSummaries(IEnumerable<Order> orders) 
            => orders.Select(getSummary).ToList();
        
        public static OrderReport GetOrderReport(IEnumerable<Order> orders)
            => orders.To(GetOrderSummaries).To(getOrderReport);

        private static OrderSummary getSummary(Order order) => new OrderSummary
        {
            Id = order.Id,
            OrderNumber = order.Number,
            ProductQty = order.Items.Sum(x => x.Qty),
            TotalAmount = order.Items.Sum(x => x.Qty * x.Product.UnitPrice),
        };

        private static OrderReport getOrderReport(IEnumerable<OrderSummary> me) => new OrderReport
        {
            TotalOrder = me.Count(),
            TotalProductQty = me.Sum(x => x.ProductQty),
            TotalOrderAmount = me.Sum(x => x.TotalAmount),
            AvgOrderAmount = me.Average(x => x.TotalAmount),
        };
    }
}
