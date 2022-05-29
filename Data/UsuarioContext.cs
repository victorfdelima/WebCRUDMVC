using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudAdv.Model;
using Microsoft.EntityFrameworkCore;

namespace CrudAdv.Data
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}