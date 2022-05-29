using CrudAdv.Model;

namespace CrudAdv.Repository
{
    public interface IUsuarioRepository
    {
        Task<IEnumerable<Usuario>> BuscaUsuarios();
        Task<Usuario> BuscaUsuarios(int OAB);
        void AdicionaUsuario(Usuario usuario);
        void AtualizaUsuario(Usuario usuario);
        void DeleteUsuario(Usuario usuario);

        Task<bool> SaveChangesAsync();
    }
}