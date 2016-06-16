using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz
{
    [Serializable]
    public sealed class OrderSummary
    {
        public static readonly OrderSummary Empty = Of(0, string.Empty, 0, 0m);

        public static OrderSummary Of(long id, string orderNbr, int productQty, decimal totalAmt)
            => new OrderSummary(id, orderNbr, productQty, totalAmt);

        public static IEnumerable<OrderSummary> Of(IEnumerable<Order> orders)
            => orders.Select(
                x => new OrderSummary(
                    x.Id,
                    x.Number,
                    x.Items.Sum(o => o.Qty),
                    x.Items.Sum(o => o.Qty * o.Product.UnitPrice)
                )
            );

        private OrderSummary(long id, string orderNbr, int productQty, decimal totalAmt)
        {
            Id = id; ProductQuantity = productQty; OrderNumber = orderNbr; TotalAmount = totalAmt;
        }

        public long Id { get; }
        public int ProductQuantity { get; }
        public string OrderNumber { get; }
        public decimal TotalAmount { get; }
    }
}
