--DROP TABLE alunos;

CREATE TABLE alunos(
	id INTEGER PRIMARY KEY,
	nome VARCHAR(60),
	nota_1 DECIMAL(4,2),
	nota_2 DECIMAL(4,2)
);

INSERT INTO alunos (id, nome) VALUES (1, 'Kauã');
INSERT INTO alunos (nome, id) VALUES ('Claúdio', 2);

SELECT id, nome, nota_1, nota_2 FROM alunos;

--Definir a nota 1 do Kauã
UPDATE alunos SET nota_1 = 4.75 WHERE id = 1;
-- Definir a nota 1 do Claúdio
UPDATE alunos SET nota_1 = 8.5 WHERE id = 2;


-- Definir a nota 2 do Claúdio
UPDATE alunos SET nota_2 = 7.5 WHERE id = 2;


SELECT nome, nota_1, nota_2 FROM alunos;

-- Definir nota 2 do Kauã
UPDATE alunos SET nota_2 = 9 WHERE id = 1;

ALTER TABLE alunos ADD media DECIMAL(4,2);

SELECT nome, nota_1, nota_2, media FROM alunos;
-- Definir a média do Kauã
-- UPDATE alunos SET media = 6.875 WHERE id = 1;
-- Definir a média do Claúdio
-- UPDATE alunos SET media = ((8.50 + 5.40)/2) WHERE id = 2;

-- Calcular a média de todos os registros da tabela de alunos;
UPDATE alunos SET media = ((nota_1 + nota_2) / 2);

ALTER TABLE alunos ADD aprovado BIT;

UPDATE alunos SET aprovado = 1 WHERE media >= 7;
UPDATE alunos SET aprovado = 0 WHERE media < 7;

SELECT id, nome, nota_1, nota_2, media, aprovado FROM alunos;

ALTER TABLE alunos ALTER COLUMN aprovado VARCHAR(9);

UPDATE alunos SET aprovado = 'Aprovado' WHERE aprovado = '1';
UPDATE alunos SET aprovado = 'Reprovado' WHERE aprovado = '0';

EXEC sp_rename 'alunos.aprovado', 'status', 'COLUMN';

SELECT id, nome, nota_1, nota_2, media, status FROM alunos;


INSERT INTO alunos (id, nome) VALUES (10, 'Ana');

-- PRIMARY KEY => Chave primária (identificador único do registro)
CREATE TABLE produtos (
	-- IDENTITY(primeiroId, valorIncremento)
	id INTEGER PRIMARY KEY IDENTITY(1,1), 
	nome VARCHAR(100),
	valor DECIMAL(5, 2),
	categoria VARCHAR(10)
);
ALTER TABLE produtos ALTER COLUMN categoria VARCHAR(12);

SELECT id, nome,valor, categoria FROM produtos;

INSERT INTO produtos (nome, valor, categoria) 
	VALUES ('Nescau', 10.70, 'achocolatado');
INSERT INTO produtos (nome, valor, categoria)
	VALUES ('Nescau cereal', 14.20, 'cereal');

INSERT INTO produtos (nome, valor, categoria)
	VALUES ('Bebida nescau com leite', 14.20, 'achocolatado');

	
INSERT INTO produtos (nome, valor, categoria)
	VALUES ('Leitche com nescau', 14.20, 'achocolatado');

	
INSERT INTO produtos (nome, valor, categoria)
	VALUES ('Nescafé da vida', 14.20, 'achocolatado');

-- Filtrar o produto em que o nome é exatamente Nescau
SELECT 
	id, nome 
	FROM produtos 
	WHERE nome = 'Nescau';

-- Filtrar o produto em que o nome 
-- começa com Nescau
SELECT id, nome
	FROM produtos
	WHERE nome LIKE 'Nescau%';

-- Filtrar o produto em que o nome 
-- termina com Nescau
SELECT id, nome
	FROM produtos
	WHERE nome LIKE '%Nescau';

-- Filtrar o produto em que o nome 
-- contém Nescau	
SELECT id, nome
	FROM produtos
	WHERE nome LIKE '%Nescau%';

SELECT id, nome, valor FROM produtos;

UPDATE produtos SET valor = 7.90 WHERE id = 5;
UPDATE produtos SET valor = 17.50 WHERE id = 5;
UPDATE produtos SET valor = 60.00 WHERE id = 6;

SELECT id, nome, valor FROM produtos;

-- Ordenar os registros A-Z 0-9
SELECT id, nome, valor 
	FROM produtos
	ORDER BY valor ASC;

-- Ordenar os registros Z-A 9-0
SELECT id, nome, valor 
	FROM produtos
	ORDER BY valor DESC;

SELECT id, nome
	FROM produtos
	ORDER BY nome ASC;

-- Descobrir o menor valor
SELECT MIN(valor) FROM produtos;

-- Descobrir o id, nome e valor do(s) produto(s) que contém o menor valor
SELECT id, nome, valor
	FROM produtos 
	WHERE valor = (SELECT MIN(p.valor) FROM produtos p);

-- Descobrir o maior valor
SELECT MAX(valor)
	FROM produtos;
-- Descobrir o maior valor da categoria Achocolatado
SELECT MAX(valor)
	FROM produtos
	WHERE categoria = 'Cereal';

