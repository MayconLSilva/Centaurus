using Centaurus.Dao;
using Centaurus.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centaurus.Bll
{
    public class ProdutoBLL
    {
        ProdutoDAO produtoDAO = new ProdutoDAO();


        public void salvar(ProdutoModelo modProduto)
        {
            try
            {
                produtoDAO.salvar(modProduto);
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        public void salvarVariacao(ProdutoModelo modProduto)
        {
            try
            {
                produtoDAO.salvarVariacao(modProduto);

            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void atualizar(ProdutoModelo modProduto)
        {
            try
            {
                produtoDAO.atualizar(modProduto);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir(ProdutoModelo modProduto)
        {
            try
            {
                produtoDAO = new ProdutoDAO();
                produtoDAO.ExcluirProduto(modProduto);
            }catch(Exception erro)
            {
                throw erro;
            }
        }

        public void excluirVariacao(ProdutoModelo modProduto)
        {
            try
            {
                produtoDAO = new ProdutoDAO();
                produtoDAO.excluirVariacao(modProduto);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void buscarProdutoPorCodigo(ProdutoModelo modProduto)
        {
            try
            {
                produtoDAO.buscarInformacoesProdutoPorCodigo(modProduto);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao buscar informações do produto, classe BLL! " + erro.Message);
            }
        }

        public void buscarUltimoRegistro(ProdutoModelo modProduto)
        {
            try
            {
                produtoDAO.buscarUltimoRegistro(modProduto);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao buscar ultimo registro, classe BLL! " + erro.Message);
            }
        }

        public void buscarProdutoCodigos(ProdutoModelo modProduto)
        {
            try
            {
                produtoDAO.buscarProdutoCodigos(modProduto);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro " + erro);
            }
        }

        public DataTable listarVariacoesDoProduto(string filtro)
        {
            DataTable dataTable = new DataTable();

            try
            {
                dataTable = produtoDAO.listarVariacaoProduto(filtro);

                return dataTable;
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao listar produto variação, classe BLL! " + erro.Message);
            }
        }

        public DataTable listarProdutosServicos(string tipoPesquisa, string filtro1, string tipoProdutoDAO, string tipoServicoDAO)
        {
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = produtoDAO.listarProdutosServicos(tipoPesquisa, filtro1, tipoProdutoDAO, tipoServicoDAO);

                return dataTable;
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao listar os produtos, classe BLL " + erro.Message);
            }
        }

        public DataTable listarProdutoVariacoes(string tipoPesquisa, string filtro1, string tipoProdutoDAO, string tipoServicoDAO)
        {
            DataTable dataTable = new DataTable();

            try
            {
                dataTable = produtoDAO.listarProdutosVariacoes(tipoPesquisa, filtro1, tipoProdutoDAO, tipoServicoDAO);

                return dataTable;
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao listar os produtos e suas variações, classe BLL! " + erro.Message);
            }
        }

    }
}
