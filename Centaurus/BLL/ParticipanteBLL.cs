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


    }
}
