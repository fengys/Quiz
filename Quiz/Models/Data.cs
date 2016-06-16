using System.Collections.Generic;

namespace Quiz
{
    public class Data
    {
        private readonly static Product product1 = new Product
        {
            Id = 100,
            Name = "Product - 1",
            UnitPrice = 29m
        };
        private readonly static Product product2 = new Product
        {
            Id = 101,
            Name = "Product - 2",
            UnitPrice = 16.99m
        };
        private readonly static Product product3 = new Product
        {
            Id = 102,
            Name = "Product - 3",
            UnitPrice = 98.99m
        };

        public static readonly IEnumerable<Order> AllOrders = new List<Order>
        {
            new Order
            {
                Id = 100,
                Number = "A001",
                Items = new List<OrderItem>
                {
                    new OrderItem {
                        Id = 100,
                        OrderId = 100,
                        Qty = 2,
                        Product = product1
                    },

                    new OrderItem {
                        Id = 101,
                        OrderId = 100,
                        Qty = 1,
                        Product = product2
                    },
                }
            },

            new Order
            {
                Id = 101,
                Number = "A002",
                Items = new List<OrderItem>
                {
                    new OrderItem {
                        Id = 103,
                        OrderId = 101,
                        Qty = 3,
                        Product = product1
                    },

                    new OrderItem {
                        Id = 104,
                        OrderId = 101,
                        Qty = 2,
                        Product = product3
                    },
                }
            },

            new Order
            {
                Id = 103,
                Number = "A0025",
                Items = new List<OrderItem>
                {
                    new OrderItem {
                        Id = 104,
                        OrderId = 103,
                        Qty = 3,
                        Product = product3
                    }
                }
            },

            new Order
            {
                Id = 107,
                Number = "A0011",
                Items = new List<OrderItem>
                {
                    new OrderItem {
                        Id = 105,
                        OrderId = 107,
                        Qty = 3,
                        Product = product3
                    },

                    new OrderItem {
                        Id = 106,
                        OrderId = 107,
                        Qty = 2,
                        Product = product1
                    },
                }
            },
        };
    }
}
