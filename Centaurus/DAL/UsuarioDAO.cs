using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centaurus.Dao;
using MySql.Data.MySqlClient;
using Centaurus.Model;
using System.Data;
using Centaurus.DTO;

namespace Centaurus.DAL
{
    public class UsuarioDAO:ConexaoBanco
    {
        MySqlCommand comando = null;
        MySqlDataReader dr;

        public void salvar(UsuarioModelo modUsuario)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("insert into usuario (ativo_usuario,nome_usuario,login_usuario,senha_usuario,botaoParticipante_usuario, "+
                " botaoGrupoProduto_usuario, botaoProduto_usuario, botaoMarca_usuario, "+
                " botaoCategoriaSubCategoria_usuario, botaoUsuarios_usuario) values(@ativo, @nome, @login, @senha, @btnParti, @btnGrupProd, @btnProd, @btnMarca, "+
                " @btncatSub, @usuario)", conexao);
                comando.Parameters.AddWithValue("@ativo", modUsuario.ativoUsuario);
                comando.Parameters.AddWithValue("@nome", modUsuario.idNomeUsuario);
                comando.Parameters.AddWithValue("@login", modUsuario.loginUsuario);
                comando.Parameters.AddWithValue("@senha", modUsuario.senhaUsuario);
                comando.Parameters.AddWithValue("@btnParti", modUsuario.botaoParticipanteUsuario);
                comando.Parameters.AddWithValue("@btnGrupProd", modUsuario.botaoGrupoProdutoUsuario);
                comando.Parameters.AddWithValue("@btnProd", modUsuario.botaoProdutoUsuario);
                comando.Parameters.AddWithValue("@btnMarca", modUsuario.botaoMarcaUsuario);
                comando.Parameters.AddWithValue("@btncatSub", modUsuario.botaoCategoriaSubCategoriaUsuario);
                comando.Parameters.AddWithValue("@usuario", modUsuario.botaoUsuariosUsuario);
                comando.ExecuteNonQuery();
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao incluir usuário, classe DAO!" + erro.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void atualizar(UsuarioModelo modUsuario)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("update usuario set ativo_usuario = @ativo,nome_usuario = @nome,login_usuario = @login,senha_usuario = @senha, "+
                " botaoParticipante_usuario = @btnParti, botaoGrupoProduto_usuario = @btnGrupProd, botaoProduto_usuario = @btnProd, botaoMarca_usuario = @btnMarca, "+
                " botaoCategoriaSubCategoria_usuario = @btncatSub, botaoUsuarios_usuario = @usuario where id_usuario = @idusuario", conexao);
                comando.Parameters.AddWithValue("@ativo", modUsuario.ativoUsuario);
                comando.Parameters.AddWithValue("@nome", modUsuario.idNomeUsuario);
                comando.Parameters.AddWithValue("@login", modUsuario.loginUsuario);
                comando.Parameters.AddWithValue("@senha", modUsuario.senhaUsuario);
                comando.Parameters.AddWithValue("@btnParti", modUsuario.botaoParticipanteUsuario);
                comando.Parameters.AddWithValue("@btnGrupProd", modUsuario.botaoGrupoProdutoUsuario);
                comando.Parameters.AddWithValue("@btnProd", modUsuario.botaoProdutoUsuario);
                comando.Parameters.AddWithValue("@btnMarca", modUsuario.botaoMarcaUsuario);
                comando.Parameters.AddWithValue("@btncatSub", modUsuario.botaoCategoriaSubCategoriaUsuario);
                comando.Parameters.AddWithValue("@usuario", modUsuario.botaoUsuariosUsuario);
                comando.Parameters.AddWithValue("@idusuario", modUsuario.idUsuario);
                comando.ExecuteNonQuery();
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao atualizar usuário, classe DAO!" + erro.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void excluir(UsuarioModelo modUsuario)
        {
            try
            {
                comando = new MySqlCommand("delete from usuario where id_usuario = @idusuario", conexao);
                comando.Parameters.AddWithValue("@idusuario", modUsuario.idUsuario);
                comando.ExecuteNonQuery();
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao excluir usuário, classe DAO" + erro.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public DataTable listarUsuario()
        {
            DataTable dt = new DataTable();
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                dt = conexao.RetDataTable("select *from usuario");
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao listar usuários, classe DAO" + erro.Message);
            }
            finally
            {
                FecharConexao();
            }

            return dt;
        }

    }
}
