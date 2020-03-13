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
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
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
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cortesoperador`
--

LOCK TABLES `cortesoperador` WRITE;
/*!40000 ALTER TABLE `cortesoperador` DISABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deposito`
--

LOCK TABLES `deposito` WRITE;
/*!40000 ALTER TABLE `deposito` DISABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gasolineria`
--

LOCK TABLES `gasolineria` WRITE;
/*!40000 ALTER TABLE `gasolineria` DISABLE KEYS */;
INSERT INTO `gasolineria` VALUES (5,'3 MObil de Autopista','Carretara a CDMX km 45 ','EISJ8412182D1','JUAN ESPINOSA','2221846700','juan@gmail.com',2),(6,'Gasolinería del Centro','Centro Puebla','SDF5619-4A65Q','Mobil Sa de CV','222 584 6846','mobil@gmail.com',2);
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
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gasto`
--

LOCK TABLES `gasto` WRITE;
/*!40000 ALTER TABLE `gasto` DISABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=530 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `log`
--

LOCK TABLES `log` WRITE;
/*!40000 ALTER TABLE `log` DISABLE KEYS */;
INSERT INTO `log` VALUES (1,'agregar','espinosa.sistemas','2020-02-07 17:31:00','unidades->id:40'),(2,'editar','espinosa.sistemas','2020-02-07 17:32:00','unidades-id:40'),(3,'eliminar','espinosa.sistemas','2020-02-07 17:35:00','unidades-id:40'),(4,'agregar','espinosa.sistemas','2020-02-07 18:07:00','operador-id:9'),(5,'editar','espinosa.sistemas','2020-02-07 18:08:00','operador-id:9'),(6,'eliminar','espinosa.sistemas','2020-02-07 18:08:00','operador-id:9'),(7,'agregar','espinosa.sistemas','2020-02-10 11:07:00','cliente-id:6'),(8,'editar','espinosa.sistemas','2020-02-10 11:16:00','cliente-id:6'),(9,'eliminar','espinosa.sistemas','2020-02-10 11:17:00','cliente-id:6'),(10,'agregar','espinosa.sistemas','2020-02-11 10:11:00','ruta-id:10'),(11,'editar','espinosa.sistemas','2020-02-11 10:12:00','ruta-id:10'),(12,'eliminar','espinosa.sistemas','2020-02-11 10:12:00','ruta-id:10'),(13,'agregar','espinosa.sistemas','2020-02-11 10:22:00','caseta-id:7'),(14,'editar','espinosa.sistemas','2020-02-11 10:22:00','caseta-id:7'),(15,'eliminar','espinosa.sistemas','2020-02-11 10:23:00','caseta-id:7'),(16,'agregar','espinosa.sistemas','2020-02-11 10:33:00','gasolineria-id:8'),(17,'editar','espinosa.sistemas','2020-02-11 10:33:00','gasolineria-id:8'),(18,'eliminar','espinosa.sistemas','2020-02-11 10:33:00','gasolineria-id:8'),(19,'agregar','espinosa.sistemas','2020-02-11 10:47:00','tipogasto-id:7'),(20,'editar','espinosa.sistemas','2020-02-11 10:47:00','tipogasto-id:7'),(21,'agregar','espinosa.sistemas','2020-02-11 10:51:00','tipogasto-id:8'),(22,'editar','espinosa.sistemas','2020-02-11 10:51:00','tipogasto-id:8'),(23,'eliminar','espinosa.sistemas','2020-02-11 10:51:00','gasto-id:8'),(24,'agregar','espinosa.sistemas','2020-02-11 10:53:00','tipogasto-id:9'),(25,'eliminar','espinosa.sistemas','2020-02-11 10:54:00','tipogasto-id:9'),(26,'eliminar','espinosa.sistemas','2020-02-11 10:59:00','statusviaje-id:14'),(27,'editar','espinosa.sistemas','2020-02-11 10:59:00','statusviaje-id:13'),(28,'eliminar','espinosa.sistemas','2020-02-11 10:59:00','statusviaje-id:13'),(29,'eliminar','espinosa.sistemas','2020-02-11 10:59:00','statusviaje-id:12'),(30,'eliminar','espinosa.sistemas','2020-02-11 10:59:00','statusviaje-id:11'),(31,'agregar','espinosa.sistemas','2020-02-11 11:00:00','statusviaje-id:15'),(32,'agregar','espinosa.sistemas','2020-02-11 11:44:00','viaje-id:15'),(33,'editar','espinosa.sistemas','2020-02-11 11:44:00','viaje-id:15'),(34,'agregar','espinosa.sistemas','2020-02-11 11:45:00','viaje-id:15 -- operador-id:21'),(35,'eliminar','espinosa.sistemas','2020-02-11 11:45:00','viaje-id:15 -- operador-id:21'),(36,'agregar','espinosa.sistemas','2020-02-11 11:45:00','viaje-id:15 -- operador-id:19'),(37,'agregar','espinosa.sistemas','2020-02-11 11:45:00','viaje-id:15 -- gasto-id:10'),(38,'editar','espinosa.sistemas','2020-02-11 11:46:00','viaje-id:15 -- gasto-id:10'),(39,'agregar','espinosa.sistemas','2020-02-11 11:50:00','viaje-id:15 -- gasto-id:11'),(40,'editar','espinosa.sistemas','2020-02-11 11:50:00','viaje-id:15 -- gasto-id:11'),(41,'agregar','espinosa.sistemas','2020-02-11 11:54:00','viaje-id:15 -- gasto-id:12'),(42,'agregar','espinosa.sistemas','2020-02-11 11:58:00','viaje-id:15 -- gasto-id:13'),(43,'eliminar','espinosa.sistemas','2020-02-11 11:58:00','viaje-id:15 -- gasto-id:13'),(44,'agregar','espinosa.sistemas','2020-02-11 12:00:00','viaje-id:15 -- cortesoperador-id:11'),(45,'editar','espinosa.sistemas','2020-02-11 12:00:00','viaje-id:15 -- cortesoperador-id:11'),(46,'eliminar','espinosa.sistemas','2020-02-11 12:00:00','viaje-id:15 -- cortesoperador-id:11'),(47,'eliminar','espinosa.sistemas','2020-02-11 12:01:00','viaje-id:15 -- operador-id:19'),(48,'eliminar','espinosa.sistemas','2020-02-11 12:01:00','viaje-id:15'),(49,'editar','fabi','2020-02-11 15:01:00','viaje-id:14'),(50,'editar','espinosa.sistemas','2020-02-12 14:18:00','caseta-id:11'),(51,'editar','espinosa.sistemas','2020-02-12 14:19:00','caseta-id:13'),(52,'agregar','test','2020-02-12 15:01:00','viaje-id:68 -- cortesoperador-id:18'),(53,'eliminar','test','2020-02-12 15:02:00','viaje-id:68 -- cortesoperador-id:18'),(54,'agregar','test','2020-02-12 15:58:00','viaje-id:81 -- gasto-id:20'),(55,'eliminar','test','2020-02-12 15:58:00','viaje-id:81 -- gasto-id:20'),(56,'editar','test','2020-02-14 14:54:00','viaje-id:68'),(57,'agregar','test','2020-02-14 14:58:00','caseta-id:34'),(58,'agregar','test','2020-02-14 18:24:00','viaje-id:50 -- cortesoperador-id:19'),(59,'editar','test','2020-02-14 18:25:00','viaje-id:50 -- cortesoperador-id:19'),(60,'editar','test','2020-02-14 18:27:00','viaje-id:58'),(61,'editar','test','2020-02-14 18:59:00','viaje-id:17'),(62,'eliminar','test','2020-02-18 11:09:00','viaje-id:23'),(63,'eliminar','test','2020-02-18 11:09:00','viaje-id:109'),(64,'eliminar','test','2020-02-18 11:09:00','viaje-id:108'),(65,'eliminar','test','2020-02-18 11:10:00','viaje-id:107'),(66,'eliminar','test','2020-02-18 11:10:00','viaje-id:106'),(67,'eliminar','test','2020-02-18 11:10:00','viaje-id:105'),(68,'eliminar','test','2020-02-18 11:10:00','viaje-id:104'),(69,'eliminar','test','2020-02-18 11:10:00','viaje-id:103'),(70,'eliminar','test','2020-02-18 11:10:00','viaje-id:102'),(71,'eliminar','test','2020-02-18 11:10:00','viaje-id:101'),(72,'eliminar','test','2020-02-18 11:10:00','viaje-id:100'),(73,'eliminar','test','2020-02-18 11:10:00','viaje-id:99'),(74,'eliminar','test','2020-02-18 11:10:00','viaje-id:98'),(75,'eliminar','test','2020-02-18 11:10:00','viaje-id:97'),(76,'eliminar','test','2020-02-18 11:10:00','viaje-id:96'),(77,'eliminar','test','2020-02-18 11:10:00','viaje-id:95'),(78,'eliminar','test','2020-02-18 11:10:00','viaje-id:94'),(79,'eliminar','test','2020-02-18 11:10:00','viaje-id:93'),(80,'eliminar','test','2020-02-18 11:10:00','viaje-id:92'),(81,'eliminar','test','2020-02-18 11:10:00','viaje-id:91'),(82,'eliminar','test','2020-02-18 11:10:00','viaje-id:90'),(83,'eliminar','test','2020-02-18 11:10:00','viaje-id:89'),(84,'eliminar','test','2020-02-18 11:10:00','viaje-id:88'),(85,'eliminar','test','2020-02-18 11:10:00','viaje-id:87'),(86,'eliminar','test','2020-02-18 11:10:00','viaje-id:86'),(87,'eliminar','test','2020-02-18 11:10:00','viaje-id:85'),(88,'eliminar','test','2020-02-18 11:10:00','viaje-id:84'),(89,'eliminar','test','2020-02-18 11:11:00','viaje-id:83'),(90,'eliminar','test','2020-02-18 11:11:00','viaje-id:82'),(91,'eliminar','test','2020-02-18 11:11:00','viaje-id:81'),(92,'eliminar','test','2020-02-18 11:11:00','viaje-id:80'),(93,'eliminar','test','2020-02-18 11:11:00','viaje-id:79'),(94,'eliminar','test','2020-02-18 11:11:00','viaje-id:78'),(95,'eliminar','test','2020-02-18 11:11:00','viaje-id:77'),(96,'eliminar','test','2020-02-18 11:11:00','viaje-id:76'),(97,'eliminar','test','2020-02-18 11:11:00','viaje-id:75'),(98,'eliminar','test','2020-02-18 11:11:00','viaje-id:74'),(99,'eliminar','test','2020-02-18 11:11:00','viaje-id:73'),(100,'eliminar','test','2020-02-18 11:11:00','viaje-id:72'),(101,'eliminar','test','2020-02-18 11:11:00','viaje-id:71'),(102,'eliminar','test','2020-02-18 11:11:00','viaje-id:70'),(103,'eliminar','test','2020-02-18 11:11:00','viaje-id:69'),(104,'eliminar','test','2020-02-18 11:11:00','viaje-id:67'),(105,'eliminar','test','2020-02-18 11:11:00','viaje-id:66'),(106,'eliminar','test','2020-02-18 11:11:00','viaje-id:65'),(107,'eliminar','test','2020-02-18 11:11:00','viaje-id:64'),(108,'eliminar','test','2020-02-18 11:11:00','viaje-id:63'),(109,'eliminar','test','2020-02-18 11:11:00','viaje-id:62'),(110,'eliminar','test','2020-02-18 11:11:00','viaje-id:61'),(111,'eliminar','test','2020-02-18 11:11:00','viaje-id:60'),(112,'eliminar','test','2020-02-18 11:11:00','viaje-id:59'),(113,'eliminar','test','2020-02-18 11:11:00','viaje-id:57'),(114,'eliminar','test','2020-02-18 11:11:00','viaje-id:56'),(115,'eliminar','test','2020-02-18 11:12:00','viaje-id:55'),(116,'eliminar','test','2020-02-18 11:12:00','viaje-id:54'),(117,'eliminar','test','2020-02-18 11:12:00','viaje-id:46'),(118,'eliminar','test','2020-02-18 11:12:00','viaje-id:53'),(119,'eliminar','test','2020-02-18 11:12:00','viaje-id:52'),(120,'eliminar','test','2020-02-18 11:12:00','viaje-id:51'),(121,'eliminar','test','2020-02-18 11:12:00','viaje-id:49'),(122,'eliminar','test','2020-02-18 11:12:00','viaje-id:48'),(123,'eliminar','test','2020-02-18 11:12:00','viaje-id:47'),(124,'eliminar','test','2020-02-18 11:12:00','viaje-id:45'),(125,'eliminar','test','2020-02-18 11:12:00','viaje-id:44'),(126,'eliminar','test','2020-02-18 11:12:00','viaje-id:43'),(127,'eliminar','test','2020-02-18 11:12:00','viaje-id:42'),(128,'eliminar','test','2020-02-18 11:12:00','viaje-id:41'),(129,'eliminar','test','2020-02-18 11:12:00','viaje-id:40'),(130,'eliminar','test','2020-02-18 11:12:00','viaje-id:39'),(131,'eliminar','test','2020-02-18 11:12:00','viaje-id:38'),(132,'eliminar','test','2020-02-18 11:12:00','viaje-id:37'),(133,'eliminar','test','2020-02-18 11:12:00','viaje-id:36'),(134,'eliminar','test','2020-02-18 11:12:00','viaje-id:35'),(135,'eliminar','test','2020-02-18 11:12:00','viaje-id:33'),(136,'eliminar','test','2020-02-18 11:12:00','viaje-id:32'),(137,'eliminar','test','2020-02-18 11:12:00','viaje-id:31'),(138,'eliminar','test','2020-02-18 11:12:00','viaje-id:30'),(139,'eliminar','test','2020-02-18 11:12:00','viaje-id:29'),(140,'eliminar','test','2020-02-18 11:12:00','viaje-id:28'),(141,'eliminar','test','2020-02-18 11:12:00','viaje-id:27'),(142,'eliminar','test','2020-02-18 11:12:00','viaje-id:26'),(143,'eliminar','test','2020-02-18 11:12:00','viaje-id:25'),(144,'eliminar','test','2020-02-18 11:12:00','viaje-id:24'),(145,'eliminar','test','2020-02-18 11:12:00','viaje-id:50'),(146,'eliminar','test','2020-02-18 11:13:00','viaje-id:58'),(147,'eliminar','test','2020-02-18 11:13:00','viaje-id:68'),(148,'agregar','test','2020-02-18 12:36:00','ruta-id:148'),(149,'editar','test','2020-02-18 12:37:00','ruta-id:148'),(150,'editar','test','2020-02-18 12:39:00','ruta-id:148'),(151,'editar','test','2020-02-18 17:58:00','ruta-id:148'),(152,'eliminar','test','2020-02-18 18:16:00','unidades-id:52'),(153,'eliminar','test','2020-02-18 18:16:00','unidades-id:30'),(154,'agregar','test','2020-02-18 18:17:00','unidades-id:54'),(155,'eliminar','test','2020-02-18 18:18:00','unidades-id:54'),(156,'agregar','test','2020-02-18 18:29:00','unidades-id:55'),(157,'eliminar','test','2020-02-18 18:30:00','unidades-id:55'),(158,'agregar','test','2020-02-18 18:34:00','unidades-id:56'),(159,'eliminar','test','2020-02-18 18:34:00','unidades-id:56'),(160,'editar','test','2020-02-18 18:41:00','ruta-id:148'),(161,'agregar','test','2020-02-18 18:53:00','viaje-id:112'),(162,'eliminar','test','2020-02-19 10:21:00','viaje-id:112'),(163,'agregar','test','2020-02-19 10:44:00','viaje-id:113'),(164,'agregar','test','2020-02-19 11:18:00','viaje-id:113 -- operador-id:4'),(165,'agregar','test','2020-02-19 11:21:00','viaje-id:114'),(166,'editar','test','2020-02-19 11:45:00','viaje-id:114'),(167,'editar','test','2020-02-19 11:55:00','viaje-id:114'),(168,'agregar','test','2020-02-19 12:41:00','viaje-id:115'),(169,'agregar','test','2020-02-19 13:57:00','viaje-id:120'),(170,'eliminar','test','2020-02-19 13:58:00','unidades-id:37'),(171,'editar','test','2020-02-19 14:03:00','viaje-id:113'),(172,'editar','test','2020-02-19 14:04:00','viaje-id:115'),(173,'editar','test','2020-02-19 14:04:00','viaje-id:113'),(174,'editar','test','2020-02-19 14:13:00','viaje-id:113'),(175,'editar','test','2020-02-19 14:13:00','viaje-id:113'),(176,'agregar','test','2020-02-19 14:28:00','viaje-id:113 -- cortesoperador-id:1'),(177,'agregar','test','2020-02-19 14:38:00','viaje-id:113 -- cortesoperador-id:2'),(178,'editar','test','2020-02-19 14:43:00','viaje-id:113 -- cortesoperador-id:2'),(179,'editar','test','2020-02-19 14:53:00','viaje-id:113 -- cortesoperador-id:2'),(180,'agregar','test','2020-02-19 18:48:00','viaje-id:121'),(181,'eliminar','test','2020-02-20 12:33:00','viaje-id:113 -- cortesoperador-id:2'),(182,'eliminar','test','2020-02-20 12:33:00','viaje-id:113 -- cortesoperador-id:1'),(183,'eliminar','test','2020-02-20 12:33:00','viaje-id:113 -- operador-id:4'),(184,'agregar','test','2020-02-20 12:54:00','viaje-id:113 -- operador-id:3'),(185,'agregar','test','2020-02-20 13:42:00','viaje-id:122'),(186,'agregar','root','2020-02-21 10:43:00','viaje-id:260'),(187,'agregar','root','2020-02-21 11:08:00','viaje-id:261'),(188,'agregar','root','2020-02-21 11:10:00','viaje-id:262'),(189,'agregar','root','2020-02-21 11:11:00','viaje-id:263'),(190,'agregar','root','2020-02-21 11:11:00','viaje-id:263 -- operador-id:21'),(191,'agregar','root','2020-02-21 11:11:00','viaje-id:263 -- operador-id:7'),(192,'agregar','root','2020-02-21 11:13:00','viaje-id:264'),(193,'agregar','root','2020-02-21 11:15:00','viaje-id:265'),(194,'agregar','root','2020-02-21 12:42:00','viaje-id:266'),(195,'agregar','root','2020-02-21 12:42:00','viaje-id:266 -- operador-id:6'),(196,'agregar','root','2020-02-21 12:42:00','viaje-id:266 -- operador-id:22'),(197,'agregar','root','2020-02-21 12:42:00','viaje-id:266 -- operador-id:8'),(198,'agregar','root','2020-02-21 12:42:00','viaje-id:266 -- operador-id:7'),(199,'agregar','root','2020-02-21 12:42:00','viaje-id:266 -- operador-id:19'),(200,'agregar','test','2020-02-21 12:52:00','viaje-id:267'),(201,'agregar','test','2020-02-21 12:52:00','viaje-id:267 -- operador-id:19'),(202,'eliminar','root','2020-02-21 14:42:00','viaje-id:266 -- operador-id:19'),(203,'eliminar','root','2020-02-21 14:43:00','viaje-id:266 -- operador-id:6'),(204,'agregar','root','2020-02-21 14:56:00','viaje-id:266 -- operador-id:19'),(205,'eliminar','root','2020-02-21 14:57:00','viaje-id:266 -- operador-id:19'),(206,'editar','root','2020-02-21 15:00:00','viaje-id:266'),(207,'editar','root','2020-02-21 15:00:00','viaje-id:266'),(208,'agregar','root','2020-02-21 15:01:00','viaje-id:266 -- operador-id:3'),(209,'editar','root','2020-02-21 15:01:00','viaje-id:266'),(210,'editar','root','2020-02-21 15:04:00','viaje-id:266'),(211,'editar','root','2020-02-21 15:08:00','viaje-id:266'),(212,'agregar','root','2020-02-21 18:45:00','deposito-id:1'),(213,'agregar','root','2020-02-24 13:36:00','deposito-id:2'),(214,'agregar','root','2020-02-24 13:36:00','deposito-id:3'),(215,'agregar','root','2020-02-24 13:39:00','deposito-id:4'),(216,'agregar','root','2020-02-24 13:40:00','deposito-id:5'),(217,'agregar','root','2020-02-24 13:40:00','deposito-id:6'),(218,'agregar','root','2020-02-24 13:40:00','deposito-id:7'),(219,'agregar','root','2020-02-24 13:43:00','deposito-id:8'),(220,'eliminar','root','2020-02-24 13:44:00','viaje-id:266 -- operador-id:3'),(221,'eliminar','root','2020-02-24 13:45:00','viaje-id:266 -- operador-id:7'),(222,'eliminar','root','2020-02-24 13:45:00','viaje-id:266 -- operador-id:8'),(223,'agregar','root','2020-02-24 13:54:00','deposito-id:1'),(224,'eliminar','root','2020-02-24 13:54:00','viaje-id:266 -- operador-id:22'),(225,'agregar','root','2020-02-24 14:01:00','viaje-id:266 -- operador-id:13'),(226,'agregar','root','2020-02-24 14:01:00','viaje-id:266 -- operador-id:19'),(227,'agregar','root','2020-02-24 14:02:00','deposito-id:1'),(228,'agregar','root','2020-02-24 14:03:00','deposito-id:2'),(229,'agregar','root','2020-02-24 14:05:00','viaje-id:266 -- operador-id:11'),(230,'eliminar','root','2020-02-24 14:05:00','viaje-id:266 -- operador-id:11'),(231,'agregar','root','2020-02-24 14:42:00','deposito-id:3'),(232,'agregar','root','2020-02-24 18:26:00','viaje-id:266 -- gasto-id:1'),(233,'editar','root','2020-02-24 18:29:00','viaje-id:266 -- gasto-id:1'),(234,'agregar','root','2020-02-24 19:14:00','viaje-id:266 -- gasto-id:2'),(235,'eliminar','root','2020-02-25 10:58:00','viaje-id:266 -- gasto-id:2'),(236,'eliminar','root','2020-02-25 10:58:00','viaje-id:266 -- gasto-id:1'),(237,'agregar','root','2020-02-25 10:59:00','viaje-id:266 -- gasto-id:3'),(238,'agregar','root','2020-02-25 11:00:00','deposito-id:4'),(239,'agregar','root','2020-02-25 11:00:00','viaje-id:266 -- gasto-id:4'),(240,'eliminar','root','2020-02-25 11:05:00','viaje-id:266 -- gasto-id:4'),(241,'agregar','root','2020-02-25 11:07:00','viaje-id:266 -- gasto-id:5'),(242,'editar','root','2020-02-25 11:08:00','viaje-id:266 -- gasto-id:5'),(243,'agregar','root','2020-02-25 11:41:00','viaje-id:266 -- cortesoperador-id:3'),(244,'editar','root','2020-02-25 11:42:00','viaje-id:266'),(245,'editar','root','2020-02-25 11:46:00','viaje-id:266'),(246,'agregar','root','2020-02-25 12:50:00','viaje-id:266 -- gasto-id:6'),(247,'eliminar','root','2020-02-25 12:50:00','viaje-id:266 -- gasto-id:6'),(248,'agregar','root','2020-02-25 13:49:00','viaje-id:266 -- cortesoperador-id:4'),(249,'agregar','root','2020-02-25 14:35:00','viaje-id:266 -- cortesoperador-id:5'),(250,'agregar','root','2020-02-25 14:58:00','viaje-id:266 -- cortesoperador-id:6'),(251,'eliminar','root','2020-02-25 15:02:00','viaje-id:266 -- cortesoperador-id:6'),(252,'eliminar','root','2020-02-25 15:02:00','viaje-id:266 -- cortesoperador-id:5'),(253,'eliminar','root','2020-02-25 15:02:00','viaje-id:266 -- cortesoperador-id:4'),(254,'eliminar','root','2020-02-25 15:02:00','viaje-id:266 -- cortesoperador-id:3'),(255,'agregar','root','2020-02-25 15:02:00','viaje-id:266 -- cortesoperador-id:7'),(256,'editar','root','2020-02-25 15:03:00','viaje-id:266 -- cortesoperador-id:7'),(257,'editar','root','2020-02-25 15:04:00','viaje-id:266 -- cortesoperador-id:7'),(258,'agregar','root','2020-02-25 15:04:00','viaje-id:266 -- cortesoperador-id:8'),(259,'agregar','root','2020-02-25 15:27:00','viaje-id:266 -- cortesoperador-id:9'),(260,'agregar','root','2020-02-25 17:26:00','viaje-id:266 -- operador-id:21'),(261,'agregar','root','2020-02-25 17:26:00','viaje-id:266 -- operador-id:16'),(262,'agregar','root','2020-02-25 18:02:00','deposito-id:5'),(263,'agregar','root','2020-02-25 18:23:00','deposito-id:6'),(264,'agregar','root','2020-02-25 18:51:00','deposito-id:7'),(265,'editar','test','2020-02-26 10:10:00','viaje-id:266'),(266,'editar','test','2020-02-26 10:14:00','viaje-id:267'),(267,'agregar','root','2020-02-26 15:04:00','viaje-id:266 -- gasto-id:7'),(268,'editar','root','2020-02-26 15:06:00','viaje-id:266 -- cortesoperador-id:9'),(269,'agregar','test','2020-02-27 13:41:00','viaje-id:266 -- operador-id:3'),(270,'eliminar','test','2020-02-27 13:41:00','viaje-id:266 -- operador-id:3'),(271,'editar','test','2020-02-27 13:42:00','viaje-id:266'),(272,'agregar','test','2020-02-27 13:43:00','viaje-id:266 -- operador-id:5'),(273,'eliminar','test','2020-02-27 13:47:00','viaje-id:266 -- operador-id:21'),(274,'agregar','test','2020-02-27 13:48:00','viaje-id:266 -- operador-id:3'),(275,'eliminar','test','2020-02-27 13:49:00','viaje-id:266 -- operador-id:3'),(276,'agregar','test','2020-02-27 13:50:00','viaje-id:266 -- operador-id:12'),(277,'agregar','root','2020-02-27 14:41:00','deposito-id:8'),(278,'agregar','root','2020-02-27 14:42:00','deposito-id:9'),(279,'agregar','root','2020-02-27 14:43:00','viaje-id:266 -- gasto-id:8'),(280,'eliminar','root','2020-02-27 14:53:00','viaje-id:266 -- gasto-id:8'),(281,'agregar','test','2020-02-27 17:24:00','viaje-id:265 -- operador-id:4'),(282,'editar','test','2020-02-27 17:45:00','viaje-id:264'),(283,'editar','test','2020-02-27 17:45:00','viaje-id:263'),(284,'editar','test','2020-02-27 17:45:00','viaje-id:262'),(285,'eliminar','test','2020-02-27 17:46:00','viaje-id:263 -- operador-id:7'),(286,'eliminar','test','2020-02-27 17:46:00','viaje-id:263 -- operador-id:21'),(287,'agregar','test','2020-02-27 17:46:00','viaje-id:263 -- operador-id:13'),(288,'agregar','test','2020-02-27 17:47:00','viaje-id:263 -- operador-id:22'),(289,'agregar','test','2020-02-27 17:47:00','viaje-id:263 -- operador-id:16'),(290,'agregar','test','2020-02-28 12:56:00','ruta-id:149'),(291,'eliminar','test','2020-02-28 12:57:00','ruta-id:149'),(292,'agregar','test','2020-02-28 13:00:00','ruta-id:150'),(293,'editar','test','2020-02-28 13:00:00','ruta-id:150'),(294,'agregar','test','2020-02-28 13:39:00','viaje-id:262 -- operador-id:24'),(295,'agregar','test','2020-02-28 13:40:00','viaje-id:262 -- operador-id:14'),(296,'agregar','test','2020-03-02 13:53:00','cobro adicional-id:1 -- viaje-id:266'),(297,'editar','test','2020-03-02 13:55:00','cobrosadicionales-id:1 -- viajes-id:266'),(298,'eliminar','test','2020-03-02 14:01:00','cobrosadicionales-id:1 -- viaje-id:266'),(299,'agregar','test','2020-03-02 14:01:00','cobro adicional-id:2 -- viaje-id:266'),(300,'editar','test','2020-03-02 14:02:00','cobrosadicionales-id:2 -- viajes-id:266'),(301,'agregar','test','2020-03-02 14:02:00','cobro adicional-id:3 -- viaje-id:266'),(302,'agregar','test','2020-03-02 16:44:00','cobro adicional-id:4 -- viaje-id:262'),(303,'eliminar','test','2020-03-02 16:45:00','cobrosadicionales-id:4 -- viaje-id:262'),(304,'agregar','test','2020-03-02 16:45:00','cobro adicional-id:5 -- viaje-id:262'),(305,'eliminar','test','2020-03-02 16:46:00','cobrosadicionales-id:5 -- viaje-id:262'),(306,'agregar','test','2020-03-02 16:46:00','cobro adicional-id:6 -- viaje-id:262'),(307,'agregar','test','2020-03-02 17:19:00','viaje-id:267 -- cortesoperador-id:10'),(308,'agregar','root','2020-03-02 18:22:00','viaje-id:268'),(309,'agregar','root','2020-03-02 18:22:00','viaje-id:268 -- operador-id:21'),(310,'agregar','root','2020-03-02 18:22:00','viaje-id:268 -- operador-id:3'),(311,'agregar','root','2020-03-02 18:22:00','viaje-id:268 -- operador-id:20'),(312,'eliminar','test','2020-03-02 18:24:00','viaje-id:268 -- operador-id:21'),(313,'eliminar','test','2020-03-02 18:24:00','viaje-id:268 -- operador-id:3'),(314,'eliminar','test','2020-03-02 18:24:00','viaje-id:268 -- operador-id:20'),(315,'eliminar','test','2020-03-02 18:24:00','viaje-id:268'),(316,'eliminar','test','2020-03-02 18:24:00','viaje-id:265 -- operador-id:4'),(317,'eliminar','test','2020-03-02 18:24:00','viaje-id:265'),(318,'eliminar','test','2020-03-02 18:24:00','viaje-id:261'),(319,'eliminar','test','2020-03-02 18:24:00','viaje-id:260'),(320,'eliminar','test','2020-03-02 18:25:00','viaje-id:259'),(321,'eliminar','test','2020-03-02 18:26:00','viaje-id:258'),(322,'eliminar','test','2020-03-02 18:26:00','viaje-id:257'),(323,'eliminar','test','2020-03-02 18:28:00','viaje-id:256'),(324,'eliminar','test','2020-03-02 18:28:00','viaje-id:255'),(325,'eliminar','test','2020-03-02 18:31:00','viaje-id:254'),(326,'eliminar','test','2020-03-02 18:31:00','viaje-id:253'),(327,'eliminar','test','2020-03-02 18:31:00','viaje-id:252'),(328,'eliminar','test','2020-03-02 18:31:00','viaje-id:251'),(329,'eliminar','test','2020-03-02 18:31:00','viaje-id:250'),(330,'eliminar','test','2020-03-02 18:32:00','viaje-id:249'),(331,'eliminar','test','2020-03-02 18:32:00','viaje-id:248'),(332,'eliminar','test','2020-03-02 18:32:00','viaje-id:247'),(333,'eliminar','test','2020-03-02 18:32:00','viaje-id:246'),(334,'eliminar','test','2020-03-02 18:32:00','viaje-id:245'),(335,'eliminar','test','2020-03-02 18:32:00','viaje-id:244'),(336,'eliminar','test','2020-03-02 18:32:00','viaje-id:243'),(337,'eliminar','test','2020-03-02 18:41:00','viaje-id:242'),(338,'eliminar','test','2020-03-02 18:43:00','viaje-id:113 -- operador-id:3'),(339,'agregar','test','2020-03-02 18:43:00','cobro adicional-id:7 -- viaje-id:113'),(340,'eliminar','test','2020-03-02 18:44:00','cobrosadicionales-id:7 -- viaje-id:113'),(341,'eliminar','test','2020-03-02 18:44:00','viaje-id:113'),(342,'eliminar','test','2020-03-02 18:48:00','viaje-id:115'),(343,'eliminar','test','2020-03-02 18:48:00','viaje-id:114'),(344,'editar','test','2020-03-02 18:49:00','viaje-id:120'),(345,'agregar','test','2020-03-03 10:37:00','viaje-id:269'),(346,'agregar','test','2020-03-03 10:37:00','viaje-id:269 -- operador-id:4'),(347,'agregar','test','2020-03-03 10:37:00','viaje-id:269 -- operador-id:10'),(348,'agregar','test','2020-03-03 10:39:00','viaje-id:270'),(349,'agregar','test','2020-03-03 10:39:00','viaje-id:270 -- operador-id:3'),(350,'agregar','test','2020-03-03 10:39:00','viaje-id:270 -- operador-id:17'),(351,'agregar','test','2020-03-03 10:39:00','viaje-id:270 -- operador-id:8'),(352,'agregar','test','2020-03-03 11:39:00','viaje-id:271'),(353,'agregar','test','2020-03-03 11:39:00','viaje-id:271 -- operador-id:19'),(354,'agregar','test','2020-03-03 11:39:00','viaje-id:271 -- operador-id:23'),(355,'eliminar','test','2020-03-03 11:42:00','viaje-id:271 -- operador-id:23'),(356,'eliminar','test','2020-03-03 11:42:00','viaje-id:271 -- operador-id:19'),(357,'agregar','test','2020-03-03 11:42:00','viaje-id:271 -- operador-id:3'),(358,'eliminar','test','2020-03-03 11:53:00','viaje-id:121'),(359,'eliminar','test','2020-03-03 11:55:00','viaje-id:122'),(360,'eliminar','test','2020-03-03 11:56:00','viaje-id:124'),(361,'eliminar','test','2020-03-03 11:57:00','viaje-id:126'),(362,'eliminar','test','2020-03-03 11:57:00','viaje-id:123'),(363,'editar','test','2020-03-03 11:57:00','viaje-id:125'),(364,'editar','test','2020-03-03 11:58:00','viaje-id:125'),(365,'editar','test','2020-03-03 11:59:00','viaje-id:125'),(366,'editar','test','2020-03-03 12:00:00','viaje-id:125'),(367,'editar','test','2020-03-03 12:00:00','viaje-id:125'),(368,'editar','test','2020-03-03 12:05:00','viaje-id:125'),(369,'editar','test','2020-03-03 12:07:00','viaje-id:125'),(370,'agregar','test','2020-03-03 12:18:00','viaje-id:125 -- operador-id:13'),(371,'editar','test','2020-03-03 12:18:00','viaje-id:125'),(372,'editar','test','2020-03-03 13:00:00','viaje-id:125'),(373,'agregar','test','2020-03-03 16:53:00','deposito-id:5'),(374,'agregar','test','2020-03-03 16:53:00','viaje-id:271 -- gasto-id:8'),(375,'agregar','test','2020-03-03 17:02:00','viaje-id:128 -- operador-id:3'),(376,'agregar','root','2020-03-03 17:10:00','viaje-id:262 -- cortesoperador-id:11'),(377,'editar','root','2020-03-03 17:22:00','viaje-id:262 -- cortesoperador-id:11'),(378,'agregar','test','2020-03-03 18:49:00','viaje-id:125 -- cortesoperador-id:12'),(379,'editar','test','2020-03-03 18:50:00','viaje-id:125 -- cortesoperador-id:12'),(380,'agregar','test','2020-03-03 18:50:00','viaje-id:125 -- cortesoperador-id:13'),(381,'agregar','test','2020-03-03 18:53:00','viaje-id:125 -- operador-id:12'),(382,'eliminar','test','2020-03-03 18:55:00','viaje-id:125 -- cortesoperador-id:13'),(383,'agregar','test','2020-03-03 18:55:00','viaje-id:125 -- cortesoperador-id:14'),(384,'editar','test','2020-03-03 18:56:00','viaje-id:125 -- cortesoperador-id:14'),(385,'agregar','test','2020-03-03 18:59:00','deposito-id:6'),(386,'agregar','test','2020-03-03 18:59:00','viaje-id:125 -- gasto-id:9'),(387,'eliminar','test','2020-03-03 19:02:00','viaje-id:125 -- gasto-id:9'),(388,'agregar','test','2020-03-03 19:04:00','viaje-id:125 -- gasto-id:10'),(389,'agregar','test','2020-03-03 19:05:00','viaje-id:125 -- gasto-id:11'),(390,'agregar','test','2020-03-03 19:20:00','ruta-id:151'),(391,'editar','test','2020-03-03 19:24:00','viaje-id:120'),(392,'agregar','test','2020-03-03 19:25:00','viaje-id:272'),(393,'agregar','test','2020-03-03 19:25:00','viaje-id:272 -- operador-id:10'),(394,'agregar','test','2020-03-03 19:25:00','viaje-id:272 -- operador-id:24'),(395,'agregar','test','2020-03-03 19:25:00','viaje-id:272 -- operador-id:18'),(396,'agregar','test','2020-03-03 19:34:00','cobro adicional-id:8 -- viaje-id:127'),(397,'agregar','root','2020-03-04 12:21:00','ruta-id:152'),(398,'editar','root','2020-03-04 12:36:00','ruta-id:152'),(399,'eliminar','root','2020-03-04 12:36:00','ruta-id:152'),(400,'agregar','root','2020-03-04 12:37:00','ruta-id:153'),(401,'editar','root','2020-03-04 12:37:00','ruta-id:153'),(402,'editar','root','2020-03-04 12:37:00','ruta-id:153'),(403,'editar','root','2020-03-04 12:37:00','ruta-id:153'),(404,'editar','root','2020-03-04 13:20:00','ruta-id:151'),(405,'editar','root','2020-03-04 13:20:00','ruta-id:148'),(406,'agregar','root','2020-03-04 13:54:00','viaje-id:273'),(407,'agregar','root','2020-03-04 13:54:00','viaje-id:273 -- operador-id:5'),(408,'editar','root','2020-03-04 13:54:00','viaje-id:273'),(409,'editar','root','2020-03-04 13:55:00','viaje-id:273'),(410,'editar','root','2020-03-04 13:55:00','ruta-id:150'),(411,'agregar','root','2020-03-04 14:10:00','deposito-id:7'),(412,'agregar','root','2020-03-04 14:11:00','viaje-id:273 -- gasto-id:12'),(413,'editar','root','2020-03-04 14:11:00','viaje-id:273 -- gasto-id:12'),(414,'agregar','root','2020-03-04 14:11:00','viaje-id:273 -- gasto-id:13'),(415,'agregar','root','2020-03-04 14:12:00','viaje-id:273 -- operador-id:3'),(416,'agregar','root','2020-03-04 14:50:00','deposito-id:8'),(417,'agregar','root','2020-03-04 14:51:00','viaje-id:273 -- gasto-id:14'),(418,'editar','root','2020-03-04 14:52:00','viaje-id:273 -- gasto-id:14'),(419,'agregar','root','2020-03-04 14:52:00','viaje-id:273 -- gasto-id:15'),(420,'editar','root','2020-03-04 14:54:00','viaje-id:273 -- gasto-id:12'),(421,'editar','root','2020-03-04 14:54:00','viaje-id:273 -- gasto-id:12'),(422,'agregar','root','2020-03-04 14:56:00','viaje-id:273 -- gasto-id:16'),(423,'eliminar','root','2020-03-04 15:22:00','viaje-id:273 -- gasto-id:16'),(424,'eliminar','root','2020-03-04 15:24:00','viaje-id:273 -- gasto-id:15'),(425,'eliminar','root','2020-03-04 15:34:00','viaje-id:273 -- gasto-id:14'),(426,'eliminar','maritza','2020-03-05 12:26:00','ruta-id:153'),(427,'agregar','maritza','2020-03-05 12:28:00','ruta-id:154'),(428,'agregar','maritza','2020-03-05 12:33:00','viaje-id:274'),(429,'agregar','maritza','2020-03-05 12:33:00','viaje-id:274 -- operador-id:7'),(430,'editar','maritza','2020-03-05 12:34:00','viaje-id:274'),(431,'agregar','maritza','2020-03-05 12:38:00','viaje-id:275'),(432,'agregar','maritza','2020-03-05 12:38:00','viaje-id:275 -- operador-id:21'),(433,'editar','maritza','2020-03-05 12:38:00','viaje-id:275'),(434,'agregar','maritza','2020-03-05 12:40:00','viaje-id:276'),(435,'agregar','maritza','2020-03-05 12:40:00','viaje-id:276 -- operador-id:15'),(436,'editar','maritza','2020-03-05 12:40:00','viaje-id:276'),(437,'agregar','maritza','2020-03-05 12:54:00','viaje-id:277'),(438,'agregar','maritza','2020-03-05 12:54:00','viaje-id:277 -- operador-id:24'),(439,'editar','maritza','2020-03-05 12:54:00','viaje-id:277'),(440,'editar','maritza','2020-03-05 13:02:00','viaje-id:277'),(441,'editar','maritza','2020-03-05 13:03:00','viaje-id:271'),(442,'eliminar','test','2020-03-05 13:09:00','viaje-id:120'),(443,'editar','test','2020-03-05 13:30:00','unidades-id:23'),(444,'editar','test','2020-03-05 13:31:00','unidades-id:23'),(445,'editar','test','2020-03-05 13:31:00','unidades-id:23'),(446,'editar','test','2020-03-05 13:32:00','unidades-id:23'),(447,'editar','test','2020-03-05 13:32:00','unidades-id:23'),(448,'agregar','test','2020-03-05 13:33:00','unidades-id:54'),(449,'eliminar','test','2020-03-05 13:33:00','unidades-id:54'),(450,'editar','test','2020-03-05 13:36:00','unidades-id:23'),(451,'editar','test','2020-03-05 13:37:00','unidades-id:23'),(452,'editar','maritza','2020-03-05 13:47:00','unidades-id:23'),(453,'editar','maritza','2020-03-05 13:48:00','viaje-id:277'),(454,'agregar','maritza','2020-03-05 16:11:00','ruta-id:155'),(455,'eliminar','maritza','2020-03-05 16:37:00','viaje-id:125 -- cortesoperador-id:12'),(456,'eliminar','maritza','2020-03-05 16:37:00','viaje-id:125 -- cortesoperador-id:14'),(457,'eliminar','maritza','2020-03-05 16:37:00','viaje-id:125 -- gasto-id:10'),(458,'eliminar','maritza','2020-03-05 16:37:00','viaje-id:125 -- gasto-id:11'),(459,'eliminar','maritza','2020-03-05 16:38:00','viaje-id:125 -- operador-id:12'),(460,'editar','maritza','2020-03-05 16:38:00','viaje-id:125'),(461,'eliminar','maritza','2020-03-05 16:38:00','viaje-id:125 -- operador-id:13'),(462,'eliminar','maritza','2020-03-05 16:38:00','viaje-id:125'),(463,'eliminar','maritza','2020-03-05 16:38:00','cobrosadicionales-id:8 -- viaje-id:127'),(464,'editar','maritza','2020-03-05 16:38:00','viaje-id:127'),(465,'eliminar','maritza','2020-03-05 16:38:00','viaje-id:127'),(466,'eliminar','maritza','2020-03-05 16:38:00','viaje-id:128 -- operador-id:3'),(467,'editar','maritza','2020-03-05 16:39:00','viaje-id:128'),(468,'eliminar','maritza','2020-03-05 16:39:00','viaje-id:128'),(469,'eliminar','maritza','2020-03-05 16:39:00','viaje-id:129'),(470,'eliminar','maritza','2020-03-05 16:39:00','viaje-id:262 -- operador-id:24'),(471,'eliminar','maritza','2020-03-05 16:39:00','viaje-id:262 -- cortesoperador-id:11'),(472,'eliminar','maritza','2020-03-05 16:39:00','cobrosadicionales-id:6 -- viaje-id:262'),(473,'eliminar','maritza','2020-03-05 16:39:00','viaje-id:262 -- operador-id:14'),(474,'editar','maritza','2020-03-05 16:39:00','viaje-id:262'),(475,'eliminar','maritza','2020-03-05 16:39:00','viaje-id:262'),(476,'eliminar','maritza','2020-03-05 16:39:00','viaje-id:264'),(477,'eliminar','maritza','2020-03-05 16:40:00','viaje-id:263 -- operador-id:13'),(478,'eliminar','maritza','2020-03-05 16:40:00','viaje-id:263 -- operador-id:22'),(479,'eliminar','maritza','2020-03-05 16:40:00','viaje-id:263 -- operador-id:16'),(480,'editar','maritza','2020-03-05 16:40:00','viaje-id:263'),(481,'eliminar','maritza','2020-03-05 16:40:00','viaje-id:263'),(482,'eliminar','maritza','2020-03-05 16:40:00','viaje-id:266 -- operador-id:12'),(483,'eliminar','maritza','2020-03-05 16:40:00','viaje-id:266 -- cortesoperador-id:7'),(484,'eliminar','maritza','2020-03-05 16:41:00','viaje-id:266 -- cortesoperador-id:8'),(485,'eliminar','maritza','2020-03-05 16:41:00','viaje-id:266 -- cortesoperador-id:9'),(486,'eliminar','maritza','2020-03-05 16:41:00','cobrosadicionales-id:2 -- viaje-id:266'),(487,'eliminar','maritza','2020-03-05 16:41:00','cobrosadicionales-id:3 -- viaje-id:266'),(488,'eliminar','maritza','2020-03-05 16:41:00','viaje-id:266 -- gasto-id:3'),(489,'eliminar','maritza','2020-03-05 16:41:00','viaje-id:266 -- gasto-id:5'),(490,'eliminar','maritza','2020-03-05 16:41:00','viaje-id:266 -- gasto-id:7'),(491,'eliminar','maritza','2020-03-05 16:42:00','viaje-id:266 -- operador-id:19'),(492,'eliminar','maritza','2020-03-05 16:42:00','viaje-id:266 -- operador-id:5'),(493,'eliminar','maritza','2020-03-05 16:42:00','viaje-id:266 -- operador-id:16'),(494,'eliminar','maritza','2020-03-05 16:43:00','viaje-id:266 -- operador-id:13'),(495,'editar','maritza','2020-03-05 16:43:00','viaje-id:266'),(496,'eliminar','maritza','2020-03-05 16:43:00','viaje-id:266'),(497,'eliminar','maritza','2020-03-05 16:43:00','viaje-id:267 -- cortesoperador-id:10'),(498,'eliminar','maritza','2020-03-05 16:43:00','viaje-id:267 -- operador-id:19'),(499,'editar','maritza','2020-03-05 16:43:00','viaje-id:267'),(500,'eliminar','maritza','2020-03-05 16:44:00','viaje-id:267'),(501,'eliminar','maritza','2020-03-05 16:44:00','viaje-id:269 -- operador-id:4'),(502,'eliminar','maritza','2020-03-05 16:44:00','viaje-id:269 -- operador-id:10'),(503,'eliminar','maritza','2020-03-05 16:45:00','viaje-id:269'),(504,'eliminar','maritza','2020-03-05 16:45:00','viaje-id:270 -- operador-id:3'),(505,'eliminar','maritza','2020-03-05 16:45:00','viaje-id:270 -- operador-id:8'),(506,'eliminar','maritza','2020-03-05 16:45:00','viaje-id:270 -- operador-id:17'),(507,'eliminar','maritza','2020-03-05 16:45:00','viaje-id:270'),(508,'eliminar','maritza','2020-03-05 18:02:00','ruta-id:147'),(509,'agregar','maritza','2020-03-05 18:08:00','ruta-id:156'),(510,'agregar','maritza','2020-03-05 18:22:00','ruta-id:157'),(511,'agregar','maritza','2020-03-05 18:26:00','ruta-id:158'),(512,'agregar','maritza','2020-03-05 18:27:00','ruta-id:159'),(513,'agregar','maritza','2020-03-05 18:29:00','ruta-id:160'),(514,'eliminar','test','2020-03-05 18:31:00','viaje-id:273 -- gasto-id:13'),(515,'eliminar','test','2020-03-05 18:31:00','viaje-id:273 -- gasto-id:12'),(516,'eliminar','test','2020-03-05 18:31:00','deposito-id:8'),(517,'eliminar','test','2020-03-05 18:31:00','deposito-id:7'),(518,'eliminar','test','2020-03-05 18:31:00','viaje-id:273 -- operador-id:3'),(519,'eliminar','test','2020-03-05 18:31:00','viaje-id:273 -- operador-id:5'),(520,'eliminar','test','2020-03-05 18:31:00','viaje-id:273'),(521,'eliminar','test','2020-03-05 18:32:00','viaje-id:271 -- gasto-id:8'),(522,'eliminar','test','2020-03-05 18:32:00','deposito-id:5'),(523,'eliminar','test','2020-03-05 18:32:00','viaje-id:271 -- operador-id:3'),(524,'eliminar','test','2020-03-05 18:32:00','viaje-id:271'),(525,'eliminar','test','2020-03-05 18:32:00','viaje-id:272 -- operador-id:18'),(526,'eliminar','test','2020-03-05 18:32:00','viaje-id:272 -- operador-id:24'),(527,'eliminar','test','2020-03-05 18:32:00','viaje-id:272 -- operador-id:10'),(528,'eliminar','test','2020-03-05 18:33:00','viaje-id:272'),(529,'agregar','maritza','2020-03-05 18:33:00','ruta-id:161');
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
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;
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
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `operadoresenviaje`
--

LOCK TABLES `operadoresenviaje` WRITE;
/*!40000 ALTER TABLE `operadoresenviaje` DISABLE KEYS */;
INSERT INTO `operadoresenviaje` VALUES (47,7,274,0,0),(48,21,275,0,0),(49,15,276,0,0),(50,24,277,0,0);
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
) ENGINE=InnoDB AUTO_INCREMENT=162 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ruta`
--

