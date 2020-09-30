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
        
        //Inicio código fonte pesquisa categorias e/ou sub-categorias
        public DataTable listarCategoriaSubCategoria(string tipoConsultaCatSub,string filtroUtilizado, string informacao)
        {
            DataTable dt = new DataTable();

            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                //Validando para puxar categoria e sub-categoria
                if(tipoConsultaCatSub == "T" && filtroUtilizado == "TODOS")
                {
                    dt = conexao.RetDataTable("select *from categoria");
                }
                else if(tipoConsultaCatSub == "T" && filtroUtilizado == "NOME")
                {
                    dt = conexao.RetDataTable("select *from categoria where descricao_categoria = '" + informacao + "'");
                }
                else if(tipoConsultaCatSub == "T" && filtroUtilizado == "INTELIGENTE")
                {
                    dt = conexao.RetDataTable("select *from categoria where descricao_categoria like '%" + informacao + "%'");
                }
                //Validação para puxar somente por categoria
                if (tipoConsultaCatSub == "C" && filtroUtilizado == "TODOS")
                {
                    dt = conexao.RetDataTable("select *from categoria where tipo_categoria = 'C'");
                }
                else if (tipoConsultaCatSub == "C" && filtroUtilizado == "NOME")
                {
                    dt = conexao.RetDataTable("select *from categoria where descricao_categoria = '" + informacao + "' and tipo_categoria = 'C'");
                }
                else if (tipoConsultaCatSub == "C" && filtroUtilizado == "INTELIGENTE")
                {
                    dt = conexao.RetDataTable("select *from categoria where descricao_categoria like '%" + informacao + "%' and tipo_categoria = 'C'");
                }
                //Validando para puxar somente por sub-categoria
                if (tipoConsultaCatSub == "S" && filtroUtilizado == "TODOS")
                {
                    dt = conexao.RetDataTable("select *from categoria where tipo_categoria = 'S'");
                }
                else if (tipoConsultaCatSub == "S" && filtroUtilizado == "NOME")
                {
                    dt = conexao.RetDataTable("select *from categoria where descricao_categoria = '" + informacao + "' and tipo_categoria = 'S'");
                }
                else if (tipoConsultaCatSub == "S" && filtroUtilizado == "INTELIGENTE")
                {
                    dt = conexao.RetDataTable("select *from categoria where descricao_categoria like '%" + informacao + "%' and tipo_categoria = 'S'");
                }
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao pesquisar as categorias e/ou sub-categorias!" + erro.Message);
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




        //Método pesquisa categoria/sub-categoria pelo código
        public CategoriaModelo buscarCatSubCat(CategoriaModelo modCatSub)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("select descricao_categoria,tipo_categoria,ativo_categoria from categoria where id_categoria = '"+modCatSub.idCategoria+"'",conexao);
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    string nomeCatSub = Convert.ToString(dr["descricao_categoria"]);
                    char tipoCatSub = Convert.ToChar(dr["tipo_categoria"]);
                    bool ativoCatSub = Convert.ToBoolean(dr["ativo_categoria"]);

                    modCatSub.nomeCategoria = nomeCatSub;
                    modCatSub.tipoCategoria = tipoCatSub;
                    modCatSub.ativoCategoria = ativoCatSub;
                }
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao pesquisar categoria e/ou sub-categoria, classe DAO!" + erro.Message);
            }
            return modCatSub;
        }

    }
}
