using ApiDeCadastro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiDeCadastro.Context.ModelsMapping;

public class UserMapping : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .IsRequired()
            .HasColumnName("Id")
            .HasColumnOrder(1);
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(64)
            .HasColumnName("Name")
            .HasColumnOrder(2);
        builder.Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(128)
            .HasColumnName("Email")
            .HasColumnOrder(4);
        builder.Property(x => x.Surname)
            .IsRequired()
            .HasMaxLength(64)
            .HasColumnName("Surname")
            .HasColumnOrder(3);
        builder.Property(x => x.Password)
            .IsRequired()
            .HasMaxLength(20)
            .HasColumnName("Password")
            .HasColumnOrder(5);
        builder.Property(x => x.Username)
            .IsRequired()
            .HasMaxLength(64)
            .HasColumnName("Username")
            .HasColumnOrder(6);
        builder.Property(x => x.DateCreating)
            .IsRequired()
            .HasColumnName("DateCreating")
            .HasColumnOrder(7);
    }
}
