using Blog.Domain.Common.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Common.Entites
{
    public class Detail : EntityBase
    {
        public Detail(string title, string description, int categoryId)
        {
            Title = title;
            Description = description;
            CategoryId = categoryId;
        }
        public Detail()
        {

        }
        public required string Title { get; set; }
        public required string Description { get; set; }

        public required int CategoryId { get; set; }

        public Category category { get; set; }
    }
}
