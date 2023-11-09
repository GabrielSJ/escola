using Microsoft.EntityFrameworkCore;

namespace Escola
{
    public class EscolaContext : DbContext
    {
        public EscolaContext(DbContextOptions<EscolaContext> options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>(entity =>
            {
                entity.ToTable("alunos");

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Nome).IsRequired().HasColumnName("nome");
                entity.Property(e => e.Idade).IsRequired().HasColumnName("idade");
                entity.Property(e => e.NotaPrimeiroSemestre).IsRequired().HasColumnName("notaprimeirosemestre");
                entity.Property(e => e.NotaSegundoSemestre).IsRequired().HasColumnName("notasegundosemestre");
                entity.Property(e => e.NomeDoProfessor).IsRequired().HasColumnName("nomedoprofessor");
                entity.Property(e => e.NumeroDaSala).IsRequired().HasColumnName("numerodasala");

            });
        }
    }
}
