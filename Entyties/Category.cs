using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Enum;

namespace WebApplication3.Entyties
{
    public class Category
    {
            public int Id { set; get; }
            public int SortOrder { set; get; }
        public bool IsShowOnHome { set; get; }
        public int? ParentId { set; get; }
        public Status Status { set; get; }
        public List<ProductInCategory> ProductInCategories { get; set; }
    }
}
