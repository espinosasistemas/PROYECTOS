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
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `caseta`
--

LOCK TABLES `caseta` WRITE;
/*!40000 ALTER TABLE `caseta` DISABLE KEYS */;
INSERT INTO `caseta` VALUES (8,'T1 - AMOZOC',176,1,3),(9,'T5-AUDI',43,1,3),(10,'SAN MARTIN',97,2,3),(11,'ARCO NORTE (SANCTORUM) TORTHON',140,2,3),(12,'SAN MARTIN',196,1,3),(13,'ARCO NORTE (SANCTORUM) TRAILER',220,1,3),(14,'ARCO NORTE (MEX. QRO)',695,2,3),(15,'PALMILLAS',180,2,3),(16,'CHICHIMEQUILLAS',84,2,3),(17,'SALAMANCA',174,2,3),(18,'LIBRAMIENTO LA PIEDAD',87,2,3),(19,'SIGLO XXI',328,2,3),(20,'QUERETARO',161,2,3),(21,'LIBRAMIENTO SUR PONIENTE',8,2,3),(22,'ARCO NORTE (MEX. QRO)',1050,1,3),(23,'PALMILLAS',362,1,3),(24,'CHICHIMEQUILLAS',91,1,3),(25,'ATLIXCO - JANTETELCO',328,2,3),(26,'VIA ATLIXCAYOTL',96,2,3),(27,'AEROPUERTO ',24,2,3),(28,'SAN NICOLAS DE LOS JASSOS',135,2,3),(29,'SAN NICOLAS DE LOS JASSOS',158,1,3),(30,'MATEHUALA',46,2,3),(31,'MATEHUALA',86,1,3),(32,'PTO. MÉXICO/HUACHICHIL',148,2,3),(33,'PTO. MÉXICO/HUACHICHIL',230,1,3);
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
-- Table structure for table `cortesoperador`
--

DROP TABLE IF EXISTS `cortesoperador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cortesoperador` (
  `idCorte` int(11) NOT NULL AUTO_INCREMENT,
  `fechaInicio` datetime NOT NULL,
  `fechaFin` datetime NOT NULL,
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
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cortesoperador`
--

LOCK TABLES `cortesoperador` WRITE;
/*!40000 ALTER TABLE `cortesoperador` DISABLE KEYS */;
INSERT INTO `cortesoperador` VALUES (4,'2020-02-11 00:00:00','2020-02-11 23:59:00',2398.33,23.98,4,7,13),(5,'2020-02-11 00:00:00','2020-02-11 23:59:00',2399.97,0,4,6,11),(6,'2020-02-05 00:00:00','2020-02-05 08:00:00',2000,8,3,7,13),(7,'2020-02-12 00:00:00','2020-02-12 15:00:00',3750,15,3,7,13),(8,'2020-02-11 00:00:00','2020-02-11 23:59:00',5995.83,23.98,3,7,13),(10,'2020-02-10 00:01:00','2020-02-11 23:59:00',4798.31,47.98,4,7,14),(14,'2020-02-11 05:00:00','2020-02-11 15:05:00',252.08,10.08,5,6,18),(15,'2020-02-11 10:00:00','2020-02-11 21:59:00',239.99,12,23,6,16),(16,'2020-02-12 08:00:00','2020-02-12 12:59:00',124.99,5,12,6,58);
/*!40000 ALTER TABLE `cortesoperador` ENABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
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
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gasto`
--

LOCK TABLES `gasto` WRITE;
/*!40000 ALTER TABLE `gasto` DISABLE KEYS */;
INSERT INTO `gasto` VALUES (1,'Caseta de San Martín Texmelucan Camioneta',200,'','','2020-02-11 13:54:00',0,'','','Transferencia',3,4,13),(5,'sfsdffsd',234,'','','2020-02-05 15:41:00',0,'','','Transferencia',1,3,11),(7,'Caseta de San Martín Texmelucan Torthon',300,'','','2020-02-06 14:50:00',0,'','','Transferencia',3,3,11),(8,'Pago de cafe',200,'','','2020-02-11 19:47:00',0,'','','Transferencia',6,3,14),(9,'Caseta de San Martín Texmelucan Trailer',800,'V14-202026-195213892-889.pdf','','2020-02-11 19:47:00',0,'','','Transferencia',3,3,14),(15,'T1 - AMOZOC',176,'','','2020-02-11 12:00:00',0,'','','Transferencia',3,4,17),(16,'T1 - AMOZOC',176,'','','2020-02-11 10:33:00',0,'','','Transferencia',3,23,16),(17,'T1 - AMOZOC',176,'','','2020-02-11 10:33:00',0,'','','Transferencia',3,23,16),(18,'T5-AUDI',43,'','','2020-02-11 10:33:00',0,'','','Transferencia',3,23,16),(19,'T5-AUDI',43,'','','2020-02-11 10:33:00',0,'','','Transferencia',3,23,16);
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
) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `log`
--

