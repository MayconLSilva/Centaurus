using Centaurus.Dao;
using Centaurus.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Centaurus.Bll
{
    public class CategoriaBLL
    {
        CategoriaDAO daoCatSub = new CategoriaDAO();


        public void salvar(CategoriaModelo categoria) 
        {
            try 
            {
                daoCatSub.salvar(categoria);
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
                daoCatSub.atualizar(categoria);
            }
            catch(Exception erro) 
            {
                throw erro;
            }
        }

        public void buscarCatSubPorCodigo(CategoriaModelo modCatSub)
        {
            try
            {
                daoCatSub.buscarCatSubCat(modCatSub);
            }catch(Exception erro)
            {
                throw new Exception("Erro ao buscar categoria e/ou sub-categoria, classe bll" + erro.Message);
            }
        }

        public void buscarIDCategoriaSubCategoria(CategoriaModelo modCatSub)
        {
            try
            {
                daoCatSub.buscarUltimoRegistro(modCatSub);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao pesquisar a id da categoria e/ou sub-categoria, classe bll! " + erro.Message);
            }
        }

        public DataTable listarCategoriasSubCategorias(string tipoConsultaCatSub, string filtroUtilizado, string informacao)
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = daoCatSub.listarCategoriaSubCategoria(tipoConsultaCatSub, filtroUtilizado, informacao);

                return dataTable;
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao pesquisar categorias e/ou sub-categorias, classe BLL!" + erro.Message);
            }
        } 

    }
}
