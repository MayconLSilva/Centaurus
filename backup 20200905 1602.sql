-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.5.21


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema centaurus
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ centaurus;
USE centaurus;

--
-- Table structure for table `centaurus`.`categoria`
--

DROP TABLE IF EXISTS `categoria`;
CREATE TABLE `categoria` (
  `id_categoria` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `descricao_categoria` varchar(45) DEFAULT NULL,
  `dataCadastro_categoria` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `ativo_categoria` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `tipo_categoria` char(1) DEFAULT NULL,
  PRIMARY KEY (`id_categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `centaurus`.`categoria`
--

/*!40000 ALTER TABLE `categoria` DISABLE KEYS */;
INSERT INTO `categoria` (`id_categoria`,`descricao_categoria`,`dataCadastro_categoria`,`ativo_categoria`,`tipo_categoria`) VALUES 
 (12,'categoria1','2020-08-21 11:34:34',1,NULL),
 (13,'categoria2','2020-08-21 11:35:08',0,'C'),
 (14,'concategoria','2020-08-21 11:36:38',0,'S'),
 (15,'5555','2020-08-22 14:19:37',1,'S'),
 (17,'789456','2020-08-22 14:23:53',1,'C'),
 (18,'ROUPAS','2020-08-22 14:37:58',1,'C'),
 (19,'sapatatos','2020-08-22 14:38:40',1,'S');
/*!40000 ALTER TABLE `categoria` ENABLE KEYS */;


--
-- Table structure for table `centaurus`.`cidade`
--

DROP TABLE IF EXISTS `cidade`;
CREATE TABLE `cidade` (
  `id_cidade` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nome_cidade` varchar(45) DEFAULT NULL,
  `uf_cidade` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_cidade`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `centaurus`.`cidade`
--

/*!40000 ALTER TABLE `cidade` DISABLE KEYS */;
INSERT INTO `cidade` (`id_cidade`,`nome_cidade`,`uf_cidade`) VALUES 
 (1,'Cornélio Procópio','PR'),
 (2,'Londrina','PR'),
 (3,'São Paulo','SP');
/*!40000 ALTER TABLE `cidade` ENABLE KEYS */;


--
-- Table structure for table `centaurus`.`locacao`
--

DROP TABLE IF EXISTS `locacao`;
CREATE TABLE `locacao` (
  `id_locacao` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `dataLancamento_locacao` datetime NOT NULL DEFAULT '0000-00-00 00:00:00',
  `dataEntrega_locacao` datetime NOT NULL DEFAULT '0000-00-00 00:00:00',
  `idCliente_locacao` int(10) unsigned DEFAULT NULL,
  `desconto_locacao` float DEFAULT NULL,
  `qtdItens_locacao` double DEFAULT NULL,
  `total_locacao` float DEFAULT NULL,
  `tipo_locacao` char(1) DEFAULT NULL,
  `numerolocacaodev_locacao` int(10) unsigned DEFAULT NULL,
  PRIMARY KEY (`id_locacao`),
  KEY `FK_locacao_cliente` (`idCliente_locacao`),
  CONSTRAINT `FK_locacao_cliente` FOREIGN KEY (`idCliente_locacao`) REFERENCES `participante` (`id_partipante`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `centaurus`.`locacao`
--

/*!40000 ALTER TABLE `locacao` DISABLE KEYS */;
INSERT INTO `locacao` (`id_locacao`,`dataLancamento_locacao`,`dataEntrega_locacao`,`idCliente_locacao`,`desconto_locacao`,`qtdItens_locacao`,`total_locacao`,`tipo_locacao`,`numerolocacaodev_locacao`) VALUES 
 (1,'2020-09-02 19:04:13','2020-09-25 19:04:12',1,0,0,0,NULL,NULL),
 (2,'2020-09-02 19:12:51','2020-09-30 19:12:50',1,0,0,0,NULL,NULL),
 (3,'2020-09-05 11:15:42','2020-09-05 11:15:41',9,0,0,0,NULL,NULL);
/*!40000 ALTER TABLE `locacao` ENABLE KEYS */;


--
-- Table structure for table `centaurus`.`marca`
--

DROP TABLE IF EXISTS `marca`;
CREATE TABLE `marca` (
  `id_marca` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `descricao_marca` varchar(45) DEFAULT NULL,
  `dataCadastro_marca` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `ativo_marca` tinyint(3) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_marca`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `centaurus`.`marca`
--

/*!40000 ALTER TABLE `marca` DISABLE KEYS */;
INSERT INTO `marca` (`id_marca`,`descricao_marca`,`dataCadastro_marca`,`ativo_marca`) VALUES 
 (1,'sapolio','2020-08-07 20:22:48',0),
 (2,'teste2','2020-08-07 20:22:48',0),
 (3,'Palmolive','2020-08-07 20:58:20',1),
 (4,'Lacta','2020-08-08 12:06:30',1),
 (5,'teste2','2020-08-08 12:09:47',0),
 (6,'teste3','2020-08-08 12:13:13',0),
 (7,'marcabela','2020-08-08 12:27:24',1),
 (9,'muitoboa2','2020-08-08 12:29:56',1),
 (10,'agoravai2','2020-08-08 12:32:42',1),
 (12,'maramarca','2020-08-25 17:41:35',1);
/*!40000 ALTER TABLE `marca` ENABLE KEYS */;


--
-- Table structure for table `centaurus`.`participante`
--

DROP TABLE IF EXISTS `participante`;
CREATE TABLE `participante` (
  `id_partipante` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `nome_fantasia_participante` varchar(45) DEFAULT NULL,
  `apelido_razao_participante` varchar(45) DEFAULT NULL,
  `cpf_cnpj_participante` varchar(45) DEFAULT NULL,
  `rg_ie_participante` varchar(45) DEFAULT NULL,
  `endereco_participante` varchar(45) DEFAULT NULL,
  `numeroendereco_participante` varchar(45) DEFAULT NULL,
  `bairro_participante` varchar(45) DEFAULT NULL,
  `cidade_participante` varchar(45) DEFAULT NULL,
  `cep_participante` varchar(45) DEFAULT NULL,
  `telefone_participante` varchar(45) DEFAULT NULL,
  `celular_participante` varchar(45) DEFAULT NULL,
  `uf_partipante` varchar(45) DEFAULT NULL,
  `email_partipante` varchar(45) DEFAULT NULL,
  `datacadastro_participante` varchar(10) DEFAULT NULL,
  `dataalteracao_partipante` varchar(10) DEFAULT NULL,
  `usuariocadastro_partipante` varchar(45) DEFAULT NULL,
  `usuarioalteracao_partipante` varchar(45) DEFAULT NULL,
  `tipocliente_participante` tinyint(1) DEFAULT NULL,
  `tipofornecedor_participante` tinyint(1) DEFAULT NULL,
  `tipofuncionario_participante` tinyint(1) DEFAULT NULL,
  `ativo_participante` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_partipante`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `centaurus`.`participante`
--

/*!40000 ALTER TABLE `participante` DISABLE KEYS */;
INSERT INTO `participante` (`id_partipante`,`nome_fantasia_participante`,`apelido_razao_participante`,`cpf_cnpj_participante`,`rg_ie_participante`,`endereco_participante`,`numeroendereco_participante`,`bairro_participante`,`cidade_participante`,`cep_participante`,`telefone_participante`,`celular_participante`,`uf_partipante`,`email_partipante`,`datacadastro_participante`,`dataalteracao_partipante`,`usuariocadastro_partipante`,`usuarioalteracao_partipante`,`tipocliente_participante`,`tipofornecedor_participante`,`tipofuncionario_participante`,`ativo_participante`) VALUES 
 (1,'Maycon Luis da Silva','maycon silvio santos','06.366.666/6666-66','666','rua teste','1111','centro','São Paulo','86.300-000','(43)3524-3334','(44)4.4444-4444','SP','aaa','20/07/2020','22/07/2020',NULL,NULL,1,1,0,1),
 (2,'Maycon Silva','maycon silva','069.900.239-70','10.695','rua tangara','101','centro','cornelio','pr','433524','9999','','a@hotmail.com','20/07/2020','22/07/2020',NULL,NULL,1,1,0,1),
 (3,'Fábio','dd','ddd','dd','ddd','dd','dd','dd','dd','ddd','dd','dd','dd','20/07/2020',NULL,NULL,NULL,1,1,0,1),
 (5,'Mauricio','nome do mauricio','44.444.444/4444-44','444444','rua teste','11','','São Paulo','SP','433)3333-3333','333)3.3333-3333','SP','tstse@teste.com.br','20/07/2020','27/07/2020',NULL,NULL,0,1,0,1);
INSERT INTO `participante` (`id_partipante`,`nome_fantasia_participante`,`apelido_razao_participante`,`cpf_cnpj_participante`,`rg_ie_participante`,`endereco_participante`,`numeroendereco_participante`,`bairro_participante`,`cidade_participante`,`cep_participante`,`telefone_participante`,`celular_participante`,`uf_partipante`,`email_partipante`,`datacadastro_participante`,`dataalteracao_partipante`,`usuariocadastro_partipante`,`usuarioalteracao_partipante`,`tipocliente_participante`,`tipofornecedor_participante`,`tipofuncionario_participante`,`ativo_participante`) VALUES 
 (9,'Marcio Antonio','marcio antonio','069.900.239-70','125555','rua tet','101','','Londrina','PR','(43)3524-2521','(43)9.9101-6440','PR','marcio','28/07/2020','23/08/2020',NULL,NULL,1,0,0,1),
 (10,'Fernandes','22222','22.222.222/2222-22','222','222','22','22','','22.222-222','(22)2222-2222','(22)2.2222-2222','','222222222','28/07/2020',NULL,NULL,NULL,0,1,0,0),
 (11,'Dapynne','55555555','99.999.999/9999-99','9999999','99999','9','999','','86.666-666','(55)5','(55)5.5555-5555','SE','555555','28/07/2020',NULL,NULL,NULL,0,1,0,1),
 (12,'Caroline','2222','22.222.222/2222-22','2222','22','2','22','','22.222-222','(22)2222-2222','(22)2.2222-2222','SE','222222','28/07/2020',NULL,NULL,NULL,0,0,1,1);
INSERT INTO `participante` (`id_partipante`,`nome_fantasia_participante`,`apelido_razao_participante`,`cpf_cnpj_participante`,`rg_ie_participante`,`endereco_participante`,`numeroendereco_participante`,`bairro_participante`,`cidade_participante`,`cep_participante`,`telefone_participante`,`celular_participante`,`uf_partipante`,`email_partipante`,`datacadastro_participante`,`dataalteracao_partipante`,`usuariocadastro_partipante`,`usuarioalteracao_partipante`,`tipocliente_participante`,`tipofornecedor_participante`,`tipofuncionario_participante`,`ativo_participante`) VALUES 
 (15,'João Gabriel','aaaaaaa','18.423.052/0001-36','666','666','66','','','RR','(66)6666-6666','(66)6.6666-6666','RR','6666','03/08/2020','04/08/2020',NULL,NULL,1,0,0,1),
 (17,'Victor','','666666666666','666666','66666','66','6666','','','','','','','03/08/2020',NULL,NULL,NULL,0,0,1,0),
 (18,'Manoel','','44.444.444/4444-44','4444','4444','44','444','','','','','','','03/08/2020',NULL,NULL,NULL,0,0,1,0),
 (19,'Willian','','00.000.000/0000-00','0000','5252525252525252','222','222','','','','','','','03/08/2020',NULL,NULL,NULL,0,1,0,0),
 (21,'Camargo','','444.444.444-44','444','si','44','','','','','','','','03/08/2020',NULL,NULL,NULL,0,1,0,0);
INSERT INTO `participante` (`id_partipante`,`nome_fantasia_participante`,`apelido_razao_participante`,`cpf_cnpj_participante`,`rg_ie_participante`,`endereco_participante`,`numeroendereco_participante`,`bairro_participante`,`cidade_participante`,`cep_participante`,`telefone_participante`,`celular_participante`,`uf_partipante`,`email_partipante`,`datacadastro_participante`,`dataalteracao_partipante`,`usuariocadastro_partipante`,`usuarioalteracao_partipante`,`tipocliente_participante`,`tipofornecedor_participante`,`tipofuncionario_participante`,`ativo_participante`) VALUES 
 (22,'Maralena','mara','069.900.239-70','isento','rua tangara','101','centro','','86.300-000','(43)3524-2521','(43)9.9101-6440','RR','maralenamara@hotmail.com','03/08/2020',NULL,NULL,NULL,1,0,0,1),
 (23,'Dayanne','','069.900.239-70','10','rua santa','10','centro','Cornélio Procópio','86.300-000','(43)3524-2521','(43)3.3333-3333','PR','','06/08/2020',NULL,NULL,NULL,0,0,1,1);
/*!40000 ALTER TABLE `participante` ENABLE KEYS */;


--
-- Table structure for table `centaurus`.`produto`
--

DROP TABLE IF EXISTS `produto`;
CREATE TABLE `produto` (
  `id_produto` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `ativo_produto` tinyint(3) unsigned NOT NULL DEFAULT '0',
  `descontinuado_produto` tinyint(3) unsigned DEFAULT NULL,
  `tipoitem_produto` char(1) DEFAULT NULL,
  `descricao_produto` varchar(45) DEFAULT NULL,
  `unidade_produto` varchar(3) NOT NULL DEFAULT '',
  `venda_produto` float DEFAULT NULL,
  `saldo_produto` double DEFAULT NULL,
  `marca_produto` int(10) unsigned DEFAULT NULL,
  `categoria_produto` int(10) unsigned DEFAULT NULL,
  `subcategoria_produto` int(10) unsigned DEFAULT NULL,
  `fornecedor_produto` int(10) unsigned DEFAULT NULL,
  `codfabricante_produto` varchar(45) DEFAULT NULL,
  `codbarras_produto` int(10) unsigned DEFAULT NULL,
  `codinterno_produto` varchar(45) DEFAULT NULL,
  `dataCadastro_produto` varchar(45) DEFAULT NULL,
  `dataAlteracao_produto` varchar(45) DEFAULT NULL,
  `usuarioCadastro_produto` varchar(45) DEFAULT NULL,
  `usuarioAlteracao_produto` varchar(45) DEFAULT NULL,
  `ultimoCustoCompra_produto` float DEFAULT NULL,
  `custoanterior_produto` float DEFAULT NULL,
  `custofinal_produto` float DEFAULT NULL,
  PRIMARY KEY (`id_produto`),
  KEY `FK_produto_marca` (`marca_produto`),
  KEY `FK_produto_fornecedor` (`fornecedor_produto`),
  KEY `FK_produto_categoria` (`categoria_produto`),
  KEY `FK_produto_subcategoria` (`subcategoria_produto`),
  CONSTRAINT `FK_produto_categoria` FOREIGN KEY (`categoria_produto`) REFERENCES `categoria` (`id_categoria`),
  CONSTRAINT `FK_produto_fornecedor` FOREIGN KEY (`fornecedor_produto`) REFERENCES `participante` (`id_partipante`),
  CONSTRAINT `FK_produto_marca` FOREIGN KEY (`marca_produto`) REFERENCES `marca` (`id_marca`),
  CONSTRAINT `FK_produto_subcategoria` FOREIGN KEY (`subcategoria_produto`) REFERENCES `categoria` (`id_categoria`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `centaurus`.`produto`
--

/*!40000 ALTER TABLE `produto` DISABLE KEYS */;
INSERT INTO `produto` (`id_produto`,`ativo_produto`,`descontinuado_produto`,`tipoitem_produto`,`descricao_produto`,`unidade_produto`,`venda_produto`,`saldo_produto`,`marca_produto`,`categoria_produto`,`subcategoria_produto`,`fornecedor_produto`,`codfabricante_produto`,`codbarras_produto`,`codinterno_produto`,`dataCadastro_produto`,`dataAlteracao_produto`,`usuarioCadastro_produto`,`usuarioAlteracao_produto`,`ultimoCustoCompra_produto`,`custoanterior_produto`,`custofinal_produto`) VALUES 
 (1,1,0,'P','Detergente Ype','UN',5,1200,NULL,NULL,NULL,NULL,'123',789,'589','24/08/2020','','','',0,0,55),
 (2,1,0,'P','Areia fina','MT',10,5000,7,18,19,1,'456',7894,'123','24/08/2020','','','',NULL,NULL,56),
 (3,0,1,'P','Farinha de trigo','PCT',15,60,3,18,19,2,'456',789,'444','24/08/2020',NULL,'',NULL,NULL,NULL,65),
 (4,1,0,'P','Produto teste4','UN',20,4,6,18,19,2,'777',7894561,'22','24/08/2020',NULL,'',NULL,NULL,NULL,66),
 (5,1,0,'S','PRODUTO TESTE 6','UN',25,7,9,18,19,5,'777',789456123,'1234','24/08/2020',NULL,'',NULL,NULL,NULL,55),
 (6,1,0,'P','produto teste 7','UN',30,36,NULL,18,14,NULL,'',44,'','25/08/2020',NULL,'',NULL,NULL,NULL,5);
INSERT INTO `produto` (`id_produto`,`ativo_produto`,`descontinuado_produto`,`tipoitem_produto`,`descricao_produto`,`unidade_produto`,`venda_produto`,`saldo_produto`,`marca_produto`,`categoria_produto`,`subcategoria_produto`,`fornecedor_produto`,`codfabricante_produto`,`codbarras_produto`,`codinterno_produto`,`dataCadastro_produto`,`dataAlteracao_produto`,`usuarioCadastro_produto`,`usuarioAlteracao_produto`,`ultimoCustoCompra_produto`,`custoanterior_produto`,`custofinal_produto`) VALUES 
 (7,0,1,'P','produto teste 7','UN',35,15,NULL,18,14,NULL,'',NULL,'','25/08/2020',NULL,'',NULL,NULL,NULL,5),
 (8,0,0,'S','produto teste 8','UN',40,2,NULL,18,14,NULL,'',NULL,'','25/08/2020',NULL,'',NULL,NULL,NULL,5),
 (9,1,0,'P','produto teste 9','UN',45,26,NULL,18,19,NULL,'',NULL,'','25/08/2020',NULL,'',NULL,NULL,NULL,0),
 (10,1,0,'S','produto teste 10','UN',50,2,NULL,18,19,NULL,'',NULL,'','25/08/2020',NULL,'',NULL,NULL,NULL,0),
 (11,1,0,'P','produto teste 11','UN',55,3,NULL,18,19,NULL,'',NULL,'','25/08/2020',NULL,'',NULL,NULL,NULL,0),
 (12,1,0,'P','produto 12','UN',60,5,NULL,18,19,NULL,'',NULL,'','25/08/2020',NULL,'',NULL,NULL,NULL,0);
INSERT INTO `produto` (`id_produto`,`ativo_produto`,`descontinuado_produto`,`tipoitem_produto`,`descricao_produto`,`unidade_produto`,`venda_produto`,`saldo_produto`,`marca_produto`,`categoria_produto`,`subcategoria_produto`,`fornecedor_produto`,`codfabricante_produto`,`codbarras_produto`,`codinterno_produto`,`dataCadastro_produto`,`dataAlteracao_produto`,`usuarioCadastro_produto`,`usuarioAlteracao_produto`,`ultimoCustoCompra_produto`,`custoanterior_produto`,`custofinal_produto`) VALUES 
 (13,1,0,'P','produto teste 13','UN',65,10,4,18,19,5,'123',789456,'123','25/08/2020',NULL,'',NULL,NULL,NULL,5),
 (14,1,0,'P','valor de venda','UN',70,20,NULL,18,14,NULL,'',NULL,'','25/08/2020',NULL,'',NULL,NULL,NULL,56),
 (15,1,0,'P','Pó Royal','UN',50,NULL,7,17,14,5,'',NULL,'','02/09/2020',NULL,'',NULL,NULL,NULL,25);
/*!40000 ALTER TABLE `produto` ENABLE KEYS */;


--
-- Table structure for table `centaurus`.`produtovariacao`
--

DROP TABLE IF EXISTS `produtovariacao`;
CREATE TABLE `produtovariacao` (
  `id_produtovariacao` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idproduto_produtovariacao` int(10) unsigned DEFAULT NULL,
  `unidade_produtovariacao` varchar(3) NOT NULL DEFAULT '',
  `fator_produtovariacao` char(1) DEFAULT NULL,
  `quantidade_produtovariacao` double DEFAULT NULL,
  `codbarras_produtovariacao` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`id_produtovariacao`),
  KEY `FK_produtovariacao_produto` (`idproduto_produtovariacao`),
  CONSTRAINT `FK_produtovariacao_produto` FOREIGN KEY (`idproduto_produtovariacao`) REFERENCES `produto` (`id_produto`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `centaurus`.`produtovariacao`
--

/*!40000 ALTER TABLE `produtovariacao` DISABLE KEYS */;
INSERT INTO `produtovariacao` (`id_produtovariacao`,`idproduto_produtovariacao`,`unidade_produtovariacao`,`fator_produtovariacao`,`quantidade_produtovariacao`,`codbarras_produtovariacao`) VALUES 
 (1,1,'CX','/',24,'1234567891234'),
 (2,2,'LTA','/',57,'1234567891238'),
 (3,3,'KG','X',5,'1234567891237'),
 (6,1,'CX','/',12,'1234567892345'),
 (7,1,'CX','/',48,'1234567891236');
/*!40000 ALTER TABLE `produtovariacao` ENABLE KEYS */;


--
-- View structure for view `centaurus`.`viewbuscarproduto`
--

DROP VIEW IF EXISTS `viewbuscarproduto`;
CREATE ALGORITHM=UNDEFINED DEFINER=`sistema`@`%` SQL SECURITY DEFINER VIEW `centaurus`.`viewbuscarproduto` AS select `centaurus`.`produto`.`ativo_produto` AS `ativo_produto`,`centaurus`.`produto`.`descontinuado_produto` AS `descontinuado_produto`,`centaurus`.`produto`.`tipoitem_produto` AS `tipoitem_produto`,`centaurus`.`produto`.`id_produto` AS `id_produto`,`centaurus`.`produto`.`descricao_produto` AS `descricao_produto`,`centaurus`.`produto`.`unidade_produto` AS `unidade_produto`,`centaurus`.`produto`.`venda_produto` AS `venda_produto`,`centaurus`.`produto`.`saldo_produto` AS `saldo_produto`,`centaurus`.`produto`.`marca_produto` AS `marca_produto`,`centaurus`.`produto`.`categoria_produto` AS `categoria_produto`,`centaurus`.`produto`.`subcategoria_produto` AS `subcategoria_produto`,`centaurus`.`produto`.`fornecedor_produto` AS `fornecedor_produto`,`centaurus`.`produto`.`codfabricante_produto` AS `codfabricante_produto`,`centaurus`.`produto`.`codbarras_produto` AS `codbarras_produto`,`centaurus`.`produto`.`codinterno_produto` AS `codinterno_produto`,`centaurus`.`produto`.`dataCadastro_produto` AS `dataCadastro_produto`,`centaurus`.`produto`.`dataAlteracao_produto` AS `dataAlteracao_produto`,`centaurus`.`produto`.`usuarioCadastro_produto` AS `usuarioCadastro_produto`,`centaurus`.`produto`.`usuarioAlteracao_produto` AS `usuarioAlteracao_produto`,`centaurus`.`produto`.`ultimoCustoCompra_produto` AS `ultimoCustoCompra_produto`,`centaurus`.`produto`.`custoanterior_produto` AS `custoAnterior_produto`,`centaurus`.`produto`.`custofinal_produto` AS `custofinal_produto`,`marc`.`descricao_marca` AS `descricao_marca`,`cat`.`descricao_categoria` AS `categoria`,`subcat`.`descricao_categoria` AS `subcategoria`,`forne`.`nome_fantasia_participante` AS `fornecedor` from ((((`centaurus`.`produto` left join `centaurus`.`marca` `marc` on((`marc`.`id_marca` = `centaurus`.`produto`.`marca_produto`))) left join `centaurus`.`categoria` `cat` on((`cat`.`id_categoria` = `centaurus`.`produto`.`categoria_produto`))) left join `centaurus`.`categoria` `subcat` on((`subcat`.`id_categoria` = `centaurus`.`produto`.`subcategoria_produto`))) left join `centaurus`.`participante` `forne` on((`forne`.`id_partipante` = `centaurus`.`produto`.`fornecedor_produto`)));


--
-- View structure for view `centaurus`.`viewlistarproduto`
--

DROP VIEW IF EXISTS `viewlistarproduto`;
CREATE ALGORITHM=UNDEFINED DEFINER=`sistema`@`%` SQL SECURITY DEFINER VIEW `centaurus`.`viewlistarproduto` AS select `pro`.`id_produto` AS `id_produto`,`pro`.`descricao_produto` AS `descricao_produto`,`pro`.`unidade_produto` AS `unidade_produto`,`cat`.`descricao_categoria` AS `categoria`,`sub`.`descricao_categoria` AS `subcategoria`,`marc`.`descricao_marca` AS `descricao_marca`,`pro`.`venda_produto` AS `venda_produto`,`pro`.`saldo_produto` AS `saldo_produto`,`cli`.`nome_fantasia_participante` AS `fornecedor`,`pro`.`codfabricante_produto` AS `codfabricante_produto`,`pro`.`codbarras_produto` AS `codbarras_produto`,`pro`.`codinterno_produto` AS `codinterno_produto`,`pro`.`tipoitem_produto` AS `tipoitem` from ((((`centaurus`.`produto` `pro` left join `centaurus`.`categoria` `cat` on((`pro`.`categoria_produto` = `cat`.`id_categoria`))) left join `centaurus`.`categoria` `sub` on((`pro`.`subcategoria_produto` = `sub`.`id_categoria`))) left join `centaurus`.`participante` `cli` on((`cli`.`id_partipante` = `pro`.`fornecedor_produto`))) left join `centaurus`.`marca` `marc` on((`marc`.`id_marca` = `pro`.`marca_produto`)));


--
-- View structure for view `centaurus`.`viewlistarvariacao`
--

DROP VIEW IF EXISTS `viewlistarvariacao`;
CREATE ALGORITHM=UNDEFINED DEFINER=`sistema`@`%` SQL SECURITY DEFINER VIEW `centaurus`.`viewlistarvariacao` AS select `centaurus`.`produto`.`id_produto` AS `idProduto`,`centaurus`.`produto`.`unidade_produto` AS `unidadeprincipal`,`centaurus`.`produto`.`saldo_produto` AS `saldoprincipal`,`centaurus`.`produtovariacao`.`fator_produtovariacao` AS `fator_produtovariacao`,`centaurus`.`produtovariacao`.`quantidade_produtovariacao` AS `multiplovariacao`,`centaurus`.`produtovariacao`.`unidade_produtovariacao` AS `unidadevariacao`,if((`centaurus`.`produtovariacao`.`fator_produtovariacao` = 'X'),(`centaurus`.`produto`.`saldo_produto` * `centaurus`.`produtovariacao`.`quantidade_produtovariacao`),(`centaurus`.`produto`.`saldo_produto` / `centaurus`.`produtovariacao`.`quantidade_produtovariacao`)) AS `saldoVariacao`,`centaurus`.`produtovariacao`.`id_produtovariacao` AS `codVariacao` from (`centaurus`.`produto` join `centaurus`.`produtovariacao` on((`centaurus`.`produtovariacao`.`idproduto_produtovariacao` = `centaurus`.`produto`.`id_produto`)));

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
