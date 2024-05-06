using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SYDSigorta.Domain.Entities
{
    using SYDSigorta.Domain.Common;

    public class Detail : EntityBase
    {
        public Detail()
        {
            
        }

        public Detail(string title, string description,int categoryID)
        {
            Title=title;
            Description=description;
            CategoryID=categoryID;
        }
        public string Title { get; set; }

        public string Description { get; set; }

        public int CategoryID { get; set; }

       //Relational Properties

       public Category Category { get; set; }

    }
}
