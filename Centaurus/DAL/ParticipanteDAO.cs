using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Centaurus.Model;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using MySqlX.XDevAPI.Common;
using MySqlX.XDevAPI.Relational;

namespace Centaurus.Dao
{
    
    public class ParticipanteDAO: ConexaoBanco
    {
        
        MySqlCommand comando = null;
        MySqlDataReader dr;

        
        public void salvar(ParticipanteModelo modParticipante)
        {
            try
            {
                AbrirConexao();
                //comando = new MySqlCommand("insert into participante (nomeParticpante, cpfcnpjParticipante) values (@nome, @cpfcnpj)",conexao);
                comando = new MySqlCommand("insert into participante (nome_fantasia_participante,apelido_razao_participante,cpf_cnpj_participante,rg_ie_participante,endereco_participante,numeroendereco_participante,bairro_participante,cidade_participante, cep_participante, telefone_participante, celular_participante, uf_partipante, email_partipante,tipocliente_participante,tipofornecedor_participante,tipofuncionario_participante,ativo_participante,datacadastro_participante,usuariocadastro_partipante) values (@nome,@razao,@cpfcnpj,@rgie,@endereco,@numero,@bairro,@cidade,@cep,@telefone,@celular,@uf,@email,@tipocli,@tipofor,@tipofunc,@ativo,@datacadastro,@usuariocadastro)", conexao);
                comando.Parameters.AddWithValue("@nome", modParticipante.nomeParticipante);
                comando.Parameters.AddWithValue("@razao",modParticipante.razaosocialapelidoParticipante);
                comando.Parameters.AddWithValue("@cpfcnpj", modParticipante.cpfcnpjParticipante);
                comando.Parameters.AddWithValue("@rgie", modParticipante.rgieParticipante);
                comando.Parameters.AddWithValue("@endereco", modParticipante.enderecoParticipante);
                comando.Parameters.AddWithValue("@numero", modParticipante.numeroEnderecoParticipante);
                comando.Parameters.AddWithValue("@bairro", modParticipante.bairoParticipante);
                comando.Parameters.AddWithValue("@cidade", modParticipante.cidadeParticipante);
                comando.Parameters.AddWithValue("@cep", modParticipante.cepParticipante);
                comando.Parameters.AddWithValue("@telefone", modParticipante.telefoneParticipante);
                comando.Parameters.AddWithValue("@celular", modParticipante.celularParticipante);
                comando.Parameters.AddWithValue("@uf", modParticipante.ufParticipante);
                comando.Parameters.AddWithValue("@email", modParticipante.emailParticipante);
                comando.Parameters.AddWithValue("@tipocli", modParticipante.tipoclienteParticipante);
                comando.Parameters.AddWithValue("@tipofor", modParticipante.tipofornecedorParticipante);
                comando.Parameters.AddWithValue("@tipofunc", modParticipante.tipofuncionarioParticipante);
                comando.Parameters.AddWithValue("@ativo", modParticipante.ativoParticipante);
                comando.Parameters.AddWithValue("@datacadastro", modParticipante.dataCadastroParticipante);
                comando.Parameters.AddWithValue("@usuariocadastro", modParticipante.usuarioCadastroParticipante);
                comando.ExecuteNonQuery();

                //UltimoRegistro();

            }
            catch(Exception erro) 
            {
                throw erro;
            }
            finally 
            {
                FecharConexao();
            }
        }

