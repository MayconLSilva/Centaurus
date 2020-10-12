using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Centaurus.Model;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Diagnostics;

namespace Centaurus.Dao
{
    public class ProdutoDAO : ConexaoBanco
    {
        MySqlCommand comando = null;
        MySqlDataReader dr;


        public string numeroIncluido { get; set; }

        public void salvar(ProdutoModelo produtoModelo)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("insert into produto (ativo_produto,descontinuado_produto,tipoitem_produto,descricao_produto,unidade_produto,venda_produto,marca_produto,categoria_produto,subcategoria_produto,fornecedor_produto,codfabricante_produto,codbarras_produto,codinterno_produto,dataCadastro_produto,usuarioCadastro_produto,custofinal_produto) values (@ativo,@descontinuado,@tipoitem,@descricao,@unidade,@venda,@marca,@categoria,@subcat,@fornecedor,@codfab,@codbarr,@codint,@dataCadas,@usuarioCadas,@custfinal)", conexao);
                comando.Parameters.AddWithValue("@ativo", produtoModelo.ativoProduto);
                comando.Parameters.AddWithValue("@descontinuado", produtoModelo.descontinuadoProduto);
                comando.Parameters.AddWithValue("@tipoitem", produtoModelo.tipoProduto);
                comando.Parameters.AddWithValue("@descricao", produtoModelo.descricaoProduto);
                comando.Parameters.AddWithValue("@unidade", produtoModelo.unidadeProduto);
                comando.Parameters.AddWithValue("@venda", produtoModelo.vendaProduto);
                comando.Parameters.AddWithValue("@marca", produtoModelo.marcaProduto);
                comando.Parameters.AddWithValue("@categoria", produtoModelo.categoriaProduto);
                comando.Parameters.AddWithValue("@subcat", produtoModelo.subCategoriaProduto);
                comando.Parameters.AddWithValue("@fornecedor", produtoModelo.fornecedorProduto);
                comando.Parameters.AddWithValue("@codfab", produtoModelo.codFabricanteProduto);
                comando.Parameters.AddWithValue("@codbarr", produtoModelo.codBarrasProduto);
                comando.Parameters.AddWithValue("@codint", produtoModelo.codInternoProduto);
                comando.Parameters.AddWithValue("@dataCadas", produtoModelo.dataCadastroProduto);
                comando.Parameters.AddWithValue("@usuarioCadas", produtoModelo.usuarioCadastroProduto);
                comando.Parameters.AddWithValue("@custfinal", produtoModelo.custoFinalProduto);
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao inserir produto: " + erro.Message);
            }
            finally
            {
                FecharConexao();
            }

        }

        public void atualizar(ProdutoModelo produtoModelo)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("update produto set ativo_produto=@ativo,descontinuado_produto=@descontinuado,tipoitem_produto=@tipoitem,descricao_produto=@descricao,unidade_produto=@unidade,venda_produto=@venda,marca_produto=@marca,categoria_produto=@categoria,subcategoria_produto=@subcat,fornecedor_produto=@fornecedor,codfabricante_produto=@codfab,codbarras_produto=@codbarr,codinterno_produto=@codint,dataAlteracao_produto=@dataAlte,usuarioAlteracao_produto=@usuarioAlt,custofinal_produto=@custfinal where id_produto=@idproduto", conexao);
                comando.Parameters.AddWithValue("@ativo", produtoModelo.ativoProduto);
                comando.Parameters.AddWithValue("@descontinuado", produtoModelo.descontinuadoProduto);
                comando.Parameters.AddWithValue("@tipoitem", produtoModelo.tipoProduto);
                comando.Parameters.AddWithValue("@descricao", produtoModelo.descricaoProduto);
                comando.Parameters.AddWithValue("@unidade", produtoModelo.unidadeProduto);
                comando.Parameters.AddWithValue("@venda", produtoModelo.vendaProduto);
                comando.Parameters.AddWithValue("@marca", produtoModelo.marcaProduto);
                comando.Parameters.AddWithValue("@categoria", produtoModelo.categoriaProduto);
                comando.Parameters.AddWithValue("@subcat", produtoModelo.subCategoriaProduto);
                comando.Parameters.AddWithValue("@fornecedor", produtoModelo.fornecedorProduto);
                comando.Parameters.AddWithValue("@codfab", produtoModelo.codFabricanteProduto);
                comando.Parameters.AddWithValue("@codbarr", produtoModelo.codBarrasProduto);
                comando.Parameters.AddWithValue("@codint", produtoModelo.codInternoProduto);
                comando.Parameters.AddWithValue("@dataAlte", produtoModelo.dataAlteracaoProduto);
                comando.Parameters.AddWithValue("@usuarioAlt", produtoModelo.usuarioAlteracaoProduto);
                comando.Parameters.AddWithValue("@custfinal", produtoModelo.custoFinalProduto);
                comando.Parameters.AddWithValue("@idproduto", produtoModelo.idProduto);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao atualizar produto: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        /*
        public void UltimoRegistro(string valorReturn)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("select max(id_produto) as numeroPego from produto where descricao_produto = '" + valorReturn + "'", conexao);
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    numeroIncluido = Convert.ToString(dr["numeroPego"]);
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao pesquisar id do produto: " + erro.Message);
            }
        }
        */

        //Método de lista de produtos e seus respectivos filtros
        public DataTable listarProdutosServicos(string tipoPesquisa, string filtro1, string tipoProdutoDAO, string tipoServicoDAO)
        {
            DataTable dt = new DataTable();

            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                if (tipoPesquisa == "TODOS")
                {
                    dt = conexao.RetDataTable("select *from viewlistarproduto where categoria = '' and tipoitem in ('', '') or subcategoria = '' and tipoitem in ('', '') or fornecedor = '' and tipoitem in ('', '') or id_produto = '' and tipoitem in ('', '') or descricao_marca = '' and tipoitem in ('', '') or descricao_produto = '' and tipoitem in ('', '') or categoria like '' or subcategoria like '' or descricao_produto like '' or descricao_marca like '' or fornecedor like '' and tipoitem in ('', '') or tipoitem in ('" + tipoProdutoDAO + "', '" + tipoServicoDAO + "')");
                }
                else if (tipoPesquisa == "CÓDIGO")
                {
                    dt = conexao.RetDataTable("select *from viewlistarproduto where categoria = '' and tipoitem in ('', '') or subcategoria = '' and tipoitem in ('', '') or fornecedor = '' and tipoitem in ('', '') or id_produto = '" + filtro1 + "' and tipoitem in ('" + tipoProdutoDAO + "', '" + tipoServicoDAO + "') or descricao_marca = '' and tipoitem in ('', '') or descricao_produto = '' and tipoitem in ('', '') or categoria like '' or subcategoria like '' or descricao_produto like '' or descricao_marca like '' or fornecedor like '' and tipoitem in ('', '') or tipoitem in ('', '')");
                }
                else if (tipoPesquisa == "NOME")
                {
                    dt = conexao.RetDataTable("select *from viewlistarproduto where categoria = '' and tipoitem in ('', '') or subcategoria = '' and tipoitem in ('', '') or fornecedor = '' and tipoitem in ('', '') or id_produto = '' and tipoitem in ('', '') or descricao_marca = '' and tipoitem in ('', '') or descricao_produto = '" + filtro1 + "' and tipoitem in ('" + tipoProdutoDAO + "', '" + tipoServicoDAO + "') or categoria like '' or subcategoria like '' or descricao_produto like '' or descricao_marca like '' or fornecedor like '' and tipoitem in ('', '') or tipoitem in ('', '')");
                }
                else if (tipoPesquisa == "CATEGORIA")
                {
                    dt = conexao.RetDataTable("select *from viewlistarproduto where categoria = '" + filtro1 + "' and tipoitem in ('" + tipoProdutoDAO + "', '" + tipoServicoDAO + "') or subcategoria = '' and tipoitem in ('', '') or fornecedor = '' and tipoitem in ('', '') or id_produto = '' and tipoitem in ('', '') or descricao_marca = '' and tipoitem in ('', '') or descricao_produto = '' and tipoitem in ('', '') or categoria like '' or subcategoria like '' or descricao_produto like '' or descricao_marca like '' or fornecedor like '' and tipoitem in ('', '') or tipoitem in ('', '')");
                }
                else if (tipoPesquisa == "SUB-CATEGORIA")
                {
                    dt = conexao.RetDataTable("select *from viewlistarproduto where categoria = '' and tipoitem in ('', '') or subcategoria = '" + filtro1 + "' and tipoitem in ('" + tipoProdutoDAO + "', '" + tipoServicoDAO + "') or fornecedor = '' and tipoitem in ('', '') or id_produto = '' and tipoitem in ('', '') or descricao_marca = '' and tipoitem in ('', '') or descricao_produto = '' and tipoitem in ('', '') or categoria like '' or subcategoria like '' or descricao_produto like '' or descricao_marca like '' or fornecedor like '' and tipoitem in ('', '') or tipoitem in ('', '')");
                }
                else if (tipoPesquisa == "MARCA")
                {
                    dt = conexao.RetDataTable("select *from viewlistarproduto where categoria = '' and tipoitem in ('', '') or subcategoria = '' and tipoitem in ('', '') or fornecedor = '' and tipoitem in ('', '') or id_produto = '' and tipoitem in ('', '') or descricao_marca = '" + filtro1 + "' and tipoitem in ('" + tipoProdutoDAO + "', '" + tipoServicoDAO + "') or descricao_produto = '' and tipoitem in ('', '') or categoria like '' or subcategoria like '' or descricao_produto like '' or descricao_marca like '' or fornecedor like '' and tipoitem in ('', '') or tipoitem in ('', '')");
                }
                else if (tipoPesquisa == "FORNECEDOR")
                {
                    dt = conexao.RetDataTable("select *from viewlistarproduto where categoria = '' and tipoitem in ('', '') or subcategoria = '' and tipoitem in ('', '') or fornecedor = '" + filtro1 + "' and tipoitem in ('" + tipoProdutoDAO + "', '" + tipoServicoDAO + "') or id_produto = '' and tipoitem in ('', '') or descricao_marca = '' and tipoitem in ('', '') or descricao_produto = '' and tipoitem in ('', '') or categoria like '' or subcategoria like '' or descricao_produto like '' or descricao_marca like '' or fornecedor like '' and tipoitem in ('', '') or tipoitem in ('', '')");
                }
                else if (tipoPesquisa == "TIPO")
                {
                    dt = conexao.RetDataTable("select *from viewlistarproduto where categoria = '' and tipoitem in ('', '') or subcategoria = '' and tipoitem in ('', '') or fornecedor = '' and tipoitem in ('', '') or id_produto = '' and tipoitem in ('', '') or descricao_marca = '' and tipoitem in ('', '') or descricao_produto = '' and tipoitem in ('', '') or categoria like '' or subcategoria like '' or descricao_produto like '' or descricao_marca like '' or fornecedor like '' and tipoitem in ('', '') or tipoitem in ('" + tipoProdutoDAO + "', '" + tipoServicoDAO + "')");
                }
                else if (tipoPesquisa == "INTELIGENTE")
                {
                    dt = conexao.RetDataTable("select *from viewlistarproduto where categoria = '' and tipoitem in ('', '') or subcategoria = '' and tipoitem in ('', '') or fornecedor = '' and tipoitem in ('', '') or id_produto = '' and tipoitem in ('', '') or descricao_marca = '' and tipoitem in ('', '') or descricao_produto = '' and tipoitem in ('', '') or categoria like '%" + filtro1 + "%' or subcategoria like '%" + filtro1 + "%' or descricao_produto like '%" + filtro1 + "%' or descricao_marca like '%" + filtro1 + "%' or fornecedor like '%" + filtro1 + "%' and tipoitem in ('" + tipoProdutoDAO + "', '" + tipoServicoDAO + "') or tipoitem in ('', '')");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar produtos: " + ex.Message);
            }
            return dt;
        }

        //Metodo de lista de produtos com variações e seus respectivos filtros
        public DataTable listarProdutosVariacoes(string tipoPesquisa, string filtro1, string tipoProdutoDAO, string tipoServicoDAO)
        {
            DataTable dt = new DataTable();

            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                if (tipoPesquisa == "TODOS")
                {
                    dt = conexao.RetDataTable("select *from viewlistarprodutocomvariacao where categoria = '' and tipoitem in ('', '') or subcategoria = '' and tipoitem in ('', '') or fornecedor = '' and tipoitem in ('', '') or id_produto = '' and tipoitem in ('', '') or descricao_marca = '' and tipoitem in ('', '') or descricao_produto = '' and tipoitem in ('', '') or categoria like '' or subcategoria like '' or descricao_produto like '' or descricao_marca like '' or fornecedor like '' and tipoitem in ('', '') or tipoitem in ('" + tipoProdutoDAO + "', '" + tipoServicoDAO + "')");
                }
                else if (tipoPesquisa == "CÓDIGO")
                {
                    dt = conexao.RetDataTable("select *from viewlistarprodutocomvariacao where categoria = '' and tipoitem in ('', '') or subcategoria = '' and tipoitem in ('', '') or fornecedor = '' and tipoitem in ('', '') or id_produto = '" + filtro1 + "' and tipoitem in ('" + tipoProdutoDAO + "', '" + tipoServicoDAO + "') or descricao_marca = '' and tipoitem in ('', '') or descricao_produto = '' and tipoitem in ('', '') or categoria like '' or subcategoria like '' or descricao_produto like '' or descricao_marca like '' or fornecedor like '' and tipoitem in ('', '') or tipoitem in ('', '')");
                }
                else if (tipoPesquisa == "NOME")
                {
                    dt = conexao.RetDataTable("select *from viewlistarprodutocomvariacao where categoria = '' and tipoitem in ('', '') or subcategoria = '' and tipoitem in ('', '') or fornecedor = '' and tipoitem in ('', '') or id_produto = '' and tipoitem in ('', '') or descricao_marca = '' and tipoitem in ('', '') or descricao_produto = '" + filtro1 + "' and tipoitem in ('" + tipoProdutoDAO + "', '" + tipoServicoDAO + "') or categoria like '' or subcategoria like '' or descricao_produto like '' or descricao_marca like '' or fornecedor like '' and tipoitem in ('', '') or tipoitem in ('', '')");
                }
                else if (tipoPesquisa == "CATEGORIA")
                {
                    dt = conexao.RetDataTable("select *from viewlistarprodutocomvariacao where categoria = '" + filtro1 + "' and tipoitem in ('" + tipoProdutoDAO + "', '" + tipoServicoDAO + "') or subcategoria = '' and tipoitem in ('', '') or fornecedor = '' and tipoitem in ('', '') or id_produto = '' and tipoitem in ('', '') or descricao_marca = '' and tipoitem in ('', '') or descricao_produto = '' and tipoitem in ('', '') or categoria like '' or subcategoria like '' or descricao_produto like '' or descricao_marca like '' or fornecedor like '' and tipoitem in ('', '') or tipoitem in ('', '')");
                }
                else if (tipoPesquisa == "SUB-CATEGORIA")
                {
                    dt = conexao.RetDataTable("select *from viewlistarprodutocomvariacao where categoria = '' and tipoitem in ('', '') or subcategoria = '" + filtro1 + "' and tipoitem in ('" + tipoProdutoDAO + "', '" + tipoServicoDAO + "') or fornecedor = '' and tipoitem in ('', '') or id_produto = '' and tipoitem in ('', '') or descricao_marca = '' and tipoitem in ('', '') or descricao_produto = '' and tipoitem in ('', '') or categoria like '' or subcategoria like '' or descricao_produto like '' or descricao_marca like '' or fornecedor like '' and tipoitem in ('', '') or tipoitem in ('', '')");
                }
                else if (tipoPesquisa == "MARCA")
                {
                    dt = conexao.RetDataTable("select *from viewlistarprodutocomvariacao where categoria = '' and tipoitem in ('', '') or subcategoria = '' and tipoitem in ('', '') or fornecedor = '' and tipoitem in ('', '') or id_produto = '' and tipoitem in ('', '') or descricao_marca = '" + filtro1 + "' and tipoitem in ('" + tipoProdutoDAO + "', '" + tipoServicoDAO + "') or descricao_produto = '' and tipoitem in ('', '') or categoria like '' or subcategoria like '' or descricao_produto like '' or descricao_marca like '' or fornecedor like '' and tipoitem in ('', '') or tipoitem in ('', '')");
                }
                else if (tipoPesquisa == "FORNECEDOR")
                {
                    dt = conexao.RetDataTable("select *from viewlistarprodutocomvariacao where categoria = '' and tipoitem in ('', '') or subcategoria = '' and tipoitem in ('', '') or fornecedor = '" + filtro1 + "' and tipoitem in ('" + tipoProdutoDAO + "', '" + tipoServicoDAO + "') or id_produto = '' and tipoitem in ('', '') or descricao_marca = '' and tipoitem in ('', '') or descricao_produto = '' and tipoitem in ('', '') or categoria like '' or subcategoria like '' or descricao_produto like '' or descricao_marca like '' or fornecedor like '' and tipoitem in ('', '') or tipoitem in ('', '')");
                }
                else if (tipoPesquisa == "TIPO")
                {
                    dt = conexao.RetDataTable("select *from viewlistarprodutocomvariacao where categoria = '' and tipoitem in ('', '') or subcategoria = '' and tipoitem in ('', '') or fornecedor = '' and tipoitem in ('', '') or id_produto = '' and tipoitem in ('', '') or descricao_marca = '' and tipoitem in ('', '') or descricao_produto = '' and tipoitem in ('', '') or categoria like '' or subcategoria like '' or descricao_produto like '' or descricao_marca like '' or fornecedor like '' and tipoitem in ('', '') or tipoitem in ('" + tipoProdutoDAO + "', '" + tipoServicoDAO + "')");
                }
                else if (tipoPesquisa == "INTELIGENTE")
                {
                    dt = conexao.RetDataTable("select *from viewlistarprodutocomvariacao where categoria = '' and tipoitem in ('', '') or subcategoria = '' and tipoitem in ('', '') or fornecedor = '' and tipoitem in ('', '') or id_produto = '' and tipoitem in ('', '') or descricao_marca = '' and tipoitem in ('', '') or descricao_produto = '' and tipoitem in ('', '') or categoria like '%" + filtro1 + "%' or subcategoria like '%" + filtro1 + "%' or descricao_produto like '%" + filtro1 + "%' or descricao_marca like '%" + filtro1 + "%' or fornecedor like '%" + filtro1 + "%' and tipoitem in ('" + tipoProdutoDAO + "', '" + tipoServicoDAO + "') or tipoitem in ('', '')");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar produtos: " + ex.Message);
            }
            return dt;
        }

        //Método pesquisa todos dados do produto por id para setar nos seus respectivos campos
        public ProdutoModelo buscarInformacoesProdutoPorCodigo(ProdutoModelo modelo)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("select *from viewbuscarproduto where id_produto = '" + modelo.idProduto + "'", conexao);
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    bool ativo = Convert.ToBoolean(dr["ativo_produto"]);
                    bool descontinuado = Convert.ToBoolean(dr["descontinuado_produto"]);
                    char tipoitem = Convert.ToChar(dr["tipoitem_produto"]);
                    string nomeProduto = Convert.ToString(dr["descricao_produto"]);
                    int iditem = Convert.ToInt32(dr["id_produto"]);
                    string unidade = Convert.ToString(dr["unidade_produto"]);
                    float valorvenda = Convert.ToSingle(dr["venda_produto"]);
                    string estoque = Convert.ToString(dr["saldo_produto"]);//Validar como farei o estoque
                    string idmarca = Convert.ToString(dr["marca_produto"]);
                    string idcategoria = Convert.ToString(dr["categoria_produto"]);
                    string subcategoria = Convert.ToString(dr["subcategoria_produto"]);
                    string idfornecedor = Convert.ToString(dr["fornecedor_produto"]);
                    string codfabri = Convert.ToString(dr["codfabricante_produto"]);
                    string codbarras = Convert.ToString(dr["codbarras_produto"]);
                    string codinterno = Convert.ToString(dr["codinterno_produto"]);
                    string datacad = Convert.ToString(dr["dataCadastro_produto"]);
                    string dataalt = Convert.ToString(dr["dataAlteracao_produto"]);
                    string usariocad = Convert.ToString(dr["usuarioCadastro_produto"]);
                    string usarioalt = Convert.ToString(dr["usuarioAlteracao_produto"]);
                    string ultcusto = Convert.ToString(dr["ultimoCustoCompra_produto"]);
                    string custoant = Convert.ToString(dr["custoAnterior_produto"]);
                    float custofin = Convert.ToSingle(dr["custofinal_produto"]);

                    string marcanome = Convert.ToString(dr["descricao_marca"]);
                    string catnome = Convert.ToString(dr["categoria"]);
                    string subcatnome = Convert.ToString(dr["subcategoria"]);
                    string nomeforne = Convert.ToString(dr["fornecedor"]);

                    modelo.ativoProduto = ativo;
                    modelo.descontinuadoProduto = descontinuado;
                    modelo.tipoProduto = tipoitem;
                    modelo.idProduto = iditem;
                    modelo.descricaoProduto = nomeProduto;
                    modelo.unidadeProduto = unidade;
                    modelo.vendaProduto = valorvenda;
                    if (estoque == "")
                    {
                        modelo.saldoProduto = 0;
                    }
                    else
                    {
                        modelo.saldoProduto = Convert.ToDouble(estoque);
                    }
                    modelo.marcaProduto = idmarca;
                    modelo.categoriaProduto = idcategoria;
                    modelo.subCategoriaProduto = subcategoria;
                    modelo.fornecedorProduto = idfornecedor;
                    modelo.codFabricanteProduto = codfabri;
                    modelo.codBarrasProduto = codbarras;
                    modelo.codInternoProduto = codinterno;
                    modelo.dataCadastroProduto = datacad;
                    modelo.dataAlteracaoProduto = dataalt;
                    modelo.usuarioCadastroProduto = usariocad;
                    modelo.usuarioAlteracaoProduto = usarioalt;
                    if (ultcusto == "")
                    {
                        modelo.ultimoCustoCompraProduto = 0;
                    }
                    else
                    {
                        modelo.ultimoCustoCompraProduto = Convert.ToSingle(ultcusto);
                    }
                    if (custoant == "")
                    {
                        modelo.custoAnteriorProduto = 0;
                    }
                    else
                    {
                        modelo.custoAnteriorProduto = Convert.ToSingle(custoant);
                    }

                    modelo.custoFinalProduto = custofin;

                    modelo.nomeCategoria = catnome;
                    modelo.nomeSubCategoria = subcatnome;
                    modelo.nomeMarca = marcanome;
                    modelo.nomeFornecedor = nomeforne;
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao pesquisar informações do produto: " + erro.Message);
            }
            return modelo;
        }

        public void ExcluirProduto(ProdutoModelo produtoModelo)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                string comando = "delete from produto where id_produto=" + produtoModelo.idProduto;
                conexao.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir produto: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void salvarVariacao(ProdutoModelo produtoModelo)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("insert into produtovariacao (idproduto_produtovariacao,unidade_produtovariacao,fator_produtovariacao,quantidade_produtovariacao,codbarras_produtovariacao) values (@idProdVari,@unVari,@fatVari,@qtdVari,@codbarrava)", conexao);
                comando.Parameters.AddWithValue("@idProdVari", produtoModelo.idProdVariacao);
                comando.Parameters.AddWithValue("@unVari", produtoModelo.unProdVariacao);
                comando.Parameters.AddWithValue("@fatVari", produtoModelo.fatorProdVariacao);
                comando.Parameters.AddWithValue("@qtdVari", produtoModelo.qtdProdVariacao);
                comando.Parameters.AddWithValue("@codbarrava",produtoModelo.codBarrasVariacao);
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao inserir produto variação: " + erro.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public void excluirVariacao(ProdutoModelo produtoModelo)
        {
            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                string comando = "delete from produtovariacao where id_produtovariacao=" + produtoModelo.idProdVariacao;
                conexao.ExecutarComandoSQL(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir produto variação: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método lista os produtos variações do produto informado pelo código
        public DataTable listarVariacaoProduto(string filtro)
        {
            DataTable dt = new DataTable();

            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                dt = conexao.RetDataTable("select *from viewlistarvariacao where idProduto ='" + filtro + "'");
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar variacoes do produto: " + ex.Message);
            }
            return dt;
        }

        public ProdutoModelo buscarUltimoRegistro(ProdutoModelo modProduto)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("select max(id_produto) as numeroPego from produto where descricao_produto = '" + modProduto.descricaoProduto + "'", conexao);
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    int numeroReturn = Convert.ToInt32(dr["numeroPego"]);
                    modProduto.idProduto = numeroReturn;
                }
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao pesquisar id do produto: " + erro.Message);
            }
            finally
            {
                FecharConexao();
            }
            return modProduto;
        }

        public ProdutoModelo buscarProdutoClick(ProdutoModelo modProduto)
        {
            int contador = 0;
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("select *from viewlistarprodutocomvariacao where id_produto = '"+modProduto.idProduto+"'", conexao);
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    string nomeProduto = Convert.ToString(dr["descricao_produto"]);
                    float custoProduto = Convert.ToSingle(dr["custo"]);
                    float valorReal = Convert.ToSingle(dr["venda_produto"]);
                    contador = contador + 1;

                    modProduto.descricaoProduto = nomeProduto;
                    modProduto.idProduto = contador;
                    modProduto.custoFinalProduto = custoProduto;
                    modProduto.vendaProduto = valorReal;
                }

            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao buscar o produto pelo código informado, classe DAO! " + erro.Message);
            }
            finally
            {
                FecharConexao();
            }
            return modProduto;
        }

    }
}
