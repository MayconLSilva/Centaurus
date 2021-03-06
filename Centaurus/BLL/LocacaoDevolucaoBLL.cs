﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centaurus.Dao;
using Centaurus.Model;
using Centaurus.DTO;
using Centaurus.DAL;
using System.Data;

namespace Centaurus.BLL
{
    public class LocacaoDevolucaoBLL
    {
        LocacaoDevolucaoDAO daoLocDev = new LocacaoDevolucaoDAO();

        public void importarLocacao(LocacaoDevolucaoModelo modLocacaoDev)
        {
            try
            {
                daoLocDev.importarLocacao(modLocacaoDev);
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao gerar devolução, classe BLL " + erro.Message);
            }
        }

        public void importarItensLocacaoDev(LocacaoDevolucaoModelo modLocacaoDev)
        {
            try
            {
                daoLocDev.importarItemLocacao(modLocacaoDev);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao inserir item da devolução, classe BLL " + erro.Message);
            }
        }

        public void inserirItemDevLocacao(LocacaoDevolucaoModelo modLocacaoDev)
        {
            try
            {
                daoLocDev.inserirItemDevLocacao(modLocacaoDev);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao inserir o item!" + erro.Message);
            }
        }

        public void salvarLocacao(LocacaoDevolucaoModelo modLocacaoDev)
        {
            try
            {
                daoLocDev.SalvarDevLocacao(modLocacaoDev);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao finalizar locação devolução, classe BLL " + erro.Message);
            }
        }

        public void gerarIDLocacaoDev(LocacaoDevolucaoModelo modLocacaoDev)
        {
            try
            {
                daoLocDev.gerarIdLocacaoDev(modLocacaoDev);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao gerar id locação devolução, classe BLL " + erro.Message);
            }
        }

        public void excluirItemLocacaoDev(LocacaoDevolucaoModelo modLocacaoDev)
        {
            try
            {
                daoLocDev.excluirItemLocacaoDevolucao(modLocacaoDev);
            }catch(Exception erro)
            {
                throw erro;
            }
        }

        public void excluirLocacao(LocacaoDevolucaoModelo modLocacaoDev)
        {
            try
            {
                daoLocDev.excluirDevolucaoLocacao(modLocacaoDev);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao excluir locação, classe BLL" + erro.Message);
            }
        }

        public DataTable listarItensDaLocacaoDevolucao(string filtro)
        {
            DataTable dataTable = new DataTable();

            try
            {
               dataTable = daoLocDev.listarItensDaLocacaoDevolucao(filtro);

                return dataTable;
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao listar os itens da locação devolução, classe BLL! " + erro.Message);
            }
        }

        public DataTable listarItensParaDevolucao(string filtroNumLocacao, string filtroIDItem)
        {
            DataTable dataTable = new DataTable();

            try
            {
                dataTable = daoLocDev.listarItensParaDevolucao(filtroNumLocacao, filtroIDItem);

                return dataTable;
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao listar os itens para devolução, classe BLL! " + erro.Message);
            }
        }

        public DataTable listarLocacaoDevolucao(string tipoFiltro, string filtro)
        {
            DataTable dataTable = new DataTable();

            try
            {
                dataTable = daoLocDev.listarLocacaoDevolucao(tipoFiltro, filtro);

                return dataTable;
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao listar as devoluções da locação, classe BLL! " + erro.Message);
            }
        }

        public void buscarInformacoesLocacao(LocacaoDevolucaoModelo modLocacaoDev)
        {
            try
            {
                daoLocDev.buscarInformacoesLocacao(modLocacaoDev);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao buscar informações da locação devolução, classe BLL! " + erro.Message);
            }
        }

        public void buscarUltimoRegistro(LocacaoDevolucaoModelo modLocacaoDev)
        {
            try
            {
                daoLocDev.buscarUltimoRegistro(modLocacaoDev);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao buscar o ultimo registro da devolução, classe BLL! " + erro.Message);
            }
        }

        public void buscarInformacoesDevLocacao(LocacaoDevolucaoModelo modLocacaoDev)
        {
            try
            {
                daoLocDev.buscarInformacoesDevLocacao(modLocacaoDev);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao pesquisar locacão devolução, classe BLL! " + erro.Message);
            }
        }

    }
}
