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

        public void criarTables()
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand(
                /* CRIAÇÃO DA TABELA CATEGORIA */    
                "CREATE TABLE IF NOT EXISTS `centaurus`.`categoria` ( "+
                "  `id_categoria` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '', " +
                "  `descricao_categoria` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                "  `dataCadastro_categoria` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT '', " +
                "  `ativo_categoria` TINYINT(3) UNSIGNED NOT NULL DEFAULT '0' COMMENT '', " +
                "  `tipo_categoria` CHAR(1) NULL DEFAULT NULL COMMENT '', " +
                "  PRIMARY KEY(`id_categoria`)  COMMENT '') " +
                " ENGINE = InnoDB " +
                " AUTO_INCREMENT = 22 " +
                " DEFAULT CHARACTER SET = latin1; " +
                /* CRIAÇÃO DA TABELA CIDADE */
                " CREATE TABLE IF NOT EXISTS `centaurus`.`cidade` ( " +
                " `id_cidade` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '', " +
                " `nome_cidade` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `uf_cidade` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " PRIMARY KEY(`id_cidade`)  COMMENT '') " +
                " ENGINE = InnoDB " +
                " AUTO_INCREMENT = 4 " +
                " DEFAULT CHARACTER SET = latin1; " +
                /* CRIAÇÃO DA TABELA PARTICIPANTE*/
                " CREATE TABLE IF NOT EXISTS `centaurus`.`participante` ( " +
                " `id_partipante` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '', " +
                " `nome_fantasia_participante` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `apelido_razao_participante` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `cpf_cnpj_participante` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `rg_ie_participante` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `endereco_participante` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `numeroendereco_participante` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `bairro_participante` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `cidade_participante` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `cep_participante` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `telefone_participante` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `celular_participante` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `uf_partipante` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `email_partipante` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `datacadastro_participante` VARCHAR(10) NULL DEFAULT NULL COMMENT '', " +
                " `dataalteracao_partipante` VARCHAR(10) NULL DEFAULT NULL COMMENT '', " +
                " `usuariocadastro_partipante` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `usuarioalteracao_partipante` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `tipocliente_participante` TINYINT(1) NULL DEFAULT NULL COMMENT '', " +
                " `tipofornecedor_participante` TINYINT(1) NULL DEFAULT NULL COMMENT '', " +
                " `tipofuncionario_participante` TINYINT(1) NULL DEFAULT NULL COMMENT '', " +
                " `ativo_participante` TINYINT(1) NULL DEFAULT NULL COMMENT '', " +
                " PRIMARY KEY(`id_partipante`)  COMMENT '') " +
                " ENGINE = InnoDB " +
                " AUTO_INCREMENT = 25 " +
                " DEFAULT CHARACTER SET = latin1;" +
                /* CRIAÇÃO DA TABELA LOCAÇÃO */
                " CREATE TABLE IF NOT EXISTS `centaurus`.`locacao` ( " +
                " `id_locacao` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '', " +
                " `dataLancamento_locacao` DATETIME NOT NULL DEFAULT '0000-00-00 00:00:00' COMMENT '', " +
                " `dataPrevisaoEntrega_locacao` DATETIME NULL DEFAULT NULL COMMENT '', " +
                " `idCliente_locacao` INT(10) UNSIGNED NULL DEFAULT NULL COMMENT '', " +
                " `desconto_locacao` FLOAT NULL DEFAULT NULL COMMENT '', " +
                " `qtdItens_locacao` DOUBLE NULL DEFAULT NULL COMMENT '', " +
                " `total_locacao` FLOAT NULL DEFAULT NULL COMMENT '', " +
                " `tipo_locacao` CHAR(1) NULL DEFAULT NULL COMMENT '', " +
                " `numerolocacaodev_locacao` INT(10) UNSIGNED NULL DEFAULT NULL COMMENT '', " +
                " `usuario_locacao` VARCHAR(20) NULL DEFAULT NULL COMMENT '', " +
                " `dataDevolucao_locacao` DATETIME NULL DEFAULT NULL COMMENT '', " +
                " PRIMARY KEY(`id_locacao`)  COMMENT '', " +
                " INDEX `FK_locacao_cliente` (`idCliente_locacao` ASC)  COMMENT '', " +
                " CONSTRAINT `FK_locacao_cliente` " +
                "  FOREIGN KEY(`idCliente_locacao`) " +
                "  REFERENCES `centaurus`.`participante` (`id_partipante`)) " +
                " ENGINE = InnoDB " +
                " AUTO_INCREMENT = 130 " +
                " DEFAULT CHARACTER SET = latin1;" +
                /* CRIAÇÃO DA TABELA LOCAÇÃO ITENS */
                " CREATE TABLE IF NOT EXISTS `centaurus`.`locacaoitens` (" +
                " `id_locacaoitens` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '', " +
                " `idProduto_locacaoitens` INT(10) UNSIGNED NOT NULL DEFAULT '0' COMMENT '', " +
                " `valorLocado_locacaoitens` FLOAT NULL DEFAULT NULL COMMENT '', " +
                " `valorOriginal_locacaoitens` FLOAT NULL DEFAULT NULL COMMENT '', " +
                " `custoDia_locacaoitens` FLOAT NULL DEFAULT NULL COMMENT '', " +
                " `idLocacao_locacaoitens` INT(10) UNSIGNED NOT NULL DEFAULT '0' COMMENT '', " +
                " `qtdLocada_locacaoitens` DOUBLE NULL DEFAULT NULL COMMENT '', " +
                " `tipo_locacaoitens` CHAR(1) NULL DEFAULT NULL COMMENT '', " +
                " `idVariacaoProduto_locacaoitens` INT(10) UNSIGNED NOT NULL DEFAULT '0' COMMENT '', " +
                " PRIMARY KEY(`id_locacaoitens`)  COMMENT '', " +
                " INDEX `FK_locacaoitens_idLocacao` (`idLocacao_locacaoitens` ASC)  COMMENT '', " +
                " CONSTRAINT `FK_locacaoitens_idLocacao` " +
                " FOREIGN KEY(`idLocacao_locacaoitens`) " +
                " REFERENCES `centaurus`.`locacao` (`id_locacao`)) " +
                " ENGINE = InnoDB " +
                " AUTO_INCREMENT = 150 " +
                " DEFAULT CHARACTER SET = latin1;" +
                /* CRIAÇÃO DA TABELA MARCA */
                " CREATE TABLE IF NOT EXISTS `centaurus`.`marca` (" +
                " `id_marca` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '', " +
                " `descricao_marca` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `dataCadastro_marca` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT '', " +
                " `ativo_marca` TINYINT(3) UNSIGNED NOT NULL DEFAULT '0' COMMENT '', " +
                " PRIMARY KEY(`id_marca`)  COMMENT '') " +
                " ENGINE = InnoDB " +
                " AUTO_INCREMENT = 13 " +
                " DEFAULT CHARACTER SET = latin1;", conexao);
                comando.ExecuteNonQuery();
            }catch(Exception erro)
            {
                throw new Exception("Erro ao criar tabelas" +erro.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
        
    }
}
