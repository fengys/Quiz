using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz
{
    [Serializable]
    public sealed class OrderReport
    {
        public static readonly OrderReport Empty = Of(0, 0M, 0);

        public static OrderReport Of(int totalOrderCount, decimal totalOrderAmt, int totalProductQty)
            => new OrderReport(totalOrderCount, totalOrderAmt, totalProductQty);

        public static OrderReport Of(IEnumerable<Order> orders) => new OrderReport(
            orders.Count(),
            orders.Sum(x => x.Items.Sum(o => o.Qty * o.Product.UnitPrice)),
            orders.Sum(x => x.Items.Sum(o => o.Qty))
        );

        private OrderReport(int totalOrderCount, decimal totalOrderAmt, int totalProductQty)
        {
            TotalOrderCount = totalOrderCount; TotalProductQuantity = totalProductQty; TotalOrderAmount = totalOrderAmt;
        }

        public int TotalOrderCount { get; }
        public int TotalProductQuantity { get; }
        public decimal TotalOrderAmount { get; }
        public decimal AvgOrderAmount => TotalProductQuantity <= 0 ? 0M : TotalOrderAmount / TotalOrderCount;
    }
}
