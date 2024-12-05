


using Microsoft.EntityFrameworkCore;
using ProjetoExemplo.Models;

namespace ProjetoExemplo.Data
{
    public class BancoContext:DbContext
    {
        public BancoContext(DbContextOptions<BancoContext>options): base(options)
        { 
        }

        public DbSet<ContatoModel> Contatos { get; set; }


    }
}
