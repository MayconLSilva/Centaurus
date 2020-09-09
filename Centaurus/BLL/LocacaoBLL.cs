﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centaurus.Dao;
using Centaurus.Model;
using Centaurus.DTO;

namespace Centaurus.BLL
{
    public class LocacaoBLL
    {
        LocacaoDAO locacaoDao = new LocacaoDAO();

        public void salvarLoca(LocacaoModelo locacaoModelo)
        {
            try
            {
                locacaoDao.salvarLocacao(locacaoModelo);
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao inserir a locação: " + erro.Message);
            }
        }

        public void finalizarLoca(LocacaoModelo locacaoModelo)
        {
            try
            {
                locacaoDao.finalizarLocacao(locacaoModelo);
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao finalizar a locação: " + erro.Message);
            }
        }

        public void inserirItensLocacao(LocacaoModelo locacaoModelo)
        {
            try
            {
                locacaoDao.salvarItensLocacao(locacaoModelo);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao inserir itens da locação: " + erro.Message);
            }
        }

        public void atualizarLoca(LocacaoModelo locacaoModelo)
        {
            try
            {
                locacaoDao.atualizarLocacao(locacaoModelo);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao atualizar a locação " + erro.Message);
            }
        }

        public void gerarIdLocacao(LocacaoModelo locacaoModelo)
        {
            try
            {
                locacaoDao.gerarIdLocacao(locacaoModelo);
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao gerar id da locação: " + erro.Message);
            }
        }

    }
}
