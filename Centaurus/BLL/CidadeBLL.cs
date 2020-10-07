using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Centaurus.Dao;

namespace Centaurus.BLL
{
    public class CidadeBLL
    {
        CidadeDAO cidadeDAO = new CidadeDAO();
        public DataTable listarCidades(string tipoFiltro, string filtro)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = cidadeDAO.listarCidades(tipoFiltro, filtro);

                return dataTable;
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao listar as cidades, classe BLL " + erro.Message);
            }
        }
    }
}
