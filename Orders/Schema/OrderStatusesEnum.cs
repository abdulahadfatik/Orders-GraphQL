using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Schema
{
    public class OrderStatusesEnum : EnumerationGraphType
    {
        public OrderStatusesEnum()
        {
            Name = "OrderStatuses";
            AddValue("CREATED", "Order was Created",2);
            AddValue("PROCESSING", "Order is being processed",4);
            AddValue("COMPLETED", "Order is Completed",8);
            AddValue("CANCELLED", "Order was canceled",16);
            AddValue("CLOSED", "Order was closed",32);
        }
    }
}
