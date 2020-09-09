using Centaurus.Dao;
using Centaurus.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centaurus.Bll
{
    public class ProdutoBLL
    {
        ProdutoDAO produtoDAO = new ProdutoDAO();


        public void salvar(ProdutoModelo produto)
        {
            try
            {
                produtoDAO.salvar(produto);
            }
            catch(Exception erro)
            {
                throw erro;
            }
        }

        public void salvarVariacao(ProdutoModelo produto)
        {
            try
            {
                produtoDAO.salvarVariacao(produto);

            }catch(Exception ex)
            {
                throw ex;
            }
        }

        public void atualizar(ProdutoModelo produto)
        {
            try
            {
                produtoDAO.atualizar(produto);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir(ProdutoModelo produto)
        {
            try
            {
                produtoDAO = new ProdutoDAO();
                produtoDAO.ExcluirProduto(produto);
            }catch(Exception erro)
            {
                throw erro;
            }
        }

        public void excluirVariacao(ProdutoModelo produto)
        {
            try
            {
                produtoDAO = new ProdutoDAO();
                produtoDAO.excluirVariacao(produto);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

    }
}
