using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Centaurus.Dao;
using System.Data;
using Centaurus.DTO;
using MySql.Data.MySqlClient;

namespace Centaurus.DAL
{
    public class LoginDAO : ConexaoBanco
    {
        MySqlCommand comando = null;
        MySqlDataReader dr;

        //Método pesquisa o usuário no banco de dados
        public LoginModelo login(LoginModelo loginModelo)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("SELECT *FROM USUARIO WHERE LOGIN_USUARIO = '"+loginModelo.usuarioLogin+"'", conexao);
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    string senhaUsuario = Convert.ToString(dr["senha_usuario"]);                    
                    loginModelo.senhaLogin = senhaUsuario;
                }
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao pesquisar login, classe DAO " + erro.Message);
            }
            return loginModelo;
        }

    }
}
