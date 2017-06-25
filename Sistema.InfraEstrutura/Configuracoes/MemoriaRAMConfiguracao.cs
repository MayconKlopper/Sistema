using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Sistema.InfraEstrutura.Configuracoes
{
     public class MemoriaRAMConfiguracao : EntityTypeConfiguration<MemoriaRAM>
    {
        public MemoriaRAMConfiguracao()
        {
            ToTable("MemoriaRAM");

            HasKey(memoriaRAM => memoriaRAM.IDMemoriaRAM);

            Property(memoriaRAM => memoriaRAM.IDMemoriaRAM)
                .HasColumnName("IDMemoriaRAM");

            Property(memoriaRAM => memoriaRAM.Quantidade)
                .HasColumnName("Quantidade")
                .IsRequired();

            Property(memoriaRAM => memoriaRAM.Capacidade)
                .HasColumnName("Capacidade")
                .IsRequired();
        }
    }
}
