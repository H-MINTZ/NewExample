using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        MyDataContext db = new MyDataContext();
        [HttpGet]
        public List<Products> GatAllProducts()
        {
            return db.Products.ToList();
        }
        [HttpGet("ByCategory")]
        // פעולה שמקבלת קטגוריה ומחזירה רשימה של מוצרים
        public List<Products> GetAllProductsByCategory(string category) 
        {
            // סינון המוצרים לפי הקטגוריה שהתקבלה והחזרת התוצאות כרשימה
            return db.Products.Where(x =>x.Category == category).ToList();
        }
        [HttpPost]
        public void AddProducts(Products Products)
        {
            db.Products.Add(Products);
            db.SaveChanges();
        }
        [HttpPut]
        public void UpdateProducts(Products p)
        {
            Products p2 = db.Products.FirstOrDefault(x => x.ProductId == p.ProductId);
            p2.ProductName = p.ProductName;
            p2.Category = p.Category;
            p2.Status = p.Status;
            p2.Material = p.Material;
            p2.Description = p.Description;
            p2.StartDate = p.StartDate;
            p2.Discount = p.Discount;
            p2.Image = p.Image;
            p2.Price = p.Price;
            p2.Stock = p.Stock;
            db.Products.Update(p2);
            db.SaveChanges();
        }
        [HttpPut("updateTry")]
        public void UpdateProducts1(Products p)
        {
            Products p2 = db.Products.FirstOrDefault(x => x.ProductId == p.ProductId);
            p2.ProductName = p.ProductName;
            p2.Category = p.Category;
            p2.Status = p.Status;
            p2.Material = p.Material;
            p2.Description = p.Description;
           
            db.Products.Update(p2);
            db.SaveChanges();
        }
    }



}

