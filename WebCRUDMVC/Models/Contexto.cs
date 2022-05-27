using Microsoft.EntityFrameworkCore;

namespace WebCRUDMVC.Models
{
    public class Contexto : DbContext
    {
        public Contexto( DbContextOptions<Contexto> options):base(options)
        {

        }

        public DbSet<Pessoa> Pessoa { get; set; }
    }
}
