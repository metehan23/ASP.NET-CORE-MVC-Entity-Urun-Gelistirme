using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkCalismalari.MvcWebUI.Models.Entity
{
    public class Supplier
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
        }
        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }


        public virtual ICollection<Product> Products { get; set; }
    }
}
