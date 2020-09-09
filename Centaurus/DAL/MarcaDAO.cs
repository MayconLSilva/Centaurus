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


        public string numeroIncluido { get; set; }

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

        public void UltimoRegistro(string valorReturn) 
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("select max(id_marca) as numeroPego from marca where descricao_marca = '" + valorReturn + "'", conexao);
                dr = comando.ExecuteReader();

                while (dr.Read()) 
                {
                    numeroIncluido = Convert.ToString(dr["numeroPego"]);
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao pesquisar id da marca: " + erro.Message);
            }
        }

        public void ExcluirMarca(string idMarca)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                string comando = "delete from marca where id_marca =" + idMarca;
                conexao.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir o marca: " + ex.Message);
            }
        }

        public DataTable SelecionarTodasMarcas()
        {
            DataTable dt = new DataTable();

            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                dt = conexao.RetDataTable("select *from marca");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar marcas: " + ex.Message);
            }
            return dt;
        }

        public DataTable SelecionarTodasMarcasNome(string filtro)
        {
            DataTable dt = new DataTable();

            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                dt = conexao.RetDataTable("select *from marca where descricao_marca = '" + filtro + "'");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar marcas: " + ex.Message);
            }
            return dt;
        }

    }
}
