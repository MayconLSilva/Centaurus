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
    public class MarcaDAO: ConexaoBanco
    {
        MySqlCommand comando = null;
        MySqlDataReader dr;
        ConexaoBanco conexao2 = new ConexaoBanco();

        public void salvar(MarcaModelo marca) 
        {
            try 
            {
                AbrirConexao();
                comando = new MySqlCommand("insert into marca (descricao_marca,ativo_marca) values (@nomemarca,@ativo)", conexao);
                comando.Parameters.AddWithValue("@nomemarca", marca.nomeMarca);
                comando.Parameters.AddWithValue("@ativo", marca.ativoMarca);
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

        public void atualizar(MarcaModelo marca) 
        {
            try 
            {
                AbrirConexao();
                comando = new MySqlCommand("update marca set descricao_marca=@nomemarca,ativo_marca=@ativo where id_marca=@idmarca", conexao);
                comando.Parameters.AddWithValue("@nomemarca", marca.nomeMarca);
                comando.Parameters.AddWithValue("@ativo", marca.ativoMarca);
                comando.Parameters.AddWithValue("@idmarca", marca.idMarca);
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

        public void excluirMarca(MarcaModelo modMarca)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                string comando = "delete from marca where id_marca =" + modMarca.idMarca;
                conexao.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir o marca: " + ex.Message);
            }
        }

        public DataTable listarMarcas(string tipoFiltro, string filtro)
        {
            DataTable dt = new DataTable();

            try
            {
                //AbrirConexao();
                conexao2.AbrirConexao();
                if (tipoFiltro == "TODAS")
                {
                    //dt = conexao.RetDataTable("select *from marca");
                    dt = conexao2.RetDataTable("select id_marca AS idMarca, descricao_marca as nomeMarca from marca");
                }
                else if (tipoFiltro == "MARCA")
                {
                    dt = conexao2.RetDataTable("select *from marca where descricao_marca = '" + filtro + "'");
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao listar marcar, classe DAO " + erro.Message);
            }
            finally
            {
                //FecharConexao();
                conexao2.FecharConexao();


            }
            return dt;
        }

        public MarcaModelo buscarUltimoRegistro(MarcaModelo modMarca)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("select max(id_marca) as numeroPego from marca where descricao_marca = '" + modMarca.nomeMarca + "'", conexao);
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    int idMarca = Convert.ToInt32(dr["numeroPego"]);
                    modMarca.idMarca = idMarca;
                }
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao pesquisa a id da marca, classe DAO! " + erro.Message);
            }
            finally
            {
                FecharConexao();
            }
            return modMarca;
        }

        public MarcaModelo buscarMarcaPorCodigo(MarcaModelo modMarca)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("select *from marca where id_marca = '" + modMarca.idMarca + "'",conexao);
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    string nomeMarca = Convert.ToString(dr["descricao_marca"]);
                    bool ativoMarca = Convert.ToBoolean(dr["ativo_marca"]);

                    modMarca.nomeMarca = nomeMarca;
                    modMarca.ativoMarca = ativoMarca;
                }
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao pesquisar a marca pelo código, classe DAO! " + erro.Message);
            }
            finally
            {
                FecharConexao();
            }
            return modMarca;
        }

        public List<MarcaModelo> listarProdutosRelatorio()
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("select *from marca ", conexao);
                dr = comando.ExecuteReader();

                List<MarcaModelo> listarMarcas = new List<MarcaModelo>();

                while (dr.Read())
                {
                    MarcaModelo marcaModelo = new MarcaModelo();
                    marcaModelo.idMarca = Convert.ToInt32(dr["id_marca"]);
                    marcaModelo.nomeMarca = Convert.ToString(dr["descricao_marca"]);
                    listarMarcas.Add(marcaModelo);
                }
                return listarMarcas;

            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao buscar marcas " + erro.Message);
            }
        }

    }
}
