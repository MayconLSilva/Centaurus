using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Centaurus.Dao
{
    public class ConexaoBanco
    {
        
        string conecta = "DATABASE=centaurus; SERVER= server2012; UID= sistema; PWD=M12345";
        protected MySqlConnection conexao = null;
        //MySqlCommand comando = null;


        private DataTable data;
        private MySqlDataAdapter da;
        private MySqlDataReader dr;
        private MySqlCommandBuilder cb;

        //Método para conectar no banco
        public void AbrirConexao()
        {
            try
            {
                conexao = new MySqlConnection(conecta);
                conexao.Open();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            /*finally
            {
                conexao.Close();
            }
            */

        }
        
        //Método para fechar a conexão com o banco
        public void FecharConexao() 
        {
            try 
            {
                conexao = new MySqlConnection(conecta);
                conexao.Close();
            }
            catch (Exception erro) 
            {
                throw erro;
            }
            /*
            finally 
            {
                conexao.Close();
            }
            */
        }
         
        public void ExecutarComandoSQL(string comandoSql) 
        {
            MySqlCommand comando = new MySqlCommand(comandoSql,conexao);
            comando.ExecuteNonQuery();
            conexao.Close();
        }

        public DataTable RetDataTable(string sql) 
        {
            data = new DataTable();
            da = new MySqlDataAdapter(sql, conexao);
            cb = new MySqlCommandBuilder(da);
            da.Fill(data);

            return data;
        }

        public MySqlDataReader RetDataReader(string sql) 
        {
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            MySqlDataReader dr = comando.ExecuteReader();
            dr.Read();


            return dr;
        }


    }

}
