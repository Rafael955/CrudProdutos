# CrudProdutos

Sistema de Controle de Produtos (CRUD) em .NET 9

## Descri��o

Aplica��o de console para gerenciamento de produtos, permitindo cadastrar, atualizar, excluir e consultar produtos em um banco de dados SQL Server. Utiliza Dapper para acesso a dados, FluentValidation para valida��o e segue arquitetura em camadas.

## Funcionalidades

- **Cadastrar Produto:** Adiciona um novo produto com nome, pre�o e quantidade.
- **Atualizar Produto:** Atualiza os dados de um produto existente pelo ID.
- **Excluir Produto:** Remove um produto do banco de dados pelo ID.
- **Consultar Produto:** Lista produtos filtrando por nome.

## Estrutura do Projeto

- `Entities/Produto.cs`: Entidade que representa o produto.
- `Repositories/ProdutoRepository.cs`: Opera��es de acesso ao banco de dados.
- `Controllers/ProdutoController.cs`: L�gica de neg�cio e intera��o com o usu�rio.
- `Validators/ProdutoValidator.cs`: Regras de valida��o dos dados do produto.
- `Settings/AppSettings.cs`: String de conex�o com o banco de dados.

## Tecnologias Utilizadas

- .NET 9
- Dapper
- FluentValidation
- SQL Server (LocalDB)

## Pr�-requisitos

- .NET 9 SDK
- SQL Server LocalDB

## Configura��o do Banco de Dados

Crie o banco de dados `BDCrudProdutos` e a tabela `PRODUTO` com o seguinte script:

CREATE DATABASE BDCrudProdutos; 
GO

USE BDCrudProdutos; 
GO

CREATE TABLE PRODUTO (ID UNIQUEIDENTIFIER PRIMARY KEY, NOME NVARCHAR(100) NOT NULL, PRECO FLOAT NOT NULL, QUANTIDADE INT NOT NULL, DATAHORACADASTRO DATETIME NOT NULL, DATAHORAULTIMAALTERACAO DATETIME NOT NULL);

## Como Executar

1. Clone o reposit�rio.
2. Abra o projeto no Visual Studio 2022.
3. Restaure os pacotes NuGet (__Project > Manage NuGet Packages__).
4. Compile e execute o projeto (__F5__ ou __Ctrl+F5__).

## Uso

Ao iniciar, o menu principal ser� exibido:

(1) CADASTRAR PRODUTO 
(2) ATUALIZAR PRODUTO 
(3) EXCLUIR PRODUTO 
(4) CONSULTAR PRODUTO 
(5) SAIR

Digite o n�mero da op��o desejada e siga as instru��es na tela.

## Observa��es

- Os dados s�o persistidos em um banco SQL Server LocalDB.
- O projeto utiliza valida��o de dados para garantir integridade das informa��es.

---
