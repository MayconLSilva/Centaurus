using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Centaurus.DTO;
using Centaurus.Dao;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.ComponentModel;

namespace Centaurus.DAL
{
    public class DataBaseAdapter : ConexaoBanco
    {
        MySqlCommand comando = null;

        

        //Metodo criar tabela
        public void criarBD(string nomeBD)
        {
            string comandoCreate;
            try
            {
                AbrirConexao();
                //comandoCreate = "CREATE DATABASE IF NOT EXISTS `hello2`;";
                comandoCreate = "CREATE DATABASE IF NOT EXISTS "+nomeBD+";";               
                comando = new MySqlCommand(comandoCreate, conexao);
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("erro ao criar tabela" + erro.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        
    }
}
