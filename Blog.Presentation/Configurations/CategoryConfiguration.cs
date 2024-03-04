using Blog.Domain.Common.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System.Data.SqlTypes;

namespace Blog.Presentation.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x=> x.Name).HasMaxLength(150);

            Category category1 = new()
            {
                Id = 1,
                Name = "Back-End",
                CreatedDate = DateTime.Now,
                Priorty = 1,
                ParentId = 0,
                IsDeleted = false,
            };
            Category category2 = new()
            {
                Id = 2,
                Name = "Front-End",
                CreatedDate = DateTime.Now,
                Priorty = 1,
                ParentId = 0,
                IsDeleted = false,
            };
            Category category3 = new()
            {
                Id = 3,
                Name = "Full-Stack",
                CreatedDate = DateTime.Now,
                Priorty = 1,
                ParentId = 0,
                IsDeleted = true,
            };

            Category parent1 = new()
            {
                Id = 4,
                Name = "DataBase",
                CreatedDate = DateTime.Now,
                Priorty = 1,
                ParentId = 3,
                IsDeleted = false,
            };
            Category parent2 = new()
            {
                Id = 5,
                Name = "Freamwork",
                CreatedDate = DateTime.Now,
                Priorty = 1,
                ParentId = 2,
                IsDeleted = true,
            };

            builder.HasData(category1, category2,category3,parent1,parent2);
        }

    }
}
