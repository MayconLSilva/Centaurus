using Centaurus.Dao;
using Centaurus.Model;
using System;
using System.Collections.Generic;
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
    }
}
