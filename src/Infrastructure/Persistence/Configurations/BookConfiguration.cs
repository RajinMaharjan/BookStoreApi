using Bookstore.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore.Infrastructure.Persistence.Configurations
{
    public class BookConfiguration:IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").HasColumnType("VARCHAR(50)").HasMaxLength(50).IsRequired();
            builder.Property(x => x.UserId).HasColumnName("user_id").HasColumnType("VARCHAR(50)").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Title).HasColumnName("title").HasColumnType("VARCHAR(50)").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Category).HasColumnName("category").HasColumnType("VARCHAR(50)").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Author).HasColumnName("author").HasColumnType("VARCHAR(50)").HasMaxLength(50).IsRequired();
            builder.Property(x => x.YearPublished).HasColumnName("year_published").HasDefaultValue(DateTime.Now);
            builder.Property(x => x.Price).HasColumnName("price").HasColumnType("DECIMAL(18,2)").HasMaxLength(20).IsRequired();
            builder.Property(x => x.Description).HasColumnName("descriptiion").HasColumnType("VARCHAR(500)").HasMaxLength(50).IsRequired();
            builder.Property(x => x.ImagePath).HasColumnName("image_path").HasColumnType("VARCHAR(500)").HasMaxLength(500).IsRequired(false);
            builder.Property(x => x.ImageUrl).HasColumnName("image_url").HasColumnType("VARCHAR(500)").HasMaxLength(500).IsRequired(false);
            builder.Property(x => x.Available).HasColumnName("available").HasDefaultValue(true);
        }
    }
}

