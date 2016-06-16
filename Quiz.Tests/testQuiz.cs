using System.Linq;
using Shouldly;
using Xunit;

namespace Quiz
{
    public class testQuiz
    {

        [Fact]
        public void Quiz_checkData()
        {
            Data.AllOrders.Count().ShouldBe(4);
        }

        [Fact]
        public void Quiz_getOrderSummaries()
        {
            var summary = Question.GetOrderSummaries(Data.AllOrders).Where(x => x.Id == 100).First();
            summary.ProductQty.ShouldBe(3);
            summary.OrderNumber.ShouldBe("A001");
            summary.TotalAmount.ShouldBe(74.99m);
        }

        [Fact]
        public void Quiz_getOrderReport()
        {
            var report = Question.GetOrderReport(Data.AllOrders);
            report.TotalOrder.ShouldBe(4);
            report.TotalProductQty.ShouldBe(16);
            report.AvgOrderAmount.ShouldBe(252.9775m);
            report.TotalOrderAmount.ShouldBe(1011.91m);
        }
    }
}
