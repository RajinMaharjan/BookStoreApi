using Bookstore.Domain.Entities;
using Bookstore.Domain.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Infrastructure.Persistence.Configurations
{
    public class UserConfiguration:IEntityTypeConfiguration<User>
    {
        private readonly Role role = Role.User;
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("VARCHAR(50)").HasMaxLength(50).IsRequired().HasDefaultValue(Guid.NewGuid());
            builder.Property(x => x.FirstName).HasColumnName("first_name").HasColumnType("VARCHAR(50)").HasMaxLength(50).IsRequired();
            builder.Property(x => x.LastName).HasColumnName("last_name").HasColumnType("VARCHAR(50)").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Email).HasColumnName("email").HasColumnType("VARCHAR(50)").HasMaxLength(50).IsRequired();
            builder.Property(x => x.PhoneNumber).HasColumnName("phone_number").HasColumnType("VARCHAR(10)").IsFixedLength().IsRequired();
            builder.Property(x => x.PasswordHash).HasColumnName("password_hash").HasColumnType("VARCHAR(200)").HasMaxLength(200).IsRequired();
            builder.Property(x => x.Role).HasColumnName("role").HasColumnType("INT").IsRequired().HasDefaultValue(role);
            builder.Property(x => x.PhotoUrl).HasColumnName("photo_url").HasColumnType("VARCHAR(500)").HasMaxLength(500).IsRequired(false);
            builder.HasMany(x => x.Books).WithOne(x => x.User).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
