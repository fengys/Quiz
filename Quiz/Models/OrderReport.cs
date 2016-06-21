namespace Quiz
{
    public class OrderReport
    {
        public int TotalOrder { get; set; }
        public int TotalProductQty { get; set; }
        public decimal AvgOrderAmount => TotalOrder <= 0 ? 0M : TotalOrderAmount / TotalOrder;
        public decimal TotalOrderAmount { get; set; }
    }
}
