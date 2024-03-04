using Blog.Domain.Common.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Common.Entites
{
    public class Category : EntityBase
    {
        public Category(int parentId, string name, int priorty)
        {
            ParentId = parentId;
            Name = name;
            Priorty = priorty;
        }
        public Category()
        {

        }
        public required int ParentId { get; set; }
        public required string Name { get; set; }

        public required int Priorty { get; set; }

        public ICollection<Detail> Details { get; set; }
        public ICollection<LowerCard> LowerCards { get; set; }
    }
}
