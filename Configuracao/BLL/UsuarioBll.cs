using DAL;
using Models;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace BLL
{
    public class UsuarioBll
    {
        public void Inserir(Usuario _Usuario)
        {
            new UsuarioDal().Inserir(_Usuario);
        }
        public List<Usuario> BuscarPorTodos()
        {
            return new UsuarioDal().BuscarPorTodos();
        }
        public List<Usuario> BuscarPorNomeUsuario(string _nomeUsuario)
        {
            UsuarioDal _usuario = new UsuarioDal();
            return _usuario.BuscarPorNomeUsuario(_nomeUsuario);
        }
        public Usuario BuscarPorId(int _id)
        {
            UsuarioDal _usuario = new UsuarioDal();
            return _usuario.BuscarPorId(_id);
        }
        public Usuario BuscarPorCpf(string _CPF)
        {
            UsuarioDal _usuario = new UsuarioDal();
            return _usuario.BuscarPorCpf(_CPF);
        }
        public Usuario BuscarPorNome(string _nome)
        {
            UsuarioDal _usuario = new UsuarioDal();
            return _usuario.BuscarPorNome(_nome);
        }
        public void Alterar(Usuario _Usuario)
        {
            UsuarioDal _usuario = new UsuarioDal();
            _usuario.Alterar(_Usuario);
        }
        public void Excluir(int _id)
        {
            UsuarioDal _usuario = new UsuarioDal();
            _usuario.Excluir(_id);
        }
    }
}
