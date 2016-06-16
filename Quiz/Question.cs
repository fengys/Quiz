using System.Collections.Generic;
using System.Linq;

namespace Quiz
{
    /// <summary>
    ///  Todo: 实现
    ///  函数 GetOrderSummaries 列表每条Order： 计算Product数量(ProductQty)， 订单金额（TotalAmount）
    ///  函数 GetOrderReport 获取所有订单统计： Order总数（TotalRows）， Product数量（TotalProductQty），平均每个订单金额（AvgOrderAmount），所有订单金额（TotalOrderAmount）
    /// </summary>
    public class Question
    {
        public static List<OrderSummary> GetOrderSummaries(IEnumerable<Order> orders)
            => (orders == null ? Enumerable.Empty<OrderSummary>() : OrderSummary.Of(orders)).ToList();

        public static OrderReport GetOrderReport(IEnumerable<Order> orders)
            => orders == null ? OrderReport.Empty : OrderReport.Of(orders);
    }
}
