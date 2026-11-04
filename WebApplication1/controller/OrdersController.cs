using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        MyDataContext db = new MyDataContext();
        [HttpGet]
        public List<Orders> GatAllOrders()
        {
            return db.Orders.ToList();
        }
        [HttpPost]
        public void AddOrders(Orders Orders)
        {
            db.Orders.Add(Orders);
            db.SaveChanges();
        }
        [HttpPut]
        public void UpdateOrders(Orders o)
        {
            Orders o2 = db.Orders.FirstOrDefault(x => x.OrderId == o.OrderId);
            o2.CustomerNum = o.CustomerNum;
            o2.OrderDate = o.OrderDate;
            o2.TotalPrice = o.TotalPrice;
            o2.ShippingId = o.ShippingId;
            o2.GiftCard = o.GiftCard;
            db.Orders.Update(o2);
            db.SaveChanges();
        }

    }
}
