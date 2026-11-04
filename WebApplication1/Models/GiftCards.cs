using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class GiftCards
    {
        //public GiftCards()
        //{
        //    Orders = new HashSet<Orders>();
        //}

        public int GiftCardId { get; set; }
        public int? Amount { get; set; }
        public string ExpirationDate { get; set; }
        public bool? IsUsed { get; set; }
        public bool? Status { get; set; }

        //public virtual ICollection<Orders> Orders { get; set; }
    }
}
