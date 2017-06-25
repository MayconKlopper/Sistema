using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Sistema.InfraEstrutura.Configuracoes
{
    public class ComputadorConfiguracao : EntityTypeConfiguration<Computador>
    {
        public ComputadorConfiguracao()
        {
            ToTable("Computador");

            HasKey(computador => computador.IDComputador);

            Property(computador => computador.IDComputador)
                .HasColumnName("IDComputador")
                .IsRequired();

            Property(computador => computador.IDFonte)
                .HasColumnName("IDFonte")
                .IsRequired();

            Property(computador => computador.IDHD)
                .HasColumnName("IDHD")
                .IsRequired();

            Property(computador => computador.IDMemoriaRAM)
                .HasColumnName("IDMemoriaRAM")
                .IsRequired();

            Property(computador => computador.IDPlacaMae)
                .HasColumnName("IDPlacaMae")
                .IsRequired();

            Property(computador => computador.IDProcessador)
                .HasColumnName("IDProcessador")
                .IsRequired();

            Property(computador => computador.IDUsuario)
                .HasColumnName("IDUsuario")
                .IsRequired();

            #region Relacionamentos

            HasRequired(computador => computador.PlacaMae)
                .WithOptional(placaMae => placaMae.Computador);

            HasRequired(computador => computador.Fonte)
                .WithOptional(fonte => fonte.Computador);

            HasRequired(computador => computador.HD)
                .WithOptional(hd => hd.Computador);

            HasRequired(computador => computador.MemoriaRAM)
                .WithOptional(memoriaRAM => memoriaRAM.Computador);

            HasRequired(computador => computador.Processador)
                .WithOptional(processador => processador.Computador);

            #endregion
        }
    }
}
