using Firstwebday1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Firstwebday1.Configuration
{
    public class PaymentInformationConfiguration : IEntityTypeConfiguration<PaymentInformation>
    {
        public void Configure(EntityTypeBuilder<PaymentInformation> builder)
        {
            builder.ToTable("PaymentInformation");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.PaymentMethod).IsRequired();
            builder.Property(p => p.CardNumber).IsRequired();
            builder.Property(p => p.ExpirationDate).IsRequired().HasColumnType("datetime"); ;
            builder.Property(p => p.CVV).IsRequired();



            builder.HasOne(c => c.Customer)
               .WithMany(s => s.PaymentInformationList)
               .HasForeignKey(c => c.CustomerId)
               .OnDelete(DeleteBehavior.Cascade);
        }
    }
}