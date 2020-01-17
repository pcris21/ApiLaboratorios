using System.Configuration;
using System.Threading.Tasks;
using Dasa.Laboratorios.Dominio.Entidades;
using Dasa.Laboratorios.Dominio.Enuns;
using Dasa.Laboratorios.Dominio.Repositorios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dasa.Laboratorios.Repositorio.Contexto
{
    public class ContextoLaboratorioBD : DbContext
    {
       

        public ContextoLaboratorioBD(DbContextOptions<ContextoLaboratorioBD> opcoes) : base(opcoes)
        {

        }

        public DbSet<Laboratorio> Laboratorios { get; set; }
        public DbSet<Exame> Exames { get; set; }

        private void LaboratorioMap(ModelBuilder builder)
        {
            builder.Entity<Laboratorio>( e => {
                e.ToTable("tbLaboratorio");
                e.HasKey(l => l.Id).HasName("Id");
                e.Property(l => l.Id).HasColumnName("Id");
                e.Property(l => l.Nome).HasColumnName("Nome");
                e.Property(l => l.Status).HasColumnName("Status").HasConversion(new EnumToStringConverter<Status>());

                //Endereco
                e.OwnsOne(a => a.Endereco,
                    end =>
                    {
                        end.Property(a => a.Logradouro).HasColumnName("Logradouro");
                        end.Property(a => a.Numero).HasColumnName("Numero");
                        end.Property(a => a.Complemento).HasColumnName("Complemento");
                        end.Property(a => a.Bairro).HasColumnName("Bairro");
                        end.Property(a => a.Cidade).HasColumnName("Cidade");
                        end.Property(a => a.Estado).HasColumnName("Estado");
                        end.Property(a => a.Cep).HasColumnName("Cep");
                    }
                    );
            });
        }

        private void ExameMap(ModelBuilder builder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ForSqlServerUseIdentityColumns();
            modelBuilder.HasDefaultSchema("DasaControleLaboratorios");

            LaboratorioMap(modelBuilder);
            ExameMap(modelBuilder);

           // base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder opcoes)
        {
            opcoes.UseSqlServer(ConfigurationManager.ConnectionStrings["DasaGestaoLab"].ConnectionString);
        }
        
    }
}
