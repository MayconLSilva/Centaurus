using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centaurus.Model;
using Centaurus.Dao;
using System.Security.Policy;
using System.Data;

namespace Centaurus.Bll
{
    public class ParticipanteBLL
    {
        ParticipanteDAO participanteDAO = new ParticipanteDAO();


        public void salvar (ParticipanteModelo modParticipante) 
        {
            try 
            {
                participanteDAO.salvar(modParticipante);   
            }
            catch (Exception erro) 
            {
                throw erro;
            }
        }

        public void alterar(ParticipanteModelo modParticipante)
        {
            try
            {
                participanteDAO.atualizar(modParticipante);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        public void excluir(ParticipanteModelo modParticipante)
        {
            try
            {
                participanteDAO.excluirParticipante(modParticipante);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao exluir participante, classe BLL! " + erro);
            }
        }

        public void buscarUltimoRegistro(ParticipanteModelo modParticipante)
        {
            try
            {
                participanteDAO.buscarUltimoRegistro(modParticipante);
            }catch(Exception erro)
            {
                throw new Exception("Erro ao buscar o ultimo registro, classe BLL! " + erro.Message);
            }
        }

        public void buscarParticipantePorID(ParticipanteModelo modParticipante)
        {
            try
            {
                participanteDAO.buscarParticipantePorCodigo(modParticipante);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao buscar o participante pela id, classe BLL! " + erro.Message);
            }
        }

        public DataTable listarParticipantes(string tipoConsulta, string tipoFiltro, string filtroConsulta)
        {            
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = participanteDAO.listarParticipantes(tipoConsulta, tipoFiltro, filtroConsulta);

                return dataTable;
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao listar participantes, classe BLL! " + erro.Message);
            }
        }


    }
}
