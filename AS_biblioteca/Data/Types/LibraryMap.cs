using AS_biblioteca.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AS_biblioteca.Data.Types
{
    public class LibraryMap : IEntityTypeConfiguration<Library>
    {
        public void Configure(EntityTypeBuilder<Library> builder)
        {
            builder.ToTable("Library");
            builder.HasKey(i => i.Id);
            builder.Property(i => i.BookId)
                .HasColumnName("BookId")
                .IsRequired();

            builder.Property(i => i.UserId)
                .HasColumnName("UserId")
                .IsRequired();
            
            builder.Property(i => i.Acao)
                .HasColumnName("Acao")
                .IsRequired();

            builder
                .HasOne(i => i.Book)
                .WithMany(i => i.Librarys)
                .HasForeignKey(i => i.BookId)
                .OnDelete(DeleteBehavior.ClientCascade);

             builder
                .HasOne(i => i.User)
                .WithMany(i => i.Librarys)
                .HasForeignKey(i => i.BookId)
                .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}