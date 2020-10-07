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

        public DataTable listarCidades(string tipoFiltro, string filtro)
        {
            DataTable dt = new DataTable();

            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                if(tipoFiltro == "TODAS")
                {
                    dt = conexao.RetDataTable("select *from cidade");
                }
                else if(tipoFiltro == "CIDADE")
                {
                    dt = conexao.RetDataTable("select *from cidade where nome_cidade like '%" + filtro + "'");
                }
                else if (tipoFiltro == "UF")
                {
                    dt = conexao.RetDataTable("select *from cidade where uf_cidade = '" + filtro + "'");
                }
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao listar cidades, classe DAO " + erro.Message);
            }
            finally
            {
                FecharConexao();
            }
            return dt;
        }
        
    }
}
