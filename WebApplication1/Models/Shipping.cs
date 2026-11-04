using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Shipping
    {
        //public Shipping()
        //{
        //    Orders = new HashSet<Orders>();
        //}

        public int ShippingId { get; set; }
        public string ShippingDate { get; set; }
        public string StatusServer { get; set; }
        public bool? Status { get; set; }

        //public virtual ICollection<Orders> Orders { get; set; }
    }
}
