using Chapter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Reflection;

namespace Chapter.Contexts
{
    public class ChapterContext : DbContext
    {
        public ChapterContext()
        {

        }
        public ChapterContext(DbContextOptions<ChapterContext> options) : base(options)
        {

        }
        //vamos utilizar esse metodo a seguir para configurar o banco de dados
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // cada provedor tem sua sintaxe para especificação
                _ = optionsBuilder.UseSqlServer("Data Source = CLEILISBOA\\SQLEXPRESS; initial catalog = Chapter;");
            }
        }
        //dbset representa as entidades que serão utilizadas nas operações de
        //leitura, criação, atualização
        public DbSet<Livro> Livros { get; set; }
    }
}