LOCK TABLES `log` WRITE;
/*!40000 ALTER TABLE `log` DISABLE KEYS */;
INSERT INTO `log` VALUES (1,'agregar','espinosa.sistemas','2020-02-07 17:31:00','unidades->id:40'),(2,'editar','espinosa.sistemas','2020-02-07 17:32:00','unidades-id:40'),(3,'eliminar','espinosa.sistemas','2020-02-07 17:35:00','unidades-id:40'),(4,'agregar','espinosa.sistemas','2020-02-07 18:07:00','operador-id:9'),(5,'editar','espinosa.sistemas','2020-02-07 18:08:00','operador-id:9'),(6,'eliminar','espinosa.sistemas','2020-02-07 18:08:00','operador-id:9'),(7,'agregar','espinosa.sistemas','2020-02-10 11:07:00','cliente-id:6'),(8,'editar','espinosa.sistemas','2020-02-10 11:16:00','cliente-id:6'),(9,'eliminar','espinosa.sistemas','2020-02-10 11:17:00','cliente-id:6'),(10,'agregar','espinosa.sistemas','2020-02-11 10:11:00','ruta-id:10'),(11,'editar','espinosa.sistemas','2020-02-11 10:12:00','ruta-id:10'),(12,'eliminar','espinosa.sistemas','2020-02-11 10:12:00','ruta-id:10'),(13,'agregar','espinosa.sistemas','2020-02-11 10:22:00','caseta-id:7'),(14,'editar','espinosa.sistemas','2020-02-11 10:22:00','caseta-id:7'),(15,'eliminar','espinosa.sistemas','2020-02-11 10:23:00','caseta-id:7'),(16,'agregar','espinosa.sistemas','2020-02-11 10:33:00','gasolineria-id:8'),(17,'editar','espinosa.sistemas','2020-02-11 10:33:00','gasolineria-id:8'),(18,'eliminar','espinosa.sistemas','2020-02-11 10:33:00','gasolineria-id:8'),(19,'agregar','espinosa.sistemas','2020-02-11 10:47:00','tipogasto-id:7'),(20,'editar','espinosa.sistemas','2020-02-11 10:47:00','tipogasto-id:7'),(21,'agregar','espinosa.sistemas','2020-02-11 10:51:00','tipogasto-id:8'),(22,'editar','espinosa.sistemas','2020-02-11 10:51:00','tipogasto-id:8'),(23,'eliminar','espinosa.sistemas','2020-02-11 10:51:00','gasto-id:8'),(24,'agregar','espinosa.sistemas','2020-02-11 10:53:00','tipogasto-id:9'),(25,'eliminar','espinosa.sistemas','2020-02-11 10:54:00','tipogasto-id:9'),(26,'eliminar','espinosa.sistemas','2020-02-11 10:59:00','statusviaje-id:14'),(27,'editar','espinosa.sistemas','2020-02-11 10:59:00','statusviaje-id:13'),(28,'eliminar','espinosa.sistemas','2020-02-11 10:59:00','statusviaje-id:13'),(29,'eliminar','espinosa.sistemas','2020-02-11 10:59:00','statusviaje-id:12'),(30,'eliminar','espinosa.sistemas','2020-02-11 10:59:00','statusviaje-id:11'),(31,'agregar','espinosa.sistemas','2020-02-11 11:00:00','statusviaje-id:15'),(32,'agregar','espinosa.sistemas','2020-02-11 11:44:00','viaje-id:15'),(33,'editar','espinosa.sistemas','2020-02-11 11:44:00','viaje-id:15'),(34,'agregar','espinosa.sistemas','2020-02-11 11:45:00','viaje-id:15 -- operador-id:21'),(35,'eliminar','espinosa.sistemas','2020-02-11 11:45:00','viaje-id:15 -- operador-id:21'),(36,'agregar','espinosa.sistemas','2020-02-11 11:45:00','viaje-id:15 -- operador-id:19'),(37,'agregar','espinosa.sistemas','2020-02-11 11:45:00','viaje-id:15 -- gasto-id:10'),(38,'editar','espinosa.sistemas','2020-02-11 11:46:00','viaje-id:15 -- gasto-id:10'),(39,'agregar','espinosa.sistemas','2020-02-11 11:50:00','viaje-id:15 -- gasto-id:11'),(40,'editar','espinosa.sistemas','2020-02-11 11:50:00','viaje-id:15 -- gasto-id:11'),(41,'agregar','espinosa.sistemas','2020-02-11 11:54:00','viaje-id:15 -- gasto-id:12'),(42,'agregar','espinosa.sistemas','2020-02-11 11:58:00','viaje-id:15 -- gasto-id:13'),(43,'eliminar','espinosa.sistemas','2020-02-11 11:58:00','viaje-id:15 -- gasto-id:13'),(44,'agregar','espinosa.sistemas','2020-02-11 12:00:00','viaje-id:15 -- cortesoperador-id:11'),(45,'editar','espinosa.sistemas','2020-02-11 12:00:00','viaje-id:15 -- cortesoperador-id:11'),(46,'eliminar','espinosa.sistemas','2020-02-11 12:00:00','viaje-id:15 -- cortesoperador-id:11'),(47,'eliminar','espinosa.sistemas','2020-02-11 12:01:00','viaje-id:15 -- operador-id:19'),(48,'eliminar','espinosa.sistemas','2020-02-11 12:01:00','viaje-id:15'),(49,'editar','fabi','2020-02-11 15:01:00','viaje-id:14'),(50,'editar','espinosa.sistemas','2020-02-12 14:18:00','caseta-id:11'),(51,'editar','espinosa.sistemas','2020-02-12 14:19:00','caseta-id:13'),(52,'agregar','test','2020-02-12 15:01:00','viaje-id:68 -- cortesoperador-id:18'),(53,'eliminar','test','2020-02-12 15:02:00','viaje-id:68 -- cortesoperador-id:18'),(54,'agregar','test','2020-02-12 15:58:00','viaje-id:81 -- gasto-id:20'),(55,'eliminar','test','2020-02-12 15:58:00','viaje-id:81 -- gasto-id:20');
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
  `idViajeOps` int(11) NOT NULL,
  PRIMARY KEY (`idRegistro`),
  KEY `operadoresenviaje_fk0_idx` (`idOperador`),
  KEY `operadoresenviaje_fk1_idx` (`idViajeOps`),
  CONSTRAINT `operadoresenviaje_fk0` FOREIGN KEY (`idOperador`) REFERENCES `operador` (`idoperador`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `operadoresenviaje_fk1` FOREIGN KEY (`idViajeOps`) REFERENCES `viaje` (`idViajeSci`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=110 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `operadoresenviaje`
--

LOCK TABLES `operadoresenviaje` WRITE;
/*!40000 ALTER TABLE `operadoresenviaje` DISABLE KEYS */;
INSERT INTO `operadoresenviaje` VALUES (13,4,12),(16,3,13),(17,3,12),(18,4,13),(19,3,11),(21,4,11),(22,3,14),(24,4,14),(27,23,16),(29,4,17),(31,5,18),(32,21,19),(33,7,20),(34,15,21),(35,8,22),(36,18,23),(37,13,24),(38,20,25),(39,14,26),(40,3,27),(41,16,28),(42,24,29),(43,14,30),(44,10,31),(45,21,33),(46,21,34),(47,17,35),(48,4,36),(49,23,37),(50,5,38),(51,24,39),(52,8,40),(53,22,41),(54,7,42),(55,18,43),(56,6,44),(57,6,45),(58,21,46),(59,12,47),(60,13,48),(61,20,49),(62,17,50),(63,14,51),(64,14,52),(65,4,53),(66,17,54),(67,5,55),(68,22,56),(69,5,57),(70,12,58),(71,8,59),(72,7,60),(73,24,61),(74,22,62),(75,6,63),(76,16,64),(77,13,65),(78,10,66),(79,20,67),(80,11,68),(81,19,69),(82,10,70),(83,4,71),(84,14,72),(85,14,73),(86,11,74),(87,12,75),(88,5,76),(89,23,77),(90,22,79),(91,5,80),(92,12,81),(93,13,81),(94,19,83),(95,17,82),(96,13,86),(97,10,87),(98,17,88),(99,20,85),(100,5,89),(101,23,90),(102,22,92),(103,8,92),(104,7,93),(105,24,94),(106,12,95),(107,5,96),(108,19,97),(109,8,98);
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
  `idTipoDeUnidad` int(11) NOT NULL,
  PRIMARY KEY (`idruta`),
  KEY `ruta_fk0_idx` (`idTipoDeUnidad`),
  CONSTRAINT `ruta_fk0` FOREIGN KEY (`idTipoDeUnidad`) REFERENCES `tipounidad` (`idTipoDeUnidad`)
) ENGINE=InnoDB AUTO_INCREMENT=145 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ruta`
--

LOCK TABLES `ruta` WRITE;
/*!40000 ALTER TABLE `ruta` DISABLE KEYS */;
INSERT INTO `ruta` VALUES (8,'Corporación Telch - Jofel Hasta 3.5 ton',1026,3),(9,'Corporación Telch - Jofel De 3.5 a 6 ton',1414,2),(11,'Corporación Telch - Jofel De 6 a 8 ton',1459,2),(12,'Corporación Telch - Jofel De 8 a 11 ton',1749,2),(13,'Corporación Telch - Jofel De 15 a 20 ton',2730,1),(14,'Corporación Telch - Jofel De 20 a 25 ton',3356,1),(15,'Corporación Telch - Inyecciones y Espumados Hasta 3.5 ton',1026,3),(16,'Corporación Telch - Inyecciones y Espumados de 3.5 a 6 ton',1414,2),(17,'Corporación Telch - Inyecciones y Espumados de 6 a 8 ton',1459,2),(18,'Corporación Telch - Inyecciones y Espumados de 8 a 11 ton',1749,2),(19,'Corporación Telch - Inyecciones y Espumados de 15 a 20 ton',2730,1),(20,'Corporación Telch - SMP Pba Hasta 3.5',1026,3),(21,'Corporación Telch - SMP Pba de 3.5 a 6 ton ',1414,2),(22,'Corporación Telch - SMP Pba De 6 a 8 ton',1459,2),(23,'Corporación Telch - SMP Pba De 8 a 11 ton',1749,2),(24,'Corporación Telch - SMP Pba De 15 a 20  ton',2730,1),(25,'Corporación Telch - SMP Pba De 20 a 25 ton',3356,1),(26,'Nicro Bolta - SMP Zitlaltepec (Sencillo)',2232,2),(27,'Nicro Bolta - SMP Zitlaltepec (redondo)',2857,2),(28,'Nicro Bolta - SMP Zitlaltepec (redondo)',4900,1),(29,'Nicro Bolta - SMP Zitlaltepec (sencillo)',3750,1),(30,'Nicro Bolta - SMP Pba (Sencillo)',1200,1),(31,'Nicro Bolta - SMP Pba (Redondo)',1500,2),(32,'Nicro Bolta - SMP Pba (Sencillo)',1400,2),(33,'Nicro Bolta - SMP Pba (Sencillo)',1050,3),(34,'Nicro Bolta - SMP Pba (Redondo)',1800,1),(35,'Nicro Bolta - SMP Pba (Redondo)',1350,1),(36,'Nicro Bolta - Unicar (Sencillo)',1000,3),(37,'Nicro Bolta - Unicar (Sencillo)',1050,2),(38,'Nicro Bolta - Unicar (Sencillo)',1200,1),(39,'Nicro Bolta - Unicar (Redondo)',1232,3),(40,'Nicro Bolta - Unicar (Redondo)',1450,2),(41,'Nicro Bolta - Unicar (Redondo)',1700,1),(42,'Nicro Bolta - Plastic Omnium (Sencillo)',1000,3),(43,'Nicro Bolta - Plastic Omnium (Sencillo)',1050,2),(44,'Nicro Bolta - Plastic Omnium (Sencillo)',1200,1),(45,'Nicro Bolta - Plastic Omnium (Redondo)',1232,3),(46,'Nicro Bolta - Plastic Omnium (Redondo)',1450,2),(47,'Nicro Bolta - Plastic Omnium (Redondo)',1700,1),(48,'Nicro Bolta - AUDI (Sencillo)',2050,3),(49,'Nicro Bolta - AUDI (Sencillo)',2500,2),(50,'Nicro Bolta - AUDI (Sencillo)',4170,1),(51,'Nicro Bolta - AUDI (Redondo)',2630,3),(52,'Nicro Bolta - AUDI (Redondo)',3215,2),(53,'Nicro Bolta - AUDI (Redondo)',5340,1),(54,'Nicro Bolta - VWM Covadonga (Sencillo)',1000,3),(55,'Nicro Bolta - VWM Covadonga (Sencillo)',1050,3),(56,'Nicro Bolta - VWM Covadonga (Sencillo)',1200,1),(57,'Nicro Bolta - VWM Covadonga (Redondo)',1700,1),(58,'Nicro Bolta - VWM Covadonga (Redondo)',1450,2),(59,'Nicro Bolta - VWM Covadonga (Redondo)',1232,3),(60,'Nicro Bolta - Olsa (Sencillo)',7500,2),(61,'Nicro Bolta - Olsa (Sencillo)',11900,1),(62,'Nicro Bolta - Novem Queretaro',8300,2),(63,'Nicro Bolta - Magna Toluca (Sencillo)',4400,3),(64,'Nicro Bolta - Magna Toluca (Sencillo)',4800,2),(65,'Nave 21 - TB&C OUTSERT - NAVE 21',830,2),(66,'NAVE 21 - ISGO, SLP - NAVE 21',15000,1),(67,'NAVE 21 - VW COVADONGA',1200,2),(68,'VW Covadonga / VW 31 a Nave 21',2000,2),(69,'Censa / Bosch - Nave 21',9900,1),(70,'AUDI - Nave 21',12,1),(71,'FAURECIA JIT - GILL - FAURECIA JIT',8950,1),(72,'FAURECIA C&S - BORDARTE',19000,3),(73,'FAURECIA JIT - NISSAN CIVAC - FAURECIA JIT',4400,2),(74,'NATZIPPER - FAURECIA C&S',22000,2),(75,'AUNDE - FAURECIA C&S',1200,2),(76,'JIT - INNOTEC ARTEAGA / SALTILLO LAMINATION - FAURECIA JIT',24000,1),(77,'FAURECIA JIT - PSW - FAURECIA JIT',3800,1),(78,'FAURECIA SLP FRAMES - FAURECIA JIT',12900,2),(79,'CGR, QRO - FAURECIA C&S',8800,2),(80,'FYNOTEJ - FAURECIA C&S',7200,2),(81,'GST/ LEAR / TEXTILES LEÓN/ PSW LEÓN - FAURECIA C&S/JIT',11400,2),(82,'FAURECIA SLP FRAMES - BROSE - FAURECIA SLP FRAMES',11300,2),(83,'FAURECIA JIT - CAZEL / GILL - FAURECIA JIT',8950,1),(84,'FAURECIA C&S - TEXTILES LEON',6500,2),(85,'FAURECIA SLP FRAMES - TEFLU - GILL - BROSE - FAURECIA SLP FRAMES',11900,2),(86,'AUNDE/ UTT  - FAURECIA JIT/C&S',1200,2),(87,'RESORTES Y PROD METALICOS - FAURECIA SLP FRAMES',11300,2),(88,'FXI - FAURECIA C&S',7200,2),(89,'NAT ZIPPER/ BADER LEÓN/ NES - FAURECIA JIT',14800,2),(90,'GEMINI SALTILLO/GST/INNOTEC ARTEAGA - FAURECIA JIT',24000,1),(91,'DAIMAY SILAO / GRAMMER QUERETARO - FAURECIA JIT',13500,2),(92,'FAURECIA C&S - SALTILLO LAMINATION',13900,3),(93,'MIDORI SLP - FAURECIA JIT',8200,1),(94,'FAURECIA C&S - TEXTILES LEON',6500,4),(95,'UNICAR - VW COVADONGA',1200,3),(96,'UNICAR - VW COVADONGA - UNICAR',2000,1),(97,'MTC COATINGS, MEX. - KIEKERT',4800,3),(98,'KIEKERT - CELAY / ACEWAY',17000,1),(99,'KIEKERT - VW COVADONGA',1400,2),(100,'VPT / CORRUBOX - KIEKERT',2000,2),(101,'KIEKERT - VW COVADONGA',1400,2),(102,'TRW QUERETARO - THYSSEN KRUPP SAN JOSÉ CHIAPA',11000,2),(103,'KIEKERT - FEDEX',1200,3),(104,'ALTAMIRA, TAMS. - PUEBLA, PUE.',11800,3),(105,'AUTOTEK - THYSSENKRUPP SAN JOSE CHIAPA - AUTOTEK',4800,1),(106,'BODY SYSTEMS (INTEVA) - VW COVADONGA - BODY SYSTEMS (INTEVA)',1800,2),(107,'BROSE - VW COVADONGA',1400,2),(108,'MOLIENDAS TIZAYUCA  - APOLO TEXTL - MOLIENDAS (3 TON)',1700,2),(109,'MOLIENDAS TIZACUYA - MANCHESTER CHEMICAL, CHACHAPA, PUE.(10 TON)',1500,2),(110,'MOLIENDAS TIZAYUCA  - APOLO TEXTL (10.44 TON)',2000,2),(111,'MOLIENDAS TIZACUYA - ADHESIVOS Y RESINAS, PUE.(2 TON)',1200,2),(112,'MOLIENDAS TIZAYUCA - OXIQUIMICA, SAN MARTIN TEXMELUCAN (1 TON)',1200,3),(113,'MOLIENDAS TIZACUYA - PARQUE INDUSTRIAL PUEBLA 2000, PUE. (1 TON)',900,3),(114,'BODEGA ARMANDO - CUERNAVACA, MOR.',5600,2),(115,'BODEGA ARMANDO - TEHUACAN',4200,2),(116,'RENTA BODEGA ARMANDO ( Pue )',2800,2),(117,'RENTA 24 HRS CONCORDE GROUP',2800,3),(118,'RENTA 8 HRS CONCORDE GROUP',933.33,3),(119,'CONCORDE . RENTA 12 HR CAJA DE TRAILER',1500,1),(120,'CONCORDE GROUP - AGUASCALIENTES, AGS',13000,3),(121,'CONCORDE GROUP - VW COVADONGA',900,2),(122,'CONCORDE GROUP - IPP',2400,1),(123,'NAVE 21 - PYRAMID/SIKA / HATCH - NAVE 21',13900,1),(124,'N21 - ARCOMEX - N21',3800,1),(125,'NAVE 21 - AUDI',1900,3),(126,'RESURRECCIÓN - NAVE 21',1200,2),(127,'3C METROLOGY - NAVE 21',2900,3),(128,'GEMOMEX - NAVE 21',14300,1),(129,'NAVE 21 - HATCH QUERETARO',7200,3),(130,'ESTAMPADOS INDUSTRIALES - INTEVA NAVE 21',6000,2),(131,'NAVE 21 - WHITEHALL  - NAVE 21',13500,1),(132,'Telch - Aksys de 1 a 3.5 Ton',1235,2),(133,'Telch - Cormaplast de 3.5 a 6 Ton',1492,2),(134,'Audi - N 21 Cie',3950,1),(135,'Telch  -  SMP PUE de 3.5 a 5 Ton',1414,1),(136,'Censa - N 21 ',3900,2),(137,'Concorde 24 horas renta',2800,2),(138,'Telch - Gonorma de 3.5 a 6 T',1414,2),(139,'CARTONES CORRUGADOS - FAURECIA JIT',1,2),(140,'LEAR - FAURECIA N29',1,2),(141,'Corporación Telch - Possehl de 3.5 a 6 ton',1414,2),(142,'Telch - Lunketec de 6 a 8 ton',1459,2),(143,'Corporación Telch - Lunketec de 6 a 8 ton',1459,2),(144,'Cartones Corrugados Puebla - Faurecia JIT',1200,2);
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
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `statusviaje`
--

LOCK TABLES `statusviaje` WRITE;
/*!40000 ALTER TABLE `statusviaje` DISABLE KEYS */;
INSERT INTO `statusviaje` VALUES (1,'En tránsito'),(6,'En Planeación'),(7,'Inicio'),(8,'Entregado'),(15,'Detenido');
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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipogasto`
--

LOCK TABLES `tipogasto` WRITE;
/*!40000 ALTER TABLE `tipogasto` DISABLE KEYS */;
INSERT INTO `tipogasto` VALUES (1,'Viáticos'),(2,'Combustible'),(3,'Casetas'),(4,'Mantenimiento Tracto'),(5,'Talachas'),(6,'Gastos Indirectos');
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
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unidades`
--

LOCK TABLES `unidades` WRITE;
/*!40000 ALTER TABLE `unidades` DISABLE KEYS */;
INSERT INTO `unidades` VALUES (23,'Trailer 23 caja grande',31,'SDAD-ASD 45','ABCDE-ASD65','SDSDSDFSDF','2020-02-05 08:20:00','Diesel',4),(24,'Trailer 40',40,'XS595W-544','ALKJQL6546','6549A-DQEASD654','2022-02-06 19:28:00','Gasolina',1),(25,'CAMIONETA F-450	',13,'690-ET-8	','3FDXF46S22MA39438	','00000306134032	','2020-04-30 06:45:00','Gasolina',3),(26,'KODIAK 2002	',3,'413-AN-1	','3 G B M 7 H 1 E 0 2 M 1 0 8 4 9 7 	','M9 37005026	','2020-03-31 06:47:00','Diesel',2),(27,'CAMIONETA 2004	',2,'375-AS-1	','3 G B J C 3 4 R X 4 M 1 0 1 8 2 1	','2098905','2020-02-07 06:48:00','Gasolina',3),(28,'FREIGHTLINER	',25,'45AH-2X	','3AKJC5CV8JDJV7213	','3200163893	','2020-05-31 06:52:00','Diesel',1),(29,'FREIGHTLINER	',11,'396-ER-5	','3ALACXCS3EDFN0798	','0940272192	','2020-05-31 06:53:00','Diesel',2),(30,'ELF400',31,'40-AK-1X	','JAANPR750K7000153	','3058522	','2020-05-31 06:54:00','Diesel',3),(31,'FREIGHTLINER	',20,'46AH4X	','3ALHCYDJ6FDGC7039	','0940259855	','2020-05-31 06:56:00','Diesel',1),(32,'FREIGHTLINER	',28,'16AK-1U','3ALHCYDJ8KDKP5951	','3200130715	','2020-05-31 06:58:00','Diesel',1),(33,'FREIGHTLINER	',22,'78-AL-2M	','902910C1125418	','0150132521	','2020-05-31 07:08:00','Diesel',2),(34,'FREIGHTLINER	',10,'76 AN 2L','3ALACXCS5CDBJ8176	','´0940268528	','2020-05-31 07:09:00','Diesel',2),(35,'WORKER	',16,'76-AB-5J','123654123','0940260997	','2020-05-31 07:47:00','Diesel',2),(36,'FREIGHTLINER	',6,'663-AU-1','3ALACXCS2CDBE8022	','0940263817	','2020-05-31 07:54:00','Diesel',2),(37,'FREIGHTLINER	',29,'15AK-1U	','3ALHCYDJ1KDKP5953	','3200130714','2020-05-31 07:56:00','Diesel',1),(38,'ELF400	',17,'96-AE-1H	','JAANPR755H7002280	','1674176	','2020-05-31 07:59:00','Diesel',3),(39,'FREIGHTLINER	',7,'560-EW-2	','3ALHCYDJ2FDGC7037	','0940271589	','2020-05-31 08:00:00','Diesel',1),(41,'Polo',9,'UBL-5377	','9BWJB09A74P001160	','2106704	','2020-05-31 08:03:00','Gasolina',4),(42,'CHEYENNE 2003	',12,'SK09379	','1GCEC14T33Z215119	','6599260	','2020-05-31 08:04:00','Gasolina',3),(43,'NP 300 NISSAN',14,'SM-62771	','3N6AD35AXHK836623	','C00007316	','2020-05-31 08:05:00','Gasolina',4),(44,'FREIGHTLINER	',15,'777-ET-8	','3ALFCYCSXEDFM3584	','0940270809	','2020-05-31 08:06:00','Diesel',1),(45,'TRACTOCAMION FREIGHTLINER	',18,'44AH-2X	','1FUJA6AV09LAE9149	','0940271597	','2020-05-31 08:07:00','Diesel',1),(46,'FREIGHTLINER	',21,'467-FE-1	','3ALACYCS9JDJK2487	','0003081870	','2020-05-31 08:09:00','Diesel',2),(47,'FREIGHTLINER	',23,'79-AL-2M	','3ALACYCS7JDJK2486	','0150132522	','2020-05-31 08:10:00','Diesel',2),(48,'FREIGHTLINER	',24,'466-FE-1	','3ALACYCS0JDJK2488	','0003081861	','2020-05-31 08:11:00','Diesel',2),(49,'FREIGHTLINER	',26,'46AH-2X	','3ALHCYDJ4JDJV7166	','3200163895	','2020-05-31 08:12:00','Diesel',1),(50,'FREIGHTLINER	',29,'15AK-1U	','3ALHCYDJ1KDKP5953	','3200130714	','2020-05-31 08:12:00','Diesel',1),(51,'NP 300	NISSAN',30,'SM63088	','3N6AD35AXKK844096	','324200600041	','2020-05-31 08:13:00','Gasolina',4),(52,'ELF400	NISSAN',31,'40-AK-1X	','JAANPR750K7000153	','3058522	','2020-05-31 08:14:00','Gasolina',4);
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
INSERT INTO `usuario` VALUES ('edgar','edgar','Edgar'),('espinosa.sistemas','123456','Juan Espinosa'),('fabi','Falomay@-1','Fabiola Coba'),('mariana','Falomay@-1','Mariana Azcue'),('maritza','maritza','Maritza'),('test','x','Usuario de Prueba'),('yasmin','Falomay@-1','Yasmin Robles');
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
  `fechaInicioSci` datetime NOT NULL,
  `fechaInicioCliente` datetime NOT NULL,
  `fechaFinSci` datetime NOT NULL,
  `fechaFinCliente` datetime NOT NULL,
  `idStatus` int(11) NOT NULL,
  `idRuta` int(11) NOT NULL,
  `idCliente` int(11) NOT NULL,
  `idUnidad` int(11) NOT NULL,
  PRIMARY KEY (`idViajeSci`),
  KEY `viaje_fk0` (`idStatus`),
  KEY `viaje_fk1` (`idRuta`),
  KEY `viaje_fk2` (`idCliente`),
  KEY `viaje_fk4_idx` (`idUnidad`),
  CONSTRAINT `viaje_fk0` FOREIGN KEY (`idStatus`) REFERENCES `statusviaje` (`idStatus`),
  CONSTRAINT `viaje_fk1` FOREIGN KEY (`idRuta`) REFERENCES `ruta` (`idruta`),
  CONSTRAINT `viaje_fk2` FOREIGN KEY (`idCliente`) REFERENCES `cliente` (`idcliente`),
  CONSTRAINT `viaje_fk4` FOREIGN KEY (`idUnidad`) REFERENCES `unidades` (`idUnidad`)
) ENGINE=InnoDB AUTO_INCREMENT=99 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `viaje`
--

LOCK TABLES `viaje` WRITE;
/*!40000 ALTER TABLE `viaje` DISABLE KEYS */;
INSERT INTO `viaje` VALUES (11,'ABCDE-8975','2020-02-04 00:00:00','2020-02-04 00:00:00','2020-02-07 23:59:00','2020-02-07 23:59:00',8,8,5,23),(12,'','2020-02-11 00:00:00','2020-02-11 00:00:00','2020-02-14 23:59:00','2020-02-14 23:59:00',6,8,5,23),(13,'XXXXXX-45','2020-02-10 05:00:00','2020-02-10 08:00:00','2020-02-12 20:00:00','2020-02-12 15:00:00',8,8,5,23),(14,'ABCD123','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-13 23:59:00','2020-02-13 23:59:00',15,9,5,24),(16,'','2020-02-11 09:00:00','2020-02-11 15:00:00','2020-02-11 22:00:00','2020-02-11 22:43:00',8,70,9,49),(17,'','2020-02-11 08:00:00','2020-02-11 21:00:00','2020-02-11 18:52:00','2020-02-11 18:52:00',6,28,7,31),(18,'','2020-02-11 04:05:00','2020-02-11 04:05:00','2020-02-11 19:05:00','2020-02-11 19:05:00',6,67,9,36),(19,'Concorde','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-10 23:59:00','2020-02-10 23:59:00',6,117,12,30),(20,'Concorde','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-10 23:59:00','2020-02-10 23:59:00',6,117,12,27),(21,'concorde','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-10 23:59:00','2020-02-10 23:59:00',6,137,12,26),(22,'Concorde','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-10 23:59:00','2020-02-10 23:59:00',6,117,12,25),(23,'Faurecia','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-10 23:59:00','2020-02-10 23:59:00',6,77,5,45),(24,'faurecia ','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-10 23:59:00','2020-02-10 23:59:00',6,89,5,48),(25,'Faurecia GST','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-10 23:59:00','2020-02-10 23:59:00',6,81,5,47),(26,'Faurecia Aunde','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-10 23:59:00','2020-02-10 23:59:00',6,86,5,35),(27,'Faurecia CIVAC','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-10 23:59:00','2020-02-10 23:59:00',6,73,5,29),(28,'Faurecia Gemini','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-10 23:59:00','2020-02-10 23:59:00',6,90,5,28),(29,'Cie Outsert','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-10 23:59:00','2020-02-10 23:59:00',6,65,9,46),(30,'Cie Outsert','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-10 23:59:00','2020-02-10 23:59:00',6,65,9,46),(31,'Cie Isgo','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-10 23:59:00','2020-02-10 23:59:00',6,66,9,44),(32,'Cie Arcomex','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-10 23:59:00','2020-02-10 23:59:00',6,124,9,24),(33,'NB Unicar','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-10 23:59:00','2020-02-10 23:59:00',6,40,7,34),(34,'NB SMP PBA','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-10 23:59:00','2020-02-10 23:59:00',6,31,7,34),(35,'NB SMP','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-10 23:59:00','2020-02-10 23:59:00',6,28,7,32),(36,'NB SMP','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-10 23:59:00','2020-02-10 23:59:00',6,28,7,31),(37,'','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-10 23:59:00','2020-02-10 23:59:00',6,123,7,49),(38,'Cie VW Covadonga','2020-02-11 00:00:00','2020-02-11 00:00:00','2020-02-11 23:59:00','2020-02-11 23:59:00',6,67,9,36),(39,'Concorde 24 Renta','2020-02-11 00:00:00','2020-02-11 00:00:00','2020-02-11 23:59:00','2020-02-11 23:59:00',6,117,12,30),(40,'Concorde Renta 24','2020-02-11 00:00:00','2020-02-11 00:00:00','2020-02-11 23:59:00','2020-02-11 23:59:00',6,117,12,25),(41,'Concorde 24 Renta','2020-02-11 00:00:00','2020-02-11 00:00:00','2020-02-11 23:59:00','2020-02-11 23:59:00',6,137,12,26),(42,'Concorde 24 renta','2020-02-11 00:00:00','2020-02-11 00:00:00','2020-02-11 23:59:00','2020-02-11 23:59:00',6,117,12,27),(43,'Faurecia PSW','2020-02-11 00:00:00','2020-02-11 00:00:00','2020-02-11 23:59:00','2020-02-11 23:59:00',6,77,5,45),(44,'Faurecia ','2020-02-11 00:00:00','2020-02-11 00:00:00','2020-02-11 23:59:00','2020-02-11 23:59:00',6,83,5,37),(45,'Faurecia Cazel','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-10 23:59:00','2020-02-10 23:59:00',6,83,5,37),(46,'Faurecia GST','2020-02-11 00:00:00','2020-02-11 00:00:00','2020-02-11 23:59:00','2020-02-11 23:59:00',6,81,5,34),(47,'Faurecia FXI','2020-02-11 00:00:00','2020-02-11 00:00:00','2020-02-11 23:59:00','2020-02-11 23:59:00',6,88,5,29),(48,'Furecia Brose','2020-02-11 00:00:00','2020-02-11 00:00:00','2020-02-11 23:59:00','2020-02-11 23:59:00',6,82,5,46),(49,'Faurecia CIVAC','2020-02-11 00:00:00','2020-02-11 00:00:00','2020-02-11 23:59:00','2020-02-11 23:59:00',6,73,5,35),(50,'Cie Gemomex','2020-02-11 00:00:00','2020-02-11 00:00:00','2020-02-11 23:59:00','2020-02-11 23:59:00',1,128,9,32),(51,'Cie Outsert','2020-02-11 00:00:00','2020-02-11 00:00:00','2020-02-11 23:59:00','2020-02-11 23:59:00',6,65,9,26),(52,'Cie Outsert','2020-02-11 00:00:00','2020-02-11 00:00:00','2020-02-11 23:59:00','2020-02-11 23:59:00',6,65,9,26),(53,'NB SMP','2020-02-11 00:00:00','2020-02-11 00:00:00','2020-02-11 23:59:00','2020-02-11 23:59:00',6,28,7,31),(54,'NB PO','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-10 23:59:00','2020-02-10 23:59:00',6,47,7,32),(55,'NB PO','2020-02-11 00:00:00','2020-02-11 00:00:00','2020-02-11 23:59:00','2020-02-11 23:59:00',6,46,7,36),(56,'Lan Unicar - WV ','2020-02-11 00:00:00','2020-02-11 00:00:00','2020-02-11 23:59:00','2020-02-11 23:59:00',6,96,8,45),(57,'Cie VW- Covadonga','2020-02-12 06:23:00','2020-02-12 00:00:00','2020-02-12 06:23:00','2020-02-12 23:59:00',6,67,9,36),(58,'Moliendas Manchester','2020-02-12 07:00:00','2020-02-12 07:00:00','2020-02-12 14:00:00','2020-02-12 12:00:00',8,109,10,29),(59,'Concorde Renta 24','2020-02-12 06:27:00','2020-02-12 06:27:00','2020-02-12 06:27:00','2020-02-12 06:27:00',6,117,12,25),(60,'Concorde 24 renta','2020-02-12 06:27:00','2020-02-12 06:27:00','2020-02-12 06:27:00','2020-02-12 06:27:00',6,117,12,27),(61,'Concorde 24 renta','2020-02-12 06:28:00','2020-02-12 06:28:00','2020-02-12 06:28:00','2020-02-12 06:28:00',6,117,12,30),(62,'Concorde 24','2020-02-12 06:29:00','2020-02-12 06:29:00','2020-02-12 06:29:00','2020-02-12 06:29:00',6,117,12,38),(63,'Faurecia Cazel','2020-02-12 06:31:00','2020-02-12 06:31:00','2020-02-12 06:31:00','2020-02-12 06:31:00',6,83,5,37),(64,'Faurecia Innotec','2020-02-12 06:33:00','2020-02-12 06:33:00','2020-02-12 06:33:00','2020-02-12 06:33:00',6,76,5,28),(65,'Faurecia ','2020-02-12 06:34:00','2020-02-12 06:34:00','2020-02-12 06:34:00','2020-02-12 06:34:00',6,85,5,48),(66,'NB SMP','2020-02-12 06:36:00','2020-02-12 06:36:00','2020-02-12 06:36:00','2020-02-12 06:36:00',6,28,7,44),(67,'NB SMP','2020-02-12 06:37:00','2020-02-12 06:37:00','2020-02-12 06:37:00','2020-02-12 06:37:00',6,27,7,33),(68,'NB Unicar','2020-02-12 06:00:00','2020-02-12 06:39:00','2020-02-12 11:30:00','2020-02-12 11:39:00',6,39,7,38),(69,'NB Novem','2020-02-12 06:39:00','2020-02-12 06:39:00','2020-02-12 06:39:00','2020-02-12 06:39:00',6,62,7,47),(70,'NB PO','2020-02-12 06:41:00','2020-02-12 06:41:00','2020-02-12 06:41:00','2020-02-12 06:41:00',6,47,7,44),(71,'Cie Isgo','2020-02-12 05:00:00','2020-02-12 07:00:00','2020-02-13 23:59:00','2020-02-13 23:59:00',6,66,7,39),(72,'Cie Outsert','2020-02-12 06:43:00','2020-02-12 06:43:00','2020-02-12 06:43:00','2020-02-12 06:43:00',6,65,9,26),(73,'Cie Outsert','2020-02-12 06:43:00','2020-02-12 06:43:00','2020-02-12 06:43:00','2020-02-12 06:43:00',6,65,9,26),(74,'MTC - K','2020-02-12 00:00:00','2020-02-13 00:00:00','2020-02-13 23:59:00','2020-02-13 23:59:00',6,97,8,38),(75,'Telch ','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-10 23:59:00','2020-02-10 23:59:00',6,132,11,36),(76,'Telch','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-10 23:59:00','2020-02-10 23:59:00',6,133,11,36),(77,'Cie Audi','2020-02-11 00:00:00','2020-02-11 00:00:00','2020-02-11 23:59:00','2020-02-11 23:59:00',6,134,9,49),(78,'Telch','2020-02-12 00:00:00','2020-02-12 07:13:00','2020-02-12 23:59:00','2020-02-12 07:13:00',6,135,11,49),(79,'Censa Cie','2020-02-12 07:14:00','2020-02-12 07:14:00','2020-02-12 22:14:00','2020-02-12 07:14:00',6,136,9,35),(80,'Telch','2020-02-10 00:00:00','2020-02-10 00:00:00','2020-02-10 23:59:00','2020-02-10 23:59:00',6,138,11,36),(81,'','2020-02-12 00:00:00','2020-02-12 14:05:00','2020-02-13 23:59:00','2020-02-12 22:05:00',6,64,7,29),(82,'','2020-02-12 08:21:00','2020-02-12 08:21:00','2020-02-12 20:21:00','2020-02-12 20:21:00',6,139,5,34),(83,'','2020-02-12 00:00:00','2020-02-12 00:00:00','2020-02-13 23:59:00','2020-02-13 23:59:00',6,140,7,48),(84,'PSW','2020-02-13 08:15:00','2020-02-13 08:15:00','2020-02-13 08:15:00','2020-02-13 08:15:00',6,77,5,45),(85,'GST','2020-02-13 08:16:00','2020-02-13 08:16:00','2020-02-13 08:16:00','2020-02-13 08:16:00',6,81,5,34),(86,'FINOTEJ','2020-02-13 08:18:00','2020-02-13 08:18:00','2020-02-13 08:18:00','2020-02-13 08:18:00',6,80,5,29),(87,'NB SMP','2020-02-13 08:18:00','2020-02-13 08:18:00','2020-02-13 08:18:00','2020-02-13 08:18:00',6,28,7,44),(88,'NB SMP','2020-02-13 08:19:00','2020-02-13 08:19:00','2020-02-13 08:19:00','2020-02-13 08:19:00',6,28,7,32),(89,'NB PO ','2020-02-13 08:20:00','2020-02-13 08:20:00','2020-02-13 08:20:00','2020-02-13 08:20:00',6,46,7,36),(90,'CIE WHITE','2020-02-13 08:21:00','2020-02-13 08:21:00','2020-02-13 08:21:00','2020-02-13 08:21:00',6,131,9,49),(91,'Frames','2020-02-13 08:25:00','2020-02-13 08:25:00','2020-02-13 08:25:00','2020-02-13 08:25:00',6,78,5,47),(92,'Concorde 24','2020-02-13 08:26:00','2020-02-13 08:26:00','2020-02-13 08:26:00','2020-02-13 08:26:00',6,117,12,25),(93,'Concorde 24','2020-02-13 08:27:00','2020-02-13 08:27:00','2020-02-13 08:27:00','2020-02-13 08:27:00',6,117,12,27),(94,'Concorde 24','2020-02-13 08:27:00','2020-02-13 08:27:00','2020-02-13 08:27:00','2020-02-13 08:27:00',6,117,12,30),(95,'Concorde 24','2020-02-13 08:28:00','2020-02-13 08:28:00','2020-02-13 08:28:00','2020-02-13 08:28:00',6,137,12,26),(96,'LAN VPT','2020-02-13 08:28:00','2020-02-13 08:28:00','2020-02-13 08:28:00','2020-02-13 08:28:00',6,100,8,36),(97,'','2020-02-13 14:00:00','2020-02-13 14:00:00','2020-02-13 19:00:00','2020-02-13 16:00:00',6,143,11,33),(98,'','2020-02-13 15:05:00','2020-02-13 15:05:00','2020-02-13 20:05:00','2020-02-13 20:05:00',6,144,5,35);
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

-- Dump completed on 2020-02-13 19:15:59
