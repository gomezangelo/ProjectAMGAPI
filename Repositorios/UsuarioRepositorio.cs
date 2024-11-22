using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Data;
using SistemaDeTarefas.Models;
using SistemaDeTarefas.Repositorios.Interfaces;

namespace SistemaDeTarefas.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly SistemaTarefasContex _Dbcontext;
        public UsuarioRepositorio(SistemaTarefasContex sistemaTarefasContex)
        {
            _Dbcontext = sistemaTarefasContex;
        }
        public async Task<UsuarioModel> BuscarPorID(int id)
        {
            return await _Dbcontext.Usuarios.FirstOrDefaultAsync(x => x.UserAccountID == id);
        }
        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return await _Dbcontext.Usuarios.ToListAsync();
        }
        public async Task<UsuarioModel> Adicionar(UsuarioModel usuario)
        {
            await _Dbcontext.Usuarios.AddAsync(usuario);
            await _Dbcontext.SaveChangesAsync();

            return usuario;
        }

        public async Task<UsuarioModel> Atualizar(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorID(id);

            if (usuarioPorId == null) 
            {
                throw new Exception($"Usuario para o ID:{id} não foi encontrado no Banco de Dados.");
            }

            usuarioPorId.LoginID = usuario.LoginID;
            usuarioPorId.Password = usuario.Password;
            usuarioPorId.UserType = usuario.UserType;
            _Dbcontext.Usuarios.Update(usuarioPorId);
            await _Dbcontext.SaveChangesAsync();

            return usuarioPorId;
        }

        public async Task<bool> Apagar(int id)
        {
            UsuarioModel usuarioPorId = await BuscarPorID(id);

            if (usuarioPorId == null)
            {
                throw new Exception($"Usuario para o ID:{id} não foi encontrado no Banco de Dados.");
            }
            _Dbcontext.Usuarios.Remove(usuarioPorId);
            await _Dbcontext.SaveChangesAsync();

            return true;

        }
    }
}
