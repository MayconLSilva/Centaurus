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

namespace Centaurus.DAL
{
    public class DataBaseAdapter : ConexaoBanco
    {
        MySqlCommand comando = null;

        

        //Metodo criar tabela
        public void teste()
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS tabelaTeste (Processo varchar(30) NOT NULL, " +
                " Competencia varchar(7) NOT NULL, " +
                " Data_Entrada date NOT NULL, " +
                " Evento decimal(10, 2) NOT NULL, " +
                " Evento2 decimal(10, 2) NOT NULL, " +
                " Indice decimal(10, 2) DEFAULT 0.00, " +
                " Qtde_Horas time DEFAULT NULL, " +
                " Valor decimal(10, 2) DEFAULT 0.00, " +
                " PRIMARY KEY(Processo, Competencia, Data_Entrada)) " +
                " ENGINE = InnoDB DEFAULT CHARSET = latin1", conexao);
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

        public void criarBD()
        {
            string nome = "ZEUS";
            SqlConnection _conexao = new SqlConnection("'"+ nome + "';SERVER= server2012; UID= root; PWD=123456");
            conexao.Open();
            using (SqlCommand _cmd = new SqlCommand())
            {
                string nomeBanco = "CREATE SCHEMA '"+nome+"'";
                _cmd.CommandText = nomeBanco;

                try
                {
                    _cmd.ExecuteNonQuery();
                }catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
                finally
                {
                    _conexao.Close();
                }
            }
        }

       
    }
}
