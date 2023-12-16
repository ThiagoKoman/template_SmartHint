# template_SmartHint

Comando para criação da tabela:
```
'clientes', 'CREATE TABLE `clientes` (\n  `id` int NOT NULL AUTO_INCREMENT,\n  `nome` varchar(150) NOT NULL,\n  `email` varchar(150) NOT NULL,\n  `telefone` varchar(11) NOT NULL,\n  `data_cadastro` datetime DEFAULT NULL,\n  `pessoa` varchar(10) NOT NULL,\n  `cpf` varchar(11) DEFAULT NULL,\n  `cnpj` varchar(14) DEFAULT NULL,\n  `inscricao_estadual` varchar(12) DEFAULT NULL,\n  `genero` varchar(10) DEFAULT NULL,\n  `nascimento` datetime DEFAULT NULL,\n  `bloqueado` tinyint DEFAULT NULL,\n  `senha` varchar(15) DEFAULT NULL,\n  `inscricao_estadual_isento` tinyint DEFAULT NULL,\n  PRIMARY KEY (`id`),\n  UNIQUE KEY `cpf_UNIQUE` (`cpf`),\n  UNIQUE KEY `cnpj_UNIQUE` (`cnpj`)\n) ENGINE=InnoDB AUTO_INCREMENT=54 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci'
```
