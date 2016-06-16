using System;
namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderList = Question.GetOrderSummaries(Data.AllOrders);

            var orderReport = Question.GetOrderReport(Data.AllOrders);

            Console.WriteLine($"--- Done!");
        }
    }
}
