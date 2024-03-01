using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Domain.Common.Entites
{
    public class Card : EntityBase
    {
        public Card()
        {

        }
        public Card(string Name)
        {
            this.Name = Name;
        }
        public required string Name { get; set; }

    }
}
