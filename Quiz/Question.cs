using System.Collections.Generic;
using System.Linq;

namespace Quiz
{
    public class Question
    {
        public static List<OrderSummary> GetOrderSummaries(IEnumerable<Order> orders)
            => orders.Select(x => new OrderSummary
            {
                Id = x.Id,
                OrderNumber = x.Number,
                ProductQty = x.Items.Sum(o => o.Qty),
                TotalAmount = x.Items.Sum(o => o.Qty * o.Product.UnitPrice),
            }).ToList();

        public static OrderReport GetOrderReport(IEnumerable<Order> orders)
            => new OrderReport
            {
                TotalOrder = orders.Count(),
                TotalProductQty = orders.Sum(x => x.Items.Sum(o => o.Qty)),
                TotalOrderAmount = orders.Sum(x => x.Items.Sum(o => o.Qty * o.Product.UnitPrice))
            };
    }
}
