using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SteelDonkey.Core.Entities.CompetencyElements;

namespace Infrastructure.Data.Config
{
    internal class CompetenceElementGroupConfiguration : IEntityTypeConfiguration<CompetenceElementGroup>
    {
        public void Configure(EntityTypeBuilder<CompetenceElementGroup> builder)
        {
            builder.ToTable("CompetenceElementGroup");

            builder
                .HasOne(e => e.Owner)
                .WithMany()
                .HasForeignKey(e => e.OwnerId)
                .HasPrincipalKey(e => e.Id);
        }
    }
}
