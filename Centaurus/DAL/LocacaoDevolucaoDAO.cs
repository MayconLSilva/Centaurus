using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centaurus.Model;
using MySql.Data.MySqlClient;
using System.Data;
using Centaurus.DTO;
using Centaurus.Dao;

namespace Centaurus.DAL
{
    public class LocacaoDevolucaoDAO : ConexaoBanco
    {
        MySqlCommand comando = null;
        MySqlDataReader dr;

        public void inserirDevLocacao(LocacaoDevolucaoModelo modLocacaoDev)
        {
            try
            {
                AbrirConexao();
                //comando = new MySqlCommand("insert into locacao (dataLancamento_locacao) values (@dataLan)", conexao);
                comando = new MySqlCommand("insert into locacao (dataLancamento_locacao, " +
                   " idCliente_locacao, " +
                   " tipo_locacao, " +
                   " numerolocacaodev_locacao, " +
                   " dataDevolucao_locacao) " +
                   " select current_timestamp(),idCliente_locacao,'D',id_locacao,current_timestamp() " +
                   " from locacao where id_locacao = @idLocacao", conexao);
                comando.Parameters.AddWithValue("@idLocacao", modLocacaoDev.idLocacao);
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

        public LocacaoDevolucaoModelo buscarLocacaoDev(LocacaoDevolucaoModelo locacaoDev)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("select id_locacao, dataLancamento_locacao,idCliente_locacao,dataDevolucao_locacao,nome_fantasia_participante from locacao as loc " +
                    " inner join participante as parti on parti.id_partipante = loc.idCliente_locacao where numerolocacaodev_locacao = '" + locacaoDev.idLocacao + "'", conexao);
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    int idLocacaoDev = Convert.ToInt32(dr["id_locacao"]);
                    int idCliente = Convert.ToInt32(dr["idCliente_locacao"]);
                    DateTime dataLancamento = Convert.ToDateTime(dr["dataLancamento_locacao"]);
                    DateTime dataDevolucao = Convert.ToDateTime(dr["dataDevolucao_locacao"]);
                    string nomeCliente = Convert.ToString(dr["nome_fantasia_participante"]);


                    locacaoDev.idLocacaoDev = idLocacaoDev;
                    locacaoDev.idClienteLocacaoDev = idCliente;
                    locacaoDev.dataLancamentoLocacaoDev = dataLancamento;
                    locacaoDev.dataDevolucaoLocacaoDev = dataDevolucao;
                    locacaoDev.nomeClienteLocacaoDev = nomeCliente;
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao pesquisar locação devolução " + erro.Message);
            }
            return locacaoDev;
        }



    }
}
