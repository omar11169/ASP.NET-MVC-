using Firstwebday1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Firstwebday1.Configuration
{
    public class CatagoryConfiguration : IEntityTypeConfiguration<Catagory>
    {
        public void Configure(EntityTypeBuilder<Catagory> builder)
        {
            builder.ToTable("Catagory");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Name).IsRequired();


        }
    }
}