        //Inicio do código fonte alterar participante
        public void atualizar(ParticipanteModelo modParticipante)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("update participante set nome_fantasia_participante=@nome,apelido_razao_participante = @nome,cpf_cnpj_participante = @cpfcnpj,rg_ie_participante = @rgie,endereco_participante = @endereco,numeroendereco_participante = @numero,bairro_participante = @bairro,cidade_participante = @cidade,cep_participante = @cep,telefone_participante = @telefone,celular_participante = @celular,uf_partipante = @uf,email_partipante = @email,tipocliente_participante = @tipocli,tipofornecedor_participante = @tipofor,tipofuncionario_participante = @tipofunc,ativo_participante = @ativo,dataalteracao_partipante = @dataalteracao, usuarioalteracao_partipante = @usuarioalteracao where id_partipante= @idParticipante", conexao);
                comando.Parameters.AddWithValue("@nome", modParticipante.nomeParticipante);
                comando.Parameters.AddWithValue("@razao", modParticipante.razaosocialapelidoParticipante);
                comando.Parameters.AddWithValue("@cpfcnpj", modParticipante.cpfcnpjParticipante);
                comando.Parameters.AddWithValue("@rgie", modParticipante.rgieParticipante);
                comando.Parameters.AddWithValue("@endereco", modParticipante.enderecoParticipante);
                comando.Parameters.AddWithValue("@numero", modParticipante.numeroEnderecoParticipante);
                comando.Parameters.AddWithValue("@bairro", modParticipante.bairoParticipante);
                comando.Parameters.AddWithValue("@cidade", modParticipante.cidadeParticipante);
                comando.Parameters.AddWithValue("@cep", modParticipante.cepParticipante);
                comando.Parameters.AddWithValue("@telefone", modParticipante.telefoneParticipante);
                comando.Parameters.AddWithValue("@celular", modParticipante.celularParticipante);
                comando.Parameters.AddWithValue("@uf", modParticipante.ufParticipante);
                comando.Parameters.AddWithValue("@email", modParticipante.emailParticipante);
                comando.Parameters.AddWithValue("@tipocli", modParticipante.tipoclienteParticipante);
                comando.Parameters.AddWithValue("@tipofor", modParticipante.tipofornecedorParticipante);
                comando.Parameters.AddWithValue("@tipofunc", modParticipante.tipofuncionarioParticipante);
                comando.Parameters.AddWithValue("@ativo", modParticipante.ativoParticipante);
                comando.Parameters.AddWithValue("@dataalteracao", modParticipante.dataAlteracaoParticipante);
                comando.Parameters.AddWithValue("@usuarioalteracao", modParticipante.usuarioAlteracaoParticipante);
                comando.Parameters.AddWithValue("@idParticipante", modParticipante.idParticipante);
                comando.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                FecharConexao();
            }
        }
              
        //Inicio do código fonte excluir participante
        public void excluirParticipante(ParticipanteModelo modParticipante) 
        {
            try 
            {
                ConexaoBanco conexao = new ConexaoBanco();
                //conexao.FecharConexao();
                conexao.AbrirConexao();
                string comando = "delete from participante where id_partipante =" + modParticipante.idParticipante;
                conexao.ExecutarComandoSQL(comando);
            }
            catch(Exception ex) 
            {
                throw new Exception("Erro ao excluir o participante: " + ex.Message);
            }
        }

        //Método busca o ultimo registro
        public ParticipanteModelo buscarUltimoRegistro(ParticipanteModelo modParticipante)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("select max(id_partipante) as numeroPego from participante where nome_fantasia_participante = '" + modParticipante.nomeParticipante + "'", conexao);
                dr = comando.ExecuteReader();

                while (dr.Read())
                {                    
                    int numeroIncluido = Convert.ToInt32(dr["numeroPego"]);
                    modParticipante.idParticipante = numeroIncluido;
                }

            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao buscar ultimo registro, classe DAO! " + erro.Message);
            }
            finally
            {
                FecharConexao();
            }
            return modParticipante;
        }

        //Método lista todos participantes e caso informe irá filtrar
        public DataTable pesquisarParticipantes(string tipoConsulta, string tipoFiltro,string filtroConsulta)
        {
            DataTable dt = new DataTable();

            try
            {
                ConexaoBanco conexao = new ConexaoBanco();
                conexao.AbrirConexao();
                //Pesquisa particpante cliente e seus respectivos filtros
                if (tipoConsulta == "CLIENTE")
                {
                    if(tipoFiltro == "TODOS")
                    {
                        dt = conexao.RetDataTable("select * from participante where tipocliente_participante = 1");
                    }
                    else if(tipoFiltro == "NOME")
                    {
                        dt = conexao.RetDataTable("select * from participante where nome_fantasia_participante = '" + filtroConsulta + "' and tipocliente_participante = 1");
                    }
                    else if (tipoFiltro == "CPF/CNPJ")
                    {
                        string valor = filtroConsulta;
                        int contador = valor.Length;                        

                        //Chama CPF SEM PONTUAÇÃO
                        if (contador == 11)
                        {                            
                            string filtroCPFCNPJ = valor.Substring(0, 3) + "." + valor.Substring(3, 3) + "." + valor.Substring(6, 3) + "-" + valor.Substring(9, 2);
                            dt = conexao.RetDataTable("select * from participante where cpf_cnpj_participante = '" + filtroCPFCNPJ + "' and tipocliente_participante = 1");                            
                        }
                        else if (contador == 14)
                        {
                            //Chama CNPJ SEM PONTUAÇÃO 
                            decimal num;
                            if (decimal.TryParse(valor, out num))
                            {                                
                                string filtroCPFCNPJ = valor.Substring(0, 2) + "." + valor.Substring(2, 3) + "." + valor.Substring(5, 3) + "/" + valor.Substring(8, 4) + "-" + valor.Substring(12, 2);
                                dt = conexao.RetDataTable("select * from participante where cpf_cnpj_participante = '" + filtroCPFCNPJ + "' and tipocliente_participante = 1");
                            }
                            //Chama CPF COM PONTUAÇÃO
                            else
                            {
                                dt = conexao.RetDataTable("select * from participante where cpf_cnpj_participante = '" + filtroConsulta + "' and tipocliente_participante = 1");
                            }
                        }
                        //Chama CNPJ COM PONTUAÇÃO
                        else if (contador == 18)
                        {
                            dt = conexao.RetDataTable("select * from participante where cpf_cnpj_participante = '" + filtroConsulta + "' and tipocliente_participante = 1");
                        }
                    }
                    else if (tipoFiltro == "TELEFONE/CELULAR")
                    {
                        dt = conexao.RetDataTable("select * from participante where telefone_participante = '" + filtroConsulta + "' or celular_participante = '" + filtroConsulta + "' and tipocliente_participante = 1");
                    }
                    else if (tipoFiltro == "INTELIGENTE")
                    {
                        dt = conexao.RetDataTable("select *from participante where telefone_participante like '%" + filtroConsulta + "%' or celular_participante like '%" + filtroConsulta + "%' or cpf_cnpj_participante like  '%" + filtroConsulta + "%' or nome_fantasia_participante like  '%" + filtroConsulta + "%' and tipocliente_participante = 1");
                    }

                }
                
                //Pesquisa particpante fornecedor e seus respectivos filtros
                else if(tipoConsulta == "FORNECEDOR")
                {
                    if(tipoFiltro == "NOME")
                    {
                        dt = conexao.RetDataTable("select * from participante where nome_fantasia_participante = '" + filtroConsulta + "' and tipofornecedor_participante = 1");
                    }
                    else if(tipoFiltro == "CPF/CNPJ")
                    {
                        string valor = filtroConsulta;
                        int contador = valor.Length;

                        //Chama CPF SEM PONTUAÇÃO
                        if (contador == 11)
                        {
                            string filtroCPFCNPJ = valor.Substring(0, 3) + "." + valor.Substring(3, 3) + "." + valor.Substring(6, 3) + "-" + valor.Substring(9, 2);
                            dt = conexao.RetDataTable("select * from participante where cpf_cnpj_participante = '" + filtroCPFCNPJ + "' and tipofornecedor_participante = 1");
                        }
                        else if (contador == 14)
                        {
                            //Chama CNPJ SEM PONTUAÇÃO 
                            decimal num;
                            if (decimal.TryParse(valor, out num))
                            {
                                string filtroCPFCNPJ = valor.Substring(0, 2) + "." + valor.Substring(2, 3) + "." + valor.Substring(5, 3) + "/" + valor.Substring(8, 4) + "-" + valor.Substring(12, 2);
                                dt = conexao.RetDataTable("select * from participante where cpf_cnpj_participante = '" + filtroCPFCNPJ + "' and tipofornecedor_participante = 1");
                            }
                            //Chama CPF COM PONTUAÇÃO
                            else
                            {
                                dt = conexao.RetDataTable("select * from participante where cpf_cnpj_participante = '" + filtroConsulta + "' and tipofornecedor_participante = 1");
                            }
                        }
                        //Chama CNPJ COM PONTUAÇÃO
                        else if (contador == 18)
                        {
                            dt = conexao.RetDataTable("select * from participante where cpf_cnpj_participante = '" + filtroConsulta + "' and tipofornecedor_participante = 1");
                        }                        
                    }
                    else if(tipoFiltro == "TELEFONE/CELULAR")
                    {
                        dt = conexao.RetDataTable("select * from participante where telefone_participante = '" + filtroConsulta + "' or celular_participante = '" + filtroConsulta + "' and tipofornecedor_participante = 1");
                    }
                    else if(tipoFiltro == "INTELIGENTE")
                    {
                        dt = conexao.RetDataTable("select *from participante where telefone_participante like '%" + filtroConsulta + "%' or celular_participante like '%" + filtroConsulta + "%' or cpf_cnpj_participante like  '%" + filtroConsulta + "%' or nome_fantasia_participante like  '%" + filtroConsulta + "%' and tipofornecedor_participante = 1");
                    }
                    else if(tipoFiltro == "TODOS")
                    {
                        dt = conexao.RetDataTable("select * from participante where tipofornecedor_participante = 1");
                    }

                }

                //Pesquisa participante funcionário e seus respectivos filtros
                else if(tipoConsulta == "FUNCIONARIO")
                {
                    if (tipoFiltro == "TODOS")
                    {
                        dt = conexao.RetDataTable("select * from participante where tipofuncionario_participante = 1");
                    }
                    else if (tipoFiltro == "NOME")
                    {
                        dt = conexao.RetDataTable("select * from participante where nome_fantasia_participante = '" + filtroConsulta + "' and tipofuncionario_participante = 1");
                    }
                    else if (tipoFiltro == "CPF/CNPJ")
                    {
                        string valor = filtroConsulta;
                        int contador = valor.Length;

                        //Chama CPF SEM PONTUAÇÃO
                        if (contador == 11)
                        {
                            string filtroCPFCNPJ = valor.Substring(0, 3) + "." + valor.Substring(3, 3) + "." + valor.Substring(6, 3) + "-" + valor.Substring(9, 2);
                            dt = conexao.RetDataTable("select * from participante where cpf_cnpj_participante = '" + filtroCPFCNPJ + "' and tipofuncionario_participante = 1");
                        }
                        else if (contador == 14)
                        {
                            //Chama CNPJ SEM PONTUAÇÃO 
                            decimal num;
                            if (decimal.TryParse(valor, out num))
                            {
                                string filtroCPFCNPJ = valor.Substring(0, 2) + "." + valor.Substring(2, 3) + "." + valor.Substring(5, 3) + "/" + valor.Substring(8, 4) + "-" + valor.Substring(12, 2);
                                dt = conexao.RetDataTable("select * from participante where cpf_cnpj_participante = '" + filtroCPFCNPJ + "' and tipofuncionario_participante = 1");
                            }
                            //Chama CPF COM PONTUAÇÃO
                            else
                            {
                                dt = conexao.RetDataTable("select * from participante where cpf_cnpj_participante = '" + filtroConsulta + "' and tipofuncionario_participante = 1");
                            }
                        }
                        //Chama CNPJ COM PONTUAÇÃO
                        else if (contador == 18)
                        {
                            dt = conexao.RetDataTable("select * from participante where cpf_cnpj_participante = '" + filtroConsulta + "' and tipofuncionario_participante = 1");
                        }                        
                    }
                    else if (tipoFiltro == "TELEFONE/CELULAR")
                    {
                        dt = conexao.RetDataTable("select * from participante where telefone_participante = '" + filtroConsulta + "' or celular_participante = '" + filtroConsulta + "' and tipofuncionario_participante = 1");
                    }
                    else if (tipoFiltro == "INTELIGENTE")
                    {
                        dt = conexao.RetDataTable("select *from participante where telefone_participante like '%" + filtroConsulta + "%' or celular_participante like '%" + filtroConsulta + "%' or cpf_cnpj_participante like  '%" + filtroConsulta + "%' or nome_fantasia_participante like  '%" + filtroConsulta + "%' and tipofuncionario_participante = 1");
                    }

                }
            
                //Pesquisa todos participantes e seus respectivos filtros
                else if(tipoConsulta == "TODOS")
                {
                    if(tipoFiltro == "TODOS")
                    {
                        dt = conexao.RetDataTable("select * from participante");
                    }
                    else if (tipoFiltro == "NOME")
                    {
                        dt = conexao.RetDataTable("select * from participante where nome_fantasia_participante = '" + filtroConsulta + "'");
                    }
                    else if (tipoFiltro == "CPF/CNPJ")
                    {
                        string valor = filtroConsulta;
                        int contador = valor.Length;

                        //Chama CPF SEM PONTUAÇÃO
                        if (contador == 11)
                        {
                            string filtroCPFCNPJ = valor.Substring(0, 3) + "." + valor.Substring(3, 3) + "." + valor.Substring(6, 3) + "-" + valor.Substring(9, 2);
                            dt = conexao.RetDataTable("select * from participante where cpf_cnpj_participante = '" + filtroCPFCNPJ + "'");
                        }
                        else if (contador == 14)
                        {
                            //Chama CNPJ SEM PONTUAÇÃO 
                            decimal num;
                            if (decimal.TryParse(valor, out num))
                            {
                                string filtroCPFCNPJ = valor.Substring(0, 2) + "." + valor.Substring(2, 3) + "." + valor.Substring(5, 3) + "/" + valor.Substring(8, 4) + "-" + valor.Substring(12, 2);
                                dt = conexao.RetDataTable("select * from participante where cpf_cnpj_participante = '" + filtroCPFCNPJ + "' ");
                            }
                            //Chama CPF COM PONTUAÇÃO
                            else
                            {
                                dt = conexao.RetDataTable("select * from participante where cpf_cnpj_participante = '" + filtroConsulta + "'");
                            }
                        }
                        //Chama CNPJ COM PONTUAÇÃO
                        else if (contador == 18)
                        {
                            dt = conexao.RetDataTable("select * from participante where cpf_cnpj_participante = '" + filtroConsulta + "'");
                        }
                    }
                    else if (tipoFiltro == "TELEFONE/CELULAR")
                    {
                        dt = conexao.RetDataTable("select * from participante where telefone_participante = '" + filtroConsulta + "' or celular_participante = '" + filtroConsulta + "'");
                    }
                    else if (tipoFiltro == "INTELIGENTE")
                    {
                        dt = conexao.RetDataTable("select *from participante where telefone_participante like '%" + filtroConsulta + "%' or celular_participante like '%" + filtroConsulta + "%' or cpf_cnpj_participante like  '%" + filtroConsulta + "%' or nome_fantasia_participante like  '%" + filtroConsulta + "%'");
                    }

                }             
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar os participante: " + ex.Message);
            }
            return dt;
        }

        //Método busca o participante por código
        public ParticipanteModelo buscarParticipantePorCodigo(ParticipanteModelo modParticipante)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("select *from participante where id_partipante = '"+modParticipante.idParticipante+"'", conexao);
                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    string nomeFantasia = Convert.ToString(dr["nome_fantasia_participante"]);
                    string apelidoRazao = Convert.ToString(dr["apelido_razao_participante"]);
                    string cpfCnpj = Convert.ToString(dr["cpf_cnpj_participante"]);
                    string rgIe = Convert.ToString(dr["rg_ie_participante"]);
                    string endereco = Convert.ToString(dr["endereco_participante"]);
                    string numeroEndereco = Convert.ToString(dr["numeroendereco_participante"]);
                    string bairro = Convert.ToString(dr["bairro_participante"]);
                    string cidade = Convert.ToString(dr["cidade_participante"]);
                    string cep = Convert.ToString(dr["cep_participante"]);
                    string telefone = Convert.ToString(dr["telefone_participante"]);
                    string celular = Convert.ToString(dr["celular_participante"]);
                    string uf = Convert.ToString(dr["uf_partipante"]);
                    string email = Convert.ToString(dr["email_partipante"]);
                    string dataCadastro = Convert.ToString(dr["datacadastro_participante"]);
                    string dataAlteracao = Convert.ToString(dr["dataalteracao_partipante"]);
                    string usuarioCadastro = Convert.ToString(dr["usuariocadastro_partipante"]);
                    string usuarioAlteracao = Convert.ToString(dr["usuarioalteracao_partipante"]);
                    bool tipoCliente = Convert.ToBoolean(dr["tipocliente_participante"]);
                    bool tipoFornecedor = Convert.ToBoolean(dr["tipofornecedor_participante"]);
                    bool tipoFuncionario = Convert.ToBoolean(dr["tipofuncionario_participante"]);
                    bool ativo = Convert.ToBoolean(dr["ativo_participante"]);

                    modParticipante.nomeParticipante = nomeFantasia;
                    modParticipante.razaosocialapelidoParticipante = apelidoRazao;
                    modParticipante.cpfcnpjParticipante = cpfCnpj;
                    modParticipante.rgieParticipante = rgIe;
                    modParticipante.enderecoParticipante = endereco;
                    modParticipante.numeroEnderecoParticipante = numeroEndereco;
                    modParticipante.bairoParticipante = bairro;
                    modParticipante.cidadeParticipante = cidade;
                    modParticipante.cepParticipante = cep;
                    modParticipante.telefoneParticipante = telefone;
                    modParticipante.celularParticipante = celular;
                    modParticipante.ufParticipante = uf;
                    modParticipante.emailParticipante = email;
                    modParticipante.dataCadastroParticipante = dataCadastro;
                    modParticipante.dataAlteracaoParticipante = dataAlteracao;
                    modParticipante.usuarioCadastroParticipante = usuarioCadastro;
                    modParticipante.usuarioAlteracaoParticipante = usuarioAlteracao;
                    modParticipante.tipoclienteParticipante = tipoCliente;
                    modParticipante.tipofornecedorParticipante = tipoFornecedor;
                    modParticipante.tipofuncionarioParticipante = tipoFuncionario;
                    modParticipante.ativoParticipante = ativo;
                }
            }
            catch(Exception erro)
            {
                throw new Exception("Erro ao buscar o participante pelo código, classe DAO! " + erro.Message); 
            }
            finally
            {
                FecharConexao();
            }
            return modParticipante;
        }

    }
    
}
