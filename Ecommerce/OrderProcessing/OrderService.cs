using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessing
{
    public class OrderService : IOrderService
    {
        private List<Order> orders;
        public OrderService()
        {
            this.orders = new List<Order>();
        }
        public bool Delete(int id)
        {
            Order order = this.Get(id);
            orders.Remove(order);
            return true;
        }

        public Order Get(int id)
        {
            foreach (Order order in orders)
            {
                if (order.OrderId == id) return order;
            }
            return null;
        }

        public List<Order> GetAll()
        {
            return this.orders;
        }

        public bool Insert(Order order)
        {
            this.orders.Add(order);
            return true;
        }

        public bool Update(Order order)
        {
            Order order1 = this.Get(order.OrderId);
            orders.Remove(order);
            orders.Add(order1);
            return true;

        }
    }
}