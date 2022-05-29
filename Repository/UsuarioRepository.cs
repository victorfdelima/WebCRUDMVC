using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudAdv.Data;
using CrudAdv.Model;
using Microsoft.EntityFrameworkCore;

namespace CrudAdv.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly UsuarioContext _context;

        public UsuarioRepository(UsuarioContext context)
        {
            _context = context;

        }
        public async Task<IEnumerable<Usuario>> BuscaUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task<Usuario> BuscaUsuarios(int OAB)
        {
            return await _context.Usuarios.Where(x => x.OAB == OAB)
                .FirstOrDefaultAsync();
        }
        public void AdicionaUsuario(Usuario usuario)
        {
            _context.Add(usuario);
        }

        public void AtualizaUsuario(Usuario usuario)
        {
            _context.Update(usuario);
        }

        public void DeleteUsuario(Usuario usuario)
        {
            _context.Remove(usuario);

        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}