SELECT id, nome, valor, categoria FROM produtos;

-- Descobrir a soma dos valores
SELECT SUM(valor) FROM produtos;

-- Descobrir a média dos preços
-- AVG => Average
SELECT AVG(valor)
	FROM produtos
	WHERE categoria = 'Achocolatado';

SELECT id, nome, valor, categoria 
	FROM produtos
	WHERE categoria = 'Achocolatado';

-- Descobrir a quantidade de caracteres 
SELECT id, nome, LEN(nome) FROM produtos;

-- Descobrir as inforamções do produto que contém o menor nome
-- AS => Apelido da coluna, tabela
SELECT 
	id AS 'Código', 
	nome AS 'Nome Produto', 
	LEN(nome) AS 'Quantidade de caracteres do nome do produto'
	FROM produtos
	WHERE LEN(nome) = (SELECT MIN(LEN(p.nome)) FROM produtos p);

-- Descobrir os produtos que não são a categoria 'Achocolatado'
SELECT
	id,
	nome,
	categoria
	FROM produtos
	WHERE categoria != 'Achocolatado'

CREATE TABLE trabalhos(
	id INTEGER PRIMARY KEY IDENTITY(1,1),
	titulo VARCHAR(100),
	subtitulo VARCHAR(50), -- armazenár até 50 caracteres
	descricao TEXT, -- armazenar textos grandes
	data_publicacao DATETIME2, -- data e hora
	tipo VARCHAR(15)
);

INSERT INTO trabalhos 
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('A melhor pizza do mundo', 
		'Como degustar uma pizza de calabresa', 
		'Grande descrição aki', '1994-06-04', 'Receita');

INSERT INTO trabalhos 
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Clean code', 'Como trabalhar melhor no seu dia a dia', 
	'Utilizar var no lugar de tipo primitivos, Identar seu código,
	Utilizar constantes', '2000-03-20', 'Leitura técnica');

INSERT INTO trabalhos 
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Pudim com ovo', 'Aprenda o que não fazer na sua vida', 
	'Jogue o pudim no lixo e faça um ovo', '2022-07-06', 'Receita');

INSERT INTO trabalhos 
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Estrutura de dados', 
	'como sofrer sem saber, porém é necessário', 
	'Importante para aprender fifo, lifo, fefo, listas encadeadas', 
	'1980-05-11', 'Leitura técnica');

INSERT INTO trabalhos 
	(titulo, subtitulo, descricao, data_publicacao, tipo)
	VALUES ('Strogonoff de frango', 'a vitória da batata palha', 
	'Compre frango e batata palha, jogue na panela, acenda o fogão, 
	espera 5 minutinhos e ta plonto o sorvetinho', 
	'2000-09-10', 'Receita');

SELECT id, titulo, subtitulo, descricao, data_publicacao, tipo 
	FROM trabalhos;

-- Concatenar informação de duas colunas
SELECT 
	CONCAT(titulo, ' - ', subtitulo) AS 'Título completo'
	FROM trabalhos;

-- Consultar a descrição limitando a quantidade de caracteres
SELECT 
	titulo AS 'Título',
	CONCAT(SUBSTRING(descricao, 0, 30), '...') AS 'Descrição'
	FROM trabalhos;

-- Consultar os trabalhos filtrando por ano da publicação entre 1990 até 2010
SELECT id, titulo, data_publicacao 
	FROM trabalhos
	WHERE 
		YEAR(data_publicacao) >= 1990 AND 
		YEAR(data_publicacao) <= 2010;

-- Consultar data publicação formato BR huehue
-- BR: dia/mes/ano
SELECT id, titulo, 
	CONCAT(
		DAY(data_publicacao), '/', 
		MONTH(data_publicacao), '/', 
		YEAR(data_publicacao))
	FROM trabalhos;

-- Consultar data publicação formatando no padrão BR, utilizando função para isso
SELECT id, titulo, FORMAT(data_publicacao, 'dd/MM/yyyy')
	FROM trabalhos;

SELECT id, titulo FROM trabalhos;

-- Limitar a consulta para dois registros
SELECT TOP(2) id, titulo FROM trabalhos;

-- Apresentar o código, nome, preço, se está favoritado 
-- filtrando por Placa mãe ou placa de vídeo do maior preço para o menor
-- SELECT TOP(20) id, nome, preco, favoritado 
-- FROM produtos 
-- WHERE categoria = 'Placa mãe' OR categoria = 'Placa de vídeo'
-- ORDER BY preco DESC


-- Consulta com paginação apresentando 2 registros da página 1
SELECT  id, titulo 
	FROM trabalhos 
	ORDER BY id
	OFFSET 0 ROWS FETCH NEXT 2 ROWS ONLY;

-- Consulta com paginação apresentando 2 registros da página 2
SELECT  id, titulo 
	FROM trabalhos 
	ORDER BY id
	OFFSET 2 ROWS FETCH NEXT 2 ROWS ONLY;

-- Consulta com paginação apresentando 2 registros da página 3
SELECT  id, titulo 
	FROM trabalhos 
	ORDER BY id
	OFFSET 4 ROWS FETCH NEXT 2 ROWS ONLY;
