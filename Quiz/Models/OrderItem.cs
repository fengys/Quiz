namespace Quiz
{
    public class OrderItem
    {
        public long Id { get; set; }
        public long OrderId {get;set;}
        public int Qty { get; set; }
        public Product Product { get; set; }
    }
}
