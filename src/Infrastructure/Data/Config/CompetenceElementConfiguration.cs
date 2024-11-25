using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SteelDonkey.Core.Entities.CompetencyElements;

namespace Infrastructure.Data.Config
{
    public class CompetenceElementConfiguration : IEntityTypeConfiguration<CompetenceElement>
    {
        public void Configure(EntityTypeBuilder<CompetenceElement> builder)
        {
            builder.ToTable("CompetenceElement");

            builder.HasOne(e => e.CompetenceElementGroup)
                .WithMany(e => e.CompetenceElements)
                .HasForeignKey(e => e.CompetenceElementGroupId)
                .HasPrincipalKey(e => e.Id);
        }
    }
}
