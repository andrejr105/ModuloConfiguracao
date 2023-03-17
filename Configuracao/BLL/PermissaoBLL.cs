using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PermissaoBLL
    {
        public void Inserir(Permissao _permissao)
        {
            new PermissaoDal().Inserir(_permissao);
        }
        public List<Permissao> BuscarTodos()
        {
            return new PermissaoDal().BuscarTodos();
        }
        public List<Permissao> BuscarPorDescricao(string _descricao)
        {
            PermissaoDal _permissao = new PermissaoDal();
            return _permissao.BuscarPorDescricao(_descricao);
        }
        public List<Permissao> BuscarPorId(int _id)
        {
            PermissaoDal _permissao = new PermissaoDal();
            return _permissao.BuscarPorId(_id);
        }
        public void Alterar(Permissao _Permissao)
        {
            PermissaoDal _permissao = new PermissaoDal();
            _permissao.Alterar(_Permissao);
        }
        public void Excluir(int _id)
        {
            PermissaoDal _usuario = new PermissaoDal();
            _usuario.Excluir(_id);
        }
    }
}
