using AS_biblioteca.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AS_biblioteca.Data.Types
{
    public class BookMap : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.ToTable("Books");
        builder.Property(i => i.Id)
            .HasColumnName("id");
        builder.HasKey(i => i.Id);

        builder.Property(i => i.UserId)
                .HasColumnName("UserId")
                .IsRequired();

        builder.Property(i => i.AuthorId)
                .HasColumnName("AuthorId")
                .IsRequired();

        builder.Property(i => i.Title)
            .HasColumnName("Title")
            .IsRequired()
            .HasColumnType("Varchar(200)");

        builder.Property(i => i.Publisher)
            .HasColumnName("Publisher")
            .IsRequired()
            .HasColumnType("Varchar(200)");

        builder.Property(i => i.SerialNumber)
            .HasColumnName("Serial Number")
            .IsRequired();

        builder.HasOne(i => i.User)
            .WithMany(j => j.Book);

        builder
            .HasMany(b => b.Author)
            .WithMany(a => a.Book)
            .UsingEntity<Dictionary<string, object>>(
                "BookAuthor",
                j => j.HasOne<Author>().WithMany().HasForeignKey("AuthorId"),
                j => j.HasOne<Book>().WithMany().HasForeignKey("BookId"),
                j =>
                {
                    j.HasKey("BookId", "AuthorId");
                    j.ToTable("BookAuthor");
                });
    }
}
}