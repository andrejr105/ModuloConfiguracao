using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace BLL
{
    public class UsuarioBll
    {
        public void Inserir(Usuario _Usuario)
        {
            ValidarPermissao(2);
            UsuarioDal _usuario = new UsuarioDal();
            _usuario.Inserir(_Usuario);
        }
        public List<Usuario> BuscarPorTodos()
        {
            ValidarPermissao(1);
            return new UsuarioDal().BuscarPorTodos();
        }
        public List<Usuario> BuscarPorNomeUsuario(string _nomeUsuario)
        {
            ValidarPermissao(1);
            UsuarioDal _usuario = new UsuarioDal();
            return _usuario.BuscarPorNomeUsuario(_nomeUsuario);
        }
        public Usuario BuscarPorId(int _id)
        {
            ValidarPermissao(1);
            UsuarioDal _usuario = new UsuarioDal();
            return _usuario.BuscarPorId(_id);
        }
        public Usuario BuscarPorCpf(string _CPF)
        {
            ValidarPermissao(1);
            UsuarioDal _usuario = new UsuarioDal();
            return _usuario.BuscarPorCpf(_CPF);
        }
        public Usuario BuscarPorNome(string _nome)
        {
            ValidarPermissao(1);
            UsuarioDal _usuario = new UsuarioDal();
            return _usuario.BuscarPorNome(_nome);
        }
        public void Alterar(Usuario _Usuario)
        {
            ValidarPermissao(3);
            UsuarioDal _usuario = new UsuarioDal();
            _usuario.Alterar(_Usuario);
        }
        public void Excluir(int _id)
        {
            ValidarPermissao(4);
            UsuarioDal _usuario = new UsuarioDal();
            _usuario.Excluir(_id);
        }
        public void ValidarPermissao(int _idPermisao)
        {
           if(!new UsuarioDal().ValidarPermissao(Constantes.IdUsuarioLogado,_idPermisao))
                    throw new Exception("Você não tem permissao de realizar essa operação.");
            
        }

        public void AdicionarGrupoUsuario(int _idUsuario, int _idGrupoUsuario)
        {
            if(!new UsuarioDal().UsuarioPertenceAoGrupo(_idUsuario, _idGrupoUsuario))
                new UsuarioDal().AdicionarGrupoUsuario(_idUsuario, _idGrupoUsuario);
        }
    }
}
