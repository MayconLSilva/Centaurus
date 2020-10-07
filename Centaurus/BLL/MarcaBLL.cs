using Centaurus.Dao;
using Centaurus.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centaurus.Bll
{
    public class MarcaBLL
    {
        MarcaDAO marcaDAO = new MarcaDAO();


        public void salvar(MarcaModelo marca) 
        {
            try 
            {
                marcaDAO.salvar(marca);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void atualizar(MarcaModelo marca) 
        {
            try 
            {
                marcaDAO.atualizar(marca);
            }
            catch(Exception erro) 
            {
                throw erro;
            }
        }

        public DataTable listarMarcas(string tipoFiltro, string filtro)
        {
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = marcaDAO.listarMarcas(tipoFiltro, filtro);
                return dataTable;
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao listar marcas, classe BLL " + erro.Message);
            }
        }

        public void buscarIDMarca(MarcaModelo modMarca)
        {
            try
            {
                marcaDAO.buscarUltimoRegistro(modMarca);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao buscar id da marca, classe BLL " + erro.Message);
            }
        }

        public void excluirMarca(MarcaModelo modMarca)
        {
            try
            {
                marcaDAO.excluirMarca(modMarca);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao excluir marca, classe BLL " + erro.Message);
            }
        }
    }
}
