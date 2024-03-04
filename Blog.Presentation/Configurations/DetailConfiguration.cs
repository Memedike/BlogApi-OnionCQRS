using Blog.Domain.Common.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Blog.Presentation.Configurations
{
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(150);
            builder.Property(x=> x.Description).HasMaxLength(550);

            Detail detail1 = new()
            {
                Id = 1,
                Title = "arayuz",
                Description = "Web İçindir",
                CategoryId = 2,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            };
            Detail detail2 = new()
            {
                Id = 2,
                Title = "verit",
                Description = "Veri tabanı",
                CategoryId = 3,
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            };
            Detail detail3 = new()
            {
                Id = 2,
                Title = "back",
                Description = "Backend icin",
                CategoryId = 1,
                CreatedDate = DateTime.Now,
                IsDeleted = true,
            };
            builder.HasData(detail1,detail2,detail3);

        }
    }
}
