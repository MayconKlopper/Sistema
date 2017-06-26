using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Sistema.InfraEstrutura.Configuracoes
{
    public class ProcessadorConfiguracao : EntityTypeConfiguration<Processador>
    {
        public ProcessadorConfiguracao()
        {
            ToTable("Processador");

            HasKey(processador => processador.IDProcessador);

            Property(processador => processador.IDProcessador)
                .HasColumnName("IDProcessador");

            //Property(processador => processador.IDComputador)
            //    .HasColumnName("IDComputador")
            //    .IsRequired();

            Property(processador => processador.Velocidade)
                .HasColumnName("Velocidade")
                .IsRequired();

            Property(processador => processador.Marca)
                .HasColumnName("Marca")
                .IsRequired();

            Property(processador => processador.Modelo)
                .HasColumnName("Modelo")
                .IsRequired();

            //HasRequired(processador => processador.Computadores)
            //    .WithOptional(computador => computador.Processador);
        }
    }
}
