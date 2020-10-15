using Centaurus.DAL;
using Centaurus.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centaurus.BLL
{
    public class EmpresaBLL
    {
        EmpresaDAO daoEmpresa = new EmpresaDAO();

        public void buscarInformacoesEmpresa(EmpresaModelo modEmpresa)
        {
            try
            {
                daoEmpresa.buscarInformacoesEmpresa(modEmpresa);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao buscar informações da empresa, classe BLL! " + erro.Message);
            }
        }
    }
}
