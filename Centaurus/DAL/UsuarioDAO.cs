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
    public class UsuarioDAO : ConexaoBanco
    {
        MySqlCommand comando = null;
        MySqlDataReader dr;

        public void salvar(UsuarioModelo modUsuario)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("insert into usuario (ativo_usuario,nome_usuario,login_usuario,senha_usuario,botaoParticipante_usuario, " +
                " botaoGrupoProduto_usuario, botaoProduto_usuario, botaoMarca_usuario, " +
                " botaoCategoriaSubCategoria_usuario, botaoUsuarios_usuario,botaoLocacao_usuario,botaoDevLocacao_usuario) values(@ativo, @nome, @login, @senha, @btnParti, @btnGrupProd, @btnProd, @btnMarca, " +
                " @btncatSub, @usuario,@loc,@devloc)", conexao);
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
                comando.Parameters.AddWithValue("@loc", modUsuario.botaoLocacaoUsuario);
                comando.Parameters.AddWithValue("@devloc", modUsuario.botaoDevLocacaoUsuario);
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
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
                comando = new MySqlCommand("update usuario set ativo_usuario = @ativo,nome_usuario = @nome,login_usuario = @login,senha_usuario = @senha, " +
                " botaoParticipante_usuario = @btnParti, botaoGrupoProduto_usuario = @btnGrupProd, botaoProduto_usuario = @btnProd, botaoMarca_usuario = @btnMarca, " +
                " botaoCategoriaSubCategoria_usuario = @btncatSub, botaoUsuarios_usuario = @usuario,botaoLocacao_usuario = @loc, botaoDevLocacao_usuario = @devloc where id_usuario = @idusuario", conexao);
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
                comando.Parameters.AddWithValue("@loc", modUsuario.botaoLocacaoUsuario);
                comando.Parameters.AddWithValue("@devloc", modUsuario.botaoDevLocacaoUsuario);
                comando.Parameters.AddWithValue("@idusuario", modUsuario.idUsuario);
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
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
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                string comando = "delete from usuario where id_usuario = " + Convert.ToInt32(modUsuario.idUsuario);
                conexao.ExecutarComandoSQL(comando);
            }
            catch (Exception erro)
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
                dt = conexao.RetDataTable("select id_usuario, nome_fantasia_participante, login_usuario,dataCadastro_usuario " +
                " from usuario " +
                " inner join participante on participante.id_partipante = usuario.nome_usuario");
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao listar usuários, classe DAO" + erro.Message);
            }
            finally
            {
                FecharConexao();
            }

            return dt;
        }

        public UsuarioModelo buscarUltimoRegistro(UsuarioModelo modUsuario)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("select max(id_usuario) as numeroPego from usuario where login_usuario = '" + modUsuario.loginUsuario + "'", conexao);
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    int idUsuario = Convert.ToInt32(dr["numeroPego"]);
                    modUsuario.idUsuario = idUsuario;
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao buscar id do usuário, classe DAO" + erro.Message);
            }
            finally
            {
                FecharConexao();
            }
            return modUsuario;
        }

        //Busco informações do usuário peda id
        public UsuarioModelo buscarInformacoesUsuario(UsuarioModelo modUsuario)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("select ativo_usuario,nome_usuario,nome_fantasia_participante,login_usuario,senha_usuario,botaoParticipante_usuario,botaoGrupoProduto_usuario,botaoProduto_usuario, botaoMarca_usuario, botaoCategoriaSubCategoria_usuario, botaoUsuarios_usuario,botaoLocacao_usuario,botaoDevLocacao_usuario from usuario inner join participante on participante.id_partipante = usuario.nome_usuario where id_usuario = '" + modUsuario.idUsuario + "'", conexao);
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    bool ativoUsuario = Convert.ToBoolean(dr["ativo_usuario"]);
                    string nomeUsuario = Convert.ToString(dr["nome_fantasia_participante"]);
                    string idNomeUsuario = Convert.ToString(dr["nome_usuario"]);
                    string login = Convert.ToString(dr["login_usuario"]);
                    string senha = Convert.ToString(dr["senha_usuario"]);
                    bool btnParticipante = Convert.ToBoolean(dr["botaoParticipante_usuario"]);
                    bool btnGrupoProduto = Convert.ToBoolean(dr["botaoGrupoProduto_usuario"]);
                    bool btnProduto = Convert.ToBoolean(dr["botaoProduto_usuario"]);
                    bool btnMaca = Convert.ToBoolean(dr["botaoMarca_usuario"]);
                    bool btnCatSub = Convert.ToBoolean(dr["botaoCategoriaSubCategoria_usuario"]);
                    bool btnUsuario = Convert.ToBoolean(dr["botaoUsuarios_usuario"]);
                    bool btnLocacao = Convert.ToBoolean(dr["botaoLocacao_usuario"]);
                    bool btnDevLocacao = Convert.ToBoolean(dr["botaoDevLocacao_usuario"]);

                    modUsuario.ativoUsuario = ativoUsuario;
                    modUsuario.nomeUsuario = nomeUsuario;
                    modUsuario.idNomeUsuario = idNomeUsuario;
                    modUsuario.loginUsuario = login;
                    modUsuario.senhaUsuario = senha;
                    modUsuario.botaoParticipanteUsuario = btnParticipante;
                    modUsuario.botaoGrupoProdutoUsuario = btnGrupoProduto;
                    modUsuario.botaoProdutoUsuario = btnProduto;
                    modUsuario.botaoMarcaUsuario = btnMaca;
                    modUsuario.botaoCategoriaSubCategoriaUsuario = btnCatSub;
                    modUsuario.botaoUsuariosUsuario = btnUsuario;
                    modUsuario.botaoLocacaoUsuario = btnLocacao;
                    modUsuario.botaoDevLocacaoUsuario = btnDevLocacao;

                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao buscar id do usuário, classe DAO" + erro.Message);
            }
            finally
            {
                FecharConexao();
            }
            return modUsuario;
        }

        //Busco informações do usuário pelo login
        public UsuarioModelo buscarInformacoesUsuarioLogin(UsuarioModelo modUsuario)
        {
            Console.WriteLine("logado dao " + modUsuario.loginUsuario);
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("select ativo_usuario,nome_usuario,nome_fantasia_participante,login_usuario,senha_usuario,botaoParticipante_usuario,botaoGrupoProduto_usuario,botaoProduto_usuario, botaoMarca_usuario, botaoCategoriaSubCategoria_usuario, botaoUsuarios_usuario,botaoLocacao_usuario,botaoDevLocacao_usuario from usuario inner join participante on participante.id_partipante = usuario.nome_usuario where login_usuario = '" + modUsuario.loginUsuario + "'", conexao);
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    bool ativoUsuario = Convert.ToBoolean(dr["ativo_usuario"]);
                    string nomeUsuario = Convert.ToString(dr["nome_fantasia_participante"]);
                    string idNomeUsuario = Convert.ToString(dr["nome_usuario"]);
                    string login = Convert.ToString(dr["login_usuario"]);
                    string senha = Convert.ToString(dr["senha_usuario"]);
                    bool btnParticipante = Convert.ToBoolean(dr["botaoParticipante_usuario"]);
                    bool btnGrupoProduto = Convert.ToBoolean(dr["botaoGrupoProduto_usuario"]);
                    bool btnProduto = Convert.ToBoolean(dr["botaoProduto_usuario"]);
                    bool btnMaca = Convert.ToBoolean(dr["botaoMarca_usuario"]);
                    bool btnCatSub = Convert.ToBoolean(dr["botaoCategoriaSubCategoria_usuario"]);
                    bool btnUsuario = Convert.ToBoolean(dr["botaoUsuarios_usuario"]);
                    bool btnLocacao = Convert.ToBoolean(dr["botaoLocacao_usuario"]);
                    bool btnDevLocacao = Convert.ToBoolean(dr["botaoDevLocacao_usuario"]);

                    modUsuario.ativoUsuario = ativoUsuario;
                    modUsuario.nomeUsuario = nomeUsuario;
                    modUsuario.idNomeUsuario = idNomeUsuario;
                    modUsuario.loginUsuario = login;
                    modUsuario.senhaUsuario = senha;
                    modUsuario.botaoParticipanteUsuario = btnParticipante;
                    modUsuario.botaoGrupoProdutoUsuario = btnGrupoProduto;
                    modUsuario.botaoProdutoUsuario = btnProduto;
                    modUsuario.botaoMarcaUsuario = btnMaca;
                    modUsuario.botaoCategoriaSubCategoriaUsuario = btnCatSub;
                    modUsuario.botaoUsuariosUsuario = btnUsuario;
                    modUsuario.botaoLocacaoUsuario = btnLocacao;
                    modUsuario.botaoDevLocacaoUsuario = btnDevLocacao;

                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao buscar id do usuário, classe DAO" + erro.Message);
            }
            finally
            {
                FecharConexao();
            }
            return modUsuario;
        }
    }
}
