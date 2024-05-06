using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYDSigorta.Domain.Entities
{
    using SYDSigorta.Domain.Common;

    public class Brand : EntityBase,IEntityBase
    {
        public Brand()
        {
            
        }

        public Brand(string name)
        {
            Name = name;
            
        }
        public required string Name { get; set; }


        //Relational Properties
        public ICollection<Product> Products { get; set; }


        
    }
}
