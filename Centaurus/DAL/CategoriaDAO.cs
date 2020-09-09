using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Centaurus.Model;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using MySqlX.XDevAPI.Common;
using MySqlX.XDevAPI.Relational;

namespace Centaurus.Dao
{
    public class CategoriaDAO: ConexaoBanco
    {
        MySqlCommand comando = null;
        MySqlDataReader dr;


        public string numeroIncluido { get; set; }

        public void salvar(CategoriaModelo categoria) 
        {
            try 
            {
                AbrirConexao();
                comando = new MySqlCommand("insert into categoria (descricao_categoria,ativo_categoria,tipo_categoria) values (@nomecategoria,@ativo,@tipocategoria)", conexao);
                comando.Parameters.AddWithValue("@nomecategoria", categoria.nomeCategoria);
                comando.Parameters.AddWithValue("@ativo", categoria.ativoCategoria);
                comando.Parameters.AddWithValue("@tipocategoria", categoria.tipoCategoria);
                comando.ExecuteNonQuery();
            }
            catch (Exception erro) 
            {
                throw erro;
            }
            finally 
            {
                FecharConexao();
            }
            
        }

        public void atualizar(CategoriaModelo categoria) 
        {
            try 
            {
                AbrirConexao();
                comando = new MySqlCommand("update categoria set descricao_categoria=@nomecategoria,ativo_categoria=@ativo,tipo_categoria=@tipocategoria where id_categoria=@idcategoria", conexao);
                comando.Parameters.AddWithValue("@nomecategoria", categoria.nomeCategoria);
                comando.Parameters.AddWithValue("@ativo", categoria.ativoCategoria);
                comando.Parameters.AddWithValue("@tipocategoria", categoria.tipoCategoria);
                comando.Parameters.AddWithValue("@idcategoria", categoria.idCategoria);
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally 
            {
                FecharConexao();
            }
        }

        public void UltimoRegistro(string valorReturn) 
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("select max(id_categoria) as numeroPego from categoria where descricao_categoria = '" + valorReturn + "'", conexao);
                dr = comando.ExecuteReader();

                while (dr.Read()) 
                {
                    numeroIncluido = Convert.ToString(dr["numeroPego"]);
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao pesquisar id da categoria: " + erro.Message);
            }
        }

        public void ExcluirCategoria(string idCategoria)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                string comando = "delete from categoria where id_categoria =" + idCategoria;
                conexao.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir a categoria: " + ex.Message);
            }
        }

        //Inicio código fonte pesquisa todas sub-categorias e categorias
        public DataTable SelecionarTodasCategoriaSubCategoria()
        {
            DataTable dt = new DataTable();

            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                dt = conexao.RetDataTable("select *from categoria");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar categorias e/ou sub-categorias: " + ex.Message);
            }
            return dt;
        }

        //Inicio código fonte pesquisa todas categorias
        public DataTable SelecionarTodasCategoria()
        {
            DataTable dt = new DataTable();

            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                dt = conexao.RetDataTable("select *from categoria where tipo_categoria = 'C' ");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar categorias: " + ex.Message);
            }
            return dt;
        }

        //Inicio código fonte pesquisa todas sub-categorias e categorias filtrando
        public DataTable SelecionarTodasCategoriaSubCategoriaNome(string filtro)
        {
            DataTable dt = new DataTable();

            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                dt = conexao.RetDataTable("select *from categoria where descricao_categoria = '" + filtro + "'");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar categoria: " + ex.Message);
            }
            return dt;
        }

        //Inicio código fonte pesquisa todas categorias filtrando
        public DataTable SelecionarTodasCategoriaNome(string filtro)
        {
            DataTable dt = new DataTable();

            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                dt = conexao.RetDataTable("select *from categoria where descricao_categoria = '" + filtro + "' and tipo_categoria = 'C'");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar categoria: " + ex.Message);
            }
            return dt;
        }

        //Inicio código fonte pesquisa todas sub-categorias
        public DataTable SelecionarTodasSubCategoria()
        {
            DataTable dt = new DataTable();

            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                dt = conexao.RetDataTable("select *from categoria where tipo_categoria = 'S' ");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar categorias: " + ex.Message);
            }
            return dt;
        }

        //Inicio código fonte pesquisa todas sub-categorias filtrando
        public DataTable SelecionarTodasSubCategoriaNome(string filtro)
        {
            DataTable dt = new DataTable();

            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                dt = conexao.RetDataTable("select *from categoria where descricao_categoria = '" + filtro + "' and tipo_categoria = 'S'");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar categoria: " + ex.Message);
            }
            return dt;
        }

    }
}
