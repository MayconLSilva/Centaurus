using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centaurus.Model;
using MySql.Data.MySqlClient;
using System.Data;
using Centaurus.DTO;

namespace Centaurus.Dao
{
    public class LocacaoDAO: ConexaoBanco
    {
        MySqlCommand comando = null;
        MySqlDataReader dr;
        public string numeroIncluido{ get; set; }

        //Método utilizado para salvar a locação sem itens, quando usuário só preencheu as informações e salvou para prosseguir mais tarde
        public void salvarLocacao(LocacaoModelo locacaoModelo)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("insert into locacao (dataLancamento_locacao,dataPrevisaoEntrega_locacao,idCliente_locacao,desconto_locacao,qtdItens_locacao,total_locacao,tipo_locacao,usuario_locacao) values (@dataLan,@dataEnt,@idCli,@dec,@qtdItem,@valorTo,@tipo,@usuario)", conexao);
                comando.Parameters.AddWithValue("@dataLan", locacaoModelo.dataLancamentoLocao);
                comando.Parameters.AddWithValue("@dataEnt", locacaoModelo.dataPrevisaoEntregaLocao);
                comando.Parameters.AddWithValue("@idCli", locacaoModelo.idClienteLocao);
                comando.Parameters.AddWithValue("@dec", locacaoModelo.descontoLocao);
                comando.Parameters.AddWithValue("@qtdItem", locacaoModelo.qtdItensLocao);
                comando.Parameters.AddWithValue("@valorTo", locacaoModelo.totalLocao);
                comando.Parameters.AddWithValue("@tipo", "L");
                comando.Parameters.AddWithValue("@usuario", locacaoModelo.usuarioLocacao);
                comando.ExecuteNonQuery();
            }catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método utilizado para salvar a locação quando o usuário informou todos itens na mesma
        public void finalizarLocacao(LocacaoModelo locacaoModelo)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("update locacao set dataPrevisaoEntrega_locacao = @dataEnt, idCliente_locacao = @idCli,desconto_locacao = @dec,qtdItens_locacao=@qtdItem,total_locacao=@valorTo,tipo_locacao=@tipo,usuario_locacao=@usuario where id_locacao = @idLocacao", conexao);
                comando.Parameters.AddWithValue("@dataEnt", locacaoModelo.dataPrevisaoEntregaLocao);
                comando.Parameters.AddWithValue("@idCli", locacaoModelo.idClienteLocao);
                comando.Parameters.AddWithValue("@dec", locacaoModelo.descontoLocao);
                comando.Parameters.AddWithValue("@qtdItem", locacaoModelo.qtdItensLocao);
                comando.Parameters.AddWithValue("@valorTo", locacaoModelo.totalLocao);
                comando.Parameters.AddWithValue("@tipo", "L");
                comando.Parameters.AddWithValue("@usuario", locacaoModelo.usuarioLocacao);
                comando.Parameters.AddWithValue("@idLocacao", locacaoModelo.idLocacao);
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

        //Método utilizado para atualizar a locação quando pesquisado a mesma
        public void atualizarLocacao(LocacaoModelo locacaoModelo)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("update locacao set dataPrevisaoEntrega_locacao = @dataEnt, idCliente_locacao = @idCli,desconto_locacao = @dec,qtdItens_locacao=@qtdItem,total_locacao=@valorTo where id_locacao = @idLocacao", conexao);
                comando.Parameters.AddWithValue("@dataEnt", locacaoModelo.dataPrevisaoEntregaLocao);
                comando.Parameters.AddWithValue("@idCli", locacaoModelo.idClienteLocao);
                comando.Parameters.AddWithValue("@dec", locacaoModelo.descontoLocao);
                comando.Parameters.AddWithValue("@qtdItem", locacaoModelo.qtdItensLocao);
                comando.Parameters.AddWithValue("@valorTo", locacaoModelo.totalLocao);
                comando.Parameters.AddWithValue(" @idLocacao", locacaoModelo.idLocacao);
                comando.ExecuteNonQuery();
            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método utilizado para pegar o ultimo registro incluido quando salvado uma locação
        public void UltimoRegistro(string valorReturn)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("select max(id_locacao) as numeroPego from locacao where idCliente_locacao = '" + valorReturn + "'", conexao);
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

