using AS_biblioteca.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AS_biblioteca.Data.Types
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
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

            builder.Property(i => i.Cpf)
                .HasColumnName("Cpf")
                .IsRequired()
                .HasColumnType("Varchar(14)");

            builder.HasMany(i => i.Book)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);
        }
    }
}