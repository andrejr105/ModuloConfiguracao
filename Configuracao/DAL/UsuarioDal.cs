using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UsuarioDal
    {
        public void Inserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = @"insert into Usuario(Nome,NomeUsuario,Email,CPF,Ativo,Senha) 
                                    values (@Nome,@NomeUsuario,@Email,@CPF,@Ativo,@Senha)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@Email", _usuario.Email);
                cmd.Parameters.AddWithValue("@CPF", _usuario.CPF);
                cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar inserir um usuário no banco de dados: ", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Usuario> BuscarPorTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                Usuario usuario = new Usuario();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "Select Id,Nome,NomeUsuario,Email,CPF,Ativo from Usuario";
                cmd.CommandType = System.Data.CommandType.Text;
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["Id"]);
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.Email = rd["Email"].ToString();
                        usuario.CPF = rd["CPF"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        usuario.GrupoUsuarios = new GrupoUsuarioDal().BuscarPorId(usuario.Id);
                        usuarios.Add(usuario);
                    }

                }
                return usuarios;
            }
            catch
            {
                throw new Exception();
            }
            finally
            {
                cn.Close();
            }
        }
        public List<Usuario> BuscarPorNomeUsuario(string _nomeUsuario)
        {
            List<Usuario> usuarios = new List<Usuario>();
            Usuario usuario = new Usuario();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "Select Id, Nome, NomeUsuario, Email, CPF, Ativo, Senha from Usuario where Nome like @Nome";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Nome", "%" + _nomeUsuario + "%");
                cn.Open();
                using(SqlDataReader rd = cmd.ExecuteReader())
                {
                    while(rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["Id"]);
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.Email = rd["Email"].ToString();
                        usuario.CPF = rd["CPF"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        usuario.Senha = rd["Senha"].ToString();
                        usuarios.Add(usuario);
                    }
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro");
            }
        }
        public Usuario BuscarPorId(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            List<Usuario> usuarios = new List<Usuario>();
            
          try {   
            SqlCommand cmd = cn.CreateCommand();
            Usuario usuario = new Usuario();
            cmd.Connection = cn;
            cmd.CommandText = @"Select Id, Nome, NomeUsuario, Email, CPF, Ativo, Senha From Usuario where Id = @Id";
            cmd.CommandType = System.Data.CommandType.Text;

            cmd.Parameters.AddWithValue("@Id", _id);
            cn.Open();
            using (SqlDataReader rd = cmd.ExecuteReader())
            {
                while (rd.Read())
                {
                    usuario = new Usuario();
                    usuario.Id = Convert.ToInt32(rd["Id"]);
                    usuario.Nome = rd["Nome"].ToString();
                    usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                    usuario.Email = rd["Email"].ToString();
                    usuario.CPF = rd["CPF"].ToString();
                    usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                    usuario.Senha = rd["Senha"].ToString();
                    usuario.GrupoUsuarios = new GrupoUsuarioDal().BuscarPorId(usuario.Id);   
                    }

            }
            return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro");
            }
            finally
            {
                cn.Close();
            }
        }
        public Usuario BuscarPorCpf(string _CPF)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                Usuario usuario = new Usuario();
                cmd.Connection = cn;
                cmd.CommandText = "Select Id,Nome,NomeUsuario,Email,CPF,Ativo,Senha from Usuario where CPF = @CPF";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@CPF", _CPF);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["Id"]);
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.Email = rd["Email"].ToString();
                        usuario.CPF = rd["CPF"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        usuario.Senha = rd["Senha"].ToString();
                    }

                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro");
            }
        }
        public Usuario BuscarPorNome(string _nome)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                Usuario usuario = new Usuario();
                cmd.Connection = cn;
                cmd.CommandText = "Select Id,Nome,NomeUsuario,Email,CPF,Ativo,Senha from Usuario where Nome = @Nome";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", _nome);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(rd["Id"]);
                        usuario.Nome = rd["Nome"].ToString();
                        usuario.NomeUsuario = rd["NomeUsuario"].ToString();
                        usuario.Email = rd["Email"].ToString();
                        usuario.CPF = rd["CPF"].ToString();
                        usuario.Ativo = Convert.ToBoolean(rd["Ativo"]);
                        usuario.Senha = rd["Senha"].ToString();
                    }

                }
                return usuario;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro");
            }
        }

        public void Alterar(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand(); 
            try
            { 
                cmd.CommandText = "UPDATE Usuario set Nome=@Nome,NomeUsuario=@NomeUsuario,Email=@Email,CPF=@CPF,Ativo=@Ativo,Senha=@Senha where Id=@Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _usuario.Id);
                cmd.Parameters.AddWithValue("@Nome", _usuario.Nome);
                cmd.Parameters.AddWithValue("@NomeUsuario", _usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@Email", _usuario.Email);
                cmd.Parameters.AddWithValue("@CPF", _usuario.CPF);
                cmd.Parameters.AddWithValue("@Ativo", _usuario.Ativo);
                cmd.Parameters.AddWithValue("@Senha", _usuario.Senha);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar alterar um usuário no banco de dados: ", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public void Excluir(int _id)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "Delete From Usuario where Id=@Id";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@Id", _id);
                cmd.Connection = cn;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar excluir um usuário no banco de dados: ", ex);
            }
            finally
            {
                cn.Close();
            }
        }

        public bool ValidarPermissao(int _idUsuario, int _idPermisao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT 1 FROM PermissaoGrupoUsuario INNER JOIN UsuarioGrupoUsuario ON PermissaoGrupoUsuario.IdGrupoUsuario = UsuarioGrupoUsuario.IdGrupoUsuario Where UsuarioGrupoUsuario.IdUsuario = @IdUsuario AND PermissaoGrupoUsuario.IdPermissao = @IdPermissao";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@IdUsuario", _idUsuario);
                cmd.Parameters.AddWithValue("@IdPermissao", _idPermisao);
                cn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                throw new Exception();
            }
            finally
            {
                cn.Close();
            }
        }

        public void AdicionarGrupoUsuario(int _idUsuario, int _idGrupoUsuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.Connection = cn;
                cmd.CommandText = "insert into UsuarioGrupoUsuario(IdGrupoUsuario, IdUsuario) values (@IdGrupoUsuario,@IdUsuario)";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@idUsuario", _idUsuario);
                cmd.Parameters.AddWithValue("@idGrupoUsuario", _idGrupoUsuario);
                cn.Open();

            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar vincular um grupo a um usuário");
            }
            finally
            {
                cn.Close();
            }
        }

        public bool UsuarioPertenceAoGrupo(int _idUsuario, int _idGrupoUsuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.Connection = cn;
                cmd.CommandText = @"Select 1 from UsuarioGrupoUsuario where Id = @Id and IdGrupoUsuario = @idGrupoUsuario";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _idUsuario);
                cmd.Parameters.AddWithValue("@idGrupoUsuario", _idGrupoUsuario);
                cn.Open();
                cmd.ExecuteNonQuery();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        return true;
                    }

                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar validar os dados do usuário",ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
