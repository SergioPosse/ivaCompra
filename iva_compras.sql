/*
MySQL Data Transfer
Source Host: localhost
Source Database: iva_compras
Target Host: localhost
Target Database: iva_compras
Date: 22/11/2012 08:18:02 p.m.
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for condicion_iva
-- ----------------------------
DROP TABLE IF EXISTS `condicion_iva`;
CREATE TABLE `condicion_iva` (
  `civa_id` int(11) NOT NULL AUTO_INCREMENT,
  `civa_desc` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`civa_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Table structure for iva_compras
-- ----------------------------
DROP TABLE IF EXISTS `iva_compras`;
CREATE TABLE `iva_compras` (
  `ivac_id` int(11) NOT NULL AUTO_INCREMENT,
  `prov_id` int(11) DEFAULT NULL,
  `tdoc_id` int(11) DEFAULT NULL,
  `ivac_fech` date DEFAULT NULL,
  `ivac_subt` decimal(10,2) DEFAULT NULL,
  `ivac_iva` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`ivac_id`)
) ENGINE=InnoDB AUTO_INCREMENT=68 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Table structure for localidades
-- ----------------------------
DROP TABLE IF EXISTS `localidades`;
CREATE TABLE `localidades` (
  `loca_id` int(11) NOT NULL AUTO_INCREMENT,
  `loca_nomb` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`loca_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Table structure for proveedores
-- ----------------------------
DROP TABLE IF EXISTS `proveedores`;
CREATE TABLE `proveedores` (
  `prov_id` int(11) NOT NULL AUTO_INCREMENT,
  `prov_nomb` varchar(30) DEFAULT NULL,
  `prov_cuit` varchar(20) DEFAULT NULL,
  `civa_id` int(11) DEFAULT NULL,
  `loca_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`prov_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Table structure for tipo_documento
-- ----------------------------
DROP TABLE IF EXISTS `tipo_documento`;
CREATE TABLE `tipo_documento` (
  `tdoc_id` int(11) NOT NULL AUTO_INCREMENT,
  `tdoc_desc` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`tdoc_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records 
-- ----------------------------
INSERT INTO `condicion_iva` VALUES ('1', 'asd');
INSERT INTO `condicion_iva` VALUES ('2', 'dsa');
INSERT INTO `condicion_iva` VALUES ('3', 'defr');
INSERT INTO `iva_compras` VALUES ('1', '2', '2', '2012-11-20', '458.00', '21.00');
INSERT INTO `iva_compras` VALUES ('2', '2', '3', '2012-11-20', '456.00', '32.00');
INSERT INTO `iva_compras` VALUES ('3', '2', '2', '2012-11-22', '344.00', '35.00');
INSERT INTO `iva_compras` VALUES ('4', '2', '2', '2012-11-22', '344.00', '35.00');
INSERT INTO `iva_compras` VALUES ('5', '2', '3', '2012-11-22', '4556.00', '344.00');
INSERT INTO `iva_compras` VALUES ('6', '2', '2', '2012-11-07', '55.00', '34.00');
INSERT INTO `iva_compras` VALUES ('7', '2', '2', '2012-11-22', '4234.00', '234.00');
INSERT INTO `iva_compras` VALUES ('8', '2', '3', '2012-11-22', '99999999.99', '22222.00');
INSERT INTO `iva_compras` VALUES ('9', '2', '2', '2012-11-22', '55555.00', '345.00');
INSERT INTO `iva_compras` VALUES ('10', '3', '1', '2012-11-22', '11111.00', '111.00');
INSERT INTO `iva_compras` VALUES ('11', '1', '1', '2012-11-22', '1111.00', '11.00');
INSERT INTO `iva_compras` VALUES ('12', '3', '3', '2012-11-22', '1111.00', '11.00');
INSERT INTO `iva_compras` VALUES ('13', '3', '3', '2012-11-22', '1111.00', '11.00');
INSERT INTO `iva_compras` VALUES ('14', '3', '3', '2012-11-22', '2222.00', '32.00');
INSERT INTO `iva_compras` VALUES ('15', '3', '2', '2012-11-22', '1111.00', '12.00');
INSERT INTO `iva_compras` VALUES ('16', '3', '3', '2012-11-22', '1111.00', '11.00');
INSERT INTO `iva_compras` VALUES ('17', '3', '3', '2012-11-22', '1111.00', '11.00');
INSERT INTO `iva_compras` VALUES ('18', '1', '1', '2002-09-09', '0.70', '0.13');
INSERT INTO `iva_compras` VALUES ('19', '1', '2', '2500-03-03', '0.49', '0.58');
INSERT INTO `iva_compras` VALUES ('20', '2', '2', '2885-05-14', '0.57', '0.90');
INSERT INTO `iva_compras` VALUES ('21', '1', '2', '2005-05-25', '783.92', '3676.54');
INSERT INTO `iva_compras` VALUES ('22', '2', '1', '2005-06-12', '3824.27', '5461.42');
INSERT INTO `iva_compras` VALUES ('23', '1', '1', '2002-08-19', '1269.66', '5497.03');
INSERT INTO `iva_compras` VALUES ('24', '2', '1', '1999-11-12', '271.84', '1600.15');
INSERT INTO `iva_compras` VALUES ('25', '2', '1', '1995-02-23', '405.89', '115.16');
INSERT INTO `iva_compras` VALUES ('26', '2', '2', '2008-08-17', '753.07', '2831.36');
INSERT INTO `iva_compras` VALUES ('27', '2', '2', '2006-07-23', '1010.62', '617.39');
INSERT INTO `iva_compras` VALUES ('28', '1', '2', '1997-04-16', '1037.08', '4227.62');
INSERT INTO `iva_compras` VALUES ('29', '1', '1', '1995-01-09', '3270.20', '9.84');
INSERT INTO `iva_compras` VALUES ('30', '2', '1', '2009-01-02', '322.01', '1656.56');
INSERT INTO `iva_compras` VALUES ('31', '1', '1', '2007-01-21', '1525.76', '819.79');
INSERT INTO `iva_compras` VALUES ('32', '1', '1', '2004-11-27', '51.48', '3637.67');
INSERT INTO `iva_compras` VALUES ('33', '2', '1', '2002-11-20', '2098.65', '6.05');
INSERT INTO `iva_compras` VALUES ('34', '2', '1', '1998-06-14', '69.70', '1824.02');
INSERT INTO `iva_compras` VALUES ('35', '2', '1', '1996-05-19', '266.99', '4934.28');
INSERT INTO `iva_compras` VALUES ('36', '1', '2', '2010-02-13', '2057.48', '1494.52');
INSERT INTO `iva_compras` VALUES ('37', '2', '2', '2008-03-19', '455.15', '3138.89');
INSERT INTO `iva_compras` VALUES ('38', '2', '2', '1998-03-02', '993.65', '208.67');
INSERT INTO `iva_compras` VALUES ('39', '2', '1', '1996-05-21', '1515.54', '318.26');
INSERT INTO `iva_compras` VALUES ('40', '1', '1', '2011-06-12', '2759.83', '579.56');
INSERT INTO `iva_compras` VALUES ('41', '2', '1', '2008-07-20', '847.41', '177.96');
INSERT INTO `iva_compras` VALUES ('42', '1', '2', '2006-01-11', '286.87', '60.24');
INSERT INTO `iva_compras` VALUES ('43', '2', '2', '2003-01-03', '1909.06', '400.90');
INSERT INTO `iva_compras` VALUES ('44', '1', '1', '2001-08-09', '111.47', '23.41');
INSERT INTO `iva_compras` VALUES ('45', '2', '1', '1999-08-30', '1613.52', '338.84');
INSERT INTO `iva_compras` VALUES ('46', '2', '1', '1996-07-06', '562.96', '118.22');
INSERT INTO `iva_compras` VALUES ('47', '2', '1', '2010-09-13', '5677.29', '1192.23');
INSERT INTO `iva_compras` VALUES ('48', '2', '1', '2008-07-20', '847.41', '177.96');
INSERT INTO `iva_compras` VALUES ('49', '1', '1', '2006-02-09', '2347.65', '493.01');
INSERT INTO `iva_compras` VALUES ('50', '2', '2', '2003-11-17', '168.71', '35.43');
INSERT INTO `iva_compras` VALUES ('51', '1', '1', '2001-07-23', '4778.62', '1003.51');
INSERT INTO `iva_compras` VALUES ('52', '2', '1', '1999-07-15', '7264.32', '1525.51');
INSERT INTO `iva_compras` VALUES ('53', '2', '1', '1996-07-06', '562.96', '118.22');
INSERT INTO `iva_compras` VALUES ('54', '1', '1', '2011-06-12', '2759.83', '579.56');
INSERT INTO `iva_compras` VALUES ('55', '1', '1', '2008-06-04', '4357.79', '915.14');
INSERT INTO `iva_compras` VALUES ('56', '2', '2', '2006-03-27', '2171.46', '456.01');
INSERT INTO `iva_compras` VALUES ('57', '1', '2', '2003-04-04', '506.41', '106.35');
INSERT INTO `iva_compras` VALUES ('58', '2', '2', '1996-11-22', '1092.22', '229.37');
INSERT INTO `iva_compras` VALUES ('59', '1', '2', '2010-03-15', '4741.84', '995.79');
INSERT INTO `iva_compras` VALUES ('60', '1', '2', '2007-05-22', '1685.61', '353.98');
INSERT INTO `iva_compras` VALUES ('61', '1', '1', '2004-03-01', '1201.81', '252.38');
INSERT INTO `iva_compras` VALUES ('62', '1', '2', '2001-01-25', '3884.51', '815.75');
INSERT INTO `iva_compras` VALUES ('63', '2', '1', '2011-04-26', '1341.49', '281.71');
INSERT INTO `iva_compras` VALUES ('64', '2', '1', '2008-07-20', '847.41', '177.96');
INSERT INTO `iva_compras` VALUES ('65', '2', '2', '2005-04-12', '5.49', '1.15');
INSERT INTO `iva_compras` VALUES ('66', '1', '2', '2003-04-04', '506.41', '106.35');
INSERT INTO `iva_compras` VALUES ('67', '2', '2', '2000-04-25', '1360.53', '285.71');
INSERT INTO `localidades` VALUES ('1', 'Rio Cuarto');
INSERT INTO `localidades` VALUES ('2', 'Holmberg');
INSERT INTO `localidades` VALUES ('3', 'Rio Tercero');
INSERT INTO `localidades` VALUES ('4', 'San Luis');
INSERT INTO `localidades` VALUES ('5', 'Cordoba');
INSERT INTO `proveedores` VALUES ('1', 'Gonzales', '0325698745', '1', '1');
INSERT INTO `proveedores` VALUES ('2', 'Perez', '0956874236', '2', '2');
INSERT INTO `proveedores` VALUES ('3', 'Gomez', '5632146987', '1', '3');
INSERT INTO `tipo_documento` VALUES ('1', 'A');
INSERT INTO `tipo_documento` VALUES ('2', 'B');
INSERT INTO `tipo_documento` VALUES ('3', 'C');
