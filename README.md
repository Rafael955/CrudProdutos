# CrudProdutos

Sistema de Controle de Produtos (CRUD) em .NET 9

## Descrição

Aplicação de console para gerenciamento de produtos, permitindo cadastrar, atualizar, excluir e consultar produtos em um banco de dados SQL Server. Utiliza Dapper para acesso a dados, FluentValidation para validação e segue arquitetura em camadas.

## Funcionalidades

- **Cadastrar Produto:** Adiciona um novo produto com nome, preço e quantidade.
- **Atualizar Produto:** Atualiza os dados de um produto existente pelo ID.
- **Excluir Produto:** Remove um produto do banco de dados pelo ID.
- **Consultar Produto:** Lista produtos filtrando por nome.

## Estrutura do Projeto

- `Entities/Produto.cs`: Entidade que representa o produto.
- `Repositories/ProdutoRepository.cs`: Operações de acesso ao banco de dados.
- `Controllers/ProdutoController.cs`: Lógica de negócio e interação com o usuário.
- `Validators/ProdutoValidator.cs`: Regras de validação dos dados do produto.
- `Settings/AppSettings.cs`: String de conexão com o banco de dados.

## Tecnologias Utilizadas

- .NET 9
- Dapper
- FluentValidation
- SQL Server (LocalDB)

## Pré-requisitos

- .NET 9 SDK
- SQL Server LocalDB

## Configuração do Banco de Dados

Crie o banco de dados `BDCrudProdutos` e a tabela `PRODUTO` com o seguinte script:

CREATE DATABASE BDCrudProdutos; 
GO

USE BDCrudProdutos; 
GO

CREATE TABLE PRODUTO (ID UNIQUEIDENTIFIER PRIMARY KEY, NOME NVARCHAR(100) NOT NULL, PRECO FLOAT NOT NULL, QUANTIDADE INT NOT NULL, DATAHORACADASTRO DATETIME NOT NULL, DATAHORAULTIMAALTERACAO DATETIME NOT NULL);

## Como Executar

1. Clone o repositório.
2. Abra o projeto no Visual Studio 2022.
3. Restaure os pacotes NuGet (__Project > Manage NuGet Packages__).
4. Compile e execute o projeto (__F5__ ou __Ctrl+F5__).

## Uso

Ao iniciar, o menu principal será exibido:

(1) CADASTRAR PRODUTO 
(2) ATUALIZAR PRODUTO 
(3) EXCLUIR PRODUTO 
(4) CONSULTAR PRODUTO 
(5) SAIR

Digite o número da opção desejada e siga as instruções na tela.

## Observações

- Os dados são persistidos em um banco SQL Server LocalDB.
- O projeto utiliza validação de dados para garantir integridade das informações.

---
