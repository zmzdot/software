using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagement
{
    public class OrderService
    {
        public List<Order> orders = new List<Order>();

        public void AddOrder(Order order)
        {
            if (orders.Contains(order))
            {
                throw new InvalidOperationException("订单已存在");
            }
            orders.Add(order);
        }

        public void DeleteOrder(string orderId)
        {
            Order orderToDelete = orders.FirstOrDefault(o => o.OrderId == orderId);
            if (orderToDelete == null)
            {
                throw new InvalidOperationException($"订单 {orderId} 不存在");
            }
            orders.Remove(orderToDelete);
        }

        public void UpdateOrder(Order updatedOrder)
        {
            Order orderToUpdate = orders.FirstOrDefault(o => o.OrderId == updatedOrder.OrderId);
            if (orderToUpdate == null)
            {
                throw new InvalidOperationException($"订单 {updatedOrder.OrderId} 不存在");
            }
            if (orders.Where(o => o != orderToUpdate).Contains(updatedOrder))
            {
                throw new InvalidOperationException("更新后的订单已存在");
            }
            orderToUpdate.Customer = updatedOrder.Customer;
            orderToUpdate.Details = updatedOrder.Details;
        }

        public List<Order> QueryOrdersByOrderId(string orderId)
        {
            return orders.Where(o => o.OrderId == orderId).OrderBy(o => o.TotalAmount).ToList();
        }

        public List<Order> QueryOrdersByProduct(string product)
        {
            return orders.Where(o => o.Details.Any(d => d.Product == product)).OrderBy(o => o.TotalAmount).ToList();
        }

        public List<Order> QueryOrdersByCustomer(string customer)
        {
            return orders.Where(o => o.Customer == customer).OrderBy(o => o.TotalAmount).ToList();
        }

        public void SortOrders()
        {
            orders = orders.OrderBy(o => o.OrderId).ToList();
        }

        public void SortOrders(Func<Order, Order, int> compare)
        {
            orders = orders.OrderBy(o => o, new OrderComparer(compare)).ToList();
        }
        public class OrderComparer : IComparer<Order>
        {
            private readonly Func<Order, Order, int> compare;

            public OrderComparer(Func<Order, Order, int> compare)
            {
                this.compare = compare;
            }

            public int Compare(Order x, Order y)
            {
                return compare(x, y);
            }
        }
    }

    public class OrderDetails
    {
        public string Product { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            OrderDetails other = (OrderDetails)obj;
            return Product == other.Product;
        }

        public override int GetHashCode()
        {
            return Product.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Product}: {Quantity} x {Price}";
        }
    }

    public class Order
    {
        public string OrderId { get; set; }
        public string Customer { get; set; }
        public List<OrderDetails> Details { get; set; } = new List<OrderDetails>();
        public decimal TotalAmount => Details.Sum(d => d.Price * d.Quantity);

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Order other = (Order)obj;
            return OrderId == other.OrderId;
        }

        public override int GetHashCode()
        {
            return OrderId.GetHashCode();
        }

        public override string ToString()
        {
            string detailsStr = string.Join(", ", Details.Select(d => $"{d.Product}: {d.Quantity} x {d.Price}"));
            return $"OrderId: {OrderId}, Customer: {Customer}, Details: [{detailsStr}], TotalAmount: {TotalAmount}";
        }
    }
    class Program
    {
        static void Main()
        {
            OrderService orderService = new OrderService();
            List<Order> orders = orderService.orders;
            // 测试添加订单
            Order order1 = new Order
            {
                OrderId = "1",
                Customer = "Customer1",
                Details = { new OrderDetails { Product = "Product1", Price = 10, Quantity = 2 } }
            };
            try
            {
                orderService.AddOrder(order1);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"添加订单失败: {ex.Message}");
            }

            // 测试查询订单
            var ordersByCustomer = orderService.QueryOrdersByCustomer("Customer1");
            foreach (var order in ordersByCustomer)
            {
                Console.WriteLine(order);
            }

            Console.ReadLine();
        }
    }
}
