using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYDSigorta.Domain.Entities
{
    using SYDSigorta.Domain.Common;

    public class Category : EntityBase,IEntityBase
    {
        public Category()
        {
            
        }

        public Category(int parentID,string name, int priorty)
        {
            ParentID = parentID;
            Name = name;
            Priorty = priorty;
        }
        public required int ParentID { get; set; }
        public required string Name { get; set; }
        public required int Priorty { get; set; }


        //Relational Properties
        public ICollection<Detail> Details { get; set; }

        public ICollection<Product> Products { get; set; }






    }
}
