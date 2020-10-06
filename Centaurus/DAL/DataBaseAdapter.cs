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
                " CREATE TABLE IF NOT EXISTS " + nomeBD + ".`viewbuscarproduto` (`ativo_produto` INT, `descontinuado_produto` INT, `tipoitem_produto` INT, `id_produto` INT, `descricao_produto` INT, `unidade_produto` INT, `venda_produto` INT, `saldo_produto` INT, `marca_produto` INT, `categoria_produto` INT, `subcategoria_produto` INT, `fornecedor_produto` INT, `codfabricante_produto` INT, `codbarras_produto` INT, `codinterno_produto` INT, `dataCadastro_produto` INT, `dataAlteracao_produto` INT, `usuarioCadastro_produto` INT, `usuarioAlteracao_produto` INT, `ultimoCustoCompra_produto` INT, `custoAnterior_produto` INT, `custofinal_produto` INT, `descricao_marca` INT, `categoria` INT, `subcategoria` INT, `fornecedor` INT);"+
                /* CREATE VIEW LISTAR LOCAÇÃO ITENS DEV */
                " CREATE TABLE IF NOT EXISTS " + nomeBD + ".`viewlistarlocacaoitensdev` (`IDProduto` INT, `IDProdutoVariacao` INT, `Descricao` INT, `UN` INT, `ValorLocado` INT, `QtdLocada` INT, `QtdDevolvida` INT, `Restante` INT, `Marca` INT, `Categoria` INT, `SubCategoria` INT, `Fornecedor` INT, `Cod.Fabricante` INT, `Cod.Interno` INT, `IDLocacao` INT);"+
                /* CREATE VIEW LISTAR PRODUTOS */
                " CREATE TABLE IF NOT EXISTS " + nomeBD + ".`viewlistarproduto` (`id_produto` INT, `descricao_produto` INT, `unidade_produto` INT, `categoria` INT, `subcategoria` INT, `descricao_marca` INT, `venda_produto` INT, `custo` INT, `saldo_produto` INT, `fornecedor` INT, `codfabricante_produto` INT, `codbarras_produto` INT, `codinterno_produto` INT, `tipoitem` INT);"+
                /* CREATE VIEW LISTAR PRODUTOS COM VARIAÇÃO*/
                " CREATE TABLE IF NOT EXISTS " + nomeBD + ".`viewlistarprodutocomvariacao` (`id_produto` INT, `variacaoproduto` INT, `descricao_produto` INT, `unidade_produto` INT, `custo` INT, `venda_produto` INT, `descricao_marca` INT, `categoria` INT, `subcategoria` INT, `fornecedor` INT, `saldoprincipal` INT, `saldovariacao` INT, `codfabricante_produto` INT, `codbarras_produto` INT, `codinterno_produto` INT, `tipoitem` INT);"+
                /* CREATE VIEW LISTAR VARIAÇÃO */
                " CREATE TABLE IF NOT EXISTS " + nomeBD + ".`viewlistarvariacao` (`idProduto` INT, `unidadeprincipal` INT, `saldoprincipal` INT, `fator_produtovariacao` INT, `multiplovariacao` INT, `unidadevariacao` INT, `saldoVariacao` INT, `codVariacao` INT);"+
                /* CREATE VIEW LOCAÇÃO */
                " CREATE TABLE IF NOT EXISTS " + nomeBD + ".`viewlocacao` (`Codigo` INT, `CodigoCliente` INT, `NomeCliente` INT, `DataLancamento` INT, `DataPrevisaoEntrega` INT, `DataDevolucao` INT, `numerolocacaodev_locacao` INT, `Total` INT, `UsuarioLocacao` INT, `DescontoLocacao` INT, `QtdItensLocacao` INT, `TipoLocacao` INT);"+
                /* CREATE VIEW LOCAÇÃO ITENS */
                " CREATE TABLE IF NOT EXISTS " + nomeBD + ".`viewlocacaoitens` (`Codigo` INT, `CodigoProdutoVariacao` INT, `Descricao` INT, `UN` INT, `QtdLocada` INT, `ValorLocado` INT, `ValorTotal` INT, `Marca` INT, `Categoria` INT, `SubCategoria` INT, `Fornecedor` INT, `idLocacao_locacaoitens` INT, `idlocacaoitens` INT);"+
                /* DROP TABLE VIEW BUSCAR PRODUTO*/
                " DROP TABLE IF EXISTS " + nomeBD + ".`viewbuscarproduto`; "+
                " USE " + nomeBD + "; " +
                " CREATE OR REPLACE ALGORITHM = UNDEFINED DEFINER =`sistema`@`%` SQL SECURITY DEFINER VIEW " + nomeBD + ".`viewbuscarproduto` AS select " + nomeBD + ".`produto`.`ativo_produto` AS `ativo_produto`," + nomeBD + ".`produto`.`descontinuado_produto` AS `descontinuado_produto`," + nomeBD + ".`produto`.`tipoitem_produto` AS `tipoitem_produto`," + nomeBD + ".`produto`.`id_produto` AS `id_produto`," + nomeBD + ".`produto`.`descricao_produto` AS `descricao_produto`," + nomeBD + ".`produto`.`unidade_produto` AS `unidade_produto`," + nomeBD + ".`produto`.`venda_produto` AS `venda_produto`," + nomeBD + ".`produto`.`saldo_produto` AS `saldo_produto`," + nomeBD + ".`produto`.`marca_produto` AS `marca_produto`," + nomeBD + ".`produto`.`categoria_produto` AS `categoria_produto`," + nomeBD + ".`produto`.`subcategoria_produto` AS `subcategoria_produto`," + nomeBD + ".`produto`.`fornecedor_produto` AS `fornecedor_produto`," + nomeBD + ".`produto`.`codfabricante_produto` AS `codfabricante_produto`," + nomeBD + ".`produto`.`codbarras_produto` AS `codbarras_produto`," + nomeBD + ".`produto`.`codinterno_produto` AS `codinterno_produto`," + nomeBD + ".`produto`.`dataCadastro_produto` AS `dataCadastro_produto`," + nomeBD + ".`produto`.`dataAlteracao_produto` AS `dataAlteracao_produto`," + nomeBD + ".`produto`.`usuarioCadastro_produto` AS `usuarioCadastro_produto`," + nomeBD + ".`produto`.`usuarioAlteracao_produto` AS `usuarioAlteracao_produto`," + nomeBD + ".`produto`.`ultimoCustoCompra_produto` AS `ultimoCustoCompra_produto`," + nomeBD + ".`produto`.`custoanterior_produto` AS `custoAnterior_produto`," + nomeBD + ".`produto`.`custofinal_produto` AS `custofinal_produto`,`marc`.`descricao_marca` AS `descricao_marca`,`cat`.`descricao_categoria` AS `categoria`,`subcat`.`descricao_categoria` AS `subcategoria`,`forne`.`nome_fantasia_participante` AS `fornecedor` from((((" + nomeBD + ".`produto` left join " + nomeBD + ".`marca` `marc` on((`marc`.`id_marca` = " + nomeBD + ".`produto`.`marca_produto`))) left join " + nomeBD + ".`categoria` `cat` on((`cat`.`id_categoria` = " + nomeBD + ".`produto`.`categoria_produto`))) left join " + nomeBD + ".`categoria` `subcat` on((`subcat`.`id_categoria` = " + nomeBD + ".`produto`.`subcategoria_produto`))) left join " + nomeBD + ".`participante` `forne` on((`forne`.`id_partipante` = " + nomeBD + ".`produto`.`fornecedor_produto`)));"+
                /* DROP TABLE VIEW LISTAR LOCAÇÃO ITENS DEV */
                " DROP TABLE IF EXISTS " + nomeBD + ".`viewlistarlocacaoitensdev`; " +
                " USE " + nomeBD + "; " +
                " CREATE OR REPLACE ALGORITHM = UNDEFINED DEFINER =`sistema`@`%` SQL SECURITY DEFINER VIEW " + nomeBD + ".`viewlistarlocacaoitensdev` AS select `loci`.`idProduto_locacaoitens` AS `IDProduto`,`loci`.`idVariacaoProduto_locacaoitens` AS `IDProdutoVariacao`,`prod`.`descricao_produto` AS `Descricao`,if ((`loci`.`idVariacaoProduto_locacaoitens` = 0),`prod`.`unidade_produto`,concat(" + nomeBD + ".`produtovariacao`.`unidade_produtovariacao`, '/', " + nomeBD + ".`produtovariacao`.`quantidade_produtovariacao`)) AS `UN`,(`loci`.`valorLocado_locacaoitens` -(select(" + nomeBD + ".`locacao`.`desconto_locacao` / " + nomeBD + ".`locacao`.`qtdItens_locacao`) from " + nomeBD + ".`locacao` where(" + nomeBD + ".`locacao`.`id_locacao` = `loc`.`id_locacao`))) AS `ValorLocado`,`loci`.`qtdLocada_locacaoitens` AS `QtdLocada`,if (((select sum(`locdev`.`qtdLocada_locacaoitens`) from(" + nomeBD + ".`locacaoitens` `locdev` join " + nomeBD + ".`locacao` on((" + nomeBD + ".`locacao`.`id_locacao` = `locdev`.`idLocacao_locacaoitens`))) where((" + nomeBD + ".`locacao`.`numerolocacaodev_locacao` = `loc`.`id_locacao`) and(`loci`.`idProduto_locacaoitens` = `locdev`.`idProduto_locacaoitens`))) <> 0),(select sum(`locdev`.`qtdLocada_locacaoitens`) from(" + nomeBD + ".`locacaoitens` `locdev` join " + nomeBD + ".`locacao` on((" + nomeBD + ".`locacao`.`id_locacao` = `locdev`.`idLocacao_locacaoitens`))) where((" + nomeBD + ".`locacao`.`numerolocacaodev_locacao` = `loc`.`id_locacao`) and(`loci`.`idProduto_locacaoitens` = `locdev`.`idProduto_locacaoitens`))),0) AS `QtdDevolvida`,if (((`loci`.`qtdLocada_locacaoitens` -(select sum(`locdev`.`qtdLocada_locacaoitens`) from(" + nomeBD + ".`locacaoitens` `locdev` join " + nomeBD + ".`locacao` on((" + nomeBD + ".`locacao`.`id_locacao` = `locdev`.`idLocacao_locacaoitens`))) where((" + nomeBD + ".`locacao`.`numerolocacaodev_locacao` = `loc`.`id_locacao`) and(`loci`.`idProduto_locacaoitens` = `locdev`.`idProduto_locacaoitens`)))) = 0),(`loci`.`qtdLocada_locacaoitens` - (select sum(`locdev`.`qtdLocada_locacaoitens`) from (" + nomeBD + ".`locacaoitens` `locdev` join " + nomeBD + ".`locacao` on((" + nomeBD + ".`locacao`.`id_locacao` = `locdev`.`idLocacao_locacaoitens`))) where ((" + nomeBD + ".`locacao`.`numerolocacaodev_locacao` = `loc`.`id_locacao`) and (`loci`.`idProduto_locacaoitens` = `locdev`.`idProduto_locacaoitens`)))),`loci`.`qtdLocada_locacaoitens`) AS `Restante`,`marc`.`descricao_marca` AS `Marca`,`cat`.`descricao_categoria` AS `Categoria`,`subcat`.`descricao_categoria` AS `SubCategoria`,`forn`.`nome_fantasia_participante` AS `Fornecedor`,`prod`.`codfabricante_produto` AS `Cod.Fabricante`,`prod`.`codinterno_produto` AS `Cod.Interno`,`loc`.`id_locacao` AS `IDLocacao` from (((((((" + nomeBD + ".`locacaoitens` `loci` join " + nomeBD + ".`produto` `prod` on((`loci`.`idProduto_locacaoitens` = `prod`.`id_produto`))) left join " + nomeBD + ".`marca` `marc` on((`prod`.`marca_produto` = `marc`.`id_marca`))) left join " + nomeBD + ".`categoria` `cat` on((`cat`.`id_categoria` = `prod`.`categoria_produto`))) left join " + nomeBD + ".`categoria` `subcat` on((`subcat`.`id_categoria` = `prod`.`subcategoria_produto`))) left join " + nomeBD + ".`participante` `forn` on((`forn`.`id_partipante` = `prod`.`fornecedor_produto`))) left join " + nomeBD + ".`produtovariacao` on((" + nomeBD + ".`produtovariacao`.`id_produtovariacao` = `loci`.`idProduto_locacaoitens`))) join " + nomeBD + ".`locacao` `loc` on((`loc`.`id_locacao` = `loci`.`idLocacao_locacaoitens`)));"+
                /* DROP TABLE VIEW LISTAR PRODUTO */
                " DROP TABLE IF EXISTS " + nomeBD + ".`viewlistarproduto`; " +
                " USE " + nomeBD + "; " +
                " CREATE OR REPLACE ALGORITHM = UNDEFINED DEFINER =`sistema`@`%` SQL SECURITY DEFINER VIEW " + nomeBD + ".`viewlistarproduto` AS select `pro`.`id_produto` AS `id_produto`,`pro`.`descricao_produto` AS `descricao_produto`,`pro`.`unidade_produto` AS `unidade_produto`,`cat`.`descricao_categoria` AS `categoria`,`sub`.`descricao_categoria` AS `subcategoria`,`marc`.`descricao_marca` AS `descricao_marca`,`pro`.`venda_produto` AS `venda_produto`,`pro`.`custofinal_produto` AS `custo`,`pro`.`saldo_produto` AS `saldo_produto`,`cli`.`nome_fantasia_participante` AS `fornecedor`,`pro`.`codfabricante_produto` AS `codfabricante_produto`,`pro`.`codbarras_produto` AS `codbarras_produto`,`pro`.`codinterno_produto` AS `codinterno_produto`,`pro`.`tipoitem_produto` AS `tipoitem` from((((" + nomeBD + ".`produto` `pro` left join " + nomeBD + ".`categoria` `cat` on((`pro`.`categoria_produto` = `cat`.`id_categoria`))) left join " + nomeBD + ".`categoria` `sub` on((`pro`.`subcategoria_produto` = `sub`.`id_categoria`))) left join " + nomeBD + ".`participante` `cli` on((`cli`.`id_partipante` = `pro`.`fornecedor_produto`))) left join " + nomeBD + ".`marca` `marc` on((`marc`.`id_marca` = `pro`.`marca_produto`)));"+

                /* DROP TABLE VIEW LISTAR PRODUTO COM VARIAÇÃO */
                //" DROP TABLE IF EXISTS " + nomeBD + ".`viewlistarprodutocomvariacao`; "+
                //" USE " + nomeBD + "; " +
                //" CREATE OR REPLACE ALGORITHM = UNDEFINED DEFINER =`sistema`@`%` SQL SECURITY DEFINER VIEW " + nomeBD + ".`viewlistarprodutocomvariacao` AS select `prod1`.`id_produto` AS `id_produto`,0 AS `variacaoproduto`,`prod1`.`descricao_produto` AS `descricao_produto`,`prod1`.`unidade_produto` AS `unidade_produto`,`prod1`.`custofinal_produto` AS `custo`,`prod1`.`venda_produto` AS `venda_produto`,`marca1`.`descricao_marca` AS `descricao_marca`,`cat1`.`descricao_categoria` AS `categoria`,`subcat1`.`descricao_categoria` AS `subcategoria`,`forn1`.`nome_fantasia_participante` AS `fornecedor`,`prod1`.`saldo_produto` AS `saldoprincipal`,`prod1`.`saldo_produto` AS `saldovariacao`,`prod1`.`codfabricante_produto` AS `codfabricante_produto`,`prod1`.`codbarras_produto` AS `codbarras_produto`,`prod1`.`codinterno_produto` AS `codinterno_produto`,`prod1`.`tipoitem_produto` AS `tipoitem` from((((" + nomeBD + ".`produto` `prod1` left join " + nomeBD + ".`marca` `marca1` on((`marca1`.`id_marca` = `prod1`.`marca_produto`))) left join " + nomeBD + ".`categoria` `cat1` on((`cat1`.`id_categoria` = `prod1`.`categoria_produto`))) left join " + nomeBD + ".`categoria` `subcat1` on((`prod1`.`subcategoria_produto` = `subcat1`.`id_categoria`))) left join " + nomeBD + ".`participante` `forn1` on((`prod1`.`fornecedor_produto` = `forn1`.`id_partipante`))) union all select `prodv`.`idproduto_produtovariacao` AS `idproduto_produtovariacao`,`prodv`.`id_produtovariacao` AS `id_produtovariacao`,`prod2`.`descricao_produto` AS `descricao_produto`,concat(`prodv`.`unidade_produtovariacao`, '/',`prodv`.`quantidade_produtovariacao`) AS `concat(prodv.unidade_produtovariacao, '/', prodv.quantidade_produtovariacao)`,(`prod2`.`custofinal_produto` * `prodv`.`quantidade_produtovariacao`) AS `prod2.custofinal_produto* prodv.quantidade_produtovariacao`,if ((`prodv`.`unidade_produtovariacao` = NULL),`prod2`.`venda_produto`,(`prod2`.`venda_produto` * `prodv`.`quantidade_produtovariacao`)) AS `if(prodv.unidade_produtovariacao = null,prod2.venda_produto,prod2.venda_produto * prodv.quantidade_produtovariacao)`,`marca2`.`descricao_marca` AS `descricao_marca`,`cat2`.`descricao_categoria` AS `descricao_categoria`,`subcat2`.`descricao_categoria` AS `descricao_categoria`,`forn2`.`nome_fantasia_participante` AS `nome_fantasia_participante`,`prod2`.`saldo_produto` AS `saldo_produto`,if((`prodv`.`fator_produtovariacao` = 'X'),(`prod2`.`saldo_produto` * `prodv`.`quantidade_produtovariacao`),(`prod2`.`saldo_produto` / `prodv`.`quantidade_produtovariacao`)) AS `if(prodv.fator_produtovariacao = 'X',prod2.saldo_produto * prodv.quantidade_produtovariacao ,prod2.saldo_produto / prodv.quantidade_produtovariacao)`,`prod2`.`codfabricante_produto` AS `codfabricante_produto`,`prodv`.`codbarras_produtovariacao` AS `codbarras_produtovariacao`,`prod2`.`codinterno_produto` AS `codinterno_produto`,`prod2`.`tipoitem_produto` AS `tipoitem_produto` from (((((" + nomeBD + ".`produtovariacao` `prodv` join " + nomeBD + ".`produto` `prod2` on((`prod2`.`id_produto` = `prodv`.`idproduto_produtovariacao`))) left join " + nomeBD + ".`marca` `marca2` on((`prod2`.`marca_produto` = `marca2`.`id_marca`))) left join " + nomeBD + ".`categoria` `cat2` on((`prod2`.`categoria_produto` = `cat2`.`id_categoria`))) left join " + nomeBD + ".`categoria` `subcat2` on((`prod2`.`subcategoria_produto` = `subcat2`.`id_categoria`))) left join " + nomeBD + ".`participante` `forn2` on((`prod2`.`fornecedor_produto` = `forn2`.`id_partipante`))) order by `id_produto`; "+


                /* DROP TABLE VIEW LISTAR VARIAÇÃO */
                " DROP TABLE IF EXISTS " + nomeBD + ".`viewlistarvariacao`; " +
                " USE " + nomeBD + "; " +
                " CREATE OR REPLACE ALGORITHM = UNDEFINED DEFINER =`sistema`@`%` SQL SECURITY DEFINER VIEW " + nomeBD + ".`viewlistarvariacao` AS select " + nomeBD + ".`produto`.`id_produto` AS `idProduto`," + nomeBD + ".`produto`.`unidade_produto` AS `unidadeprincipal`," + nomeBD + ".`produto`.`saldo_produto` AS `saldoprincipal`," + nomeBD + ".`produtovariacao`.`fator_produtovariacao` AS `fator_produtovariacao`," + nomeBD + ".`produtovariacao`.`quantidade_produtovariacao` AS `multiplovariacao`," + nomeBD + ".`produtovariacao`.`unidade_produtovariacao` AS `unidadevariacao`,if ((" + nomeBD + ".`produtovariacao`.`fator_produtovariacao` = 'X'),(" + nomeBD + ".`produto`.`saldo_produto` *" + nomeBD + ".`produtovariacao`.`quantidade_produtovariacao`),(" + nomeBD + ".`produto`.`saldo_produto` / " + nomeBD + ".`produtovariacao`.`quantidade_produtovariacao`)) AS `saldoVariacao`," + nomeBD + ".`produtovariacao`.`id_produtovariacao` AS `codVariacao` from(" + nomeBD + ".`produto` join " + nomeBD + ".`produtovariacao` on((" + nomeBD + ".`produtovariacao`.`idproduto_produtovariacao` = " + nomeBD + ".`produto`.`id_produto`)));"+
                /* DROP TABLE VIEW LOCAÇÃO */
                " DROP TABLE IF EXISTS " + nomeBD + ".`viewlocacao`; " +
                " USE " + nomeBD + "; " +
                " CREATE OR REPLACE ALGORITHM = UNDEFINED DEFINER =`sistema`@`%` SQL SECURITY DEFINER VIEW " + nomeBD + ".`viewlocacao` AS select `loc`.`id_locacao` AS `Codigo`,`loc`.`idCliente_locacao` AS `CodigoCliente`,`cli`.`nome_fantasia_participante` AS `NomeCliente`,`loc`.`dataLancamento_locacao` AS `DataLancamento`,`loc`.`dataPrevisaoEntrega_locacao` AS `DataPrevisaoEntrega`,`loc`.`dataDevolucao_locacao` AS `DataDevolucao`,`loc`.`numerolocacaodev_locacao` AS `numerolocacaodev_locacao`,`loc`.`total_locacao` AS `Total`,`loc`.`usuario_locacao` AS `UsuarioLocacao`,`loc`.`desconto_locacao` AS `DescontoLocacao`,`loc`.`qtdItens_locacao` AS `QtdItensLocacao`,`loc`.`tipo_locacao` AS `TipoLocacao` from(" + nomeBD + ".`locacao` `loc` join " + nomeBD + ".`participante` `cli` on((`cli`.`id_partipante` = `loc`.`idCliente_locacao`)));"+
                /* DROP TABLE VIEW LOCAÇÃO ITENS */
                " DROP TABLE IF EXISTS " + nomeBD + ".`viewlocacaoitens`; " +
                " USE " + nomeBD + "; " +
                " CREATE OR REPLACE ALGORITHM = UNDEFINED DEFINER =`sistema`@`%` SQL SECURITY DEFINER VIEW " + nomeBD + ".`viewlocacaoitens` AS select " + nomeBD + ".`locacaoitens`.`idProduto_locacaoitens` AS `Codigo`," + nomeBD + ".`locacaoitens`.`idVariacaoProduto_locacaoitens` AS `CodigoProdutoVariacao`," + nomeBD + ".`produto`.`descricao_produto` AS `Descricao`,if ((" + nomeBD + ".`locacaoitens`.`idVariacaoProduto_locacaoitens` = 0)," + nomeBD + ".`produto`.`unidade_produto`," + nomeBD + ".`produtovariacao`.`unidade_produtovariacao`) AS `UN`," + nomeBD + ".`locacaoitens`.`qtdLocada_locacaoitens` AS `QtdLocada`," + nomeBD + ".`locacaoitens`.`valorLocado_locacaoitens` AS `ValorLocado`,(" + nomeBD + ".`locacaoitens`.`valorLocado_locacaoitens` *" + nomeBD + ".`locacaoitens`.`qtdLocada_locacaoitens`) AS `ValorTotal`," + nomeBD + ".`marca`.`descricao_marca` AS `Marca`,`cat`.`descricao_categoria` AS `Categoria`,`subcat`.`descricao_categoria` AS `SubCategoria`," + nomeBD + ".`participante`.`nome_fantasia_participante` AS `Fornecedor`," + nomeBD + ".`locacaoitens`.`idLocacao_locacaoitens` AS `idLocacao_locacaoitens`," + nomeBD + ".`locacaoitens`.`id_locacaoitens` AS `idlocacaoitens` from((((((" + nomeBD + ".`locacaoitens` left join " + nomeBD + ".`produtovariacao` on((" + nomeBD + ".`produtovariacao`.`id_produtovariacao` = " + nomeBD + ".`locacaoitens`.`idProduto_locacaoitens`))) join " + nomeBD + ".`produto` on((" + nomeBD + ".`produto`.`id_produto` = " + nomeBD + ".`locacaoitens`.`idProduto_locacaoitens`))) left join " + nomeBD + ".`marca` on((" + nomeBD + ".`marca`.`id_marca` = " + nomeBD + ".`produto`.`marca_produto`))) left join " + nomeBD + ".`categoria` `cat` on((`cat`.`id_categoria` = " + nomeBD + ".`produto`.`categoria_produto`))) left join " + nomeBD + ".`categoria` `subcat` on((`subcat`.`id_categoria` = " + nomeBD + ".`produto`.`subcategoria_produto`))) left join " + nomeBD + ".`participante` on((" + nomeBD + ".`participante`.`id_partipante` = " + nomeBD + ".`produto`.`fornecedor_produto`)));" +
                " USE " + nomeBD + "; "+
                /* CREATE TRIGGER DELETE LOCAÇÃO*/
                " CREATE DEFINER = CURRENT_USER TRIGGER " + nomeBD + ".`locacao_BEFORE_DELETE` BEFORE DELETE ON `locacao` FOR EACH ROW " +
                " BEGIN " +
                " delete from locacaoitens where idLocacao_locacaoitens = OLD.id_locacao; " +
                "                END", conexao);



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
