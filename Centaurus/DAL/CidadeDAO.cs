using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Centaurus.Model;

namespace Centaurus.Dao
{
    public class CidadeDAO: ConexaoBanco
    {
        MySqlCommand comando = null;

        public DataTable SelecionarTodasCidades() 
        {
            DataTable dt = new DataTable();

            try 
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                dt = conexao.RetDataTable("select *from cidade");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar cidade: " + ex.Message);
            }
            return dt;
        }

        public DataTable SelecionarTodasCidadesFiltrandoNome(string filtro)
        {
            DataTable dt = new DataTable();

            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                dt = conexao.RetDataTable("select *from cidade where nome_cidade like '%" + filtro+"'");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar cidade: " + ex.Message);
            }
            return dt;
        }

        public DataTable SelecionarTodasCidadesFiltrandoUF(string filtro)
        {
            DataTable dt = new DataTable();

            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                dt = conexao.RetDataTable("select *from cidade where uf_cidade = '"+filtro+"'");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar cidade: " + ex.Message);
            }
            return dt;
        }
    }
}
