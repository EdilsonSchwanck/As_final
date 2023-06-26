using AS_biblioteca.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AS_biblioteca.Data.Types
{
    public class AuthorMap : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Authors");
            builder.Property(i => i.Id)
                .HasColumnName("id");
            builder.HasKey(i => i.Id);

            builder.Property(i => i.BookId)
                .HasColumnName("BookId")
                .IsRequired();

            builder.Property(i => i.Name)
                .HasColumnName("Name")
                .IsRequired()
                .HasColumnType("Varchar(200)");

            builder.HasMany(i => i.Book)
                .WithMany(p => p.Author)
                .UsingEntity<Dictionary<string, object>>(
                    "AuthorBook",
                    j => j.HasOne<Book>().WithMany().HasForeignKey("BookId"),
                    j => j.HasOne<Author>().WithMany().HasForeignKey("AuthorId"),
                    j => 
                    {
                        j.HasKey("AuthorId", "BookId");
                        j.ToTable("AuthorBook");
                    }
                );
        }
    }
}