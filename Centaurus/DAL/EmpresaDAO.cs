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
    }
}
