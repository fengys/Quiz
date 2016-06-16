using System.Collections.Generic;

namespace Quiz
{
    public class Order
    {
        public long Id { get; set;}
        public string Number { get; set; }
        public IList<OrderItem> Items { get; set; }
    }
}