        //Método utilizado para salvar os itens na locação
        public void salvarItensLocacao(LocacaoModelo locacaoModelo)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("insert into locacaoitens (idProduto_locacaoitens,valorLocado_locacaoitens,valorOriginal_locacaoitens,custoDia_locacaoitens,idLocacao_locacaoitens,qtdLocada_locacaoitens,tipo_locacaoitens,idVariacaoProduto_locacaoitens) values (@idProduto,@valorLocado,@valorOrigin,@custoDia,@idLocacao,@qtd,@tipo,@idVariacao)", conexao);
                comando.Parameters.AddWithValue("@idProduto", locacaoModelo.idProdutoLocacaoItens);
                comando.Parameters.AddWithValue("@valorLocado", locacaoModelo.valorLocadoLocacaoItens);
                comando.Parameters.AddWithValue("@valorOrigin", locacaoModelo.valorOriginalLocacaoItens);
                comando.Parameters.AddWithValue("@custoDia", locacaoModelo.custoDiaLocacaoItens);
                comando.Parameters.AddWithValue("@idLocacao", locacaoModelo.idLocacaoLocacaoItens);
                comando.Parameters.AddWithValue("@qtd", locacaoModelo.qtdItensLocacaoItens);
                comando.Parameters.AddWithValue("@tipo", "L");
                comando.Parameters.AddWithValue("@idVariacao", locacaoModelo.idVariacaoProdutoLocacaoItens);
                comando.ExecuteNonQuery();
            }
            catch(Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método utilizado para gerar a id "salvar a locação" quando clicado no botão para inserir um item
        public void gerarIdLocacao(LocacaoModelo locacaoModelo)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("insert into locacao (dataLancamento_locacao) values (@dataLan)", conexao);
                comando.Parameters.AddWithValue("@dataLan", locacaoModelo.dataLancamentoLocao);
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

        //Método listar itens locação na tabela
        public DataTable listarItens(string filtro)
        {
            DataTable dt = new DataTable();

            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                dt = conexao.RetDataTable("select *from viewlocacaoitens where idLocacao_locacaoitens = '" + filtro + "'"); 
            }catch(Exception erro)
            {
                throw new Exception("Erro ao consultar itens " + erro.Message);
            }
            return dt;
        }

        //Método utilizado para excluir locação, irá exclui
        public void excluirLocacao(LocacaoModelo locacaoModelo)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                string comando = "delete from locacao where id_locacao=" + locacaoModelo.idLocacao;
                conexao.ExecutarComandoSQL(comando);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao excluir locação, classe DAO: " + erro.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método utilizado para excluir um item dalocação
        public void excluirItemLocacao(LocacaoModelo locacaoModelo)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                string comando = "delete from locacaoitens where id_locacaoitens=" + locacaoModelo.idProdutoLocacaoItens;
                conexao.ExecutarComandoSQL(comando);
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao excluir o item da locação, classe DAO: " + erro.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método listar locação na pesquisa
        public DataTable listarLocacao(string tipoFiltro,string filtro)
        {
            DataTable dt = new DataTable();

            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                if(tipoFiltro == "TODOS")
                {
                    dt = conexao.RetDataTable("select *from viewlocacao "+
                    " where NomeCliente like '' and TipoLocacao = '' " +
                    " or cast(DataLancamento as DATE) = '' and TipoLocacao = '' " +
                    " or cast(DataPrevisaoEntrega as DATE) = '' and TipoLocacao = '' " +
                    " or UsuarioLocacao = '' and TipoLocacao = '' " +
                    " or TipoLocacao = 'L'");
                }
                else if(tipoFiltro == "CLIENTE")
                {
                    dt = conexao.RetDataTable("select *from viewlocacao " +
                    " where NomeCliente like '%"+filtro+"%' and TipoLocacao = 'L' " +
                    " or cast(DataLancamento as DATE) = '' and TipoLocacao = '' " +
                    " or cast(DataPrevisaoEntrega as DATE) = '' and TipoLocacao = '' " +
                    " or UsuarioLocacao = '' and TipoLocacao = ''" +
                    " or TipoLocacao = ''");
                }
                else if (tipoFiltro == "DATA LANÇAMENTO")
                {
                    //Método chama o ultimo registro
                    var dataConvertida = DateTime.Parse(filtro).ToString("yyyy-MM-dd HH:mm:ss");
                                        
                    dt = conexao.RetDataTable("select *from viewlocacao " +
                    " where NomeCliente like '' and TipoLocacao = '' " +
                    " or cast(DataLancamento as DATE) = '"+ dataConvertida + "' and TipoLocacao = 'L' " +
                    " or cast(DataPrevisaoEntrega as DATE) = '' and TipoLocacao = '' " +
                    " or UsuarioLocacao = '' and TipoLocacao = ''" +
                    " or TipoLocacao = ''");
                    
                }
                else if (tipoFiltro == "DATA DEVOLUÇÃO")
                {
                    //Método chama o ultimo registro
                    var dataConvertida = DateTime.Parse(filtro).ToString("yyyy-MM-dd HH:mm:ss");

                    dt = conexao.RetDataTable("select *from viewlocacao " +
                    " where NomeCliente like '' and TipoLocacao = '' " +
                    " or cast(DataLancamento as DATE) = '' and TipoLocacao = '' " +
                    " or cast(DataPrevisaoEntrega as DATE) = '"+ dataConvertida + "' and TipoLocacao = 'L' " +
                    " or UsuarioLocacao = '' and TipoLocacao = ''" +
                    " or TipoLocacao = ''");
                }
                else if (tipoFiltro == "USUÁRIO")
                {
                    dt = conexao.RetDataTable("select *from viewlocacao " +
                    " where NomeCliente like '' and TipoLocacao = '' " +
                    " or cast(DataLancamento as DATE) = '' and TipoLocacao = '' " +
                    " or cast(DataPrevisaoEntrega as DATE) = '' and TipoLocacao = '' " +
                    " or UsuarioLocacao = '" + filtro + "' and TipoLocacao = 'L'" +
                    " or TipoLocacao = ''");
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao consultar locação, classe DAO " + erro.Message);
            }
            return dt;
        }









    }
}
