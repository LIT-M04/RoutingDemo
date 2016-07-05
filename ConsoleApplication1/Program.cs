using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public enum OrderStatus
    {
        Placed,
        Viewed,
        OutForDelivery,
        Delivered
    }

    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new ThrowawayDataContext();
            Order o = new Order();
            o.Status = OrderStatus.OutForDelivery;
            ctx.Orders.InsertOnSubmit(o);
            ctx.SubmitChanges();
        }
    }
}
