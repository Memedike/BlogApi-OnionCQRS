using Blog.Domain.Common.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Presentation.Configurations
{
    public class LowerCardConfiguration : IEntityTypeConfiguration<LowerCard>
    {
        public void Configure(EntityTypeBuilder<LowerCard> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(150);
            builder.Property(x => x.Description).HasMaxLength(550);

            LowerCard lowerCard1 = new()
            {
                Id = 1,
                Title = "Reat",
                Description = "dsadasd",
                CardId = 2,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            };
            LowerCard lowerCard2 = new()
            {
                Id = 2,
                Title = "SQLite",
                Description = "dsadasd",
                CardId = 3,
                CreatedDate = DateTime.Now,
                IsDeleted = true,
            };
            LowerCard lowerCard3 = new()
            {
                Id = 3,
                Title = "Web API",
                Description = "dsadasd",
                CardId = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = true,
            };

            builder.HasData(lowerCard1, lowerCard2,lowerCard3);
        }
    }
}
