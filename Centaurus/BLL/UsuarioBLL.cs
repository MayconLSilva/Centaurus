﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centaurus.DTO;
using Centaurus.DAL;
using System.Data;

namespace Centaurus.BLL
{
    public class UsuarioBLL
    {
        UsuarioDAO daoUsuario = new UsuarioDAO();

        public void salvar(UsuarioModelo modUsuario)
        {
            try
            {
                daoUsuario.salvar(modUsuario);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao inserir usuário, classe BLL!" + erro.Message);
            }            
        }

        public void atualizar(UsuarioModelo modUsuario)
        {
            try
            {
                daoUsuario.atualizar(modUsuario);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao atualizar usuário, classe BLL" + erro.Message);
            }
        }

        public void excluir(UsuarioModelo modUsuario)
        {
            try
            {
                daoUsuario.excluir(modUsuario);
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao excluir usuário, classe BLL" + erro.Message);
            }
        }

        public DataTable listarUsuarios()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = daoUsuario.listarUsuario();

                return dt;
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao listar usuários, classe BLL" + erro.Message);
            }
        }

    }
}
