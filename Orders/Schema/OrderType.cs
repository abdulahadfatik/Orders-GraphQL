using GraphQL.Types;
using Orders.Models;
using Orders.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Schema
{
    public class OrderType : ObjectGraphType<Order>
    {
        public OrderType(ICustomerService customers)
        {
            Field(o => o.Id);
            Field(o => o.Name);
            Field(o => o.Description);
            Field<CustomerType>("customer", resolve: context => 
                customers.GetCustomerByIdAsync(context.Source.CustomerId));
            Field(o => o.Created);
        }
    }
}
