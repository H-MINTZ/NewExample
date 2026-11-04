using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        MyDataContext db = new MyDataContext();
        [HttpGet]
        public List<Customers> GetAllCustomers()
        {
            return db.Customers.ToList();
        }
        [HttpGet("by City")]
        // פעולה שמקבלת שם עיר ומחזירה רשימת לקוחות
        public List<Customers> GetCustomersByCity(string City)
        {
            // סינון הלקוחות לפי העיר שהתקבלה והחזרת התוצאות כרשימה
            return db.Customers.Where(x => x.City == City).ToList();
        }
        [HttpPost]
        public void AddCustomers (Customers customers)
        {
            db.Customers.Add(customers);
            db.SaveChanges();
        }
        [HttpPut]
        public void UpdateCustomers(Customers c)
        {
            Customers c2 = db.Customers.FirstOrDefault(x => x.CustomerId == c.CustomerId);
            c2.CustomerNum = c.CustomerNum;
            c2.Address = c.Address;
            c2.Firstname = c.Firstname;
            c2.Lastname = c.Lastname;
            c2.City = c.City;
            c2.Status = c.Status;
            c2.Email = c.Email;
            db.Customers.Update(c2);
            db.SaveChanges();
        }


    }
}