LOCK TABLES `ruta` WRITE;
/*!40000 ALTER TABLE `ruta` DISABLE KEYS */;
INSERT INTO `ruta` VALUES (148,'Ruta 2',15000,'Camioneta Pickup',5),(150,'wwwwww',1333,'Torthon',5),(151,'Ruta de Prueba',15000,'Camioneta',5),(154,'RENTA CAMIONETA 24 HRS',2800,'Camioneta',12),(155,'JIT - PSW - JIT',3800,'Trailer',5),(156,'JIT - CAZEL/GILL - JIT',8950,'Trailer',5),(157,'FYNOTEJ - FAURECIA C&C',7200,'Trailer',5),(158,'CGR - FAURECIA C&S',8800,'Torthon',5),(159,'GST/LEAR/TEXTILES/PSW - FAURECIA JIT/C&S',11400,'Torthon',5),(160,'FRAMES - RESORTES/BROSE - FRAMES',11300,'Torthon',5),(161,'MILK RUN FAS SLP FRAMES (6 DÍAS)',39200,'Trailer',5);
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
) ENGINE=InnoDB AUTO_INCREMENT=55 DEFAULT CHARSET=utf8;
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
  CONSTRAINT `viaje_fk0` FOREIGN KEY (`idStatus`) REFERENCES `statusviaje` (`idStatus`),
  CONSTRAINT `viaje_fk1` FOREIGN KEY (`idRuta`) REFERENCES `ruta` (`idruta`),
  CONSTRAINT `viaje_fk4` FOREIGN KEY (`idUnidad`) REFERENCES `unidades` (`idUnidad`)
) ENGINE=InnoDB AUTO_INCREMENT=278 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `viaje`
--

LOCK TABLES `viaje` WRITE;
/*!40000 ALTER TABLE `viaje` DISABLE KEYS */;
INSERT INTO `viaje` VALUES (274,'','2020-03-04 23:00:00','2020-03-05 22:00:00',2,154,25),(275,'','2020-03-04 23:00:00','2020-03-05 23:00:00',2,154,27),(276,'','2020-03-04 23:00:00','2020-03-05 12:39:00',2,154,26),(277,'','2020-03-04 23:00:00','2020-03-05 23:00:00',2,154,23);
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

-- Dump completed on 2020-03-05 18:34:54
