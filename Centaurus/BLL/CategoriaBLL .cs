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
    public class CategoriaBLL
    {
        CategoriaDAO categoriasDAO = new CategoriaDAO();


        public void salvar(CategoriaModelo categoria) 
        {
            try 
            {
                categoriasDAO.salvar(categoria);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void atualizar(CategoriaModelo categoria) 
        {
            try 
            {
                categoriasDAO.atualizar(categoria);
            }
            catch(Exception erro) 
            {
                throw erro;
            }
        }
    }
}
