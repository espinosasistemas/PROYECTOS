-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: 172.29.50.1    Database: db_sci
-- ------------------------------------------------------
-- Server version	5.7.29-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `caseta`
--

DROP TABLE IF EXISTS `caseta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `caseta` (
  `idCaseta` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(200) NOT NULL,
  `costo` double NOT NULL,
  `idTipoDeUnidad` int(11) NOT NULL,
  `idTipoDeGasto` int(11) DEFAULT NULL,
  PRIMARY KEY (`idCaseta`),
  KEY `caseta_fk0_idx` (`idTipoDeUnidad`),
  KEY `caseta_fk1_idx` (`idTipoDeGasto`),
  CONSTRAINT `caseta_fk0` FOREIGN KEY (`idTipoDeUnidad`) REFERENCES `tipounidad` (`idTipoDeUnidad`),
  CONSTRAINT `caseta_fk1` FOREIGN KEY (`idTipoDeGasto`) REFERENCES `tipogasto` (`idTipoGasto`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `caseta`
--

LOCK TABLES `caseta` WRITE;
/*!40000 ALTER TABLE `caseta` DISABLE KEYS */;
INSERT INTO `caseta` VALUES (8,'T1 - AMOZOC',176,1,2),(9,'T5-AUDI',43,1,2),(10,'SAN MARTIN',97,2,2),(11,'ARCO NORTE (SANCTORUM) TORTHON',140,2,2),(12,'SAN MARTIN',196,1,2),(13,'ARCO NORTE (SANCTORUM) TRAILER',220,1,2),(14,'ARCO NORTE (MEX. QRO)',695,2,2),(15,'PALMILLAS',180,2,2),(16,'CHICHIMEQUILLAS',84,2,2),(17,'SALAMANCA',174,2,2),(18,'LIBRAMIENTO LA PIEDAD',87,2,2),(19,'SIGLO XXI',328,2,2),(20,'QUERETARO',161,2,2),(21,'LIBRAMIENTO SUR PONIENTE',8,2,2),(22,'ARCO NORTE (MEX. QRO)',1050,1,2),(23,'PALMILLAS',362,1,2),(24,'CHICHIMEQUILLAS',91,1,2),(25,'ATLIXCO - JANTETELCO',328,2,2),(26,'VIA ATLIXCAYOTL',96,2,2),(27,'AEROPUERTO ',24,2,2),(28,'SAN NICOLAS DE LOS JASSOS',135,2,2),(29,'SAN NICOLAS DE LOS JASSOS',158,1,2),(30,'MATEHUALA',46,2,2),(31,'MATEHUALA',86,1,2),(32,'PTO. MÉXICO/HUACHICHIL',148,2,2),(33,'PTO. MÉXICO/HUACHICHIL',230,1,2),(34,'1231244213',1000,3,2);
/*!40000 ALTER TABLE `caseta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `idcliente` int(11) NOT NULL AUTO_INCREMENT,
  `razonsocial` varchar(200) NOT NULL,
  `rfc` varchar(15) NOT NULL,
  `giro` varchar(50) NOT NULL,
  `telefono` varchar(20) NOT NULL,
  `correo` varchar(100) NOT NULL,
  `nombrecontacto` varchar(200) NOT NULL,
  `direccion` varchar(500) NOT NULL,
  PRIMARY KEY (`idcliente`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (5,'Faurecia Sistemas Automotrices de México S.A. DE C.V.','FSA980318AL3','Automotriz','9152479644','jsaucedo@venturelogistics.com','Venture','km 117 Autopista México Puebla, Nave 17 Parque Indutrial FINSA, \r\nSan Lorenzo Almecatla, Puebla, Pue\r\n7719'),(7,'NICRO BOLTA SA DE CV','NBOO4O42OCN0','Automotriz','2226169237','loreidy.ramirez@nicrobolta.com','Loreidy Ramirez','Ricardo Flores Magón 98, San Jerónimo Caleras, 72100.\r\nPuebla, Pue.'),(8,'LAN LOGISTICS DE MEXICO SA DE CV','LME161011F93','LOGISTICA','2225054753','antonio.landa@lanlogistics.com.mx','ANTONIO LANDA','Sin numero'),(9,'CIE GLOBAL','AIM090105218','Automotriz','2226142613','esosa@ciegolde.com','Elias Sosa','Autopista México - Puebla km 117.\r\nPuebla, pue'),(10,'Moliendas Tizayuca','MTI900307NJ7','NA','2222815336','compras@manchestermex.com.mx','Ana Elsa','Carretera Xoxtla SN, 90721\r\nTlatengango, Tlax'),(11,'Corporación Telch SA DE CV','CTE871203RL6','Insumos','2223564251','jfsanchez@telch.com.mx','Fabian Sanchez','Cholula - Pue 522. Colonia a,  San Juan Tlauta; \r\nHuejotzingo, Pue\r\n72750'),(12,'Concorde Group S.A. DE C.V.','CGR020208GD6','Automotriz','2227943082','dolores.juarez@concorde.com.mx','Dolores Juarez','Periférico Ecológico 17, Cuatro Caminos, 72710.\r\nPuebla, Pue'),(13,'Armando Cruz Robles','CURA810514G82','-','-','armcruz.10@gmail.com','Armando Cruz','na');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cobrosadicionales`
--

DROP TABLE IF EXISTS `cobrosadicionales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cobrosadicionales` (
  `idCobroAdicional` int(11) NOT NULL AUTO_INCREMENT,
  `idViajeSci` int(11) NOT NULL,
  `tipoCobro` varchar(20) NOT NULL,
  `monto` double NOT NULL,
  `fecha` datetime NOT NULL,
  PRIMARY KEY (`idCobroAdicional`),
  KEY `cobrosadicionales_fk0_idx` (`idViajeSci`),
  CONSTRAINT `cobrosadicionales_fk0` FOREIGN KEY (`idViajeSci`) REFERENCES `viaje` (`idViajeSci`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cobrosadicionales`
--

LOCK TABLES `cobrosadicionales` WRITE;
/*!40000 ALTER TABLE `cobrosadicionales` DISABLE KEYS */;
/*!40000 ALTER TABLE `cobrosadicionales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cortesoperador`
--

DROP TABLE IF EXISTS `cortesoperador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cortesoperador` (
  `idCorte` int(11) NOT NULL AUTO_INCREMENT,
  `fechaInicio` datetime NOT NULL,
  `fechaFin` datetime DEFAULT '0000-00-00 00:00:00',
  `costo` double NOT NULL,
  `horas` double NOT NULL,
  `idOperador` int(11) NOT NULL,
  `idStatus` int(11) NOT NULL,
  `idViajeSci` int(11) NOT NULL,
  PRIMARY KEY (`idCorte`),
  KEY `cortesOperacion_fk1_idx` (`idViajeSci`),
  KEY `cortesOperacion_fk2_idx` (`idOperador`),
  KEY `cortesOperacion_fk3_idx` (`idStatus`),
  CONSTRAINT `cortesOperacion_fk1` FOREIGN KEY (`idViajeSci`) REFERENCES `viaje` (`idViajeSci`),
  CONSTRAINT `cortesOperacion_fk2` FOREIGN KEY (`idOperador`) REFERENCES `operador` (`idoperador`),
  CONSTRAINT `cortesOperacion_fk3` FOREIGN KEY (`idStatus`) REFERENCES `statusviaje` (`idStatus`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cortesoperador`
--

LOCK TABLES `cortesoperador` WRITE;
/*!40000 ALTER TABLE `cortesoperador` DISABLE KEYS */;
INSERT INTO `cortesoperador` VALUES (18,'2020-03-22 23:00:00','2020-03-24 06:00:00',775,31,12,1,297),(19,'2020-03-22 21:00:00','2020-03-24 06:00:00',825,33,7,1,296),(21,'2020-03-22 23:30:00','2020-03-24 06:00:00',762.5,30.5,15,4,295),(22,'2020-03-22 22:00:00','2020-03-24 06:00:00',640,32,21,1,294),(23,'2020-03-23 06:00:00','2020-03-24 10:15:00',706.25,28.25,6,4,298);
/*!40000 ALTER TABLE `cortesoperador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `deposito`
--

DROP TABLE IF EXISTS `deposito`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `deposito` (
  `idDeposito` int(11) NOT NULL AUTO_INCREMENT,
  `idOperador` int(11) NOT NULL,
  `idViajeSci` int(11) NOT NULL,
  `monto` double NOT NULL,
  `tipo` varchar(20) NOT NULL,
  `referencia` varchar(40) NOT NULL,
  `fecha` datetime NOT NULL,
  `nota` varchar(100) NOT NULL,
  PRIMARY KEY (`idDeposito`),
  KEY `deposito_fk0_idx` (`idOperador`),
  KEY `deposito_fk1_idx` (`idViajeSci`),
  CONSTRAINT `deposito_fk0` FOREIGN KEY (`idOperador`) REFERENCES `operador` (`idoperador`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `deposito_fk1` FOREIGN KEY (`idViajeSci`) REFERENCES `viaje` (`idViajeSci`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deposito`
--

LOCK TABLES `deposito` WRITE;
/*!40000 ALTER TABLE `deposito` DISABLE KEYS */;
INSERT INTO `deposito` VALUES (14,7,296,2158.54,'Crédito','PUEBLA AVANZA','2020-03-25 22:35:00',''),(15,15,295,2331.18,'Crédito','','2020-03-25 22:40:00',''),(16,21,294,1055.28,'Crédito','','2020-03-25 23:07:00',''),(17,6,298,1032,'Efectivo','','2020-03-25 23:13:00',''),(18,19,300,4000,'Efectivo','','2020-03-25 23:35:00',''),(19,19,300,100,'Crédito','','2020-03-26 08:32:00','');
/*!40000 ALTER TABLE `deposito` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gasolineria`
--

DROP TABLE IF EXISTS `gasolineria`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gasolineria` (
  `idGasolineria` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `direccion` varchar(200) NOT NULL,
  `rfc` varchar(15) NOT NULL,
  `razonsocial` varchar(100) NOT NULL,
  `telefono` varchar(20) NOT NULL,
  `correo` varchar(50) NOT NULL,
  `idTipoGasto` int(11) NOT NULL,
  PRIMARY KEY (`idGasolineria`),
  KEY `gasolineria_fk0_idx` (`idTipoGasto`),
  CONSTRAINT `gasolineria_fk0` FOREIGN KEY (`idTipoGasto`) REFERENCES `tipogasto` (`idTipoGasto`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gasolineria`
--

LOCK TABLES `gasolineria` WRITE;
/*!40000 ALTER TABLE `gasolineria` DISABLE KEYS */;
INSERT INTO `gasolineria` VALUES (7,'EL CRUCERO DE ZACATLAN','Mirador No. 1 San Francisco Ocotlan Coronango, Puebla','CZA910304LM2','EL CRUCERO DE ZACATLAN S.A. DE C.V.','222 2894442','CENTROCZ@GMAIL.COM',1),(8,'MOBIL PUEBLA AVANZA','-','PAV121024TR3','MOBIL PUEBLA AVANZA S DE RL DE CV','222 4549653','PUEBLAAVANZA12383@GMAIL.COM',1),(9,'MOBIL CUPULAS','.','SCU1008169V4','SERVICIO LAS CUPULAS SA DE CV','','cupulas11471@gmail.com',1);
/*!40000 ALTER TABLE `gasolineria` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gasto`
--

DROP TABLE IF EXISTS `gasto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `gasto` (
  `idGasto` int(11) NOT NULL AUTO_INCREMENT,
  `concepto` varchar(100) NOT NULL,
  `costo` double NOT NULL,
  `rutapdf` varchar(100) NOT NULL,
  `rutaxml` varchar(100) NOT NULL,
  `fecha` datetime NOT NULL,
  `numeroDePoliza` int(11) NOT NULL,
  `folioFactura` varchar(50) NOT NULL,
  `numTicket` varchar(50) NOT NULL,
  `formaDePago` varchar(20) NOT NULL,
  `idTipoGasto` int(11) NOT NULL,
  `idOperador` int(11) NOT NULL,
  `idViajeSci` int(11) NOT NULL,
  PRIMARY KEY (`idGasto`),
  KEY `gasto_fk0` (`idTipoGasto`),
  KEY `gasto_fk1` (`idViajeSci`),
  KEY `gasto_fk2_idx` (`idOperador`),
  CONSTRAINT `gasto_fk0` FOREIGN KEY (`idTipoGasto`) REFERENCES `tipogasto` (`idTipoGasto`),
  CONSTRAINT `gasto_fk1` FOREIGN KEY (`idViajeSci`) REFERENCES `viaje` (`idViajeSci`),
  CONSTRAINT `gasto_fk2` FOREIGN KEY (`idOperador`) REFERENCES `operador` (`idoperador`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=50 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gasto`
--

LOCK TABLES `gasto` WRITE;
/*!40000 ALTER TABLE `gasto` DISABLE KEYS */;
INSERT INTO `gasto` VALUES (26,'EL CRUCERO DE ZACATLAN',2158.54,'','','2020-03-22 22:35:00',0,'','609210','Crédito',1,7,296),(27,'EL CRUCERO DE ZACATLAN',2331.18,'','','2020-03-22 22:56:00',0,'','','Crédito',1,15,295),(28,'EL CRUCERO DE ZACATLAN',1055.28,'','','2020-03-22 23:07:00',0,'','','Crédito',1,21,294),(29,'ARCO NORTE (SANCTORUM) TRAILER',220,'','','2020-03-22 23:13:00',0,'','','Efectivo',2,6,298),(30,'SAN MARTIN',196,'','','2020-03-23 23:14:00',0,'','','Efectivo',2,6,298),(31,'ARCO NORTE (SANCTORUM) TRAILER',220,'','','2020-03-23 23:14:00',0,'','','Efectivo',2,6,298),(32,'SAN MARTIN',196,'','','2020-03-23 23:14:00',0,'','','Efectivo',2,6,298),(33,'COMIDA',200,'','','2020-03-23 23:15:00',0,'','','Efectivo',3,6,298),(34,'SAN MARTIN',97,'','','2020-03-23 23:34:00',0,'','','Efectivo',2,19,300),(35,'ARCO NORTE (MEX. QRO)',695,'','','2020-03-23 23:36:00',0,'','','Efectivo',2,19,300),(36,'PALMILLAS',180,'','','2020-03-23 23:37:00',0,'','','Efectivo',2,19,300),(37,'CHICHIMEQUILLAS',84,'','','2020-03-23 23:37:00',0,'','','Efectivo',2,19,300),(38,'CHICHIMEQUILLAS',84,'','','2020-03-23 23:37:00',0,'','','Efectivo',2,19,300),(39,'QUERETARO',161,'','','2020-03-23 23:38:00',0,'','','Efectivo',2,19,300),(40,'SALAMANCA',174,'','','2020-03-23 23:40:00',0,'','','Efectivo',2,19,300),(41,'LIBRAMIENTO LA PIEDAD',87,'','','2020-03-23 23:40:00',0,'','','Efectivo',2,19,300),(42,'LIBRAMIENTO SUR PONIENTE',8,'','','2020-03-23 23:41:00',0,'','','Efectivo',2,19,300),(43,'SAN MARTIN',97,'','','2020-03-23 23:41:00',0,'','','Efectivo',2,19,300),(44,'ARCO NORTE (MEX. QRO)',695,'','','2020-03-23 23:41:00',0,'','','Efectivo',2,19,300),(45,'PALMILLAS',180,'','','2020-03-23 23:42:00',0,'','','Efectivo',2,19,300),(46,'LIBRAMIENTO LA PIEDAD',87,'','','2020-03-23 23:43:00',0,'','','Efectivo',2,19,300),(47,'SALAMANCA',174,'','','2020-03-23 23:43:00',0,'','','Efectivo',2,19,300),(48,'QUERETARO',161,'','','2020-03-23 23:43:00',0,'','','Efectivo',2,19,300),(49,'COMIDA',400,'','','2020-03-23 23:44:00',0,'','','Efectivo',3,19,300);
/*!40000 ALTER TABLE `gasto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `log`
--

DROP TABLE IF EXISTS `log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `log` (
  `idmovimiento` int(11) NOT NULL AUTO_INCREMENT,
  `accion` varchar(50) NOT NULL,
  `nombreusuario` varchar(50) NOT NULL,
  `fecha` datetime NOT NULL,
  `moduloafectado` varchar(50) NOT NULL,
  PRIMARY KEY (`idmovimiento`),
  KEY `registro_fk0` (`nombreusuario`),
  CONSTRAINT `registro_fk0` FOREIGN KEY (`nombreusuario`) REFERENCES `usuario` (`nombreusuario`)
) ENGINE=InnoDB AUTO_INCREMENT=126 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `log`
--

LOCK TABLES `log` WRITE;
/*!40000 ALTER TABLE `log` DISABLE KEYS */;
INSERT INTO `log` VALUES (1,'agregar','maritza','2020-03-25 21:59:00','viaje-id:294'),(2,'agregar','maritza','2020-03-25 21:59:00','viaje-id:294 -- operador-id:21'),(3,'agregar','maritza','2020-03-25 22:00:00','viaje-id:295'),(4,'agregar','maritza','2020-03-25 22:00:00','viaje-id:295 -- operador-id:15'),(5,'agregar','maritza','2020-03-25 22:03:00','viaje-id:296'),(6,'agregar','maritza','2020-03-25 22:03:00','viaje-id:296 -- operador-id:7'),(7,'agregar','maritza','2020-03-25 22:26:00','viaje-id:297'),(8,'agregar','maritza','2020-03-25 22:26:00','viaje-id:297 -- operador-id:12'),(9,'agregar','maritza','2020-03-25 22:31:00','viaje-id:297 -- cortesoperador-id:18'),(10,'editar','maritza','2020-03-25 22:31:00','viaje-id:297'),(11,'agregar','maritza','2020-03-25 22:32:00','viaje-id:296 -- cortesoperador-id:19'),(12,'editar','maritza','2020-03-25 22:33:00','viaje-id:296'),(13,'agregar','maritza','2020-03-25 22:35:00','deposito-id:14'),(14,'agregar','maritza','2020-03-25 22:36:00','viaje-id:296 -- gasto-id:26'),(15,'editar','maritza','2020-03-25 22:37:00','viaje-id:296'),(16,'agregar','maritza','2020-03-25 22:40:00','deposito-id:15'),(17,'agregar','maritza','2020-03-25 22:49:00','gasolineria-id:7'),(18,'editar','maritza','2020-03-25 22:50:00','viaje-id:296 -- gasto-id:26'),(19,'editar','maritza','2020-03-25 22:50:00','viaje-id:296'),(20,'agregar','maritza','2020-03-25 22:52:00','viaje-id:295 -- cortesoperador-id:20'),(21,'editar','maritza','2020-03-25 22:53:00','viaje-id:295'),(22,'agregar','maritza','2020-03-25 22:56:00','viaje-id:295 -- gasto-id:27'),(23,'editar','maritza','2020-03-25 22:57:00','viaje-id:295 -- cortesoperador-id:20'),(24,'editar','maritza','2020-03-25 22:57:00','viaje-id:295'),(25,'agregar','maritza','2020-03-25 22:57:00','viaje-id:295 -- cortesoperador-id:21'),(26,'eliminar','maritza','2020-03-25 22:58:00','viaje-id:295 -- cortesoperador-id:20'),(27,'editar','maritza','2020-03-25 22:58:00','viaje-id:295'),(28,'agregar','maritza','2020-03-25 23:03:00','gasolineria-id:8'),(29,'agregar','maritza','2020-03-25 23:04:00','gasolineria-id:9'),(30,'agregar','maritza','2020-03-25 23:07:00','deposito-id:16'),(31,'agregar','maritza','2020-03-25 23:08:00','viaje-id:294 -- gasto-id:28'),(32,'agregar','maritza','2020-03-25 23:08:00','viaje-id:294 -- cortesoperador-id:22'),(33,'editar','maritza','2020-03-25 23:08:00','viaje-id:294'),(34,'editar','maritza','2020-03-25 23:09:00','viaje-id:294'),(35,'editar','maritza','2020-03-25 23:09:00','viaje-id:297'),(36,'agregar','maritza','2020-03-25 23:12:00','viaje-id:298'),(37,'agregar','maritza','2020-03-25 23:12:00','viaje-id:298 -- operador-id:6'),(38,'agregar','maritza','2020-03-25 23:13:00','deposito-id:17'),(39,'editar','maritza','2020-03-25 23:13:00','viaje-id:298'),(40,'agregar','maritza','2020-03-25 23:13:00','viaje-id:298 -- gasto-id:29'),(41,'agregar','maritza','2020-03-25 23:14:00','viaje-id:298 -- gasto-id:30'),(42,'agregar','maritza','2020-03-25 23:14:00','viaje-id:298 -- gasto-id:31'),(43,'agregar','maritza','2020-03-25 23:15:00','viaje-id:298 -- gasto-id:32'),(44,'agregar','maritza','2020-03-25 23:15:00','viaje-id:298 -- gasto-id:33'),(45,'agregar','maritza','2020-03-25 23:16:00','viaje-id:298 -- cortesoperador-id:23'),(46,'editar','maritza','2020-03-25 23:16:00','viaje-id:298'),(47,'agregar','maritza','2020-03-25 23:28:00','viaje-id:299'),(48,'agregar','maritza','2020-03-25 23:28:00','viaje-id:299 -- operador-id:13'),(49,'agregar','maritza','2020-03-25 23:31:00','ruta-id:174'),(50,'agregar','maritza','2020-03-25 23:33:00','viaje-id:300'),(51,'agregar','maritza','2020-03-25 23:33:00','viaje-id:300 -- operador-id:19'),(52,'agregar','maritza','2020-03-25 23:35:00','deposito-id:18'),(53,'editar','maritza','2020-03-25 23:35:00','viaje-id:300'),(54,'agregar','maritza','2020-03-25 23:36:00','viaje-id:300 -- gasto-id:34'),(55,'agregar','maritza','2020-03-25 23:36:00','viaje-id:300 -- gasto-id:35'),(56,'agregar','maritza','2020-03-25 23:37:00','viaje-id:300 -- gasto-id:36'),(57,'agregar','maritza','2020-03-25 23:37:00','viaje-id:300 -- gasto-id:37'),(58,'agregar','maritza','2020-03-25 23:37:00','viaje-id:300 -- gasto-id:38'),(59,'agregar','maritza','2020-03-25 23:38:00','viaje-id:300 -- gasto-id:39'),(60,'agregar','maritza','2020-03-25 23:40:00','viaje-id:300 -- gasto-id:40'),(61,'agregar','maritza','2020-03-25 23:40:00','viaje-id:300 -- gasto-id:41'),(62,'agregar','maritza','2020-03-25 23:41:00','viaje-id:300 -- gasto-id:42'),(63,'agregar','maritza','2020-03-25 23:41:00','viaje-id:300 -- gasto-id:43'),(64,'agregar','maritza','2020-03-25 23:42:00','viaje-id:300 -- gasto-id:44'),(65,'agregar','maritza','2020-03-25 23:42:00','viaje-id:300 -- gasto-id:45'),(66,'agregar','maritza','2020-03-25 23:43:00','viaje-id:300 -- gasto-id:46'),(67,'agregar','maritza','2020-03-25 23:43:00','viaje-id:300 -- gasto-id:47'),(68,'agregar','maritza','2020-03-25 23:43:00','viaje-id:300 -- gasto-id:48'),(69,'agregar','maritza','2020-03-25 23:44:00','viaje-id:300 -- gasto-id:49'),(70,'editar','maritza','2020-03-25 23:44:00','viaje-id:300'),(71,'agregar','maritza','2020-03-25 23:48:00','ruta-id:175'),(72,'agregar','maritza','2020-03-25 23:48:00','ruta-id:176'),(73,'agregar','maritza','2020-03-25 23:49:00','ruta-id:177'),(74,'agregar','maritza','2020-03-25 23:51:00','ruta-id:178'),(75,'agregar','maritza','2020-03-25 23:54:00','ruta-id:179'),(76,'agregar','maritza','2020-03-25 23:56:00','ruta-id:180'),(77,'editar','maritza','2020-03-25 23:56:00','viaje-id:300'),(78,'editar','maritza','2020-03-25 23:56:00','viaje-id:299'),(79,'agregar','maritza','2020-03-26 06:56:00','viaje-id:301'),(80,'agregar','maritza','2020-03-26 06:56:00','viaje-id:301 -- operador-id:15'),(81,'agregar','maritza','2020-03-26 06:57:00','viaje-id:302'),(82,'agregar','maritza','2020-03-26 06:57:00','viaje-id:302 -- operador-id:24'),(83,'agregar','maritza','2020-03-26 06:58:00','viaje-id:303'),(84,'agregar','maritza','2020-03-26 06:58:00','viaje-id:303 -- operador-id:7'),(85,'agregar','maritza','2020-03-26 06:58:00','viaje-id:304'),(86,'agregar','maritza','2020-03-26 06:58:00','viaje-id:304 -- operador-id:17'),(87,'agregar','maritza','2020-03-26 06:59:00','ruta-id:181'),(88,'agregar','maritza','2020-03-26 07:00:00','ruta-id:182'),(89,'editar','maritza','2020-03-26 07:00:00','ruta-id:181'),(90,'editar','maritza','2020-03-26 07:00:00','ruta-id:180'),(91,'editar','maritza','2020-03-26 07:00:00','ruta-id:179'),(92,'agregar','maritza','2020-03-26 07:03:00','viaje-id:305'),(93,'agregar','maritza','2020-03-26 07:03:00','viaje-id:305 -- operador-id:11'),(94,'agregar','maritza','2020-03-26 07:04:00','viaje-id:306'),(95,'agregar','maritza','2020-03-26 07:04:00','viaje-id:306 -- operador-id:22'),(96,'agregar','maritza','2020-03-26 07:05:00','ruta-id:183'),(97,'agregar','maritza','2020-03-26 07:05:00','ruta-id:184'),(98,'agregar','maritza','2020-03-26 07:06:00','ruta-id:185'),(99,'editar','maritza','2020-03-26 07:07:00','ruta-id:163'),(100,'editar','maritza','2020-03-26 07:09:00','ruta-id:166'),(101,'agregar','maritza','2020-03-26 07:09:00','viaje-id:307'),(102,'agregar','maritza','2020-03-26 07:09:00','viaje-id:307 -- operador-id:13'),(103,'agregar','maritza','2020-03-26 07:17:00','viaje-id:308'),(104,'agregar','maritza','2020-03-26 07:17:00','viaje-id:308 -- operador-id:4'),(105,'agregar','maritza','2020-03-26 07:35:00','viaje-id:309'),(106,'agregar','maritza','2020-03-26 07:35:00','viaje-id:309 -- operador-id:13'),(107,'eliminar','maritza','2020-03-26 07:35:00','viaje-id:309 -- operador-id:13'),(108,'editar','maritza','2020-03-26 07:35:00','viaje-id:309'),(109,'eliminar','maritza','2020-03-26 07:36:00','viaje-id:309'),(110,'agregar','maritza','2020-03-26 07:42:00','viaje-id:310'),(111,'agregar','maritza','2020-03-26 07:42:00','viaje-id:310 -- operador-id:3'),(112,'agregar','maritza','2020-03-26 07:51:00','viaje-id:311'),(113,'agregar','maritza','2020-03-26 07:51:00','viaje-id:311 -- operador-id:8'),(114,'agregar','maritza','2020-03-26 07:53:00','viaje-id:312'),(115,'agregar','maritza','2020-03-26 07:53:00','viaje-id:312 -- operador-id:17'),(116,'agregar','maritza','2020-03-26 07:54:00','viaje-id:313'),(117,'agregar','maritza','2020-03-26 07:54:00','viaje-id:313 -- operador-id:12'),(118,'agregar','maritza','2020-03-26 08:01:00','ruta-id:186'),(119,'agregar','maritza','2020-03-26 08:01:00','viaje-id:314'),(120,'agregar','maritza','2020-03-26 08:01:00','viaje-id:314 -- operador-id:13'),(121,'agregar','maritza','2020-03-26 08:32:00','deposito-id:19'),(122,'agregar','test','2020-03-26 10:32:00','viaje-id:315'),(123,'agregar','test','2020-03-26 10:32:00','viaje-id:315 -- operador-id:21'),(124,'eliminar','test','2020-03-26 10:33:00','viaje-id:315 -- operador-id:21'),(125,'eliminar','test','2020-03-26 10:33:00','viaje-id:315');
/*!40000 ALTER TABLE `log` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `operador`
--

DROP TABLE IF EXISTS `operador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `operador` (
  `idoperador` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) NOT NULL,
  `apellidos` varchar(100) NOT NULL,
  `fechaIngreso` datetime NOT NULL,
  `salarioporhora` double NOT NULL,
  `direccion` varchar(500) NOT NULL,
  `telefonoDeCasa` varchar(20) NOT NULL,
  `celular` varchar(20) NOT NULL,
  `correo` varchar(50) NOT NULL,
  `fechaDeVencimientoExamenMedico` datetime NOT NULL,
  `numeroDeLicencia` varchar(15) NOT NULL,
  `fechaDeVencimientoLicencia` datetime NOT NULL,
  `numSeguroSocial` varchar(15) NOT NULL,
  PRIMARY KEY (`idoperador`)
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `operador`
--

LOCK TABLES `operador` WRITE;
/*!40000 ALTER TABLE `operador` DISABLE KEYS */;
INSERT INTO `operador` VALUES (3,'JUAN','PEREZ ORTEGA','2019-01-16 17:42:00',25,'Sin dirección por el momento','NA','2222755717','sci@gmail.com','2019-01-30 10:20:00','PUE0037394','2020-01-30 10:20:00','62129300539'),(4,'Martin','Arellano Portilla','2019-01-01 11:20:00',50,'na','-','2226280339','sci@gmail.com','2019-01-08 11:20:00','PUE14394','2021-01-15 11:20:00','142569764'),(5,'GERALDO ','TEPALE CORNEJOR','2019-01-07 13:08:00',25,'NA','na','2271160897','sci@gmail.com','2020-02-07 13:08:00','PUE0036841','2020-02-07 13:08:00','46068732568 '),(6,'Octavio ','Coyotl Hernandez','2019-01-07 13:38:00',25,'C Francisco I Madero 10 Pblo San Mateo Cuanala\r\nCP 72640\r\nJuan C Bonilla, Pue','-','2223084943','sci@gmail.com','2020-06-08 13:38:00','PUE0021080','2020-06-14 13:38:00','62977896554'),(7,'Carlos Gerardo','Estrada Hernandez','2019-02-06 13:52:00',25,'Conj Hab Geovillas Los Encinos\r\nCp 72590\r\nPuebla, pue','-','2224114004','sci@gmail.com','2019-02-03 13:52:00','PUE0026397','2021-02-08 13:52:00','62897026084'),(8,'Jorge','Tellez Sanchez','2020-02-07 14:00:00',20,'Calle Guadalupe LT 30\r\nCol San Diego Ecatepec, Chachapa\r\nCP 72990\r\nAmozoc, Pue','-','2212040324','sci@gmail.com','2020-02-02 14:00:00','PUE0018089','2020-02-02 14:00:00','6291722566'),(10,'Mario','Perez','2019-02-10 17:06:00',12,'na','na','2212882072','sci@gmal.com','2020-02-10 17:06:00','-','2020-02-10 17:06:00','-'),(11,'Domingo','Hernandez Juarez','2019-02-10 17:09:00',23,'na','na','2271119353','sci@gmail.com','2019-02-10 17:09:00','na','2020-02-10 17:09:00','na'),(12,'Leobardo','Juarez','2020-02-10 17:10:00',25,'na','na','2271159048','sci@gmail.com','2020-02-10 17:10:00','-','2020-02-10 17:10:00','-'),(13,'Ruben ','Soto','2020-02-10 17:12:00',25,'na','na','2465931732','sci@gmail.com','2020-02-10 17:12:00','-','2020-02-10 17:12:00','-'),(14,'Emmanuel','Morales','2020-02-10 17:13:00',25,'na','na','2214267768','sci@gmail.com','2020-02-10 17:13:00','-','2020-02-10 17:13:00','-'),(15,'Ricardo','Mata Nuñez','2019-02-10 17:36:00',25,'na','na','2481807466','sci@gmail.com','2020-02-10 17:36:00','-','2020-02-10 17:36:00','-'),(16,'Raul','Ramirez Romero','2020-02-10 17:38:00',25,'na','na','2212850612','sci@gmail.com','2020-02-10 17:38:00','-','2020-02-10 17:38:00','-'),(17,'Jose Eduardo','Espinosa','2020-02-10 17:38:00',23,'na','-','2215788824','sci@gmail.com','2020-02-10 17:38:00','-','2020-02-10 17:38:00','-'),(18,'Fredy','Martinez','2020-02-10 17:39:00',25,'na','-','2711037879','sci@gmail.com','2020-02-10 17:39:00','-','2020-02-10 17:39:00','-'),(19,'Alvaro','Pedro Marques','2020-02-10 17:40:00',25,'na','-','2224586649','sci@gmail.com','2020-02-10 17:40:00','-','2020-02-10 17:40:00','-'),(20,'Jordan Armando','Dorado Trujillo','2020-02-10 17:41:00',25,'na','-','9514086405','sci@gmail.com','2020-02-10 17:41:00','-','2020-02-10 17:41:00','-'),(21,'Luis Lazaro','Valencia Sanchez','2020-02-10 17:43:00',20,'na','na','na','sci@gmail.com','2020-04-11 17:43:00','-','2020-02-10 17:43:00','-'),(22,'Ricardo Arturo','Rodriguez Mendizabal','2020-02-10 17:43:00',20,'na','-','2481807466','sci@gmail.com','2020-02-10 17:43:00','-','2020-02-10 17:43:00','-'),(23,'Aurelio','Juarez Tepox','2020-02-10 17:45:00',20,'na','n','2228429107','sci@gmail.com','2020-02-10 17:45:00','-','2020-02-10 17:45:00','-'),(24,'Issac','Lozada','2020-02-10 17:47:00',20,'na','na','2213189788/','sci@gmail.com','2020-02-10 17:47:00','.','2020-02-10 17:47:00',',');
/*!40000 ALTER TABLE `operador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `operadoresenviaje`
--

DROP TABLE IF EXISTS `operadoresenviaje`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `operadoresenviaje` (
  `idRegistro` int(11) NOT NULL AUTO_INCREMENT,
  `idOperador` int(11) NOT NULL,
  `idViajeSci` int(11) NOT NULL,
  `saldoActual` double NOT NULL,
  `posicion` int(11) NOT NULL,
  PRIMARY KEY (`idRegistro`),
  KEY `operadoresenviaje_fk0_idx` (`idOperador`),
  KEY `operadoresenviaje_fk1_idx` (`idViajeSci`),
  CONSTRAINT `operadoresenviaje_fk0` FOREIGN KEY (`idOperador`) REFERENCES `operador` (`idoperador`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `operadoresenviaje_fk1` FOREIGN KEY (`idViajeSci`) REFERENCES `viaje` (`idViajeSci`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=77 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `operadoresenviaje`
--

LOCK TABLES `operadoresenviaje` WRITE;
/*!40000 ALTER TABLE `operadoresenviaje` DISABLE KEYS */;
INSERT INTO `operadoresenviaje` VALUES (55,21,294,0,0),(56,15,295,0,0),(57,7,296,0,0),(58,12,297,0,0),(59,6,298,0,0),(60,13,299,0,0),(61,19,300,736,0),(62,15,301,0,0),(63,24,302,0,0),(64,7,303,0,0),(65,17,304,0,0),(66,11,305,0,0),(67,22,306,0,0),(68,13,307,0,0),(69,4,308,0,0),(71,3,310,0,0),(72,8,311,0,0),(73,17,312,0,0),(74,12,313,0,0),(75,13,314,0,0);
/*!40000 ALTER TABLE `operadoresenviaje` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ruta`
--

DROP TABLE IF EXISTS `ruta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ruta` (
  `idruta` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(200) NOT NULL,
  `costo` double NOT NULL,
  `unidadAfacturar` varchar(20) NOT NULL,
  `idcliente` int(11) DEFAULT NULL,
  PRIMARY KEY (`idruta`),
  KEY `ruta_fk0_idx` (`idcliente`)
) ENGINE=InnoDB AUTO_INCREMENT=187 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ruta`
--

LOCK TABLES `ruta` WRITE;
/*!40000 ALTER TABLE `ruta` DISABLE KEYS */;
INSERT INTO `ruta` VALUES (154,'RENTA CAMIONETA 24 HRS',2800,'Camioneta',12),(155,'JIT - PSW - JIT',3800,'Trailer',5),(156,'JIT - CAZEL/GILL - JIT',8950,'Trailer',5),(157,'FYNOTEJ - FAURECIA C&C',7200,'Trailer',5),(158,'CGR - FAURECIA C&S',8800,'Torthon',5),(159,'GST/LEAR/TEXTILES/PSW - FAURECIA JIT/C&S',11400,'Torthon',5),(160,'FRAMES - RESORTES/BROSE - FRAMES',11300,'Torthon',5),(161,'MILK RUN FAS SLP FRAMES (6 DÍAS)',39200,'Trailer',5),(162,'TRAILER NICRO BOLTA - SMP ZITLALTEPEC - NICRO BOLTA',4900,'Trailer',7),(163,'TORTHON  NICRO BOLTA - PLASTIC OMNIUM - NICRO BOLTA',1450,'Torthon',7),(164,'TORTHON NICRO BOLTA - VW FINSA',1200,'Torthon',7),(165,'CAMIONETA 3.5 CIE GLOBAL N21 - HATCH',1,'Camioneta',9),(166,'TORTHON CIE GLOBAL N21 - OUTSERT - CIE GLOBAL N21',830,'Torthon',9),(167,'TRAILER TELCH - LUNKETEC',2730,'Trailer',11),(168,'CAMIONETA 3.5  CENSA - CIE GLOBAL N21',4000,'Camioneta',9),(169,'CAMIONETA 3.5 VW COVADONGA/ VW NAVE 31 - CIE GLOBAL N21',1200,'Camioneta',5),(170,'TRAILER  CIE GLOBAL - ISGO - CIE GLOBAL',15000,'Trailer',9),(171,'TORTHON   NATZIPPER/BADER - N29',22000,'Torthon',5),(172,'FXI - N29',7200,'Torthon',5),(174,'NATZIPPER / BADER / NESS - FAURECIA JIT',14800,'Torthon',5),(175,'FAURECIA JIT - NISSAN - FAURECIA JIT',4400,'TORTHON',5),(176,'AUNDE / MEXIQUE - FAURECIA JIT / FAURECIA C&S',2000,'TORTHON',5),(177,'FAURECIA SLP FRAMES - FAURECIA JIT',1,'TORTHON',5),(178,'MTC COATINGS - KIEKERT',4800,'TORTHON',8),(179,'NICRO BOLTA - UNICAR - NICRO BOLTA',1450,'Torthon',7),(180,'TORTHON SMP PUEBLA - NICRO BOLTA',1200,'Torthon',7),(181,'TORTHON NICRO BOLTA - VW COVADONGA',1450,'Torthon',7),(182,'TRAILER NICRO BOLTA - PLASTIC OMNIUM - NICRO BOLTA',1700,'Trailer',7),(183,'TORTHON FAURECIA JIT - NISSAN',4400,'Torthon',5),(184,'TORTHON CIE GLOBAL N21 - VW COVADONGA',1200,'Torthon',9),(185,'TRAILER NICRO BOLTA - MITSUBA - NICRO BOLTA',1,'Trailer',7),(186,'TORTHON KIEKERT - VW COVADONGA',1200,'Torthon',8);
/*!40000 ALTER TABLE `ruta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `statusviaje`
--

DROP TABLE IF EXISTS `statusviaje`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `statusviaje` (
  `idStatus` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`idStatus`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `statusviaje`
--

LOCK TABLES `statusviaje` WRITE;
/*!40000 ALTER TABLE `statusviaje` DISABLE KEYS */;
INSERT INTO `statusviaje` VALUES (1,'Iniciado'),(2,'En Tránsito'),(3,'En Espera'),(4,'Entregado'),(5,'Cerrado'),(6,'Cancelado'),(7,'En Falso');
/*!40000 ALTER TABLE `statusviaje` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipogasto`
--

DROP TABLE IF EXISTS `tipogasto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipogasto` (
  `idTipoGasto` int(11) NOT NULL AUTO_INCREMENT,
  `concepto` varchar(100) NOT NULL,
  PRIMARY KEY (`idTipoGasto`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipogasto`
--

LOCK TABLES `tipogasto` WRITE;
/*!40000 ALTER TABLE `tipogasto` DISABLE KEYS */;
INSERT INTO `tipogasto` VALUES (1,'Combustible'),(2,'Casetas'),(3,'Comida'),(4,'Mantenimiento'),(5,'Infracciones'),(6,'Pensión'),(7,'Maniobras'),(8,'Báscula');
/*!40000 ALTER TABLE `tipogasto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipounidad`
--

DROP TABLE IF EXISTS `tipounidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tipounidad` (
  `idTipoDeUnidad` int(11) NOT NULL AUTO_INCREMENT,
  `descripcion` varchar(20) NOT NULL,
  PRIMARY KEY (`idTipoDeUnidad`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipounidad`
--

LOCK TABLES `tipounidad` WRITE;
/*!40000 ALTER TABLE `tipounidad` DISABLE KEYS */;
INSERT INTO `tipounidad` VALUES (1,'Trailer'),(2,'Torthon'),(3,'Camioneta'),(4,'Camioneta Pickup');
/*!40000 ALTER TABLE `tipounidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `unidades`
--

DROP TABLE IF EXISTS `unidades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `unidades` (
  `idUnidad` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(50) NOT NULL,
  `numeroEconomico` int(11) NOT NULL,
  `placas` varchar(15) NOT NULL,
  `numeroserie` varchar(50) NOT NULL,
  `polizaSeguro` varchar(20) NOT NULL,
  `fechaVencimientoSeguro` datetime NOT NULL,
  `tipocombustible` varchar(50) NOT NULL,
  `idTipoDeUnidad` int(11) NOT NULL,
  PRIMARY KEY (`idUnidad`),
  KEY `unidades_fk0_idx` (`idTipoDeUnidad`),
  CONSTRAINT `unidades_fk0` FOREIGN KEY (`idTipoDeUnidad`) REFERENCES `tipounidad` (`idTipoDeUnidad`)
) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unidades`
--

LOCK TABLES `unidades` WRITE;
/*!40000 ALTER TABLE `unidades` DISABLE KEYS */;
INSERT INTO `unidades` VALUES (23,'ELF 400',31,'40AK-1X','JAANPR750K7000153','SDSDSDFSDF','2020-02-05 08:20:00','Diesel',3),(24,'Trailer 40',40,'XS595W-544','ALKJQL6546','6549A-DQEASD654','2022-02-06 19:28:00','Gasolina',1),(25,'CAMIONETA F-450	',13,'690-ET-8	','3FDXF46S22MA39438	','00000306134032	','2020-04-30 06:45:00','Gasolina',3),(26,'KODIAK 2002	',3,'413-AN-1	','3 G B M 7 H 1 E 0 2 M 1 0 8 4 9 7 	','M9 37005026	','2020-03-31 06:47:00','Diesel',2),(27,'CAMIONETA 2004	',2,'375-AS-1	','3 G B J C 3 4 R X 4 M 1 0 1 8 2 1	','2098905','2020-02-07 06:48:00','Gasolina',3),(28,'FREIGHTLINER	',25,'45AH-2X	','3AKJC5CV8JDJV7213	','3200163893	','2020-05-31 06:52:00','Diesel',1),(29,'FREIGHTLINER	',11,'396-ER-5	','3ALACXCS3EDFN0798	','0940272192	','2020-05-31 06:53:00','Diesel',2),(31,'FREIGHTLINER	',20,'46AH4X	','3ALHCYDJ6FDGC7039	','0940259855	','2020-05-31 06:56:00','Diesel',1),(32,'FREIGHTLINER	',28,'16AK-1U','3ALHCYDJ8KDKP5951	','3200130715	','2020-05-31 06:58:00','Diesel',1),(33,'FREIGHTLINER	',22,'78-AL-2M	','902910C1125418	','0150132521	','2020-05-31 07:08:00','Diesel',2),(34,'FREIGHTLINER	',10,'76 AN 2L','3ALACXCS5CDBJ8176	','´0940268528	','2020-05-31 07:09:00','Diesel',2),(35,'WORKER	',16,'76-AB-5J','123654123','0940260997	','2020-05-31 07:47:00','Diesel',2),(36,'FREIGHTLINER	',6,'663-AU-1','3ALACXCS2CDBE8022	','0940263817	','2020-05-31 07:54:00','Diesel',2),(38,'ELF400	',17,'96-AE-1H	','JAANPR755H7002280	','1674176	','2020-05-31 07:59:00','Diesel',3),(39,'FREIGHTLINER	',7,'560-EW-2	','3ALHCYDJ2FDGC7037	','0940271589	','2020-05-31 08:00:00','Diesel',1),(41,'Polo',9,'UBL-5377	','9BWJB09A74P001160	','2106704	','2020-05-31 08:03:00','Gasolina',4),(42,'CHEYENNE 2003	',12,'SK09379	','1GCEC14T33Z215119	','6599260	','2020-05-31 08:04:00','Gasolina',3),(43,'NP 300 NISSAN',14,'SM-62771	','3N6AD35AXHK836623	','C00007316	','2020-05-31 08:05:00','Gasolina',4),(44,'FREIGHTLINER	',15,'777-ET-8	','3ALFCYCSXEDFM3584	','0940270809	','2020-05-31 08:06:00','Diesel',1),(45,'TRACTOCAMION FREIGHTLINER	',18,'44AH-2X	','1FUJA6AV09LAE9149	','0940271597	','2020-05-31 08:07:00','Diesel',1),(46,'FREIGHTLINER	',21,'467-FE-1	','3ALACYCS9JDJK2487	','0003081870	','2020-05-31 08:09:00','Diesel',2),(47,'FREIGHTLINER	',23,'79-AL-2M	','3ALACYCS7JDJK2486	','0150132522	','2020-05-31 08:10:00','Diesel',2),(48,'FREIGHTLINER	',24,'466-FE-1	','3ALACYCS0JDJK2488	','0003081861	','2020-05-31 08:11:00','Diesel',2),(49,'FREIGHTLINER	',26,'46AH-2X	','3ALHCYDJ4JDJV7166	','3200163895	','2020-05-31 08:12:00','Diesel',1),(50,'FREIGHTLINER	',29,'15AK-1U	','3ALHCYDJ1KDKP5953	','3200130714	','2020-05-31 08:12:00','Diesel',1),(51,'NP 300	NISSAN',30,'SM63088	','3N6AD35AXKK844096	','324200600041	','2020-05-31 08:13:00','Gasolina',4),(53,'KODIA 2000',4,'457-AS-1','-','-','2020-02-13 19:36:00','Diesel',2);
/*!40000 ALTER TABLE `unidades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `nombreusuario` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `nombrecompleto` varchar(50) NOT NULL,
  PRIMARY KEY (`nombreusuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES ('edgar','edgar','Edgar'),('espinosa.sistemas','123456','Juan Espinosa'),('fabi','Falomay@-1','Fabiola Coba'),('mariana','Falomay@-1','Mariana Azcue'),('maritza','maritza','Maritza'),('root','Falomay@-2','Usuario administrador'),('test','x','Usuario de Prueba'),('yasmin','Falomay@-1','Yasmin Robles');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `viaje`
--

DROP TABLE IF EXISTS `viaje`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `viaje` (
  `idViajeSci` int(11) NOT NULL AUTO_INCREMENT,
  `idViajeCliente` varchar(100) NOT NULL,
  `fechaInicio` datetime NOT NULL,
  `fechaFin` datetime DEFAULT '0000-00-00 00:00:00',
  `idStatus` int(11) NOT NULL,
  `idRuta` int(11) NOT NULL,
  `idUnidad` int(11) NOT NULL,
  PRIMARY KEY (`idViajeSci`),
  KEY `viaje_fk0` (`idStatus`),
  KEY `viaje_fk1` (`idRuta`),
  KEY `viaje_fk4_idx` (`idUnidad`),
  KEY `viaje_fk5_idx` (`idViajeSci`),
  CONSTRAINT `viaje_fk0` FOREIGN KEY (`idStatus`) REFERENCES `statusviaje` (`idStatus`),
  CONSTRAINT `viaje_fk1` FOREIGN KEY (`idRuta`) REFERENCES `ruta` (`idruta`),
  CONSTRAINT `viaje_fk4` FOREIGN KEY (`idUnidad`) REFERENCES `unidades` (`idUnidad`)
) ENGINE=InnoDB AUTO_INCREMENT=316 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `viaje`
--

LOCK TABLES `viaje` WRITE;
/*!40000 ALTER TABLE `viaje` DISABLE KEYS */;
INSERT INTO `viaje` VALUES (294,'','2020-03-22 21:00:00','2020-03-23 06:00:00',4,154,27),(295,'','2020-03-22 23:00:00','2020-03-23 06:00:00',4,154,38),(296,'','2020-03-22 23:00:00','2020-03-24 06:00:00',4,154,25),(297,'','2020-03-23 06:00:00','2020-03-24 06:00:00',4,155,39),(298,'PJD001','2020-03-23 16:00:00','0001-01-01 00:00:00',4,156,50),(299,'PUD300','2020-03-23 08:00:00','0001-01-01 00:00:00',4,159,48),(300,'PJD004','2020-03-23 07:00:00','0001-01-01 00:00:00',4,174,33),(301,'','2020-03-26 06:00:00','0001-01-01 00:00:00',1,154,23),(302,'','2020-03-26 06:00:00','0001-01-01 00:00:00',1,154,27),(303,'','2020-03-26 06:00:00','0001-01-01 00:00:00',1,154,25),(304,'','2020-03-26 09:00:00','0001-01-01 00:00:00',1,162,28),(305,'','2020-03-26 08:00:00','0001-01-01 00:00:00',1,181,29),(306,'','2020-03-26 05:00:00','0001-01-01 00:00:00',1,170,32),(307,'','2020-03-26 11:00:00','0001-01-01 00:00:00',1,166,34),(308,'','2020-03-26 09:00:00','0001-01-01 00:00:00',1,185,31),(310,'','2020-03-26 07:36:00','0001-01-01 00:00:00',1,183,38),(311,'','2020-03-26 05:00:00','0001-01-01 00:00:00',1,160,48),(312,'','2020-03-26 20:00:00','0001-01-01 00:00:00',1,182,28),(313,'','2020-03-26 05:00:00','0001-01-01 00:00:00',1,184,47),(314,'','2020-03-26 09:00:00','0001-01-01 00:00:00',1,186,34);
/*!40000 ALTER TABLE `viaje` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-03-26 11:10:37
