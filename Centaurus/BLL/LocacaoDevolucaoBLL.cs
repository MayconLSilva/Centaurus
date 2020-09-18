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
        LocacaoDevolucaoDAO locacaoDev = new LocacaoDevolucaoDAO();

        public void devolucaoLocacao(LocacaoDevolucaoModelo modLocacaoDev)
        {
            try
            {
                locacaoDev.inserirDevLocacao(modLocacaoDev);
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
                locacaoDev.inserirItemDevLocacao(modLocacaoDev);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao inserir item da devolução, classe BLL " + erro.Message);
            }
        }


    }
}
