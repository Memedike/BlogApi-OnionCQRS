using Blog.Domain.Common.Entites;
using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Blog.Presentation.Configurations;

public class CardConfiguration: IEntityTypeConfiguration<Card>
{
    public void Configure(EntityTypeBuilder<Card> builder)
    {
        builder.Property(x=> x.Name).HasMaxLength(150);

        Card card1 = new()
        {
            Id= 1,
            Name = "C#",
            CreatedDate = DateTime.Now,
            IsDeleted = false,
        };
        Card card2 = new()
        {
            Id = 2,
            Name = "JavaScript",
            CreatedDate = DateTime.Now,
            IsDeleted = true,
        };
        Card card3 = new()
        {
            Id = 3,
            Name = "SQL",
            CreatedDate = DateTime.Now,
            IsDeleted = false,
        };
        builder.HasData(card1,card2, card3);

    }
}
