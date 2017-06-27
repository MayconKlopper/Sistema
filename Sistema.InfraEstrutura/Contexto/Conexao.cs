using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sistema.InfraEstrutura.Configuracoes;
using Sistema.Dominio.Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Configuration;

namespace Sistema.InfraEstrutura.Contexto
{
    public class Conexao : DbContext
    {
        public Conexao()
            //: base(ConfigurationManager.ConnectionStrings["Sistema"].ConnectionString)
            : base(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\mayco\documents\visual studio 2015\Projects\Sistema\Sistema.Apresentacao\App_Data\BaseDados.mdf;Integrated Security = True")
        {
            //Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ComputadorConfiguracao());
            modelBuilder.Configurations.Add(new FonteConfiguracao());
            modelBuilder.Configurations.Add(new HDConfiguracao());
            modelBuilder.Configurations.Add(new MemoriaRAMConfiguracao());
            modelBuilder.Configurations.Add(new PlacaMaeConfiguracao());
            modelBuilder.Configurations.Add(new ProcessadorConfiguracao());

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure(coluna => coluna.HasColumnType("varchar"));
        }

        public DbSet<Computador> Computador { get; set; }
        public DbSet<Fonte> Fonte { get; set; }
        public DbSet<HD> HD { get; set; }
        public DbSet<MemoriaRAM> MemoriaRAM { get; set; }
        public DbSet<PlacaMae> PlacaMae { get; set; }
        public DbSet<Processador> Processador { get; set; }
    }
}
