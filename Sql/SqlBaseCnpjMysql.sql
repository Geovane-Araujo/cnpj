CREATE TABLE `basecnpj` (
  `id` smallint NOT NULL AUTO_INCREMENT,
  `cnpj` varchar(14) DEFAULT NULL,
  `identificador` varchar(2) DEFAULT NULL,
  `nomeempresa` varchar(150) DEFAULT NULL,
  `fantasia` varchar(55) DEFAULT NULL,
  `situacaocadastral` varchar(2) DEFAULT NULL,
  `datasituacao` date DEFAULT NULL,
  `motivosituacao` varchar(2) DEFAULT NULL,
  `naturezajuridica` varchar(4) DEFAULT NULL,
  `dataabertura` date DEFAULT NULL,
  `cnae` varchar(8) DEFAULT NULL,
  `tipologradouro` varchar(20) DEFAULT NULL,
  `endereco` varchar(60) DEFAULT NULL,
  `complemento` varchar(156) DEFAULT NULL,
  `cep` varchar(8) DEFAULT NULL,
  `uf` varchar(2) DEFAULT NULL,
  `cidade` varchar(50) DEFAULT NULL,
  `telefone1` varchar(36) DEFAULT NULL,
  `numero` varchar(6) DEFAULT NULL,
  `bairro` varchar(50) DEFAULT NULL,
  `email` varchar(115) DEFAULT NULL,
  `porte` varchar(2) DEFAULT NULL,
  `qualificacaopessoaresp` varchar(2) DEFAULT NULL,
  `capital` varchar(14) DEFAULT NULL,
  `opcaosimples` varchar(1) DEFAULT NULL,
  `dataopcaosimples` date DEFAULT NULL,
  `dataexclusaosimles` date DEFAULT NULL,
  `opcaomei` varchar(1) DEFAULT NULL,
  `situacaoespecial` varchar(23) DEFAULT NULL,
  `datasituacaoespecial` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=25226 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci


CREATE TABLE `cnaesecond` (
  `id` smallint NOT NULL AUTO_INCREMENT,
  `cnpj` varchar(14) DEFAULT NULL,
  `cnae` varchar(8) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci

CREATE TABLE `socio` (
  `id` smallint NOT NULL AUTO_INCREMENT,
  `cnpj` varchar(14) DEFAULT NULL,
  `socio` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci


