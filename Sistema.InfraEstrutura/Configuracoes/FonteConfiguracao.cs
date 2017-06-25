using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Sistema.InfraEstrutura.Configuracoes
{
    public class FonteConfiguracao : EntityTypeConfiguration<Fonte>
    {
        public FonteConfiguracao()
        {
            ToTable("Fonte");

            HasKey(fonte => fonte.IDFonte);

            Property(fonte => fonte.IDFonte)
                .HasColumnName("IDFonte");

            Property(fonte => fonte.Marca)
                .HasColumnName("Marca")
                .IsRequired();

            Property(fonte => fonte.Modelo)
                .HasColumnName("Modelo")
                .IsRequired();
        }
    }
}
