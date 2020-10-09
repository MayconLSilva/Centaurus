using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centaurus.Dao;
using Centaurus.Model;
using Centaurus.DTO;
using System.Data;

namespace Centaurus.BLL
{
    public class LocacaoBLL
    {
        LocacaoDAO locacaoDao = new LocacaoDAO();

        public void atualizarLoca(LocacaoModelo locacaoModelo)
        {
            try
            {
                locacaoDao.atualizarLocacao(locacaoModelo);
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao atualizar a locação " + erro.Message);
            }
        }

        public void inserirItensLocacao(LocacaoModelo locacaoModelo)
        {
            try
            {
                locacaoDao.inserirItensLocacao(locacaoModelo);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao inserir itens da locação: " + erro.Message);
            }
        }
                 
        public void excluirLocacao(LocacaoModelo locacaoModelo)
        {
            try
            {
                locacaoDao.excluirLocacao(locacaoModelo);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao excluir locação, Classe BLL: " + erro.Message);
            }
        }

        public void excluirItemLocacao(LocacaoModelo locacaoModelo)
        {
            try
            {
                locacaoDao.excluirItemLocacao(locacaoModelo);
            }catch(Exception erro)
            {
                throw new Exception("Erro ao excluir item, classe BLL" + erro.Message);
            }
        }

        public DataTable listarItensLocacao(string filtro)
        {
            DataTable dataTable = new DataTable();

            try
            {
                dataTable = locacaoDao.listarItensLocacao(filtro);

                return dataTable;
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao listar os itens da locação, classe BLL!");
            }
        }

        public DataTable listarLocacao(string tipoFiltro, string filtro)
        {
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = locacaoDao.listarLocacao(tipoFiltro, filtro);

                return dataTable;
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao listar locação, classe BLL! " + erro.Message);
            }
        }
        
        public void buscarUltimoRegistro(LocacaoModelo locacaoModelo)
        {
            try
            {
                locacaoDao.buscarUltimoRegistro(locacaoModelo);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao buscar o ultimo registro da locação, classe BLL! " + erro.Message);
            }
        }

        public void buscarLocacaoPorCodigo(LocacaoModelo locacaoModelo)
        {
            try
            {
                locacaoDao.buscarLocacaoCodigo(locacaoModelo);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao buscar locação pelo código, classe BLL! " + erro.Message);
            }
        }

        public void salvarLocacao(LocacaoModelo locacaoModelo)
        {
            try
            {
                locacaoDao.salvar(locacaoModelo);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao salvar locação e/ou gerar id, classe BLL! " + erro.Message);
            }
        }

    }
}
