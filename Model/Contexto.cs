using Microsoft.EntityFrameworkCore;

namespace Atividade_Almir_Api.Model
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Motos> Motos { get; set; }

        public DbSet<EncomendaMoto> EncomendaMotos { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
