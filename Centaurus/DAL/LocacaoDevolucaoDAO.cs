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

        public string numeroIncluido { get; set; }

        //Método inserir locação devolução copiando dados da locação
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

        //Método inserir itens locação devolução copiando dados da locação
        public void importarItemLocacao(LocacaoDevolucaoModelo modLocacaoDev)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("insert into locacaoitens (idProduto_locacaoitens,valorLocado_locacaoitens,idLocacao_locacaoitens, "+
                " qtdLocada_locacaoitens, tipo_locacaoitens, idVariacaoProduto_locacaoitens) "+
                " select idProduto_locacaoitens, valorLocado_locacaoitens,@idLocacaoDev, " +
                " qtdLocada_locacaoitens,'D',idVariacaoProduto_locacaoitens from locacaoitens where idLocacao_locacaoitens = @idLocacaoOld", conexao);
                comando.Parameters.AddWithValue("@idLocacaoDev", modLocacaoDev.idLocacaoDev);
                comando.Parameters.AddWithValue("@idLocacaoOld", modLocacaoDev.idLocacao);
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

        //Método busca informações da locação devolução para setar nos seus respectivos campos
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

        //Método listar itens locação na tabela
        public DataTable listarItens(string filtro)
        {
            DataTable dt = new DataTable();
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                dt = conexao.RetDataTable("select *from viewlocacaoitens where idLocacao_locacaoitens = '" + filtro + "'");
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao consultar itens " + erro.Message);
            }
            return dt;
        }

        //Método salvar locação devolução, será finalizado com update
        public void SalvarDevLocacao(LocacaoDevolucaoModelo modLocacaoDev)
        {
            try
            {
                AbrirConexao();
                if(modLocacaoDev.idClienteLocacaoDev == null || Convert.ToString(modLocacaoDev.idClienteLocacaoDev) == "" || modLocacaoDev.idClienteLocacaoDev == 0)
                {   //Cláusula utilizada para salvar devolução da locação quando for gerado automaticamente
                    comando = new MySqlCommand("update locacao set qtdItens_locacao = @qtdItens,total_locacao = @totalLoca,usuario_locacao = @usuarioLoca,dataDevolucao_locacao = @dataDevLoca where id_locacao = @idLocacao", conexao);
                    comando.Parameters.AddWithValue("@qtdItens", modLocacaoDev.qtdItensLocacaoDev);
                    comando.Parameters.AddWithValue("@totalLoca", modLocacaoDev.totalLocacaoDev);
                    comando.Parameters.AddWithValue("@usuarioLoca", modLocacaoDev.usuarioLocacaoDev);
                    comando.Parameters.AddWithValue("@dataDevLoca", modLocacaoDev.dataDevolucaoLocacaoDev);
                    comando.Parameters.AddWithValue("@idLocacao", modLocacaoDev.idLocacaoDev);
                    comando.ExecuteNonQuery();
                }
                else
                {   //Clausula utilizada para salvar devolução da locação quando for gerado manualmente
                    comando = new MySqlCommand("update locacao set idCliente_locacao = @idCliente, qtdItens_locacao = @qtd, total_locacao = @total, "+
                    " tipo_locacao = @tipo, numerolocacaodev_locacao = @numero, usuario_locacao = @usuario, "+
                    " dataDevolucao_locacao = @data where id_locacao = @idlocacao", conexao);
                    comando.Parameters.AddWithValue("@idCliente", modLocacaoDev.idClienteLocacaoDev);
                    comando.Parameters.AddWithValue("@qtd", modLocacaoDev.qtdItensLocacaoDev);
                    comando.Parameters.AddWithValue("@total", modLocacaoDev.totalLocacaoDev);
                    comando.Parameters.AddWithValue("@tipo", "D");
                    comando.Parameters.AddWithValue("@numero", modLocacaoDev.idLocacao);
                    comando.Parameters.AddWithValue("@usuario", modLocacaoDev.usuarioLocacaoDev);
                    comando.Parameters.AddWithValue("@data", modLocacaoDev.dataDevolucaoLocacaoDev);
                    comando.Parameters.AddWithValue("@idlocacao", modLocacaoDev.idLocacaoDev);
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception erro)
            {
                throw new Exception ("Erro ao finalizar devolução da locação! "+erro.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método utilizado para gerar a id "salvar a locação" quando clicado no botão para inserir um item
        public void gerarIdLocacaoDev(LocacaoDevolucaoModelo modLocacaoDev)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("insert into locacao (dataLancamento_locacao) values (@dataLan)", conexao);
                comando.Parameters.AddWithValue("@dataLan", modLocacaoDev.dataLancamentoLocacaoDev);
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

        //Método utizado para pegar a id da ultima locação quando inserido um item e não preenchido as informações, é filtrado pela data de lançamento
        public void pegarIdGerada(string valorReturn)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("select max(id_locacao) as numeroPego from locacao where dataLancamento_locacao = '" + valorReturn + "'", conexao);
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    numeroIncluido = Convert.ToString(dr["numeroPego"]);
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao pesquisar id da locação: " + erro.Message);
            }
        }

        //Método utilizado para excluir o item da devolução da locação
        public void excluirItemLocacaoDevolucao(LocacaoDevolucaoModelo modLocacaoDev)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                string comando = "delete from locacaoitens where id_locacaoitens=" + modLocacaoDev.codigoItem;
                conexao.ExecutarComandoSQL(comando);
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao excluir o item da devolução, classe DAO: " + erro.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Inicio código fonte pesquisa os itens para devolução da locação informada
        public DataTable listarItensParaDevolucao(string filtro)
        {
            DataTable dt = new DataTable();

            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                dt = conexao.RetDataTable("select *from viewlistarlocacaoitensdev where idlocacao = '"+filtro+"' order by IDLocacao");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar itens da devolução: " + ex.Message);
            }
            return dt;
        }

        //Método inserir item manualmente na devolução da locação
        public void inserirItemDevLocacao(LocacaoDevolucaoModelo modLocacaoDev)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("insert into locacaoitens (idProduto_locacaoitens,valorLocado_locacaoitens,idLocacao_locacaoitens, "+
                " qtdLocada_locacaoitens, tipo_locacaoitens, idVariacaoProduto_locacaoitens) values(@idProd, @valo, @idLoca, @qtd, @tipo, @idvariacao)",conexao);
                comando.Parameters.AddWithValue("@idProd", modLocacaoDev.idClienteLocacaoDev);

            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao inserir item, classe DAO " + erro.Message);
            }
            finally
            {
                FecharConexao();
            }
        }



    }
}
