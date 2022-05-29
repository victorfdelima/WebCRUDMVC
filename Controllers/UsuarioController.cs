using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudAdv.Model;
using CrudAdv.Repository;
using Microsoft.AspNetCore.Mvc;

namespace CrudAdv.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioController(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var usuarios = await _repository.BuscaUsuarios();
            return usuarios.Any()
                    ? Ok(usuarios)
                    : NoContent();
        }

        [HttpGet("{OAB}")]
        public async Task<IActionResult> GetById(int OAB)
        {
            var usuarios = await _repository.BuscaUsuarios(OAB);
            return usuarios != null
                    ? Ok(usuarios)
                    : NotFound("Advogado não encontrado");
        }

        [HttpPost]
        public async Task<IActionResult> Post(Usuario usuario)
        {
            _repository.AdicionaUsuario(usuario);
            return await _repository.SaveChangesAsync()
                    ? Ok("Usuário adicionado com sucesso")
                    : BadRequest("Erro ao salvar usuário");
        }

        [HttpPut("{OAB}")]
        public async Task<IActionResult> Put(int OAB,
                                             Usuario usuario)
        {
            var usuarioBanco = await _repository.BuscaUsuarios(OAB);
            if (usuario == null) return NotFound("Advogado Não encontrado");

            usuarioBanco.OAB = usuario.OAB == usuario.OAB ? usuario.OAB : usuarioBanco.OAB;
            usuarioBanco.Nome = usuario.Nome == usuario.Nome ? usuario.Nome : usuarioBanco.Nome;

            _repository.AtualizaUsuario(usuarioBanco);

            return await _repository.SaveChangesAsync()
                    ? Ok("Usuário Atualizado com sucesso")
                    : BadRequest("Erro ao atualizar usuário");
        }

        [HttpDelete("{OAB}")]

        public async Task<IActionResult> Delete(int OAB)
        {
            var usuarioBanco = await _repository.BuscaUsuarios(OAB);
            if (usuarioBanco == null) return NotFound("Advogado Não encontrado");

            _repository.DeleteUsuario(usuarioBanco);

            return await _repository.SaveChangesAsync()
                    ? Ok("Usuário deletado com sucesso")
                    : BadRequest("Erro ao deletar usuário");

        }

    }
}