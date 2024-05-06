using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYDSigorta.Domain.Entities
{
    using SYDSigorta.Domain.Common;

    public class Product : EntityBase
    {
        public string Title { get; set; }

        public string Name { get; set; }

        public int BrandID { get; set; }

        public decimal Price { get; set; }

        public decimal Discount { get; set; }
        
        //Relational Properties
        public Brand Brand { get; set; }

        public ICollection<Category> Categories { get; set; }
    }
}
