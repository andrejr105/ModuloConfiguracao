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
    internal class UsuarioDal
    {
        public void Iserir(Usuario _usuario)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
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
        public List<Usuario> BuscarPorTodos(int _id)
        {
            List<Usuario> usuarios = new List<Usuario>();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                Usuario usuario = new Usuario();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "Select Id,Nome,NomeUsuario,Email,CPF,Ativo,Senha from Usuario where Id=@Id";
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
                        usuario.Senha = rd["Senha"].ToString();
                        usuarios.Add(usuario);
                    }

                }
                return usuarios;
            }
            catch
            {
                throw new Exception();
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
            SqlCommand cmd = cn.CreateCommand();
          try {   
            Usuario usuario = new Usuario();
            cmd.Connection = cn;
            cmd.CommandText = "Select Id,Nome,NomeUsuario,Email,CPF,Ativo,Senha from Usuario where Id = @Id";
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
                cmd.CommandText = "UPDATE Candidato set Nome=@Nome,NomeUsuario=@NomeUsuario,Email=@Email,CPF=@CPF,Ativo=@Ativo,Senha=@Senha where ID_Candidato=@ID_Candidato";
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
    }
}
