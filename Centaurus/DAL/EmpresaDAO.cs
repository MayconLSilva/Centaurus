using Centaurus.Dao;
using Centaurus.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centaurus.DAL
{
    public class EmpresaDAO: ConexaoBanco
    {
        MySqlCommand comando = null;
        MySqlDataReader dr;

        public EmpresaModelo buscarInformacoesEmpresa(EmpresaModelo modEmpresa)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("select *from empresa where id_empresa = 1", conexao);
                dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    string nomeFantasia = Convert.ToString(dr["fantasia_empresa"]);
                    string razaosocial = Convert.ToString(dr["razaosocial_empresa"]);
                    string telefone = Convert.ToString(dr["telefone_empresa"]);
                    string celular = Convert.ToString(dr["celular_empresa"]);
                    string endereco = Convert.ToString(dr["endereco_empresa"]);
                    string numeroendereco = Convert.ToString(dr["numero_empresa"]);
                    string bairro = Convert.ToString(dr["bairro_empresa"]);
                    string cidade = Convert.ToString(dr["cidade_empresa"]);
                    string cep = Convert.ToString(dr["cep_empresa"]);
                    string email = Convert.ToString(dr["email_empresa"]);
                    string cpfcnpj = Convert.ToString(dr["cpfcnpj_empresa"]);
                    string rgIe = Convert.ToString(dr["rgIe_empresa"]);
                    string uf = Convert.ToString(dr["uf_empresa"]);

                    modEmpresa.nomeFantasiaEmpresa = nomeFantasia;
                    modEmpresa.razaoSocialEmpresa = razaosocial;
                    modEmpresa.telefoneEmpresa = telefone;
                    modEmpresa.celularEmpresa = celular;
                    modEmpresa.enderecoEmpresa = endereco;
                    modEmpresa.numeroEnderecoEmpresa = numeroendereco;
                    modEmpresa.bairroEmpresa = bairro;
                    modEmpresa.cidadeEmpresa = cidade;
                    modEmpresa.cepEmpresa = cep;
                    modEmpresa.emailEmpresa = email;
                    modEmpresa.cpfCnpjEmpresa = cpfcnpj;
                    modEmpresa.rgIeEmpresa = rgIe;
                    modEmpresa.ufEmpresa = uf;
                }
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao buscar informações da empresa, classe DAO! " + erro.Message);
            }
            finally
            {
                FecharConexao();
            }
            return modEmpresa;
        }

        public void atualizarSalvar(EmpresaModelo modEmpresa)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("update empresa set fantasia_empresa = @fantasia,razaosocial_empresa = @razao,telefone_empresa = @telefone,celular_empresa = @celular,endereco_empresa = @endereco," +
                    " numero_empresa = @numero, bairro_empresa = @bairro,cidade_empresa = @cidade,cep_empresa = @cep,email_empresa = @email,rgIe_empresa = @rg,uf_empresa = @uf where id_empresa = @idempresa", conexao);
                comando.Parameters.AddWithValue("@fantasia", modEmpresa.nomeFantasiaEmpresa);
                comando.Parameters.AddWithValue("@razao", modEmpresa.razaoSocialEmpresa);
                comando.Parameters.AddWithValue("@telefone", modEmpresa.telefoneEmpresa);
                comando.Parameters.AddWithValue("@celular", modEmpresa.celularEmpresa);
                comando.Parameters.AddWithValue("@endereco", modEmpresa.enderecoEmpresa);
                comando.Parameters.AddWithValue("@numero", modEmpresa.numeroEnderecoEmpresa);
                comando.Parameters.AddWithValue("@bairro", modEmpresa.bairroEmpresa);
                comando.Parameters.AddWithValue("@cidade", modEmpresa.cidadeEmpresa);
                comando.Parameters.AddWithValue("@cep", modEmpresa.cepEmpresa);
                comando.Parameters.AddWithValue("@email", modEmpresa.emailEmpresa); 
                comando.Parameters.AddWithValue("@rg", modEmpresa.rgIeEmpresa);
                comando.Parameters.AddWithValue("@uf", modEmpresa.ufEmpresa);
                comando.Parameters.AddWithValue("@idempresa", 1);//A principio o id da empresa sempre será um, não terá outras empresas cadastradas no sistema.
                comando.ExecuteNonQuery();
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao salvar alterações da empresa, classe DAO! " + erro.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
