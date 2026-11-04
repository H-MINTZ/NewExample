using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingController : ControllerBase
    {
        MyDataContext db = new MyDataContext();
        [HttpGet]
        public List<Shipping> GatAllShipping()
        {
            return db.Shipping.ToList();
        }
        [HttpPost]
        public void AddShipping(Shipping Shipping)
        {
            db.Shipping.Add(Shipping);
            db.SaveChanges();
        }
        [HttpPut]
        public void UpdateShipping(Shipping s)
        {
            Shipping s2 = db.Shipping.FirstOrDefault(x => x.ShippingId == s.ShippingId);
            s2.ShippingDate = s.ShippingDate;
            s2.StatusServer = s.StatusServer;
            s2.Status = s.Status;
            db.Shipping.Update(s2);
            db.SaveChanges();
        }

    }
}


