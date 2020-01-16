CREATE TABLE `unidades` (
	`idUnidad` INT NOT NULL AUTO_INCREMENT,
    `nombre` varchar(50) NOT NULL,
	`numeroEconomico` INT NOT NULL,
	`placas` varchar(15) NOT NULL,
	`numeroserie` varchar(50) NOT NULL,
	`tipocombustible` TEXT(50) NOT NULL,
	PRIMARY KEY (`idUnidad`)
);

CREATE TABLE `operador` (
	`idoperador` INT NOT NULL AUTO_INCREMENT,
	`nombre` varchar(100) NOT NULL,
	`apellidos` varchar(100) NOT NULL,
	`fechaIngreso` DATETIME NOT NULL,
	`salarioporhora` DECIMAL(8.2) NOT NULL,
	`direccion` varchar(500) NOT NULL,
	PRIMARY KEY (`idoperador`)
);

CREATE TABLE `cliente` (
	`idCliente` INT NOT NULL AUTO_INCREMENT,
	`razonSocial` varchar(200) NOT NULL,
	`rfc` varchar(15) NOT NULL,
	`giro` varchar(50) NOT NULL,
	`telefono` varchar(20) NOT NULL,
	`correo` varchar(100) NOT NULL,
	`nombrecontacto` varchar(200) NOT NULL,
	`observaciones` varchar(300) NOT NULL,
	PRIMARY KEY (`idCliente`)
);

CREATE TABLE `ruta` (
	`idruta` INT NOT NULL AUTO_INCREMENT,
    `nombre` varchar(200) NOT NULL,
	`costo` DECIMAL(8.2) NOT NULL,
	`idUnidad` INT NOT NULL,
	PRIMARY KEY (`idRuta`)
);

CREATE TABLE `gasto` (
	`idGasto` INT NOT NULL AUTO_INCREMENT,
	`idTipoGasto` INT NOT NULL,
	`concepto` varchar(100) NOT NULL,
	`costo` DECIMAL(8.2) NOT NULL,
	`ruta_pdf` varchar(500) NOT NULL,
	`ruta_xml` varchar(500) NOT NULL,
	`fecha` DATETIME NOT NULL,
	`idViajeOps` INT NOT NULL,
	PRIMARY KEY (`idGasto`)
);

CREATE TABLE `tipoGasto` (
	`idTipoGasto` INT NOT NULL AUTO_INCREMENT,
	`concepto` varchar(100) NOT NULL,
	PRIMARY KEY (`idTipoGasto`)
);

CREATE TABLE `viaje` (
	`idViajeOps` INT NOT NULL AUTO_INCREMENT,
	`idViajeCliente` varchar(100) NOT NULL,
	`fechaInicioOps` DATETIME NOT NULL,
	`fechaInicioCliente` DATETIME NOT NULL,
	`fechaFinOps` DATETIME NOT NULL,
	`fechaFinCliente` DATETIME NOT NULL,
	`idStatus` INT NOT NULL,
	`idRuta` INT NOT NULL,
	`idCliente` INT NOT NULL,
	`idOperador` INT NOT NULL,
	PRIMARY KEY (`idViajeOps`)
);

CREATE TABLE `statusViaje` (
	`idStatus` INT NOT NULL AUTO_INCREMENT,
	`nombre` varchar(50) NOT NULL,
	PRIMARY KEY (`idStatus`)
);

CREATE TABLE `cortesOperacion` (
	`idCorte` INT NOT NULL AUTO_INCREMENT,
	`fechaInicio` DATETIME NOT NULL,
	`fechaFinal` DATETIME NOT NULL,
	`costo` DECIMAL(8.2) NOT NULL,
	`idViajeOps` INT NOT NULL,
	PRIMARY KEY (`idCorte`)
);

CREATE TABLE `usuario` (
	`nombreusuario` varchar(50) NOT NULL,
	`password` varchar(50) NOT NULL,
	`nombrecompleto` varchar(50) NOT NULL,
	PRIMARY KEY (`nombreusuario`)
);

CREATE TABLE `registro` (
	`idmovimiento` INT NOT NULL AUTO_INCREMENT,
	`accion` varchar(50) NOT NULL,
	`nombreusuario` varchar(50) NOT NULL,
	`fecha` DATETIME NOT NULL,
	`moduloafectado` varchar(50) NOT NULL,
	PRIMARY KEY (`idmovimiento`)
);

ALTER TABLE `registro` ADD CONSTRAINT `registro_fk0` FOREIGN KEY (`nombreusuario`) REFERENCES `usuario`(`nombreusuario`);

ALTER TABLE `ruta` ADD CONSTRAINT `ruta_fk0` FOREIGN KEY (`idUnidad`) REFERENCES `unidades`(`idUnidad`);

ALTER TABLE `gasto` ADD CONSTRAINT `gasto_fk0` FOREIGN KEY (`idTipoGasto`) REFERENCES `tipoGasto`(`idTipoGasto`);

ALTER TABLE `gasto` ADD CONSTRAINT `gasto_fk1` FOREIGN KEY (`idViajeOps`) REFERENCES `viaje`(`idViajeOps`);

ALTER TABLE `viaje` ADD CONSTRAINT `viaje_fk0` FOREIGN KEY (`idStatus`) REFERENCES `statusViaje`(`idStatus`);

ALTER TABLE `viaje` ADD CONSTRAINT `viaje_fk1` FOREIGN KEY (`idRuta`) REFERENCES `ruta`(`idRuta`);

ALTER TABLE `viaje` ADD CONSTRAINT `viaje_fk2` FOREIGN KEY (`idCliente`) REFERENCES `cliente`(`idCliente`);

ALTER TABLE `viaje` ADD CONSTRAINT `viaje_fk3` FOREIGN KEY (`idOperador`) REFERENCES `operador`(`idoperador`);

ALTER TABLE `cortesOperacion` ADD CONSTRAINT `cortesOperacion_fk1` FOREIGN KEY (`idViajeOps`) REFERENCES `viaje`(`idViajeOps`);
