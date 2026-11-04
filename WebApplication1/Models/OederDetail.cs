using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class OederDetail
    {
        public int CodeOrder { get; set; }
        public int CodeProdect { get; set; }
        public int? PriceAddition { get; set; }
        public string DiscibeAddition { get; set; }

        //public virtual Orders CodeOrderNavigation { get; set; }
        //public virtual Products CodeProdectNavigation { get; set; }
    }
}
