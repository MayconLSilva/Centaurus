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


        public void salvar (ParticipanteModelo participante) 
        {
            try 
            {
                participanteDAO.salvar(participante);   
            }
            catch (Exception erro) 
            {
                throw erro;
            }
        }

        public void alterar(ParticipanteModelo participante)
        {
            try
            {
                participanteDAO.atualizar(participante);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


    }
}
