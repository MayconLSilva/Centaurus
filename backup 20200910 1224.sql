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
  `dataPrevisaoEntrega_locacao` datetime DEFAULT NULL,
  `idCliente_locacao` int(10) unsigned DEFAULT NULL,
  `desconto_locacao` float DEFAULT NULL,
  `qtdItens_locacao` double DEFAULT NULL,
  `total_locacao` float DEFAULT NULL,
  `tipo_locacao` char(1) DEFAULT NULL,
  `numerolocacaodev_locacao` int(10) unsigned DEFAULT NULL,
  `usuario_locacao` varchar(20) DEFAULT NULL,
  `dataDevolucao_locacao` datetime DEFAULT '0000-00-00 00:00:00',
  PRIMARY KEY (`id_locacao`),
  KEY `FK_locacao_cliente` (`idCliente_locacao`),
  CONSTRAINT `FK_locacao_cliente` FOREIGN KEY (`idCliente_locacao`) REFERENCES `participante` (`id_partipante`)
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `centaurus`.`locacao`
--

/*!40000 ALTER TABLE `locacao` DISABLE KEYS */;
INSERT INTO `locacao` (`id_locacao`,`dataLancamento_locacao`,`dataPrevisaoEntrega_locacao`,`idCliente_locacao`,`desconto_locacao`,`qtdItens_locacao`,`total_locacao`,`tipo_locacao`,`numerolocacaodev_locacao`,`usuario_locacao`,`dataDevolucao_locacao`) VALUES 
 (1,'2020-09-02 19:04:13','2020-09-25 19:04:12',1,0,0,0,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (2,'2020-09-02 19:12:51','2020-09-30 19:12:50',1,0,0,0,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (3,'2020-09-05 11:15:42','2020-09-05 11:15:41',9,0,0,0,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (4,'2020-09-07 09:33:41','2020-09-07 09:33:39',1,0,0,0,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (5,'2020-09-07 10:01:50',NULL,NULL,NULL,NULL,NULL,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (13,'2020-09-07 11:08:48',NULL,NULL,NULL,NULL,NULL,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (14,'2020-09-07 11:49:36',NULL,NULL,NULL,NULL,NULL,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (15,'2020-09-07 12:06:17',NULL,NULL,NULL,NULL,NULL,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (16,'2020-09-07 12:10:49',NULL,NULL,NULL,NULL,NULL,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (17,'2020-09-07 12:15:11','2020-09-07 12:15:10',1,0,0,0,'L',NULL,NULL,'0000-00-00 00:00:00');
INSERT INTO `locacao` (`id_locacao`,`dataLancamento_locacao`,`dataPrevisaoEntrega_locacao`,`idCliente_locacao`,`desconto_locacao`,`qtdItens_locacao`,`total_locacao`,`tipo_locacao`,`numerolocacaodev_locacao`,`usuario_locacao`,`dataDevolucao_locacao`) VALUES 
 (18,'2020-09-07 12:16:04','2020-09-30 12:16:02',1,0,0,0,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (19,'2020-09-07 12:16:52','2020-09-30 12:16:51',2,0,0,0,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (20,'2020-09-07 12:18:37','2020-09-30 12:18:34',3,0,0,0,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (21,'2020-09-07 12:19:28','2020-09-07 12:19:27',9,0,0,0,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (22,'2020-09-07 12:20:52','2020-09-07 12:20:51',15,0,0,0,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (23,'2020-09-07 12:21:26','2020-09-07 12:21:24',22,0,0,0,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (24,'2020-09-07 12:23:39','2020-10-01 12:23:38',2,0,0,0,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (25,'2020-09-07 12:26:39','2020-09-07 12:26:38',2,0,0,0,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (26,'2020-09-07 12:46:24','2020-09-07 12:46:23',2,0,0,0,'L',NULL,NULL,'0000-00-00 00:00:00');
INSERT INTO `locacao` (`id_locacao`,`dataLancamento_locacao`,`dataPrevisaoEntrega_locacao`,`idCliente_locacao`,`desconto_locacao`,`qtdItens_locacao`,`total_locacao`,`tipo_locacao`,`numerolocacaodev_locacao`,`usuario_locacao`,`dataDevolucao_locacao`) VALUES 
 (27,'2020-09-07 15:50:41','2020-09-07 15:50:40',2,0,0,0,'D',19,NULL,'0000-00-00 00:00:00'),
 (28,'2020-09-07 16:07:48','2020-09-07 16:07:47',3,0,0,0,'D',20,NULL,'0000-00-00 00:00:00'),
 (29,'2020-09-08 10:07:40','2020-09-08 10:07:39',1,0,0,0,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (30,'2020-09-08 11:46:59','2020-09-08 11:46:58',1,0,0,0,'L',NULL,'MAYCO','0000-00-00 00:00:00'),
 (31,'2020-09-09 09:35:03','2020-09-09 09:35:02',9,0,0,0,'L',NULL,'MAYCON','0000-00-00 00:00:00'),
 (32,'2020-09-09 11:29:02','2020-09-09 11:29:01',15,0,0,0,'L',NULL,'MAYCON','0000-00-00 00:00:00'),
 (33,'2020-09-09 13:52:29',NULL,NULL,NULL,NULL,NULL,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (34,'2020-09-09 14:07:55',NULL,NULL,NULL,NULL,NULL,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (35,'2020-09-09 14:10:51','2020-09-09 14:10:49',3,0,9,817.5,'L',NULL,'MAYCO','0000-00-00 00:00:00');
INSERT INTO `locacao` (`id_locacao`,`dataLancamento_locacao`,`dataPrevisaoEntrega_locacao`,`idCliente_locacao`,`desconto_locacao`,`qtdItens_locacao`,`total_locacao`,`tipo_locacao`,`numerolocacaodev_locacao`,`usuario_locacao`,`dataDevolucao_locacao`) VALUES 
 (36,'2020-09-09 14:21:39','2020-09-09 14:21:38',3,5,12,831,'L',NULL,'MAYCON','0000-00-00 00:00:00'),
 (37,'2020-09-09 14:38:40','2020-09-09 14:38:39',2,5,2,34.75,'L',NULL,'MAYCON','0000-00-00 00:00:00'),
 (38,'2020-09-09 14:41:25','2020-09-09 14:41:24',3,7,3,56,'L',NULL,'MAYCON','0000-00-00 00:00:00'),
 (39,'2020-09-09 14:59:53',NULL,NULL,NULL,NULL,NULL,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (40,'2020-09-09 15:01:47',NULL,NULL,NULL,NULL,NULL,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (41,'2020-09-09 15:03:16',NULL,NULL,NULL,NULL,NULL,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (42,'2020-09-09 15:07:58','2020-09-09 15:07:57',3,0,2,487.5,'L',NULL,'MAYCON','0000-00-00 00:00:00'),
 (43,'2020-09-09 15:19:40','2020-09-09 15:19:39',9,0,1,21,'L',NULL,'MAYCON','0000-00-00 00:00:00'),
 (44,'2020-09-09 15:25:38',NULL,NULL,NULL,NULL,NULL,'L',NULL,NULL,'0000-00-00 00:00:00');
INSERT INTO `locacao` (`id_locacao`,`dataLancamento_locacao`,`dataPrevisaoEntrega_locacao`,`idCliente_locacao`,`desconto_locacao`,`qtdItens_locacao`,`total_locacao`,`tipo_locacao`,`numerolocacaodev_locacao`,`usuario_locacao`,`dataDevolucao_locacao`) VALUES 
 (45,'2020-09-09 15:27:50',NULL,NULL,NULL,NULL,NULL,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (46,'2020-09-09 15:31:31',NULL,NULL,NULL,NULL,NULL,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (47,'2020-09-09 15:32:18',NULL,NULL,NULL,NULL,NULL,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (48,'2020-09-09 15:33:39',NULL,NULL,NULL,NULL,NULL,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (49,'2020-09-09 15:34:28',NULL,NULL,NULL,NULL,NULL,'L',NULL,NULL,'0000-00-00 00:00:00'),
 (50,'2020-09-09 15:36:58','2020-09-09 15:36:56',3,20,2,985,'L',NULL,'MAYCON','0000-00-00 00:00:00'),
 (51,'2020-09-09 17:26:31',NULL,NULL,NULL,NULL,NULL,'L',NULL,NULL,'0000-00-00 00:00:00');
/*!40000 ALTER TABLE `locacao` ENABLE KEYS */;


--
-- Table structure for table `centaurus`.`locacaoitens`
--

DROP TABLE IF EXISTS `locacaoitens`;
CREATE TABLE `locacaoitens` (
  `id_locacaoitens` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `idProduto_locacaoitens` int(10) unsigned NOT NULL DEFAULT '0',
  `valorLocado_locacaoitens` float DEFAULT NULL,
  `valorOriginal_locacaoitens` float DEFAULT NULL,
  `custoDia_locacaoitens` float DEFAULT NULL,
  `idLocacao_locacaoitens` int(10) unsigned NOT NULL DEFAULT '0',
  `qtdLocada_locacaoitens` double DEFAULT NULL,
  `tipo_locacaoitens` char(1) DEFAULT NULL,
  `idVariacaoProduto_locacaoitens` int(10) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`id_locacaoitens`),
  KEY `FK_locacaoitens_idLocacao` (`idLocacao_locacaoitens`),
  CONSTRAINT `FK_locacaoitens_idLocacao` FOREIGN KEY (`idLocacao_locacaoitens`) REFERENCES `locacao` (`id_locacao`)
) ENGINE=InnoDB AUTO_INCREMENT=64 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `centaurus`.`locacaoitens`
--

/*!40000 ALTER TABLE `locacaoitens` DISABLE KEYS */;
INSERT INTO `locacaoitens` (`id_locacaoitens`,`idProduto_locacaoitens`,`valorLocado_locacaoitens`,`valorOriginal_locacaoitens`,`custoDia_locacaoitens`,`idLocacao_locacaoitens`,`qtdLocada_locacaoitens`,`tipo_locacaoitens`,`idVariacaoProduto_locacaoitens`) VALUES 
 (1,1,5,5,0,1,1,NULL,0),
 (2,1,7,5,0,2,1,NULL,0),
 (3,3,10,10,0,3,1,NULL,0),
 (4,1,7,0,0,13,1,NULL,0),
 (5,2,8,0,0,13,1,NULL,0),
 (6,3,15,15,65,14,1,NULL,0),
 (7,1,5,5,55,14,1,NULL,0),
 (8,9,45,45,0,14,1,NULL,0),
 (9,1,5,5,55,15,1,NULL,0),
 (10,6,30,30,5,15,1,NULL,0),
 (11,5,25,25,55,16,1,NULL,0),
 (12,6,30,30,5,17,1,NULL,0),
 (13,1,5,5,55,18,1,NULL,0),
 (14,1,5,5,55,19,4,NULL,0),
 (15,14,70,70,56,19,1,NULL,0),
 (16,1,5,5,55,20,1,NULL,0),
 (17,3,15,15,65,20,3,NULL,0),
 (18,5,25,25,55,21,1,NULL,0),
 (19,14,70,70,56,22,1,NULL,0),
 (20,13,65,65,5,23,1,NULL,0),
 (21,5,25,25,55,24,1,NULL,0),
 (22,5,25,25,55,25,1,NULL,0),
 (23,3,15,15,65,26,1,NULL,0),
 (24,13,65,65,5,26,1,NULL,0),
 (25,1,5,5,55,27,1,'D',0),
 (26,3,15,15,65,28,1,'D',0),
 (27,1,18.75,18.75,12.5,29,1,'L',0);
INSERT INTO `locacaoitens` (`id_locacaoitens`,`idProduto_locacaoitens`,`valorLocado_locacaoitens`,`valorOriginal_locacaoitens`,`custoDia_locacaoitens`,`idLocacao_locacaoitens`,`qtdLocada_locacaoitens`,`tipo_locacaoitens`,`idVariacaoProduto_locacaoitens`) VALUES 
 (28,1,18.75,18.75,12.5,30,1,'L',0),
 (29,1,900,900,600,31,1,'L',7),
 (30,1,225,225,150,32,1,'L',6),
 (31,4,21.375,21.375,14.25,32,1,'L',0),
 (32,1,450,450,300,33,1,'L',1),
 (33,1,450,450,300,34,2,'L',1),
 (34,3,21,21,14,34,1,'L',0),
 (35,1,225,225,150,35,3,'L',6),
 (36,3,21,21,14,35,5,'L',0),
 (37,15,37.5,37.5,25,35,1,'L',0),
 (38,1,450,450,300,36,1,'L',1),
 (39,15,37.5,37.5,25,36,10,'L',0),
 (40,3,21,21,14,36,1,'L',0),
 (41,1,18.75,18.75,12.5,37,1,'L',0),
 (42,3,21,21,14,37,1,'L',0),
 (43,3,21,21,14,38,3,'L',0),
 (44,1,225,225,150,39,1,'L',6),
 (45,3,105,105,70,39,1,'L',3),
 (46,3,21,21,14,40,1,'L',0),
 (47,1,225,225,150,40,1,'L',6),
 (48,3,21,21,14,41,1,'L',0),
 (49,15,37.5,37.5,25,41,1,'L',0),
 (50,1,450,450,300,42,1,'L',1),
 (51,15,37.5,37.5,25,42,1,'L',0);
INSERT INTO `locacaoitens` (`id_locacaoitens`,`idProduto_locacaoitens`,`valorLocado_locacaoitens`,`valorOriginal_locacaoitens`,`custoDia_locacaoitens`,`idLocacao_locacaoitens`,`qtdLocada_locacaoitens`,`tipo_locacaoitens`,`idVariacaoProduto_locacaoitens`) VALUES 
 (52,3,21,21,14,43,1,'L',0),
 (53,3,21,21,14,44,1,'L',0),
 (54,3,21,21,14,45,1,'L',0),
 (55,3,21,21,14,46,1,'L',0),
 (56,3,21,21,14,47,1,'L',0),
 (57,3,21,21,14,48,1,'L',0),
 (58,3,21,21,14,49,1,'L',0),
 (59,1,900,900,600,50,1,'L',7),
 (60,3,105,105,70,50,1,'L',3),
 (61,2,19.5,19.5,13,51,1,'L',0);
/*!40000 ALTER TABLE `locacaoitens` ENABLE KEYS */;


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
 (1,1,0,'P','Detergente Ype','UN',18.75,1200,NULL,NULL,NULL,NULL,'123',789,'589','24/08/2020','','','',0,0,12.5),
 (2,1,0,'P','Areia fina','MT',19.5,5000,7,18,19,1,'456',7894,'123','24/08/2020','','','',NULL,NULL,13),
 (3,0,1,'P','Farinha de trigo','PCT',21,60,3,18,19,2,'456',789,'444','24/08/2020',NULL,'',NULL,NULL,NULL,14),
 (4,1,0,'P','Produto teste4','UN',21.375,4,6,18,19,2,'777',7894561,'22','24/08/2020',NULL,'',NULL,NULL,NULL,14.25),
 (5,1,0,'S','PRODUTO TESTE 6','UN',16.5,7,9,18,19,5,'777',789456123,'1234','24/08/2020',NULL,'',NULL,NULL,NULL,11),
 (6,1,0,'P','produto teste 7','UN',16.725,36,NULL,18,14,NULL,'',44,'','25/08/2020',NULL,'',NULL,NULL,NULL,11.15);
INSERT INTO `produto` (`id_produto`,`ativo_produto`,`descontinuado_produto`,`tipoitem_produto`,`descricao_produto`,`unidade_produto`,`venda_produto`,`saldo_produto`,`marca_produto`,`categoria_produto`,`subcategoria_produto`,`fornecedor_produto`,`codfabricante_produto`,`codbarras_produto`,`codinterno_produto`,`dataCadastro_produto`,`dataAlteracao_produto`,`usuarioCadastro_produto`,`usuarioAlteracao_produto`,`ultimoCustoCompra_produto`,`custoanterior_produto`,`custofinal_produto`) VALUES 
 (7,0,1,'P','produto teste 7','UN',7.5,15,NULL,18,14,NULL,'',NULL,'','25/08/2020',NULL,'',NULL,NULL,NULL,5),
 (8,0,0,'S','produto teste 8','UN',7.65,2,NULL,18,14,NULL,'',NULL,'','25/08/2020',NULL,'',NULL,NULL,NULL,5.1),
 (9,1,0,'P','produto teste 9','UN',12.9,26,NULL,18,19,NULL,'',NULL,'','25/08/2020',NULL,'',NULL,NULL,NULL,8.6),
 (10,1,0,'S','produto teste 10','UN',14.7,2,NULL,18,19,NULL,'',NULL,'','25/08/2020',NULL,'',NULL,NULL,NULL,9.8),
 (11,1,0,'P','produto teste 11','UN',14.775,3,NULL,18,19,NULL,'',NULL,'','25/08/2020',NULL,'',NULL,NULL,NULL,9.85),
 (12,1,0,'P','produto 12','UN',15,5,NULL,18,19,NULL,'',NULL,'','25/08/2020',NULL,'',NULL,NULL,NULL,10);
INSERT INTO `produto` (`id_produto`,`ativo_produto`,`descontinuado_produto`,`tipoitem_produto`,`descricao_produto`,`unidade_produto`,`venda_produto`,`saldo_produto`,`marca_produto`,`categoria_produto`,`subcategoria_produto`,`fornecedor_produto`,`codfabricante_produto`,`codbarras_produto`,`codinterno_produto`,`dataCadastro_produto`,`dataAlteracao_produto`,`usuarioCadastro_produto`,`usuarioAlteracao_produto`,`ultimoCustoCompra_produto`,`custoanterior_produto`,`custofinal_produto`) VALUES 
 (13,1,0,'P','produto teste 13','UN',10.5,10,4,18,19,5,'123',789456,'123','25/08/2020',NULL,'',NULL,NULL,NULL,7),
 (14,1,0,'P','valor de venda','UN',33.3,20,NULL,18,14,NULL,'',NULL,'','25/08/2020',NULL,'',NULL,NULL,NULL,22.2),
 (15,1,0,'P','Pó Royal','UN',37.5,0,7,17,14,5,'',NULL,'','02/09/2020',NULL,'',NULL,NULL,NULL,25);
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
CREATE ALGORITHM=UNDEFINED DEFINER=`sistema`@`%` SQL SECURITY DEFINER VIEW `centaurus`.`viewlistarproduto` AS select `pro`.`id_produto` AS `id_produto`,`pro`.`descricao_produto` AS `descricao_produto`,`pro`.`unidade_produto` AS `unidade_produto`,`cat`.`descricao_categoria` AS `categoria`,`sub`.`descricao_categoria` AS `subcategoria`,`marc`.`descricao_marca` AS `descricao_marca`,`pro`.`venda_produto` AS `venda_produto`,`pro`.`custofinal_produto` AS `custo`,`pro`.`saldo_produto` AS `saldo_produto`,`cli`.`nome_fantasia_participante` AS `fornecedor`,`pro`.`codfabricante_produto` AS `codfabricante_produto`,`pro`.`codbarras_produto` AS `codbarras_produto`,`pro`.`codinterno_produto` AS `codinterno_produto`,`pro`.`tipoitem_produto` AS `tipoitem` from ((((`centaurus`.`produto` `pro` left join `centaurus`.`categoria` `cat` on((`pro`.`categoria_produto` = `cat`.`id_categoria`))) left join `centaurus`.`categoria` `sub` on((`pro`.`subcategoria_produto` = `sub`.`id_categoria`))) left join `centaurus`.`participante` `cli` on((`cli`.`id_partipante` = `pro`.`fornecedor_produto`))) left join `centaurus`.`marca` `marc` on((`marc`.`id_marca` = `pro`.`marca_produto`)));


--
-- View structure for view `centaurus`.`viewlistarprodutocomvariacao`
--

DROP VIEW IF EXISTS `viewlistarprodutocomvariacao`;
CREATE ALGORITHM=UNDEFINED DEFINER=`sistema`@`%` SQL SECURITY DEFINER VIEW `centaurus`.`viewlistarprodutocomvariacao` AS select `prod1`.`id_produto` AS `id_produto`,0 AS `variacaoproduto`,`prod1`.`descricao_produto` AS `descricao_produto`,`prod1`.`unidade_produto` AS `unidade_produto`,`prod1`.`custofinal_produto` AS `custo`,`prod1`.`venda_produto` AS `venda_produto`,`marca1`.`descricao_marca` AS `descricao_marca`,`cat1`.`descricao_categoria` AS `categoria`,`subcat1`.`descricao_categoria` AS `subcategoria`,`forn1`.`nome_fantasia_participante` AS `fornecedor`,`prod1`.`saldo_produto` AS `saldoprincipal`,`prod1`.`saldo_produto` AS `saldovariacao`,`prod1`.`codfabricante_produto` AS `codfabricante_produto`,`prod1`.`codbarras_produto` AS `codbarras_produto`,`prod1`.`codinterno_produto` AS `codinterno_produto`,`prod1`.`tipoitem_produto` AS `tipoitem` from ((((`centaurus`.`produto` `prod1` left join `centaurus`.`marca` `marca1` on((`marca1`.`id_marca` = `prod1`.`marca_produto`))) left join `centaurus`.`categoria` `cat1` on((`cat1`.`id_categoria` = `prod1`.`categoria_produto`))) left join `centaurus`.`categoria` `subcat1` on((`prod1`.`subcategoria_produto` = `subcat1`.`id_categoria`))) left join `centaurus`.`participante` `forn1` on((`prod1`.`fornecedor_produto` = `forn1`.`id_partipante`))) union all select `prodv`.`idproduto_produtovariacao` AS `idproduto_produtovariacao`,`prodv`.`id_produtovariacao` AS `id_produtovariacao`,`prod2`.`descricao_produto` AS `descricao_produto`,concat(`prodv`.`unidade_produtovariacao`,'/',`prodv`.`quantidade_produtovariacao`) AS `concat(prodv.unidade_produtovariacao,'/',prodv.quantidade_produtovariacao)`,(`prod2`.`custofinal_produto` * `prodv`.`quantidade_produtovariacao`) AS `prod2.custofinal_produto * prodv.quantidade_produtovariacao`,if((`prodv`.`unidade_produtovariacao` = NULL),`prod2`.`venda_produto`,(`prod2`.`venda_produto` * `prodv`.`quantidade_produtovariacao`)) AS `if(prodv.unidade_produtovariacao = null,prod2.venda_produto,prod2.venda_produto * prodv.quantidade_produtovariacao)`,`marca2`.`descricao_marca` AS `descricao_marca`,`cat2`.`descricao_categoria` AS `descricao_categoria`,`subcat2`.`descricao_categoria` AS `descricao_categoria`,`forn2`.`nome_fantasia_participante` AS `nome_fantasia_participante`,`prod2`.`saldo_produto` AS `saldo_produto`,if((`prodv`.`fator_produtovariacao` = 'X'),(`prod2`.`saldo_produto` * `prodv`.`quantidade_produtovariacao`),(`prod2`.`saldo_produto` / `prodv`.`quantidade_produtovariacao`)) AS `if(prodv.fator_produtovariacao = 'X',prod2.saldo_produto * prodv.quantidade_produtovariacao ,prod2.saldo_produto / prodv.quantidade_produtovariacao)`,`prod2`.`codfabricante_produto` AS `codfabricante_produto`,`prodv`.`codbarras_produtovariacao` AS `codbarras_produtovariacao`,`prod2`.`codinterno_produto` AS `codinterno_produto`,`prod2`.`tipoitem_produto` AS `tipoitem_produto` from (((((`centaurus`.`produtovariacao` `prodv` join `centaurus`.`produto` `prod2` on((`prod2`.`id_produto` = `prodv`.`idproduto_produtovariacao`))) left join `centaurus`.`marca` `marca2` on((`prod2`.`marca_produto` = `marca2`.`id_marca`))) left join `centaurus`.`categoria` `cat2` on((`prod2`.`categoria_produto` = `cat2`.`id_categoria`))) left join `centaurus`.`categoria` `subcat2` on((`prod2`.`subcategoria_produto` = `subcat2`.`id_categoria`))) left join `centaurus`.`participante` `forn2` on((`prod2`.`fornecedor_produto` = `forn2`.`id_partipante`))) order by `id_produto`;


--
-- View structure for view `centaurus`.`viewlistarvariacao`
--

DROP VIEW IF EXISTS `viewlistarvariacao`;
CREATE ALGORITHM=UNDEFINED DEFINER=`sistema`@`%` SQL SECURITY DEFINER VIEW `centaurus`.`viewlistarvariacao` AS select `centaurus`.`produto`.`id_produto` AS `idProduto`,`centaurus`.`produto`.`unidade_produto` AS `unidadeprincipal`,`centaurus`.`produto`.`saldo_produto` AS `saldoprincipal`,`centaurus`.`produtovariacao`.`fator_produtovariacao` AS `fator_produtovariacao`,`centaurus`.`produtovariacao`.`quantidade_produtovariacao` AS `multiplovariacao`,`centaurus`.`produtovariacao`.`unidade_produtovariacao` AS `unidadevariacao`,if((`centaurus`.`produtovariacao`.`fator_produtovariacao` = 'X'),(`centaurus`.`produto`.`saldo_produto` * `centaurus`.`produtovariacao`.`quantidade_produtovariacao`),(`centaurus`.`produto`.`saldo_produto` / `centaurus`.`produtovariacao`.`quantidade_produtovariacao`)) AS `saldoVariacao`,`centaurus`.`produtovariacao`.`id_produtovariacao` AS `codVariacao` from (`centaurus`.`produto` join `centaurus`.`produtovariacao` on((`centaurus`.`produtovariacao`.`idproduto_produtovariacao` = `centaurus`.`produto`.`id_produto`)));


--
-- View structure for view `centaurus`.`viewlocacao`
--

DROP VIEW IF EXISTS `viewlocacao`;
CREATE ALGORITHM=UNDEFINED DEFINER=`sistema`@`%` SQL SECURITY DEFINER VIEW `centaurus`.`viewlocacao` AS select `loc`.`id_locacao` AS `Codigo`,`loc`.`idCliente_locacao` AS `CodigoCliente`,`cli`.`nome_fantasia_participante` AS `NomeCliente`,`loc`.`dataLancamento_locacao` AS `DataLancamento`,`loc`.`dataPrevisaoEntrega_locacao` AS `DataPrevisaoEntrega`,`loc`.`dataDevolucao_locacao` AS `DataDevolucao`,`loc`.`numerolocacaodev_locacao` AS `numerolocacaodev_locacao`,`loc`.`total_locacao` AS `Total`,`loc`.`usuario_locacao` AS `UsuarioLocacao`,`loc`.`desconto_locacao` AS `DescontoLocacao`,`loc`.`qtdItens_locacao` AS `QtdItensLocacao`,`loc`.`tipo_locacao` AS `TipoLocacao` from (`centaurus`.`locacao` `loc` join `centaurus`.`participante` `cli` on((`cli`.`id_partipante` = `loc`.`idCliente_locacao`)));


--
-- View structure for view `centaurus`.`viewlocacaoitens`
--

DROP VIEW IF EXISTS `viewlocacaoitens`;
CREATE ALGORITHM=UNDEFINED DEFINER=`sistema`@`%` SQL SECURITY DEFINER VIEW `centaurus`.`viewlocacaoitens` AS select `centaurus`.`locacaoitens`.`idProduto_locacaoitens` AS `Codigo`,`centaurus`.`locacaoitens`.`idVariacaoProduto_locacaoitens` AS `CodigoProdutoVariacao`,`centaurus`.`produto`.`descricao_produto` AS `Descricao`,if((`centaurus`.`locacaoitens`.`idVariacaoProduto_locacaoitens` = 0),`centaurus`.`produto`.`unidade_produto`,`centaurus`.`produtovariacao`.`unidade_produtovariacao`) AS `UN`,`centaurus`.`locacaoitens`.`qtdLocada_locacaoitens` AS `QtdLocada`,`centaurus`.`locacaoitens`.`valorLocado_locacaoitens` AS `ValorLocado`,(`centaurus`.`locacaoitens`.`valorLocado_locacaoitens` * `centaurus`.`locacaoitens`.`qtdLocada_locacaoitens`) AS `ValorTotal`,`centaurus`.`marca`.`descricao_marca` AS `Marca`,`cat`.`descricao_categoria` AS `Categoria`,`subcat`.`descricao_categoria` AS `SubCategoria`,`centaurus`.`participante`.`nome_fantasia_participante` AS `Fornecedor`,`centaurus`.`locacaoitens`.`idLocacao_locacaoitens` AS `idLocacao_locacaoitens` from ((((((`centaurus`.`locacaoitens` left join `centaurus`.`produtovariacao` on((`centaurus`.`produtovariacao`.`id_produtovariacao` = `centaurus`.`locacaoitens`.`idProduto_locacaoitens`))) join `centaurus`.`produto` on((`centaurus`.`produto`.`id_produto` = `centaurus`.`locacaoitens`.`idProduto_locacaoitens`))) left join `centaurus`.`marca` on((`centaurus`.`marca`.`id_marca` = `centaurus`.`produto`.`marca_produto`))) left join `centaurus`.`categoria` `cat` on((`cat`.`id_categoria` = `centaurus`.`produto`.`categoria_produto`))) left join `centaurus`.`categoria` `subcat` on((`subcat`.`id_categoria` = `centaurus`.`produto`.`subcategoria_produto`))) left join `centaurus`.`participante` on((`centaurus`.`participante`.`id_partipante` = `centaurus`.`produto`.`fornecedor_produto`)));

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
