# template_SmartHint

Comando para criação da tabela:
```
'CREATE TABLE `clientes` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(150) NOT NULL,
  `email` varchar(150) NOT NULL,
  `telefone` varchar(11) NOT NULL,
  `data_cadastro` datetime DEFAULT NULL,
  `pessoa` varchar(10) NOT NULL,
  `cpf` varchar(11) DEFAULT NULL,
  `cnpj` varchar(14) DEFAULT NULL,
  `inscricao_estadual` varchar(12) DEFAULT NULL,
  `genero` varchar(10) DEFAULT NULL,
  `nascimento` datetime DEFAULT NULL,
  `bloqueado` tinyint DEFAULT NULL,
  `senha` varchar(15) DEFAULT NULL,
  `inscricao_estadual_isento` tinyint DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `cpf_UNIQUE` (`cpf`),
  UNIQUE KEY `cnpj_UNIQUE` (`cnpj`)
) ENGINE=InnoDB AUTO_INCREMENT=54 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci'
```
