using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centaurus.Dao;
using Centaurus.Model;
using Centaurus.DTO;
using Centaurus.DAL;

namespace Centaurus.BLL
{
    public class LocacaoDevolucaoBLL
    {
        LocacaoDevolucaoDAO daoLocDev = new LocacaoDevolucaoDAO();

        public void devolucaoLocacao(LocacaoDevolucaoModelo modLocacaoDev)
        {
            try
            {
                daoLocDev.inserirDevLocacao(modLocacaoDev);
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao gerar devolução, classe BLL " + erro.Message);
            }
        }

        public void inserirItemLocacaoDev(LocacaoDevolucaoModelo modLocacaoDev)
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


    }
}
