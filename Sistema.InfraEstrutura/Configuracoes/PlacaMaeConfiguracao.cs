using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;


namespace Sistema.InfraEstrutura.Configuracoes
{
    public class PlacaMaeConfiguracao : EntityTypeConfiguration<PlacaMae>
    {
        public PlacaMaeConfiguracao()
        {
            ToTable("PlacaMae");

            HasKey(placaMae => placaMae.IDPlacaMae);

            Property(placaMae => placaMae.IDPlacaMae)
                .HasColumnName("IDPlacaMae");

            //Property(placaMae => placaMae.IDComputador)
            //    .HasColumnName("IDComputador")
            //    .IsRequired();

            Property(placaMae => placaMae.Marca)
                .HasColumnName("Marca")
                .IsRequired();

            Property(placaMae => placaMae.Modelo)
                .HasColumnName("Modelo")
                .IsRequired();

            //HasRequired(placaMae => placaMae.Computadores)
            //    .WithOptional(computador => computador.PlacaMae);
        }
    }
}
