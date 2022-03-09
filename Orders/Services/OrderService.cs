using Orders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Services
{
    public class OrderService : IOrderService
    {
        private IList<Order> _orders;
        public OrderService()
        {
            _orders = new List<Order>();
            _orders.Add(new Order("1000", "250 conference", DateTime.Now, 1, "dghkrhglsgh"));
            _orders.Add(new Order("1000", "250 conference", DateTime.Now.AddHours(1), 2, "glerukdghlr"));
            _orders.Add(new Order("1000", "250 conference", DateTime.Now.AddHours(2), 3, "drlijhpijrd"));
            _orders.Add(new Order("1000", "250 conference", DateTime.Now.AddHours(2), 4, "tuhoeudybhn"));
        }
        public Task<Order> GetOrderByIdAsync(string id)
        {
            return Task.FromResult(_orders.Single(o => Equals
            (o.Id, id)));
        }

        public Task<IEnumerable<Order>> GetOrdersAsync()
        {
            return Task.FromResult(_orders.AsEnumerable());
        }
    }
    public interface IOrderService
    {
        Task<Order> GetOrderByIdAsync(string id);
        Task<IEnumerable<Order>> GetOrdersAsync();

    }
}
