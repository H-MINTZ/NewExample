using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Orders
    {
        //public Orders()
        //{
        //    OederDetail = new HashSet<OederDetail>();
        //}

        public int OrderId { get; set; }
        public int? CustomerNum { get; set; }
        public string OrderDate { get; set; }
        public int? TotalPrice { get; set; }
        public int? ShippingId { get; set; }
        public int? GiftCard { get; set; }

        //public virtual Customers CustomerNumNavigation { get; set; }
        //public virtual GiftCards GiftCardNavigation { get; set; }
        //public virtual Shipping Shipping { get; set; }
        //public virtual ICollection<OederDetail> OederDetail { get; set; }
    }
}
