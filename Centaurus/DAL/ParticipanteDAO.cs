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

        public string numeroIncluido { get; set; }

        public void salvar(ParticipanteModelo participante)
        {
            try
            {
                AbrirConexao();
                //comando = new MySqlCommand("insert into participante (nomeParticpante, cpfcnpjParticipante) values (@nome, @cpfcnpj)",conexao);
                comando = new MySqlCommand("insert into participante (nome_fantasia_participante,apelido_razao_participante,cpf_cnpj_participante,rg_ie_participante,endereco_participante,numeroendereco_participante,bairro_participante,cidade_participante, cep_participante, telefone_participante, celular_participante, uf_partipante, email_partipante,tipocliente_participante,tipofornecedor_participante,tipofuncionario_participante,ativo_participante,datacadastro_participante) values (@nome,@razao,@cpfcnpj,@rgie,@endereco,@numero,@bairro,@cidade,@cep,@telefone,@celular,@uf,@email,@tipocli,@tipofor,@tipofunc,@ativo,@datacadastro)", conexao);
                comando.Parameters.AddWithValue("@nome", participante.nomeParticipante);
                comando.Parameters.AddWithValue("@razao",participante.razaosocialapelidoParticipante);
                comando.Parameters.AddWithValue("@cpfcnpj", participante.cpfcnpjParticipante);
                comando.Parameters.AddWithValue("@rgie", participante.rgieParticipante);
                comando.Parameters.AddWithValue("@endereco", participante.enderecoParticipante);
                comando.Parameters.AddWithValue("@numero", participante.numeroEnderecoParticipante);
                comando.Parameters.AddWithValue("@bairro", participante.bairoParticipante);
                comando.Parameters.AddWithValue("@cidade", participante.cidadeParticipante);
                comando.Parameters.AddWithValue("@cep", participante.cepParticipante);
                comando.Parameters.AddWithValue("@telefone", participante.telefoneParticipante);
                comando.Parameters.AddWithValue("@celular", participante.celularParticipante);
                comando.Parameters.AddWithValue("@uf", participante.ufParticipante);
                comando.Parameters.AddWithValue("@email", participante.emailParticipante);
                comando.Parameters.AddWithValue("@tipocli", participante.tipoclienteParticipante);
                comando.Parameters.AddWithValue("@tipofor", participante.tipofornecedorParticipante);
                comando.Parameters.AddWithValue("@tipofunc", participante.tipofuncionarioParticipante);
                comando.Parameters.AddWithValue("@ativo", participante.ativoParticipante);
                comando.Parameters.AddWithValue("@datacadastro", participante.dataCadastroParticipante);
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
        public void atualizar(ParticipanteModelo participante)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("update participante set nome_fantasia_participante=@nome,apelido_razao_participante = @nome,cpf_cnpj_participante = @cpfcnpj,rg_ie_participante = @rgie,endereco_participante = @endereco,numeroendereco_participante = @numero,bairro_participante = @bairro,cidade_participante = @cidade,cep_participante = @cep,telefone_participante = @telefone,celular_participante = @celular,uf_partipante = @uf,email_partipante = @email,tipocliente_participante = @tipocli,tipofornecedor_participante = @tipofor,tipofuncionario_participante = @tipofunc,ativo_participante = @ativo,dataalteracao_partipante = @dataalteracao where id_partipante= @idParticipante", conexao);
                comando.Parameters.AddWithValue("@nome", participante.nomeParticipante);
                comando.Parameters.AddWithValue("@razao", participante.razaosocialapelidoParticipante);
                comando.Parameters.AddWithValue("@cpfcnpj", participante.cpfcnpjParticipante);
                comando.Parameters.AddWithValue("@rgie", participante.rgieParticipante);
                comando.Parameters.AddWithValue("@endereco", participante.enderecoParticipante);
                comando.Parameters.AddWithValue("@numero", participante.numeroEnderecoParticipante);
                comando.Parameters.AddWithValue("@bairro", participante.bairoParticipante);
                comando.Parameters.AddWithValue("@cidade", participante.cidadeParticipante);
                comando.Parameters.AddWithValue("@cep", participante.cepParticipante);
                comando.Parameters.AddWithValue("@telefone", participante.telefoneParticipante);
                comando.Parameters.AddWithValue("@celular", participante.celularParticipante);
                comando.Parameters.AddWithValue("@uf", participante.ufParticipante);
                comando.Parameters.AddWithValue("@email", participante.emailParticipante);
                comando.Parameters.AddWithValue("@tipocli", participante.tipoclienteParticipante);
                comando.Parameters.AddWithValue("@tipofor", participante.tipofornecedorParticipante);
                comando.Parameters.AddWithValue("@tipofunc", participante.tipofuncionarioParticipante);
                comando.Parameters.AddWithValue("@ativo", participante.ativoParticipante);
                comando.Parameters.AddWithValue("@dataalteracao", participante.dataAlteracaoParticipante);
                comando.Parameters.AddWithValue("@idParticipante", participante.idParticipante);
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
        public void ExcluirParticipante(string idParticipante) 
        {
            try 
            {
                ConexaoBanco conexao = new ConexaoBanco();
                //conexao.FecharConexao();
                conexao.AbrirConexao();
                string comando = "delete from participante where id_partipante =" + idParticipante;
                conexao.ExecutarComandoSQL(comando);
            }
            catch(Exception ex) 
            {
                throw new Exception("Erro ao excluir o participante: " + ex.Message);
            }
        }

        //Inicio do código fonte pesquisar ultimo registro
        public void UltimoRegistro(string valorReturn)
        {            
            try
            {
                AbrirConexao();
                comando = new MySqlCommand("select max(id_partipante) as numeroPego from participante where nome_fantasia_participante = '"+ valorReturn + "'" , conexao);
                dr = comando.ExecuteReader();

                while (dr.Read()) 
                {
                    numeroIncluido = Convert.ToString(dr["numeroPego"]);
                    //Console.WriteLine("o valor foi "+ numeroIncluido);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao pesquisar id do participante: " + ex.Message);
            }





        }

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

    }
    
}
