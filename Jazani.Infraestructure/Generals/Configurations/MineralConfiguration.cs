using Jazani.Domain.Generals.Models;
using Jazani.Infraestructure.Cores.Converters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Jazani.Infraestructure.Generals.Configurations
{
    public class MineralConfiguration : IEntityTypeConfiguration<Mineral>
    {
        public void Configure(EntityTypeBuilder<Mineral> builder)
        {
            builder.ToTable("mineral", "ge");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.MineraltypeId).HasColumnName("mineraltypeid");
            builder.Property(x => x.Name).HasColumnName("name");
            builder.Property(x => x.Description).HasColumnName("description");
            builder.Property(x => x.Symbol).HasColumnName("symbol");
            builder.Property(x => x.RegistrationDate)
                .HasColumnName("registrationdate")
                .HasConversion(new DateTimeToDateTimeOffset());
            builder.Property(x => x.State).HasColumnName("state");

            builder.HasOne(one => one.MineralType).WithMany(many => many.Minerals)
                .HasForeignKey(fk => fk.MineraltypeId);
        }
    }
}
