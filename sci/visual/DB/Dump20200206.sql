-- MySQL dump 10.13  Distrib 8.0.17, for Win64 (x86_64)
--
-- Host: localhost    Database: db_sci
-- ------------------------------------------------------
-- Server version	5.7.15-log

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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `caseta`
--

LOCK TABLES `caseta` WRITE;
/*!40000 ALTER TABLE `caseta` DISABLE KEYS */;
INSERT INTO `caseta` VALUES (3,'Caseta de San Martín Texmelucan Trailer',450,1,3),(4,'Caseta de San Martín Texmelucan Torthon',300,2,3),(5,'Caseta de San Martín Texmelucan Camioneta',200,3,3),(6,'Caseta de San Martín Texmelucan Pickup',100,4,3);
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
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (5,'Faurecia SA de CV','ARECIA-468-6643','Atomotríz','225 695 6548','faurecia@gmail.com','Departamento Embarques','Finsa Puebla y Querétaro.');
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
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cortesoperador`
--

LOCK TABLES `cortesoperador` WRITE;
/*!40000 ALTER TABLE `cortesoperador` DISABLE KEYS */;
INSERT INTO `cortesoperador` VALUES (4,'2020-02-11 00:00:00','2020-02-11 23:59:00',5999.93,0,3,7,13),(5,'2020-02-11 00:00:00','2020-02-11 23:59:00',2399.97,0,4,6,11),(6,'2020-02-05 00:00:00','2020-02-05 08:00:00',2000,8,3,7,13),(7,'2020-02-12 00:00:00','2020-02-12 15:00:00',3750,15,3,7,13),(8,'2020-02-11 00:00:00','2020-02-11 23:59:00',2398,23.98,4,7,13);
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
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gasolineria`
--

LOCK TABLES `gasolineria` WRITE;
/*!40000 ALTER TABLE `gasolineria` DISABLE KEYS */;
INSERT INTO `gasolineria` VALUES (4,'Gasolinería Finsa','Parque Finsa2','','','','',2),(5,'3 MObil de Autopista','Carretara a CDMX km 45 ','EISJ8412182D1','JUAN ESPINOSA','2221846700','juan@gmail.com',2),(6,'Gasolinería del Centro','Centro Puebla','SDF5619-4A65Q','Mobil Sa de CV','222 584 6846','mobil@gmail.com',2),(7,'asd','asd','ABCA2223AD11','a','a','juan@gmail.com',2);
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
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gasto`
--

LOCK TABLES `gasto` WRITE;
/*!40000 ALTER TABLE `gasto` DISABLE KEYS */;
INSERT INTO `gasto` VALUES (1,'Gasolinería Finsa',1500,'','','2020-02-11 13:54:00',0,'','','Transferencia',2,4,13),(2,'Gasolinería Finsa',1000,'','','2020-02-12 15:20:00',0,'','','Transferencia',2,3,12),(3,'Caseta de San Martín Texmelucan Trailer',450,'','','2020-02-12 15:20:00',0,'','','Transferencia',3,3,12),(5,'sfsdffsd',234,'','','2020-02-05 15:41:00',0,'','','Transferencia',1,3,11);
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
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `log`
--

LOCK TABLES `log` WRITE;
/*!40000 ALTER TABLE `log` DISABLE KEYS */;
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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `operador`
--

LOCK TABLES `operador` WRITE;
/*!40000 ALTER TABLE `operador` DISABLE KEYS */;
INSERT INTO `operador` VALUES (3,'Juan','Espinosa Salazar','2020-01-16 17:42:00',250,'Sin dirección por el momento','222 2569 654','222 184 6700','juan@gmail.com','2020-01-30 10:20:00','AD46546','2020-01-30 10:20:00',''),(4,'Jose Jose','Salazar Hernández','2020-01-01 11:20:00',100,'adasdasdasdasdasd','2228579874','2221846700','jjsala@gmail.com','2020-01-08 11:20:00','ABCD-4568546','2025-01-09 11:20:00','142569764');
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
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `operadoresenviaje`
--

LOCK TABLES `operadoresenviaje` WRITE;
/*!40000 ALTER TABLE `operadoresenviaje` DISABLE KEYS */;
INSERT INTO `operadoresenviaje` VALUES (13,4,12),(16,3,13),(17,3,12),(18,4,13),(19,3,11),(21,4,11);
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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ruta`
--

LOCK TABLES `ruta` WRITE;
/*!40000 ALTER TABLE `ruta` DISABLE KEYS */;
INSERT INTO `ruta` VALUES (8,'Ruta de Puebla a Querétaro',8000,4);
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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `statusviaje`
--

LOCK TABLES `statusviaje` WRITE;
/*!40000 ALTER TABLE `statusviaje` DISABLE KEYS */;
INSERT INTO `statusviaje` VALUES (1,'En tránsito'),(6,'En Planeación'),(7,'Inicio'),(8,'Entregado');
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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipogasto`
--

LOCK TABLES `tipogasto` WRITE;
/*!40000 ALTER TABLE `tipogasto` DISABLE KEYS */;
INSERT INTO `tipogasto` VALUES (1,'Viáticos'),(2,'Combustible'),(3,'Casetas'),(4,'Mantenimiento Tracto');
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
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unidades`
--

LOCK TABLES `unidades` WRITE;
/*!40000 ALTER TABLE `unidades` DISABLE KEYS */;
INSERT INTO `unidades` VALUES (22,'Torthon nuevo sin caja',40,'AKDA-59761','65654ASD9865465ADA','12345aaaaaa','2025-02-05 08:20:00','Gasolina',2),(23,'Trailer 23 caja grande',31,'SDAD-ASD 45','ABCDE-ASD65','','2020-02-05 08:20:00','Diesel',4);
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
INSERT INTO `usuario` VALUES ('espinosa.sistemas','123456','Juan Espinosa');
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
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `viaje`
--

LOCK TABLES `viaje` WRITE;
/*!40000 ALTER TABLE `viaje` DISABLE KEYS */;
INSERT INTO `viaje` VALUES (11,'ABCDE-8975','2020-02-04 00:00:00','2020-02-04 00:00:00','2020-02-07 23:59:00','2020-02-07 23:59:00',6,8,5,23),(12,'','2020-02-11 00:00:00','2020-02-11 00:00:00','2020-02-14 23:59:00','2020-02-14 23:59:00',6,8,5,23),(13,'XXXXXX-45','2020-02-10 05:00:00','2020-02-10 08:00:00','2020-02-12 20:00:00','2020-02-12 15:00:00',7,8,5,23);
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

-- Dump completed on 2020-02-06 10:19:21
