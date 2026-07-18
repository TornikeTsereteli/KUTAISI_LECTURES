using Exerciece_EFCORE.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Exerciece_EFCORE.Configuration;

public class LoanConfiguration : IEntityTypeConfiguration<Loan>
{
    public void Configure(EntityTypeBuilder<Loan> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Amount).IsRequired();
        builder.Property(x => x.CountOfMonths).IsRequired();
        builder.Property(x => x.StartDate).IsRequired();
        builder.Property(x => x.CreateAt).IsRequired();
        builder.Property(x => x.UpdateAt).IsRequired(false);


        builder.HasMany(x => x.Payments)
            .WithOne()
            .HasForeignKey(x => x.LoanId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(x => x.Collaterals)
            .WithOne()
            .HasForeignKey(x => x.LoanId)
            .OnDelete(DeleteBehavior.Cascade);
        
    }
}