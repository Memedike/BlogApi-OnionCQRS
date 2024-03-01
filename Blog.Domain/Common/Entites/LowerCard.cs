using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Common.Entites
{
    public class LowerCard: EntityBase
    {

        public required string Title { get; set; }
        public required string Description { get; set; }
        public required int CardId { get; set; }

        public  Card card { get; set; }
        public ICollection<Category> categories { get; set; }

        // public string ImagePath { get; set; }
    }
}
