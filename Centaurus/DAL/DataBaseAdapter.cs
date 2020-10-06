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



        //Metodo criar banco de dados
        public void criarBD(string nomeBD)
        {
            string comandoCreate;
            try
            {
                AbrirConexao();
                //comandoCreate = "CREATE DATABASE IF NOT EXISTS `hello2`;";
                comandoCreate = "CREATE DATABASE IF NOT EXISTS " + nomeBD + ";";
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

        //Método criar tabelas e views
        public void criarTables(string nomeBD)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand(
                /* CRIAÇÃO DA TABELA CATEGORIA */
                "CREATE TABLE IF NOT EXISTS " + nomeBD + ".`categoria` ( " +
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
                " CREATE TABLE IF NOT EXISTS " + nomeBD + ".`cidade` ( " +
                " `id_cidade` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '', " +
                " `nome_cidade` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `uf_cidade` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " PRIMARY KEY(`id_cidade`)  COMMENT '') " +
                " ENGINE = InnoDB " +
                " AUTO_INCREMENT = 4 " +
                " DEFAULT CHARACTER SET = latin1; " +
                /* CRIAÇÃO DA TABELA PARTICIPANTE*/
                " CREATE TABLE IF NOT EXISTS " + nomeBD + ".`participante` ( " +
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
                " CREATE TABLE IF NOT EXISTS " + nomeBD + ".`locacao` ( " +
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
                "  REFERENCES " + nomeBD + ".`participante` (`id_partipante`)) " +
                " ENGINE = InnoDB " +
                " AUTO_INCREMENT = 130 " +
                " DEFAULT CHARACTER SET = latin1;" +
                /* CRIAÇÃO DA TABELA LOCAÇÃO ITENS */
                " CREATE TABLE IF NOT EXISTS " + nomeBD + ".`locacaoitens` (" +
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
                " REFERENCES " + nomeBD + ".`locacao` (`id_locacao`)) " +
                " ENGINE = InnoDB " +
                " AUTO_INCREMENT = 150 " +
                " DEFAULT CHARACTER SET = latin1;" +
                /* CRIAÇÃO DA TABELA MARCA */
                " CREATE TABLE IF NOT EXISTS " + nomeBD + ".`marca` (" +
                " `id_marca` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '', " +
                " `descricao_marca` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `dataCadastro_marca` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT '', " +
                " `ativo_marca` TINYINT(3) UNSIGNED NOT NULL DEFAULT '0' COMMENT '', " +
                " PRIMARY KEY(`id_marca`)  COMMENT '') " +
                " ENGINE = InnoDB " +
                " AUTO_INCREMENT = 13 " +
                " DEFAULT CHARACTER SET = latin1;" +
                /* CRIAÇÃO DA TABELA PRODUTO */
                " CREATE TABLE IF NOT EXISTS " + nomeBD + ".`produto` (" +
                " `id_produto` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '', " +
                " `ativo_produto` TINYINT(3) UNSIGNED NOT NULL DEFAULT '0' COMMENT '', " +
                " `descontinuado_produto` TINYINT(3) UNSIGNED NULL DEFAULT NULL COMMENT '', " +
                " `tipoitem_produto` CHAR(1) NULL DEFAULT NULL COMMENT '', " +
                " `descricao_produto` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `unidade_produto` VARCHAR(3) NOT NULL DEFAULT '' COMMENT '', " +
                " `venda_produto` FLOAT NULL DEFAULT NULL COMMENT '', " +
                " `saldo_produto` DOUBLE NULL DEFAULT NULL COMMENT '', " +
                " `marca_produto` INT(10) UNSIGNED NULL DEFAULT NULL COMMENT '', " +
                " `categoria_produto` INT(10) UNSIGNED NULL DEFAULT NULL COMMENT '', " +
                " `subcategoria_produto` INT(10) UNSIGNED NULL DEFAULT NULL COMMENT '', " +
                " `fornecedor_produto` INT(10) UNSIGNED NULL DEFAULT NULL COMMENT '', " +
                " `codfabricante_produto` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `codbarras_produto` INT(10) UNSIGNED NULL DEFAULT NULL COMMENT '', " +
                " `codinterno_produto` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `dataCadastro_produto` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `dataAlteracao_produto` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `usuarioCadastro_produto` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `usuarioAlteracao_produto` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `ultimoCustoCompra_produto` FLOAT NULL DEFAULT NULL COMMENT '', " +
                " `custoanterior_produto` FLOAT NULL DEFAULT NULL COMMENT '', " +
                " `custofinal_produto` FLOAT NULL DEFAULT NULL COMMENT '', " +
                " PRIMARY KEY(`id_produto`)  COMMENT '', " +
                " INDEX `FK_produto_marca` (`marca_produto` ASC)  COMMENT '', " +
                " INDEX `FK_produto_fornecedor` (`fornecedor_produto` ASC)  COMMENT '', " +
                " INDEX `FK_produto_categoria` (`categoria_produto` ASC)  COMMENT '', " +
                " INDEX `FK_produto_subcategoria` (`subcategoria_produto` ASC)  COMMENT '', " +
                " CONSTRAINT `FK_produto_categoria` " +
                " FOREIGN KEY(`categoria_produto`) " +
                " REFERENCES " + nomeBD + ".`categoria` (`id_categoria`), " +
                " CONSTRAINT `FK_produto_fornecedor` " +
                " FOREIGN KEY(`fornecedor_produto`) " +
                " REFERENCES " + nomeBD + ".`participante` (`id_partipante`), " +
                " CONSTRAINT `FK_produto_marca` " +
                " FOREIGN KEY(`marca_produto`) " +
                " REFERENCES " + nomeBD + ".`marca` (`id_marca`), " +
                " CONSTRAINT `FK_produto_subcategoria` " +
                " FOREIGN KEY(`subcategoria_produto`) " +
                " REFERENCES " + nomeBD + ".`categoria` (`id_categoria`)) " +
                " ENGINE = InnoDB " +
                " AUTO_INCREMENT = 16 " +
                " DEFAULT CHARACTER SET = latin1;" +
                /* CRIAÇÃO DA TABELA PRODUTO VARIAÇÃO */
                " CREATE TABLE IF NOT EXISTS " + nomeBD + ".`produtovariacao` (" +
                " `id_produtovariacao` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '', " +
                " `idproduto_produtovariacao` INT(10) UNSIGNED NULL DEFAULT NULL COMMENT '', " +
                " `unidade_produtovariacao` VARCHAR(3) NOT NULL DEFAULT '' COMMENT '', " +
                " `fator_produtovariacao` CHAR(1) NULL DEFAULT NULL COMMENT '', " +
                " `quantidade_produtovariacao` DOUBLE NULL DEFAULT NULL COMMENT '', " +
                " `codbarras_produtovariacao` VARCHAR(15) NULL DEFAULT NULL COMMENT '', " +
                " PRIMARY KEY(`id_produtovariacao`)  COMMENT '', " +
                " INDEX `FK_produtovariacao_produto` (`idproduto_produtovariacao` ASC)  COMMENT '', " +
                " CONSTRAINT `FK_produtovariacao_produto` " +
                " FOREIGN KEY(`idproduto_produtovariacao`) " +
                " REFERENCES " + nomeBD + ".`produto` (`id_produto`)) " +
                " ENGINE = InnoDB " +
                " AUTO_INCREMENT = 8 " +
                " DEFAULT CHARACTER SET = latin1;" +
                /* CRIAÇÃO DA TABELA USUÁRIOS */
                " CREATE TABLE IF NOT EXISTS " + nomeBD + ".`usuario` (" +
                " `id_usuario` INT(10) UNSIGNED NOT NULL AUTO_INCREMENT COMMENT '', " +
                " `ativo_usuario` TINYINT(3) UNSIGNED NOT NULL DEFAULT '0' COMMENT '', " +
                " `nome_usuario` INT(10) UNSIGNED NULL DEFAULT NULL COMMENT '', " +
                " `login_usuario` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `senha_usuario` VARCHAR(45) NULL DEFAULT NULL COMMENT '', " +
                " `dataCadastro_usuario` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT '', " +
                " `botaoParticipante_usuario` TINYINT(3) UNSIGNED NOT NULL DEFAULT '0' COMMENT '', " +
                " `botaoGrupoProduto_usuario` TINYINT(3) UNSIGNED NOT NULL DEFAULT '0' COMMENT '', " +
                " `botaoProduto_usuario` TINYINT(3) UNSIGNED NOT NULL DEFAULT '0' COMMENT '', " +
                " `botaoMarca_usuario` TINYINT(3) UNSIGNED NOT NULL DEFAULT '0' COMMENT '', " +
                " `botaoCategoriaSubCategoria_usuario` TINYINT(3) UNSIGNED NOT NULL DEFAULT '0' COMMENT '', " +
                " `botaoUsuarios_usuario` TINYINT(3) UNSIGNED NOT NULL DEFAULT '0' COMMENT '', " +
                " `botaoLocacao_usuario` TINYINT(3) NULL DEFAULT NULL COMMENT '', " +
                " `botaoDevLocacao_usuario` TINYINT(3) NULL DEFAULT NULL COMMENT '', " +
                " PRIMARY KEY(`id_usuario`)  COMMENT '', " +
                " INDEX `FK_usuario_participante` (`nome_usuario` ASC)  COMMENT '', " +
                " CONSTRAINT `FK_usuario_participante` " +
                " FOREIGN KEY(`nome_usuario`) " +
                " REFERENCES " + nomeBD + ".`participante` (`id_partipante`)) " +
                " ENGINE = InnoDB " +
                " AUTO_INCREMENT = 22 " +
                " DEFAULT CHARACTER SET = latin1;" +
                /* CREATE VIEW BUSCAR PRODUTO */
                " CREATE TABLE IF NOT EXISTS " + nomeBD + ".`viewbuscarproduto` (`ativo_produto` INT, `descontinuado_produto` INT, `tipoitem_produto` INT, `id_produto` INT, `descricao_produto` INT, `unidade_produto` INT, `venda_produto` INT, `saldo_produto` INT, `marca_produto` INT, `categoria_produto` INT, `subcategoria_produto` INT, `fornecedor_produto` INT, `codfabricante_produto` INT, `codbarras_produto` INT, `codinterno_produto` INT, `dataCadastro_produto` INT, `dataAlteracao_produto` INT, `usuarioCadastro_produto` INT, `usuarioAlteracao_produto` INT, `ultimoCustoCompra_produto` INT, `custoAnterior_produto` INT, `custofinal_produto` INT, `descricao_marca` INT, `categoria` INT, `subcategoria` INT, `fornecedor` INT);" +
                /* CREATE VIEW LISTAR LOCAÇÃO ITENS DEV */
                " CREATE TABLE IF NOT EXISTS " + nomeBD + ".`viewlistarlocacaoitensdev` (`IDProduto` INT, `IDProdutoVariacao` INT, `Descricao` INT, `UN` INT, `ValorLocado` INT, `QtdLocada` INT, `QtdDevolvida` INT, `Restante` INT, `Marca` INT, `Categoria` INT, `SubCategoria` INT, `Fornecedor` INT, `Cod.Fabricante` INT, `Cod.Interno` INT, `IDLocacao` INT);" +
                /* CREATE VIEW LISTAR PRODUTOS */
                " CREATE TABLE IF NOT EXISTS " + nomeBD + ".`viewlistarproduto` (`id_produto` INT, `descricao_produto` INT, `unidade_produto` INT, `categoria` INT, `subcategoria` INT, `descricao_marca` INT, `venda_produto` INT, `custo` INT, `saldo_produto` INT, `fornecedor` INT, `codfabricante_produto` INT, `codbarras_produto` INT, `codinterno_produto` INT, `tipoitem` INT);" +
                /* CREATE VIEW LISTAR PRODUTOS COM VARIAÇÃO*/
                " CREATE TABLE IF NOT EXISTS " + nomeBD + ".`viewlistarprodutocomvariacao` (`id_produto` INT, `variacaoproduto` INT, `descricao_produto` INT, `unidade_produto` INT, `custo` INT, `venda_produto` INT, `descricao_marca` INT, `categoria` INT, `subcategoria` INT, `fornecedor` INT, `saldoprincipal` INT, `saldovariacao` INT, `codfabricante_produto` INT, `codbarras_produto` INT, `codinterno_produto` INT, `tipoitem` INT);" +
                /* CREATE VIEW LISTAR VARIAÇÃO */
                " CREATE TABLE IF NOT EXISTS " + nomeBD + ".`viewlistarvariacao` (`idProduto` INT, `unidadeprincipal` INT, `saldoprincipal` INT, `fator_produtovariacao` INT, `multiplovariacao` INT, `unidadevariacao` INT, `saldoVariacao` INT, `codVariacao` INT);" +
                /* CREATE VIEW LOCAÇÃO */
                " CREATE TABLE IF NOT EXISTS " + nomeBD + ".`viewlocacao` (`Codigo` INT, `CodigoCliente` INT, `NomeCliente` INT, `DataLancamento` INT, `DataPrevisaoEntrega` INT, `DataDevolucao` INT, `numerolocacaodev_locacao` INT, `Total` INT, `UsuarioLocacao` INT, `DescontoLocacao` INT, `QtdItensLocacao` INT, `TipoLocacao` INT);" +
                /* CREATE VIEW LOCAÇÃO ITENS */
                " CREATE TABLE IF NOT EXISTS " + nomeBD + ".`viewlocacaoitens` (`Codigo` INT, `CodigoProdutoVariacao` INT, `Descricao` INT, `UN` INT, `QtdLocada` INT, `ValorLocado` INT, `ValorTotal` INT, `Marca` INT, `Categoria` INT, `SubCategoria` INT, `Fornecedor` INT, `idLocacao_locacaoitens` INT, `idlocacaoitens` INT);" +
                /* DROP TABLE VIEW BUSCAR PRODUTO*/
                " DROP TABLE IF EXISTS " + nomeBD + ".`viewbuscarproduto`; " +
                " USE " + nomeBD + "; " +
                " CREATE OR REPLACE ALGORITHM = UNDEFINED DEFINER =`sistema`@`%` SQL SECURITY DEFINER VIEW " + nomeBD + ".`viewbuscarproduto` AS select " + nomeBD + ".`produto`.`ativo_produto` AS `ativo_produto`," + nomeBD + ".`produto`.`descontinuado_produto` AS `descontinuado_produto`," + nomeBD + ".`produto`.`tipoitem_produto` AS `tipoitem_produto`," + nomeBD + ".`produto`.`id_produto` AS `id_produto`," + nomeBD + ".`produto`.`descricao_produto` AS `descricao_produto`," + nomeBD + ".`produto`.`unidade_produto` AS `unidade_produto`," + nomeBD + ".`produto`.`venda_produto` AS `venda_produto`," + nomeBD + ".`produto`.`saldo_produto` AS `saldo_produto`," + nomeBD + ".`produto`.`marca_produto` AS `marca_produto`," + nomeBD + ".`produto`.`categoria_produto` AS `categoria_produto`," + nomeBD + ".`produto`.`subcategoria_produto` AS `subcategoria_produto`," + nomeBD + ".`produto`.`fornecedor_produto` AS `fornecedor_produto`," + nomeBD + ".`produto`.`codfabricante_produto` AS `codfabricante_produto`," + nomeBD + ".`produto`.`codbarras_produto` AS `codbarras_produto`," + nomeBD + ".`produto`.`codinterno_produto` AS `codinterno_produto`," + nomeBD + ".`produto`.`dataCadastro_produto` AS `dataCadastro_produto`," + nomeBD + ".`produto`.`dataAlteracao_produto` AS `dataAlteracao_produto`," + nomeBD + ".`produto`.`usuarioCadastro_produto` AS `usuarioCadastro_produto`," + nomeBD + ".`produto`.`usuarioAlteracao_produto` AS `usuarioAlteracao_produto`," + nomeBD + ".`produto`.`ultimoCustoCompra_produto` AS `ultimoCustoCompra_produto`," + nomeBD + ".`produto`.`custoanterior_produto` AS `custoAnterior_produto`," + nomeBD + ".`produto`.`custofinal_produto` AS `custofinal_produto`,`marc`.`descricao_marca` AS `descricao_marca`,`cat`.`descricao_categoria` AS `categoria`,`subcat`.`descricao_categoria` AS `subcategoria`,`forne`.`nome_fantasia_participante` AS `fornecedor` from((((" + nomeBD + ".`produto` left join " + nomeBD + ".`marca` `marc` on((`marc`.`id_marca` = " + nomeBD + ".`produto`.`marca_produto`))) left join " + nomeBD + ".`categoria` `cat` on((`cat`.`id_categoria` = " + nomeBD + ".`produto`.`categoria_produto`))) left join " + nomeBD + ".`categoria` `subcat` on((`subcat`.`id_categoria` = " + nomeBD + ".`produto`.`subcategoria_produto`))) left join " + nomeBD + ".`participante` `forne` on((`forne`.`id_partipante` = " + nomeBD + ".`produto`.`fornecedor_produto`)));" +
                /* DROP TABLE VIEW LISTAR LOCAÇÃO ITENS DEV */
                " DROP TABLE IF EXISTS " + nomeBD + ".`viewlistarlocacaoitensdev`; " +
                " USE " + nomeBD + "; " +
                " CREATE OR REPLACE ALGORITHM = UNDEFINED DEFINER =`sistema`@`%` SQL SECURITY DEFINER VIEW " + nomeBD + ".`viewlistarlocacaoitensdev` AS select `loci`.`idProduto_locacaoitens` AS `IDProduto`,`loci`.`idVariacaoProduto_locacaoitens` AS `IDProdutoVariacao`,`prod`.`descricao_produto` AS `Descricao`,if ((`loci`.`idVariacaoProduto_locacaoitens` = 0),`prod`.`unidade_produto`,concat(" + nomeBD + ".`produtovariacao`.`unidade_produtovariacao`, '/', " + nomeBD + ".`produtovariacao`.`quantidade_produtovariacao`)) AS `UN`,(`loci`.`valorLocado_locacaoitens` -(select(" + nomeBD + ".`locacao`.`desconto_locacao` / " + nomeBD + ".`locacao`.`qtdItens_locacao`) from " + nomeBD + ".`locacao` where(" + nomeBD + ".`locacao`.`id_locacao` = `loc`.`id_locacao`))) AS `ValorLocado`,`loci`.`qtdLocada_locacaoitens` AS `QtdLocada`,if (((select sum(`locdev`.`qtdLocada_locacaoitens`) from(" + nomeBD + ".`locacaoitens` `locdev` join " + nomeBD + ".`locacao` on((" + nomeBD + ".`locacao`.`id_locacao` = `locdev`.`idLocacao_locacaoitens`))) where((" + nomeBD + ".`locacao`.`numerolocacaodev_locacao` = `loc`.`id_locacao`) and(`loci`.`idProduto_locacaoitens` = `locdev`.`idProduto_locacaoitens`))) <> 0),(select sum(`locdev`.`qtdLocada_locacaoitens`) from(" + nomeBD + ".`locacaoitens` `locdev` join " + nomeBD + ".`locacao` on((" + nomeBD + ".`locacao`.`id_locacao` = `locdev`.`idLocacao_locacaoitens`))) where((" + nomeBD + ".`locacao`.`numerolocacaodev_locacao` = `loc`.`id_locacao`) and(`loci`.`idProduto_locacaoitens` = `locdev`.`idProduto_locacaoitens`))),0) AS `QtdDevolvida`,if (((`loci`.`qtdLocada_locacaoitens` -(select sum(`locdev`.`qtdLocada_locacaoitens`) from(" + nomeBD + ".`locacaoitens` `locdev` join " + nomeBD + ".`locacao` on((" + nomeBD + ".`locacao`.`id_locacao` = `locdev`.`idLocacao_locacaoitens`))) where((" + nomeBD + ".`locacao`.`numerolocacaodev_locacao` = `loc`.`id_locacao`) and(`loci`.`idProduto_locacaoitens` = `locdev`.`idProduto_locacaoitens`)))) = 0),(`loci`.`qtdLocada_locacaoitens` - (select sum(`locdev`.`qtdLocada_locacaoitens`) from (" + nomeBD + ".`locacaoitens` `locdev` join " + nomeBD + ".`locacao` on((" + nomeBD + ".`locacao`.`id_locacao` = `locdev`.`idLocacao_locacaoitens`))) where ((" + nomeBD + ".`locacao`.`numerolocacaodev_locacao` = `loc`.`id_locacao`) and (`loci`.`idProduto_locacaoitens` = `locdev`.`idProduto_locacaoitens`)))),`loci`.`qtdLocada_locacaoitens`) AS `Restante`,`marc`.`descricao_marca` AS `Marca`,`cat`.`descricao_categoria` AS `Categoria`,`subcat`.`descricao_categoria` AS `SubCategoria`,`forn`.`nome_fantasia_participante` AS `Fornecedor`,`prod`.`codfabricante_produto` AS `Cod.Fabricante`,`prod`.`codinterno_produto` AS `Cod.Interno`,`loc`.`id_locacao` AS `IDLocacao` from (((((((" + nomeBD + ".`locacaoitens` `loci` join " + nomeBD + ".`produto` `prod` on((`loci`.`idProduto_locacaoitens` = `prod`.`id_produto`))) left join " + nomeBD + ".`marca` `marc` on((`prod`.`marca_produto` = `marc`.`id_marca`))) left join " + nomeBD + ".`categoria` `cat` on((`cat`.`id_categoria` = `prod`.`categoria_produto`))) left join " + nomeBD + ".`categoria` `subcat` on((`subcat`.`id_categoria` = `prod`.`subcategoria_produto`))) left join " + nomeBD + ".`participante` `forn` on((`forn`.`id_partipante` = `prod`.`fornecedor_produto`))) left join " + nomeBD + ".`produtovariacao` on((" + nomeBD + ".`produtovariacao`.`id_produtovariacao` = `loci`.`idProduto_locacaoitens`))) join " + nomeBD + ".`locacao` `loc` on((`loc`.`id_locacao` = `loci`.`idLocacao_locacaoitens`)));" +
                /* DROP TABLE VIEW LISTAR PRODUTO */
                " DROP TABLE IF EXISTS " + nomeBD + ".`viewlistarproduto`; " +
                " USE " + nomeBD + "; " +
                " CREATE OR REPLACE ALGORITHM = UNDEFINED DEFINER =`sistema`@`%` SQL SECURITY DEFINER VIEW " + nomeBD + ".`viewlistarproduto` AS select `pro`.`id_produto` AS `id_produto`,`pro`.`descricao_produto` AS `descricao_produto`,`pro`.`unidade_produto` AS `unidade_produto`,`cat`.`descricao_categoria` AS `categoria`,`sub`.`descricao_categoria` AS `subcategoria`,`marc`.`descricao_marca` AS `descricao_marca`,`pro`.`venda_produto` AS `venda_produto`,`pro`.`custofinal_produto` AS `custo`,`pro`.`saldo_produto` AS `saldo_produto`,`cli`.`nome_fantasia_participante` AS `fornecedor`,`pro`.`codfabricante_produto` AS `codfabricante_produto`,`pro`.`codbarras_produto` AS `codbarras_produto`,`pro`.`codinterno_produto` AS `codinterno_produto`,`pro`.`tipoitem_produto` AS `tipoitem` from((((" + nomeBD + ".`produto` `pro` left join " + nomeBD + ".`categoria` `cat` on((`pro`.`categoria_produto` = `cat`.`id_categoria`))) left join " + nomeBD + ".`categoria` `sub` on((`pro`.`subcategoria_produto` = `sub`.`id_categoria`))) left join " + nomeBD + ".`participante` `cli` on((`cli`.`id_partipante` = `pro`.`fornecedor_produto`))) left join " + nomeBD + ".`marca` `marc` on((`marc`.`id_marca` = `pro`.`marca_produto`)));" +

                /* DROP TABLE VIEW LISTAR PRODUTO COM VARIAÇÃO */
                //" DROP TABLE IF EXISTS " + nomeBD + ".`viewlistarprodutocomvariacao`; "+
                //" USE " + nomeBD + "; " +
                //" CREATE OR REPLACE ALGORITHM = UNDEFINED DEFINER =`sistema`@`%` SQL SECURITY DEFINER VIEW " + nomeBD + ".`viewlistarprodutocomvariacao` AS select `prod1`.`id_produto` AS `id_produto`,0 AS `variacaoproduto`,`prod1`.`descricao_produto` AS `descricao_produto`,`prod1`.`unidade_produto` AS `unidade_produto`,`prod1`.`custofinal_produto` AS `custo`,`prod1`.`venda_produto` AS `venda_produto`,`marca1`.`descricao_marca` AS `descricao_marca`,`cat1`.`descricao_categoria` AS `categoria`,`subcat1`.`descricao_categoria` AS `subcategoria`,`forn1`.`nome_fantasia_participante` AS `fornecedor`,`prod1`.`saldo_produto` AS `saldoprincipal`,`prod1`.`saldo_produto` AS `saldovariacao`,`prod1`.`codfabricante_produto` AS `codfabricante_produto`,`prod1`.`codbarras_produto` AS `codbarras_produto`,`prod1`.`codinterno_produto` AS `codinterno_produto`,`prod1`.`tipoitem_produto` AS `tipoitem` from((((" + nomeBD + ".`produto` `prod1` left join " + nomeBD + ".`marca` `marca1` on((`marca1`.`id_marca` = `prod1`.`marca_produto`))) left join " + nomeBD + ".`categoria` `cat1` on((`cat1`.`id_categoria` = `prod1`.`categoria_produto`))) left join " + nomeBD + ".`categoria` `subcat1` on((`prod1`.`subcategoria_produto` = `subcat1`.`id_categoria`))) left join " + nomeBD + ".`participante` `forn1` on((`prod1`.`fornecedor_produto` = `forn1`.`id_partipante`))) union all select `prodv`.`idproduto_produtovariacao` AS `idproduto_produtovariacao`,`prodv`.`id_produtovariacao` AS `id_produtovariacao`,`prod2`.`descricao_produto` AS `descricao_produto`,concat(`prodv`.`unidade_produtovariacao`, '/',`prodv`.`quantidade_produtovariacao`) AS `concat(prodv.unidade_produtovariacao, '/', prodv.quantidade_produtovariacao)`,(`prod2`.`custofinal_produto` * `prodv`.`quantidade_produtovariacao`) AS `prod2.custofinal_produto* prodv.quantidade_produtovariacao`,if ((`prodv`.`unidade_produtovariacao` = NULL),`prod2`.`venda_produto`,(`prod2`.`venda_produto` * `prodv`.`quantidade_produtovariacao`)) AS `if(prodv.unidade_produtovariacao = null,prod2.venda_produto,prod2.venda_produto * prodv.quantidade_produtovariacao)`,`marca2`.`descricao_marca` AS `descricao_marca`,`cat2`.`descricao_categoria` AS `descricao_categoria`,`subcat2`.`descricao_categoria` AS `descricao_categoria`,`forn2`.`nome_fantasia_participante` AS `nome_fantasia_participante`,`prod2`.`saldo_produto` AS `saldo_produto`,if((`prodv`.`fator_produtovariacao` = 'X'),(`prod2`.`saldo_produto` * `prodv`.`quantidade_produtovariacao`),(`prod2`.`saldo_produto` / `prodv`.`quantidade_produtovariacao`)) AS `if(prodv.fator_produtovariacao = 'X',prod2.saldo_produto * prodv.quantidade_produtovariacao ,prod2.saldo_produto / prodv.quantidade_produtovariacao)`,`prod2`.`codfabricante_produto` AS `codfabricante_produto`,`prodv`.`codbarras_produtovariacao` AS `codbarras_produtovariacao`,`prod2`.`codinterno_produto` AS `codinterno_produto`,`prod2`.`tipoitem_produto` AS `tipoitem_produto` from (((((" + nomeBD + ".`produtovariacao` `prodv` join " + nomeBD + ".`produto` `prod2` on((`prod2`.`id_produto` = `prodv`.`idproduto_produtovariacao`))) left join " + nomeBD + ".`marca` `marca2` on((`prod2`.`marca_produto` = `marca2`.`id_marca`))) left join " + nomeBD + ".`categoria` `cat2` on((`prod2`.`categoria_produto` = `cat2`.`id_categoria`))) left join " + nomeBD + ".`categoria` `subcat2` on((`prod2`.`subcategoria_produto` = `subcat2`.`id_categoria`))) left join " + nomeBD + ".`participante` `forn2` on((`prod2`.`fornecedor_produto` = `forn2`.`id_partipante`))) order by `id_produto`; "+


                /* DROP TABLE VIEW LISTAR VARIAÇÃO */
                " DROP TABLE IF EXISTS " + nomeBD + ".`viewlistarvariacao`; " +
                " USE " + nomeBD + "; " +
                " CREATE OR REPLACE ALGORITHM = UNDEFINED DEFINER =`sistema`@`%` SQL SECURITY DEFINER VIEW " + nomeBD + ".`viewlistarvariacao` AS select " + nomeBD + ".`produto`.`id_produto` AS `idProduto`," + nomeBD + ".`produto`.`unidade_produto` AS `unidadeprincipal`," + nomeBD + ".`produto`.`saldo_produto` AS `saldoprincipal`," + nomeBD + ".`produtovariacao`.`fator_produtovariacao` AS `fator_produtovariacao`," + nomeBD + ".`produtovariacao`.`quantidade_produtovariacao` AS `multiplovariacao`," + nomeBD + ".`produtovariacao`.`unidade_produtovariacao` AS `unidadevariacao`,if ((" + nomeBD + ".`produtovariacao`.`fator_produtovariacao` = 'X'),(" + nomeBD + ".`produto`.`saldo_produto` *" + nomeBD + ".`produtovariacao`.`quantidade_produtovariacao`),(" + nomeBD + ".`produto`.`saldo_produto` / " + nomeBD + ".`produtovariacao`.`quantidade_produtovariacao`)) AS `saldoVariacao`," + nomeBD + ".`produtovariacao`.`id_produtovariacao` AS `codVariacao` from(" + nomeBD + ".`produto` join " + nomeBD + ".`produtovariacao` on((" + nomeBD + ".`produtovariacao`.`idproduto_produtovariacao` = " + nomeBD + ".`produto`.`id_produto`)));" +
                /* DROP TABLE VIEW LOCAÇÃO */
                " DROP TABLE IF EXISTS " + nomeBD + ".`viewlocacao`; " +
                " USE " + nomeBD + "; " +
                " CREATE OR REPLACE ALGORITHM = UNDEFINED DEFINER =`sistema`@`%` SQL SECURITY DEFINER VIEW " + nomeBD + ".`viewlocacao` AS select `loc`.`id_locacao` AS `Codigo`,`loc`.`idCliente_locacao` AS `CodigoCliente`,`cli`.`nome_fantasia_participante` AS `NomeCliente`,`loc`.`dataLancamento_locacao` AS `DataLancamento`,`loc`.`dataPrevisaoEntrega_locacao` AS `DataPrevisaoEntrega`,`loc`.`dataDevolucao_locacao` AS `DataDevolucao`,`loc`.`numerolocacaodev_locacao` AS `numerolocacaodev_locacao`,`loc`.`total_locacao` AS `Total`,`loc`.`usuario_locacao` AS `UsuarioLocacao`,`loc`.`desconto_locacao` AS `DescontoLocacao`,`loc`.`qtdItens_locacao` AS `QtdItensLocacao`,`loc`.`tipo_locacao` AS `TipoLocacao` from(" + nomeBD + ".`locacao` `loc` join " + nomeBD + ".`participante` `cli` on((`cli`.`id_partipante` = `loc`.`idCliente_locacao`)));" +
                /* DROP TABLE VIEW LOCAÇÃO ITENS */
                " DROP TABLE IF EXISTS " + nomeBD + ".`viewlocacaoitens`; " +
                " USE " + nomeBD + "; " +
                " CREATE OR REPLACE ALGORITHM = UNDEFINED DEFINER =`sistema`@`%` SQL SECURITY DEFINER VIEW " + nomeBD + ".`viewlocacaoitens` AS select " + nomeBD + ".`locacaoitens`.`idProduto_locacaoitens` AS `Codigo`," + nomeBD + ".`locacaoitens`.`idVariacaoProduto_locacaoitens` AS `CodigoProdutoVariacao`," + nomeBD + ".`produto`.`descricao_produto` AS `Descricao`,if ((" + nomeBD + ".`locacaoitens`.`idVariacaoProduto_locacaoitens` = 0)," + nomeBD + ".`produto`.`unidade_produto`," + nomeBD + ".`produtovariacao`.`unidade_produtovariacao`) AS `UN`," + nomeBD + ".`locacaoitens`.`qtdLocada_locacaoitens` AS `QtdLocada`," + nomeBD + ".`locacaoitens`.`valorLocado_locacaoitens` AS `ValorLocado`,(" + nomeBD + ".`locacaoitens`.`valorLocado_locacaoitens` *" + nomeBD + ".`locacaoitens`.`qtdLocada_locacaoitens`) AS `ValorTotal`," + nomeBD + ".`marca`.`descricao_marca` AS `Marca`,`cat`.`descricao_categoria` AS `Categoria`,`subcat`.`descricao_categoria` AS `SubCategoria`," + nomeBD + ".`participante`.`nome_fantasia_participante` AS `Fornecedor`," + nomeBD + ".`locacaoitens`.`idLocacao_locacaoitens` AS `idLocacao_locacaoitens`," + nomeBD + ".`locacaoitens`.`id_locacaoitens` AS `idlocacaoitens` from((((((" + nomeBD + ".`locacaoitens` left join " + nomeBD + ".`produtovariacao` on((" + nomeBD + ".`produtovariacao`.`id_produtovariacao` = " + nomeBD + ".`locacaoitens`.`idProduto_locacaoitens`))) join " + nomeBD + ".`produto` on((" + nomeBD + ".`produto`.`id_produto` = " + nomeBD + ".`locacaoitens`.`idProduto_locacaoitens`))) left join " + nomeBD + ".`marca` on((" + nomeBD + ".`marca`.`id_marca` = " + nomeBD + ".`produto`.`marca_produto`))) left join " + nomeBD + ".`categoria` `cat` on((`cat`.`id_categoria` = " + nomeBD + ".`produto`.`categoria_produto`))) left join " + nomeBD + ".`categoria` `subcat` on((`subcat`.`id_categoria` = " + nomeBD + ".`produto`.`subcategoria_produto`))) left join " + nomeBD + ".`participante` on((" + nomeBD + ".`participante`.`id_partipante` = " + nomeBD + ".`produto`.`fornecedor_produto`)));", conexao);
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao criar tabelas" + erro.Message);
            }
            finally
            {
                FecharConexao();
                criarTriggerLocacao_deleteLocacaoItens(nomeBD);
            }
        }

        //Método criar triggers
        public void criarTriggerLocacao_deleteLocacaoItens(string nomeBD)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand(
                /* CREATE TRIGGER DELETE LOCAÇÃO*/
                "USE " + nomeBD + "; " +
                " CREATE DEFINER = CURRENT_USER TRIGGER " + nomeBD + ".`locacao_BEFORE_DELETE` BEFORE DELETE ON `locacao` FOR EACH ROW " +
                " BEGIN " +
                " delete from locacaoitens where idLocacao_locacaoitens = OLD.id_locacao; END", conexao);
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao criar trigger" + erro.Message);
            }
            finally
            {
                FecharConexao();
                criarTriggerLocacaoItens_RemoveItemEstoque(nomeBD);
            }
        }

        public void criarTriggerLocacaoItens_RemoveItemEstoque(string nomeBD)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand(
                "USE " + nomeBD + "; " +
                " CREATE TRIGGER Estoque_locacaoitens_Insert AFTER INSERT " +
                " ON locacaoitens " +
                " FOR EACH ROW " +
                " BEGIN " +
                " UPDATE produto SET saldo_produto = saldo_produto - NEW.qtdLocada_locacaoitens " +
                " WHERE id_produto = NEW.idProduto_locacaoitens; " +
                " END ", conexao);
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao criar trigger" + erro.Message);
            }
            finally
            {
                FecharConexao();
                criarTriggerLocacaoItens_DevolveItemEstoque(nomeBD);
            }
        }

        public void criarTriggerLocacaoItens_DevolveItemEstoque(string nomeBD)
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand(
                /* CREATE TRIGGER DELETE ITEM RECALCULO ESTOQUE*/
                //"USE " + nomeBD + "; " +
                //" CREATE DEFINER = CURRENT_USER TRIGGER " + nomeBD + ".`Estoque_locacaoitens_Delete` AFTER DELETE ON `locacaoitens` FOR EACH ROW " +
                //" BEGIN " +
                //" UPDATE produto SET saldo_produto = saldo_produto + OLD.qtdLocada_locacaoitens WHERE id_produto = OLD.idProduto_locacaoitens;", conexao);
                "USE " + nomeBD + "; " +
                " CREATE TRIGGER Estoque_locacaoitens_Delete AFTER DELETE " +
                " ON locacaoitens " +
                " FOR EACH ROW " +
                " BEGIN " +
                " UPDATE produto SET saldo_produto = saldo_produto + OLD.qtdLocada_locacaoitens " +
                " WHERE id_produto = OLD.idProduto_locacaoitens; " +
                " END ", conexao);
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao criar trigger" + erro.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //Método popular a tabela cidade
        public void popularCidade()
        {
            try
            {
                AbrirConexao();
                comando = new MySqlCommand(
                //"INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Alta Floresta D\'Oeste','RO',1100015);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('Ariquemes', 'RO', 1100023);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('Cabixi', 'RO', 1100031);"+
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('Cacoal', 'RO', 1100049);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('Cerejeiras', 'RO', 1100056);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('Colorado do Oeste', 'RO', 1100064);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('Corumbiara', 'RO', 1100072);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('Costa Marques', 'RO', 1100080);" +
                //"INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('Espigão D\'Oeste', 'RO', 1100098);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('Guajará-Mirim', 'RO', 1100106);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('Jaru', 'RO', 1100114);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('Ji-Paraná', 'RO', 1100122);" +
                //"INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('Machadinho D\'Oeste', 'RO', 1100130);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('Nova Brasilândia D\'Oeste', 'RO', 1100148);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('Ouro Preto do Oeste', 'RO', 1100155);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('Pimenta Bueno', 'RO', 1100189);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('Porto Velho', 'RO', 1100205);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('Presidente Médici', 'RO', 1100254);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('Rio Crespo', 'RO', 1100262);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('Rolim de Moura', 'RO', 1100288);" +
                //"INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('Santa Luzia D\'Oeste', 'RO', 1100296);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('Vilhena', 'RO', 1100304);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('São Miguel do Guaporé', 'RO', 1100320);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('Nova Mamoré', 'RO', 1100338);" +
                //"INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('Alvorada D\'Oeste', 'RO', 1100346);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES('Alto Alegre dos Parecis', 'RO', 1100379);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Alto Paraíso','RO',1100403);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Buritis','RO',1100452);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Novo Horizonte do Oeste','RO',1100502);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cacaulândia','RO',1100601);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Campo Novo de Rondônia','RO',1100700);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Candeias do Jamari','RO',1100809);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Castanheiras','RO',1100908);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Chupinguaia','RO',1100924);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cujubim','RO',1100940);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Governador Jorge Teixeira','RO',1101005);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Itapuã do Oeste','RO',1101104);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ministro Andreazza','RO',1101203);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Mirante da Serra','RO',1101302);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Monte Negro','RO',1101401);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Nova União','RO',1101435);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Parecis','RO',1101450);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pimenteiras do Oeste','RO',1101468);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Primavera de Rondônia','RO',1101476);" +
                //"INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Felipe D\'Oeste','RO',1101484);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Francisco do Guaporé','RO',1101492);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Seringueiras','RO',1101500);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Teixeirópolis','RO',1101559);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Theobroma','RO',1101609);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Urupá','RO',1101708);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Vale do Anari','RO',1101757);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Vale do Paraíso','RO',1101807);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Acrelândia','AC',1200013);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Assis Brasil','AC',1200054);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Brasiléia','AC',1200104);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bujari','AC',1200138);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Capixaba','AC',1200179);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cruzeiro do Sul','AC',1200203);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Epitaciolândia','AC',1200252);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Feijó','AC',1200302);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Jordão','AC',1200328);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Mâncio Lima','AC',1200336);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Manoel Urbano','AC',1200344);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Marechal Thaumaturgo','AC',1200351);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Plácido de Castro','AC',1200385);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Porto Walter','AC',1200393);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Rio Branco','AC',1200401);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Rodrigues Alves','AC',1200427);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Rosa do Purus','AC',1200435);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Senador Guiomard','AC',1200450);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Sena Madureira','AC',1200500);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Tarauacá','AC',1200609);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Xapuri','AC',1200708);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Porto Acre','AC',1200807);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Alvarães','AM',1300029);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Amaturá','AM',1300060);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Anamã','AM',1300086);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Anori','AM',1300102);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Apuí','AM',1300144);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Atalaia do Norte','AM',1300201);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Autazes','AM',1300300);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Barcelos','AM',1300409);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Barreirinha','AM',1300508);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Benjamin Constant','AM',1300607);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Beruri','AM',1300631);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Boa Vista do Ramos','AM',1300680);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Boca do Acre','AM',1300706);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Borba','AM',1300805);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Caapiranga','AM',1300839);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Canutama','AM',1300904);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Carauari','AM',1301001);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Careiro','AM',1301100);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Careiro da Várzea','AM',1301159);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Coari','AM',1301209);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Codajás','AM',1301308);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Eirunepé','AM',1301407);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Envira','AM',1301506);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Fonte Boa','AM',1301605);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Guajará','AM',1301654);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Humaitá','AM',1301704);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ipixuna','AM',1301803);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Iranduba','AM',1301852);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Itacoatiara','AM',1301902);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Itamarati','AM',1301951);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Itapiranga','AM',1302009);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Japurá','AM',1302108);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Juruá','AM',1302207);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Jutaí','AM',1302306);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Lábrea','AM',1302405);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Manacapuru','AM',1302504);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Manaquiri','AM',1302553);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Manaus','AM',1302603);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Manicoré','AM',1302702);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Maraã','AM',1302801);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Maués','AM',1302900);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Nhamundá','AM',1303007);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Nova Olinda do Norte','AM',1303106);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Novo Airão','AM',1303205);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Novo Aripuanã','AM',1303304);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Parintins','AM',1303403);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pauini','AM',1303502);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Presidente Figueiredo','AM',1303536);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Rio Preto da Eva','AM',1303569);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Isabel do Rio Negro','AM',1303601);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santo Antônio do Içá','AM',1303700);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Gabriel da Cachoeira','AM',1303809);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Paulo de Olivença','AM',1303908);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Sebastião do Uatumã','AM',1303957);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Silves','AM',1304005);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Tabatinga','AM',1304062);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Tapauá','AM',1304104);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Tefé','AM',1304203);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Tonantins','AM',1304237);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Uarini','AM',1304260);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Urucará','AM',1304302);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Urucurituba','AM',1304401);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Amajari','RR',1400027);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Alto Alegre','RR',1400050);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Boa Vista','RR',1400100);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bonfim','RR',1400159);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cantá','RR',1400175);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Caracaraí','RR',1400209);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Caroebe','RR',1400233);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Iracema','RR',1400282);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Mucajaí','RR',1400308);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Normandia','RR',1400407);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pacaraima','RR',1400456);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Rorainópolis','RR',1400472);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São João da Baliza','RR',1400506);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Luiz','RR',1400605);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Uiramutã','RR',1400704);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Abaetetuba','PA',1500107);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Abel Figueiredo','PA',1500131);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Acará','PA',1500206);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Afuá','PA',1500305);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Água Azul do Norte','PA',1500347);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Alenquer','PA',1500404);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Almeirim','PA',1500503);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Altamira','PA',1500602);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Anajás','PA',1500701);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ananindeua','PA',1500800);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Anapu','PA',1500859);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Augusto Corrêa','PA',1500909);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Aurora do Pará','PA',1500958);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Aveiro','PA',1501006);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bagre','PA',1501105);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Baião','PA',1501204);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bannach','PA',1501253);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Barcarena','PA',1501303);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Belém','PA',1501402);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Belterra','PA',1501451);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Benevides','PA',1501501);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bom Jesus do Tocantins','PA',1501576);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bonito','PA',1501600);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bragança','PA',1501709);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Brasil Novo','PA',1501725);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Brejo Grande do Araguaia','PA',1501758);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Breu Branco','PA',1501782);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Breves','PA',1501808);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bujaru','PA',1501907);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cachoeira do Piriá','PA',1501956);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cachoeira do Arari','PA',1502004);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cametá','PA',1502103);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Canaã dos Carajás','PA',1502152);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Capanema','PA',1502202);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Capitão Poço','PA',1502301);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Castanhal','PA',1502400);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Chaves','PA',1502509);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Colares','PA',1502608);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Conceição do Araguaia','PA',1502707);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Concórdia do Pará','PA',1502756);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cumaru do Norte','PA',1502764);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Curionópolis','PA',1502772);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Curralinho','PA',1502806);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Curuá','PA',1502855);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Curuçá','PA',1502905);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Dom Eliseu','PA',1502939);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Eldorado dos Carajás','PA',1502954);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Faro','PA',1503002);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Floresta do Araguaia','PA',1503044);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Garrafão do Norte','PA',1503077);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Goianésia do Pará','PA',1503093);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Gurupá','PA',1503101);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Igarapé-Açu','PA',1503200);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Igarapé-Miri','PA',1503309);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Inhangapi','PA',1503408);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ipixuna do Pará','PA',1503457);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Irituia','PA',1503507);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Itaituba','PA',1503606);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Itupiranga','PA',1503705);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Jacareacanga','PA',1503754);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Jacundá','PA',1503804);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Juruti','PA',1503903);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Limoeiro do Ajuru','PA',1504000);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Mãe do Rio','PA',1504059);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Magalhães Barata','PA',1504109);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Marabá','PA',1504208);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Maracanã','PA',1504307);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Marapanim','PA',1504406);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Marituba','PA',1504422);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Medicilândia','PA',1504455);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Melgaço','PA',1504505);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Mocajuba','PA',1504604);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Moju','PA',1504703);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Mojuí dos Campos','PA',1504752);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Monte Alegre','PA',1504802);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Muaná','PA',1504901);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Nova Esperança do Piriá','PA',1504950);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Nova Ipixuna','PA',1504976);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Nova Timboteua','PA',1505007);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Novo Progresso','PA',1505031);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Novo Repartimento','PA',1505064);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Óbidos','PA',1505106);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Oeiras do Pará','PA',1505205);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Oriximiná','PA',1505304);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ourém','PA',1505403);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ourilândia do Norte','PA',1505437);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pacajá','PA',1505486);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Palestina do Pará','PA',1505494);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Paragominas','PA',1505502);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Parauapebas','PA',1505536);" +
                //"INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pau D\'Arco','PA',1505551);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Peixe-Boi','PA',1505601);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Piçarra','PA',1505635);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Placas','PA',1505650);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ponta de Pedras','PA',1505700);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Portel','PA',1505809);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Porto de Moz','PA',1505908);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Prainha','PA',1506005);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Primavera','PA',1506104);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Quatipuru','PA',1506112);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Redenção','PA',1506138);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Rio Maria','PA',1506161);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Rondon do Pará','PA',1506187);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Rurópolis','PA',1506195);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Salinópolis','PA',1506203);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Salvaterra','PA',1506302);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Bárbara do Pará','PA',1506351);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Cruz do Arari','PA',1506401);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Isabel do Pará','PA',1506500);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Luzia do Pará','PA',1506559);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Maria das Barreiras','PA',1506583);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Maria do Pará','PA',1506609);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santana do Araguaia','PA',1506708);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santarém','PA',1506807);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santarém Novo','PA',1506906);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santo Antônio do Tauá','PA',1507003);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Caetano de Odivelas','PA',1507102);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Domingos do Araguaia','PA',1507151);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Domingos do Capim','PA',1507201);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Félix do Xingu','PA',1507300);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Francisco do Pará','PA',1507409);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Geraldo do Araguaia','PA',1507458);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São João da Ponta','PA',1507466);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São João de Pirabas','PA',1507474);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São João do Araguaia','PA',1507508);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Miguel do Guamá','PA',1507607);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Sebastião da Boa Vista','PA',1507706);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Sapucaia','PA',1507755);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Senador José Porfírio','PA',1507805);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Soure','PA',1507904);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Tailândia','PA',1507953);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Terra Alta','PA',1507961);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Terra Santa','PA',1507979);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Tomé-Açu','PA',1508001);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Tracuateua','PA',1508035);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Trairão','PA',1508050);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Tucumã','PA',1508084);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Tucuruí','PA',1508100);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ulianópolis','PA',1508126);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Uruará','PA',1508159);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Vigia','PA',1508209);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Viseu','PA',1508308);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Vitória do Xingu','PA',1508357);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Xinguara','PA',1508407);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Serra do Navio','AP',1600055);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Amapá','AP',1600105);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pedra Branca do Amapari','AP',1600154);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Calçoene','AP',1600204);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cutias','AP',1600212);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ferreira Gomes','AP',1600238);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Itaubal','AP',1600253);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Laranjal do Jari','AP',1600279);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Macapá','AP',1600303);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Mazagão','AP',1600402);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Oiapoque','AP',1600501);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Porto Grande','AP',1600535);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pracuúba','AP',1600550);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santana','AP',1600600);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Tartarugalzinho','AP',1600709);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Vitória do Jari','AP',1600808);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Abreulândia','TO',1700251);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Aguiarnópolis','TO',1700301);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Aliança do Tocantins','TO',1700350);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Almas','TO',1700400);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Alvorada','TO',1700707);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ananás','TO',1701002);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Angico','TO',1701051);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Aparecida do Rio Negro','TO',1701101);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Aragominas','TO',1701309);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Araguacema','TO',1701903);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Araguaçu','TO',1702000);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Araguaína','TO',1702109);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Araguanã','TO',1702158);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Araguatins','TO',1702208);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Arapoema','TO',1702307);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Arraias','TO',1702406);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Augustinópolis','TO',1702554);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Aurora do Tocantins','TO',1702703);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Axixá do Tocantins','TO',1702901);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Babaçulândia','TO',1703008);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bandeirantes do Tocantins','TO',1703057);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Barra do Ouro','TO',1703073);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Barrolândia','TO',1703107);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bernardo Sayão','TO',1703206);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bom Jesus do Tocantins','TO',1703305);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Brasilândia do Tocantins','TO',1703602);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Brejinho de Nazaré','TO',1703701);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Buriti do Tocantins','TO',1703800);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cachoeirinha','TO',1703826);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Campos Lindos','TO',1703842);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cariri do Tocantins','TO',1703867);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Carmolândia','TO',1703883);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Carrasco Bonito','TO',1703891);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Caseara','TO',1703909);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Centenário','TO',1704105);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Chapada de Areia','TO',1704600);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Chapada da Natividade','TO',1705102);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Colinas do Tocantins','TO',1705508);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Combinado','TO',1705557);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Conceição do Tocantins','TO',1705607);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Couto Magalhães','TO',1706001);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cristalândia','TO',1706100);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Crixás do Tocantins','TO',1706258);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Darcinópolis','TO',1706506);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Dianópolis','TO',1707009);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Divinópolis do Tocantins','TO',1707108);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Dois Irmãos do Tocantins','TO',1707207);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Dueré','TO',1707306);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Esperantina','TO',1707405);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Fátima','TO',1707553);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Figueirópolis','TO',1707652);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Filadélfia','TO',1707702);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Formoso do Araguaia','TO',1708205);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Fortaleza do Tabocão','TO',1708254);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Goianorte','TO',1708304);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Goiatins','TO',1709005);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Guaraí','TO',1709302);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Gurupi','TO',1709500);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ipueiras','TO',1709807);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Itacajá','TO',1710508);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Itaguatins','TO',1710706);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Itapiratins','TO',1710904);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Itaporã do Tocantins','TO',1711100);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Jaú do Tocantins','TO',1711506);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Juarina','TO',1711803);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Lagoa da Confusão','TO',1711902);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Lagoa do Tocantins','TO',1711951);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Lajeado','TO',1712009);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Lavandeira','TO',1712157);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Lizarda','TO',1712405);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Luzinópolis','TO',1712454);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Marianópolis do Tocantins','TO',1712504);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Mateiros','TO',1712702);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Maurilândia do Tocantins','TO',1712801);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Miracema do Tocantins','TO',1713205);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Miranorte','TO',1713304);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Monte do Carmo','TO',1713601);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Monte Santo do Tocantins','TO',1713700);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Palmeiras do Tocantins','TO',1713809);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Muricilândia','TO',1713957);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Natividade','TO',1714203);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Nazaré','TO',1714302);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Nova Olinda','TO',1714880);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Nova Rosalândia','TO',1715002);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Novo Acordo','TO',1715101);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Novo Alegre','TO',1715150);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Novo Jardim','TO',1715259);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Oliveira de Fátima','TO',1715507);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Palmeirante','TO',1715705);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Palmeirópolis','TO',1715754);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Paraíso do Tocantins','TO',1716109);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Paranã','TO',1716208);" +
                //"INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pau D\'Arco','TO',1716307);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pedro Afonso','TO',1716505);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Peixe','TO',1716604);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pequizeiro','TO',1716653);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Colméia','TO',1716703);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pindorama do Tocantins','TO',1717008);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Piraquê','TO',1717206);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pium','TO',1717503);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ponte Alta do Bom Jesus','TO',1717800);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ponte Alta do Tocantins','TO',1717909);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Porto Alegre do Tocantins','TO',1718006);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Porto Nacional','TO',1718204);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Praia Norte','TO',1718303);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Presidente Kennedy','TO',1718402);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pugmil','TO',1718451);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Recursolândia','TO',1718501);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Riachinho','TO',1718550);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Rio da Conceição','TO',1718659);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Rio dos Bois','TO',1718709);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Rio Sono','TO',1718758);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Sampaio','TO',1718808);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Sandolândia','TO',1718840);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Fé do Araguaia','TO',1718865);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Maria do Tocantins','TO',1718881);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Rita do Tocantins','TO',1718899);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Rosa do Tocantins','TO',1718907);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Tereza do Tocantins','TO',1719004);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Terezinha do Tocantins','TO',1720002);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Bento do Tocantins','TO',1720101);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Félix do Tocantins','TO',1720150);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Miguel do Tocantins','TO',1720200);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Salvador do Tocantins','TO',1720259);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Sebastião do Tocantins','TO',1720309);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Valério','TO',1720499);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Silvanópolis','TO',1720655);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Sítio Novo do Tocantins','TO',1720804);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Sucupira','TO',1720853);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Taguatinga','TO',1720903);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Taipas do Tocantins','TO',1720937);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Talismã','TO',1720978);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Palmas','TO',1721000);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Tocantínia','TO',1721109);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Tocantinópolis','TO',1721208);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Tupirama','TO',1721257);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Tupiratins','TO',1721307);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Wanderlândia','TO',1722081);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Xambioá','TO',1722107);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Açailândia','MA',2100055);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Afonso Cunha','MA',2100105);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Água Doce do Maranhão','MA',2100154);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Alcântara','MA',2100204);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Aldeias Altas','MA',2100303);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Altamira do Maranhão','MA',2100402);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Alto Alegre do Maranhão','MA',2100436);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Alto Alegre do Pindaré','MA',2100477);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Alto Parnaíba','MA',2100501);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Amapá do Maranhão','MA',2100550);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Amarante do Maranhão','MA',2100600);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Anajatuba','MA',2100709);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Anapurus','MA',2100808);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Apicum-Açu','MA',2100832);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Araguanã','MA',2100873);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Araioses','MA',2100907);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Arame','MA',2100956);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Arari','MA',2101004);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Axixá','MA',2101103);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bacabal','MA',2101202);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bacabeira','MA',2101251);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bacuri','MA',2101301);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bacurituba','MA',2101350);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Balsas','MA',2101400);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Barão de Grajaú','MA',2101509);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Barra do Corda','MA',2101608);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Barreirinhas','MA',2101707);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Belágua','MA',2101731);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bela Vista do Maranhão','MA',2101772);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Benedito Leite','MA',2101806);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bequimão','MA',2101905);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bernardo do Mearim','MA',2101939);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Boa Vista do Gurupi','MA',2101970);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bom Jardim','MA',2102002);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bom Jesus das Selvas','MA',2102036);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bom Lugar','MA',2102077);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Brejo','MA',2102101);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Brejo de Areia','MA',2102150);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Buriti','MA',2102200);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Buriti Bravo','MA',2102309);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Buriticupu','MA',2102325);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Buritirana','MA',2102358);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cachoeira Grande','MA',2102374);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cajapió','MA',2102408);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cajari','MA',2102507);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Campestre do Maranhão','MA',2102556);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cândido Mendes','MA',2102606);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cantanhede','MA',2102705);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Capinzal do Norte','MA',2102754);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Carolina','MA',2102804);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Carutapera','MA',2102903);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Caxias','MA',2103000);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cedral','MA',2103109);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Central do Maranhão','MA',2103125);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Centro do Guilherme','MA',2103158);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Centro Novo do Maranhão','MA',2103174);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Chapadinha','MA',2103208);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cidelândia','MA',2103257);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Codó','MA',2103307);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Coelho Neto','MA',2103406);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Colinas','MA',2103505);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Conceição do Lago-Açu','MA',2103554);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Coroatá','MA',2103604);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cururupu','MA',2103703);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Davinópolis','MA',2103752);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Dom Pedro','MA',2103802);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Duque Bacelar','MA',2103901);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Esperantinópolis','MA',2104008);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Estreito','MA',2104057);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Feira Nova do Maranhão','MA',2104073);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Fernando Falcão','MA',2104081);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Formosa da Serra Negra','MA',2104099);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Fortaleza dos Nogueiras','MA',2104107);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Fortuna','MA',2104206);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Godofredo Viana','MA',2104305);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Gonçalves Dias','MA',2104404);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Governador Archer','MA',2104503);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Governador Edison Lobão','MA',2104552);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Governador Eugênio Barros','MA',2104602);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Governador Luiz Rocha','MA',2104628);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Governador Newton Bello','MA',2104651);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Governador Nunes Freire','MA',2104677);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Graça Aranha','MA',2104701);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Grajaú','MA',2104800);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Guimarães','MA',2104909);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Humberto de Campos','MA',2105005);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Icatu','MA',2105104);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Igarapé do Meio','MA',2105153);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Igarapé Grande','MA',2105203);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Imperatriz','MA',2105302);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Itaipava do Grajaú','MA',2105351);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Itapecuru Mirim','MA',2105401);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Itinga do Maranhão','MA',2105427);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Jatobá','MA',2105450);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Jenipapo dos Vieiras','MA',2105476);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('João Lisboa','MA',2105500);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Joselândia','MA',2105609);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Junco do Maranhão','MA',2105658);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Lago da Pedra','MA',2105708);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Lago do Junco','MA',2105807);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Lago Verde','MA',2105906);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Lagoa do Mato','MA',2105922);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Lago dos Rodrigues','MA',2105948);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Lagoa Grande do Maranhão','MA',2105963);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Lajeado Novo','MA',2105989);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Lima Campos','MA',2106003);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Loreto','MA',2106102);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Luís Domingues','MA',2106201);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Magalhães de Almeida','MA',2106300);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Maracaçumé','MA',2106326);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Marajá do Sena','MA',2106359);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Maranhãozinho','MA',2106375);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Mata Roma','MA',2106409);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Matinha','MA',2106508);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Matões','MA',2106607);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Matões do Norte','MA',2106631);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Milagres do Maranhão','MA',2106672);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Mirador','MA',2106706);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Miranda do Norte','MA',2106755);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Mirinzal','MA',2106805);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Monção','MA',2106904);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Montes Altos','MA',2107001);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Morros','MA',2107100);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Nina Rodrigues','MA',2107209);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Nova Colinas','MA',2107258);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Nova Iorque','MA',2107308);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Nova Olinda do Maranhão','MA',2107357);" +
                //"INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Olho D\'Água das Cunhãs','MA',2107407);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Olinda Nova do Maranhão','MA',2107456);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Paço do Lumiar','MA',2107506);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Palmeirândia','MA',2107605);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Paraibano','MA',2107704);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Parnarama','MA',2107803);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Passagem Franca','MA',2107902);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pastos Bons','MA',2108009);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Paulino Neves','MA',2108058);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Paulo Ramos','MA',2108108);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pedreiras','MA',2108207);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pedro do Rosário','MA',2108256);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Penalva','MA',2108306);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Peri Mirim','MA',2108405);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Peritoró','MA',2108454);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pindaré-Mirim','MA',2108504);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pinheiro','MA',2108603);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pio XII','MA',2108702);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pirapemas','MA',2108801);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Poção de Pedras','MA',2108900);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Porto Franco','MA',2109007);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Porto Rico do Maranhão','MA',2109056);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Presidente Dutra','MA',2109106);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Presidente Juscelino','MA',2109205);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Presidente Médici','MA',2109239);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Presidente Sarney','MA',2109270);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Presidente Vargas','MA',2109304);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Primeira Cruz','MA',2109403);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Raposa','MA',2109452);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Riachão','MA',2109502);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ribamar Fiquene','MA',2109551);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Rosário','MA',2109601);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Sambaíba','MA',2109700);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Filomena do Maranhão','MA',2109759);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Helena','MA',2109809);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Inês','MA',2109908);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Luzia','MA',2110005);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Luzia do Paruá','MA',2110039);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Quitéria do Maranhão','MA',2110104);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Rita','MA',2110203);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santana do Maranhão','MA',2110237);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santo Amaro do Maranhão','MA',2110278);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santo Antônio dos Lopes','MA',2110302);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Benedito do Rio Preto','MA',2110401);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Bento','MA',2110500);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Bernardo','MA',2110609);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Domingos do Azeitão','MA',2110658);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Domingos do Maranhão','MA',2110708);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Félix de Balsas','MA',2110807);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Francisco do Brejão','MA',2110856);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Francisco do Maranhão','MA',2110906);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São João Batista','MA',2111003);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São João do Carú','MA',2111029);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São João do Paraíso','MA',2111052);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São João do Soter','MA',2111078);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São João dos Patos','MA',2111102);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São José de Ribamar','MA',2111201);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São José dos Basílios','MA',2111250);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Luís','MA',2111300);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Luís Gonzaga do Maranhão','MA',2111409);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Mateus do Maranhão','MA',2111508);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Pedro da Água Branca','MA',2111532);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Pedro dos Crentes','MA',2111573);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Raimundo das Mangabeiras','MA',2111607);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Raimundo do Doca Bezerra','MA',2111631);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Roberto','MA',2111672);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Vicente Ferrer','MA',2111706);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Satubinha','MA',2111722);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Senador Alexandre Costa','MA',2111748);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Senador La Rocque','MA',2111763);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Serrano do Maranhão','MA',2111789);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Sítio Novo','MA',2111805);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Sucupira do Norte','MA',2111904);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Sucupira do Riachão','MA',2111953);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Tasso Fragoso','MA',2112001);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Timbiras','MA',2112100);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Timon','MA',2112209);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Trizidela do Vale','MA',2112233);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Tufilândia','MA',2112274);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Tuntum','MA',2112308);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Turiaçu','MA',2112407);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Turilândia','MA',2112456);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Tutóia','MA',2112506);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Urbano Santos','MA',2112605);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Vargem Grande','MA',2112704);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Viana','MA',2112803);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Vila Nova dos Martírios','MA',2112852);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Vitória do Mearim','MA',2112902);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Vitorino Freire','MA',2113009);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Zé Doca','MA',2114007);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Acauã','PI',2200053);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Agricolândia','PI',2200103);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Água Branca','PI',2200202);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Alagoinha do Piauí','PI',2200251);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Alegrete do Piauí','PI',2200277);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Alto Longá','PI',2200301);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Altos','PI',2200400);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Alvorada do Gurguéia','PI',2200459);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Amarante','PI',2200509);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Angical do Piauí','PI',2200608);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Anísio de Abreu','PI',2200707);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Antônio Almeida','PI',2200806);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Aroazes','PI',2200905);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Aroeiras do Itaim','PI',2200954);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Arraial','PI',2201002);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Assunção do Piauí','PI',2201051);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Avelino Lopes','PI',2201101);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Baixa Grande do Ribeiro','PI',2201150);" +
                //"INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Barra D\'Alcântara','PI',2201176);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Barras','PI',2201200);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Barreiras do Piauí','PI',2201309);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Barro Duro','PI',2201408);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Batalha','PI',2201507);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bela Vista do Piauí','PI',2201556);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Belém do Piauí','PI',2201572);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Beneditinos','PI',2201606);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bertolínia','PI',2201705);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Betânia do Piauí','PI',2201739);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Boa Hora','PI',2201770);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bocaina','PI',2201804);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bom Jesus','PI',2201903);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bom Princípio do Piauí','PI',2201919);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bonfim do Piauí','PI',2201929);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Boqueirão do Piauí','PI',2201945);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Brasileira','PI',2201960);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Brejo do Piauí','PI',2201988);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Buriti dos Lopes','PI',2202000);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Buriti dos Montes','PI',2202026);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cabeceiras do Piauí','PI',2202059);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cajazeiras do Piauí','PI',2202075);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cajueiro da Praia','PI',2202083);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Caldeirão Grande do Piauí','PI',2202091);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Campinas do Piauí','PI',2202109);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Campo Alegre do Fidalgo','PI',2202117);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Campo Grande do Piauí','PI',2202133);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Campo Largo do Piauí','PI',2202174);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Campo Maior','PI',2202208);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Canavieira','PI',2202251);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Canto do Buriti','PI',2202307);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Capitão de Campos','PI',2202406);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Capitão Gervásio Oliveira','PI',2202455);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Caracol','PI',2202505);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Caraúbas do Piauí','PI',2202539);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Caridade do Piauí','PI',2202554);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Castelo do Piauí','PI',2202604);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Caxingó','PI',2202653);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cocal','PI',2202703);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cocal de Telha','PI',2202711);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cocal dos Alves','PI',2202729);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Coivaras','PI',2202737);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Colônia do Gurguéia','PI',2202752);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Colônia do Piauí','PI',2202778);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Conceição do Canindé','PI',2202802);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Coronel José Dias','PI',2202851);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Corrente','PI',2202901);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cristalândia do Piauí','PI',2203008);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cristino Castro','PI',2203107);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Curimatá','PI',2203206);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Currais','PI',2203230);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Curralinhos','PI',2203255);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Curral Novo do Piauí','PI',2203271);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Demerval Lobão','PI',2203305);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Dirceu Arcoverde','PI',2203354);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Dom Expedito Lopes','PI',2203404);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Domingos Mourão','PI',2203420);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Dom Inocêncio','PI',2203453);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Elesbão Veloso','PI',2203503);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Eliseu Martins','PI',2203602);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Esperantina','PI',2203701);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Fartura do Piauí','PI',2203750);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Flores do Piauí','PI',2203800);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Floresta do Piauí','PI',2203859);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Floriano','PI',2203909);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Francinópolis','PI',2204006);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Francisco Ayres','PI',2204105);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Francisco Macedo','PI',2204154);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Francisco Santos','PI',2204204);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Fronteiras','PI',2204303);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Geminiano','PI',2204352);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Gilbués','PI',2204402);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Guadalupe','PI',2204501);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Guaribas','PI',2204550);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Hugo Napoleão','PI',2204600);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ilha Grande','PI',2204659);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Inhuma','PI',2204709);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ipiranga do Piauí','PI',2204808);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Isaías Coelho','PI',2204907);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Itainópolis','PI',2205003);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Itaueira','PI',2205102);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Jacobina do Piauí','PI',2205151);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Jaicós','PI',2205201);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Jardim do Mulato','PI',2205250);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Jatobá do Piauí','PI',2205276);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Jerumenha','PI',2205300);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('João Costa','PI',2205359);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Joaquim Pires','PI',2205409);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Joca Marques','PI',2205458);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('José de Freitas','PI',2205508);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Juazeiro do Piauí','PI',2205516);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Júlio Borges','PI',2205524);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Jurema','PI',2205532);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Lagoinha do Piauí','PI',2205540);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Lagoa Alegre','PI',2205557);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Lagoa do Barro do Piauí','PI',2205565);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Lagoa de São Francisco','PI',2205573);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Lagoa do Piauí','PI',2205581);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Lagoa do Sítio','PI',2205599);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Landri Sales','PI',2205607);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Luís Correia','PI',2205706);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Luzilândia','PI',2205805);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Madeiro','PI',2205854);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Manoel Emídio','PI',2205904);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Marcolândia','PI',2205953);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Marcos Parente','PI',2206001);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Massapê do Piauí','PI',2206050);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Matias Olímpio','PI',2206100);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Miguel Alves','PI',2206209);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Miguel Leão','PI',2206308);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Milton Brandão','PI',2206357);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Monsenhor Gil','PI',2206407);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Monsenhor Hipólito','PI',2206506);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Monte Alegre do Piauí','PI',2206605);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Morro Cabeça no Tempo','PI',2206654);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Morro do Chapéu do Piauí','PI',2206670);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Murici dos Portelas','PI',2206696);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Nazaré do Piauí','PI',2206704);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Nazária','PI',2206720);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Nossa Senhora de Nazaré','PI',2206753);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Nossa Senhora dos Remédios','PI',2206803);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Novo Oriente do Piauí','PI',2206902);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Novo Santo Antônio','PI',2206951);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Oeiras','PI',2207009);" +
                //"INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Olho D\'Água do Piauí','PI',2207108);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Padre Marcos','PI',2207207);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Paes Landim','PI',2207306);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pajeú do Piauí','PI',2207355);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Palmeira do Piauí','PI',2207405);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Palmeirais','PI',2207504);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Paquetá','PI',2207553);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Parnaguá','PI',2207603);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Parnaíba','PI',2207702);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Passagem Franca do Piauí','PI',2207751);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Patos do Piauí','PI',2207777);" +
                //"INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pau D\'Arco do Piauí','PI',2207793);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Paulistana','PI',2207801);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pavussu','PI',2207850);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pedro II','PI',2207900);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pedro Laurentino','PI',2207934);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Nova Santa Rita','PI',2207959);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Picos','PI',2208007);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pimenteiras','PI',2208106);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Pio IX','PI',2208205);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Piracuruca','PI',2208304);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Piripiri','PI',2208403);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Porto','PI',2208502);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Porto Alegre do Piauí','PI',2208551);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Prata do Piauí','PI',2208601);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Queimada Nova','PI',2208650);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Redenção do Gurguéia','PI',2208700);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Regeneração','PI',2208809);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Riacho Frio','PI',2208858);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ribeira do Piauí','PI',2208874);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ribeiro Gonçalves','PI',2208908);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Rio Grande do Piauí','PI',2209005);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Cruz do Piauí','PI',2209104);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Cruz dos Milagres','PI',2209153);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Filomena','PI',2209203);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Luz','PI',2209302);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santana do Piauí','PI',2209351);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santa Rosa do Piauí','PI',2209377);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santo Antônio de Lisboa','PI',2209401);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santo Antônio dos Milagres','PI',2209450);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Santo Inácio do Piauí','PI',2209500);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Braz do Piauí','PI',2209559);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Félix do Piauí','PI',2209609);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Francisco de Assis do Piauí','PI',2209658);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Francisco do Piauí','PI',2209708);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Gonçalo do Gurguéia','PI',2209757);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Gonçalo do Piauí','PI',2209807);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São João da Canabrava','PI',2209856);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São João da Fronteira','PI',2209872);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São João da Serra','PI',2209906);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São João da Varjota','PI',2209955);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São João do Arraial','PI',2209971);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São João do Piauí','PI',2210003);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São José do Divino','PI',2210052);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São José do Peixe','PI',2210102);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São José do Piauí','PI',2210201);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Julião','PI',2210300);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Lourenço do Piauí','PI',2210359);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Luis do Piauí','PI',2210375);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Miguel da Baixa Grande','PI',2210383);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Miguel do Fidalgo','PI',2210391);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Miguel do Tapuio','PI',2210409);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Pedro do Piauí','PI',2210508);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('São Raimundo Nonato','PI',2210607);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Sebastião Barros','PI',2210623);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Sebastião Leal','PI',2210631);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Sigefredo Pacheco','PI',2210656);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Simões','PI',2210706);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Simplício Mendes','PI',2210805);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Socorro do Piauí','PI',2210904);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Sussuapara','PI',2210938);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Tamboril do Piauí','PI',2210953);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Tanque do Piauí','PI',2210979);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Teresina','PI',2211001);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('União','PI',2211100);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Uruçuí','PI',2211209);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Valença do Piauí','PI',2211308);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Várzea Branca','PI',2211357);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Várzea Grande','PI',2211407);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Vera Mendes','PI',2211506);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Vila Nova do Piauí','PI',2211605);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Wall Ferraz','PI',2211704);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Abaiara','CE',2300101);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Acarape','CE',2300150);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Acaraú','CE',2300200);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Acopiara','CE',2300309);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Aiuaba','CE',2300408);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Alcântaras','CE',2300507);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Altaneira','CE',2300606);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Alto Santo','CE',2300705);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Amontada','CE',2300754);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Antonina do Norte','CE',2300804);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Apuiarés','CE',2300903);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Aquiraz','CE',2301000);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Aracati','CE',2301109);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Aracoiaba','CE',2301208);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ararendá','CE',2301257);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Araripe','CE',2301307);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Aratuba','CE',2301406);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Arneiroz','CE',2301505);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Assaré','CE',2301604);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Aurora','CE',2301703);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Baixio','CE',2301802);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Banabuiú','CE',2301851);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Barbalha','CE',2301901);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Barreira','CE',2301950);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Barro','CE',2302008);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Barroquinha','CE',2302057);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Baturité','CE',2302107);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Beberibe','CE',2302206);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Bela Cruz','CE',2302305);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Boa Viagem','CE',2302404);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Brejo Santo','CE',2302503);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Camocim','CE',2302602);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Campos Sales','CE',2302701);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Canindé','CE',2302800);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Capistrano','CE',2302909);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Caridade','CE',2303006);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cariré','CE',2303105);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Caririaçu','CE',2303204);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cariús','CE',2303303);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Carnaubal','CE',2303402);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cascavel','CE',2303501);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Catarina','CE',2303600);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Catunda','CE',2303659);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Caucaia','CE',2303709);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cedro','CE',2303808);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Chaval','CE',2303907);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Choró','CE',2303931);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Chorozinho','CE',2303956);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Coreaú','CE',2304004);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Crateús','CE',2304103);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Crato','CE',2304202);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Croatá','CE',2304236);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Cruz','CE',2304251);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Deputado Irapuan Pinheiro','CE',2304269);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ererê','CE',2304277);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Eusébio','CE',2304285);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Farias Brito','CE',2304301);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Forquilha','CE',2304350);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Fortaleza','CE',2304400);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Fortim','CE',2304459);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Frecheirinha','CE',2304509);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('General Sampaio','CE',2304608);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Graça','CE',2304657);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Granja','CE',2304707);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Granjeiro','CE',2304806);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Groaíras','CE',2304905);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Guaiúba','CE',2304954);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Guaraciaba do Norte','CE',2305001);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Guaramiranga','CE',2305100);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Hidrolândia','CE',2305209);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Horizonte','CE',2305233);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ibaretama','CE',2305266);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ibiapina','CE',2305308);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ibicuitinga','CE',2305332);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Icapuí','CE',2305357);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Icó','CE',2305407);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Iguatu','CE',2305506);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Independência','CE',2305605);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ipaporanga','CE',2305654);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ipaumirim','CE',2305704);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ipu','CE',2305803);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Ipueiras','CE',2305902);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Iracema','CE',2306009);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Irauçuba','CE',2306108);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Itaiçaba','CE',2306207);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Itaitinga','CE',2306256);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Itapagé','CE',2306306);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Itapipoca','CE',2306405);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Itapiúna','CE',2306504);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Itarema','CE',2306553);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Itatira','CE',2306603);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Jaguaretama','CE',2306702);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Jaguaribara','CE',2306801);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Jaguaribe','CE',2306900);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Jaguaruana','CE',2307007);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Jardim','CE',2307106);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Jati','CE',2307205);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Jijoca de Jericoacoara','CE',2307254);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Juazeiro do Norte','CE',2307304);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Jucás','CE',2307403);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Lavras da Mangabeira','CE',2307502);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Limoeiro do Norte','CE',2307601);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Madalena','CE',2307635);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Maracanaú','CE',2307650);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Maranguape','CE',2307700);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Marco','CE',2307809);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Martinópole','CE',2307908);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Massapê','CE',2308005);" +
                "INSERT INTO `cidade` (`nome_cidade`,`uf_cidade`,`codigo_cidade`) VALUES ('Mauriti','CE',2308104);", conexao);

                comando.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                throw new Exception("Erro ao popular cidades!" + erro);
            }
            finally
            {
                FecharConexao();
            }
        }


    }
}
