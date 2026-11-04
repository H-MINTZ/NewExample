using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Customers
    {
        //public Customers()
        //{
        //    Orders = new HashSet<Orders>();
        //}

        public string CustomerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool? Status { get; set; }
        public string City { get; set; }
        public int CustomerNum { get; set; }

        //public virtual ICollection<Orders> Orders { get; set; }
    }
}
