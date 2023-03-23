using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;

namespace BLL
{
    public class UsuarioBll
    {
        public void Inserir(Usuario _Usuario, string _confirmacaoDeSenha)
        {
            ValidarPermissao(2);
            ValidarDados(_Usuario, _confirmacaoDeSenha);
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
        public void Alterar(Usuario _Usuario, string _confirmacaoDeSenha)
        {
            ValidarPermissao(3);
            ValidarDados(_Usuario, _confirmacaoDeSenha);
            UsuarioDal _usuario = new UsuarioDal();
            _usuario.Alterar(_Usuario);
        }

        public void ValidarDados(Usuario _usuario, string _confirmacaoDeSenha)
        {
            if (_usuario.Senha != _confirmacaoDeSenha)
                throw new Exception("A senha e a confirmação da senha devem ser iguais.");
            if (_usuario.Senha.Length <= 3)
                throw new Exception("a senha deve ter mais de 3 caracteres.");
            if (_usuario.Nome.Length <= 2)
                throw new Exception("O nome deve ter mais de 2 caracteres.");
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
            if(!new UsuarioDal().UsuarioPertenceAoGrupo(_idUsuario,_idGrupoUsuario))
                new UsuarioDal().AdicionarGrupoUsuario(_idUsuario, _idGrupoUsuario);
        }
    }
}
