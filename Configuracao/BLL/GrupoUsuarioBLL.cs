using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class GrupoUsuarioBLL
    {
        public void Inserir(GrupoUsuario _grupoUsuario)
        {
            new GrupoUsuarioDal().Inserir(_grupoUsuario);
        }
        public List<GrupoUsuario> BuscarTodos()
        {
            return new GrupoUsuarioDal().BuscarTodos();
        }
        public List<GrupoUsuario> BuscarPorNomeGrupo(string _nomeGrupo)
        {
            GrupoUsuarioDal _grupo = new GrupoUsuarioDal();
            return _grupo.BuscarPorNomeGrupo(_nomeGrupo);
        }
        public List<GrupoUsuario> BuscarPorId(int _id)
        {
            GrupoUsuarioDal _grupo = new GrupoUsuarioDal();
            return _grupo.BuscarPorId(_id);
        }
        public void Alterar(GrupoUsuario _GrupoUsuario)
        {
            GrupoUsuarioDal _grupo = new GrupoUsuarioDal();
            _grupo.Alterar(_GrupoUsuario);
        }
        public void Excluir(int _id)
        {
            GrupoUsuarioDal _grupo = new GrupoUsuarioDal();
            _grupo.Excluir(_id);
        }
    }
}
