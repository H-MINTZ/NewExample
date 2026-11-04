using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class OederDetailController : ControllerBase
    {
        MyDataContext db = new MyDataContext();
        [HttpGet]
        public List<OederDetail> GatAllOederDetail()
        {
            return db.OederDetail.ToList();
        }
        [HttpPost]
        public void AddOederDetail(OederDetail OederDetail)
        {
            db.OederDetail.Add(OederDetail);
            db.SaveChanges();
        }
        [HttpPut]
        public void UpdateProduct(OederDetail od)
        {
            OederDetail od2 = db.OederDetail.FirstOrDefault(x => x.CodeOrder == od.CodeOrder);
            od2.CodeProdect = od.CodeProdect;
            od2.PriceAddition = od.PriceAddition;
            od2.DiscibeAddition = od.DiscibeAddition;
            db.OederDetail.Update(od2);
            db.SaveChanges();
        }


    }
}
