using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PruebaTecnica.Dominio;

namespace PruebaTecnica.Infrastructure.Persistance;

public class ClienteConfigurations : IEntityTypeConfiguration<Clientes>
{
    public void Configure(EntityTypeBuilder<Clientes> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Nombre).HasMaxLength(200).IsRequired();
        builder.Property(p => p.Apellidos).HasMaxLength(200).IsRequired();
        builder.Property(p => p.Cedula).HasMaxLength(11).IsRequired();
    }
}