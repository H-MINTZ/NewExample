using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class Products
    {
        //public Products()
        //{
        //    OederDetail = new HashSet<OederDetail>();
        //}

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Material { get; set; }
        public string Description { get; set; }
        public int? Price { get; set; }
        public int? Stock { get; set; }
        public string Image { get; set; }
        public int? Discount { get; set; }
        public string StartDate { get; set; }
        public bool? Status { get; set; }

        //public virtual ICollection<OederDetail> OederDetail { get; set; }
    }
}
