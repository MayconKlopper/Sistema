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
                .WithMany(placaMae => placaMae.Computadores)
                .HasForeignKey(computador => computador.IDPlacaMae);

            HasRequired(computador => computador.Fonte)
                .WithMany(fonte => fonte.Computadores)
                .HasForeignKey(computador => computador.IDFonte);

            HasRequired(computador => computador.HD)
                .WithMany(hd => hd.Computadores)
                .HasForeignKey(computador => computador.IDHD);

            HasRequired(computador => computador.MemoriaRAM)
                .WithMany(memoriaRAM => memoriaRAM.Computadores)
                .HasForeignKey(computador => computador.IDMemoriaRAM);

            HasRequired(computador => computador.Processador)
                .WithMany(processador => processador.Computadores)
                .HasForeignKey(computador => computador.IDProcessador);

            #endregion
        }
    }
}
