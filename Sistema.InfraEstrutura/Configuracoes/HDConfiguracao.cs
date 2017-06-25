using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Sistema.InfraEstrutura.Configuracoes
{
    public class HDConfiguracao : EntityTypeConfiguration<HD>
    {
        public HDConfiguracao()
        {
            ToTable("HD");

            HasKey(hd => hd.IDHD);

            Property(hd => hd.IDHD)
                .HasColumnName("IDHD");

            Property(hd => hd.Quantidade)
                .HasColumnName("Quantidade")
                .IsRequired();

            Property(hd => hd.Capacidade)
                .HasColumnName("Capacidade")
                .IsRequired();
        }
    }
}
