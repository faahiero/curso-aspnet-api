# Curso de API ASP.NET Core

Este repositório contém o código-fonte de uma API multiplataforma implementada com .NET Core 3.1 e C# no curso [ASP.NET Core 3.1 - API com Arquitetura DDD na Prática](https://www.udemy.com/course/aspnet-core-22-c-api-com-arquitetura-ddd-na-pratica/). 
A API é projetada usando uma arquitetura em camadas com Design Orientado a Domínio (DDD) para modelagem. O banco de dados usado é o MySQL, primeiramente (mas também pode ser usando SQL Server, com os devidos ajustes) usando o Entity Framework Core como a ferramenta de Mapeamento Objeto-Relacional (ORM). O AutoMapper é usado para mapeamento entre Objetos de Transferência de Dados (DTOs) e Modelos de Domínio.

## Recursos

- **JWT (JSON Web Token)**: Usado para gerar tokens para consumo por aplicações externas ou front-end.
- **Swagger**: Uma ferramenta usada para documentar a API.
- **Testes Unitários**: A arquitetura inclui testes unitários (xUnit) para cada camada, usando Mock e Faker .NETCore.
- **Testes de Integração**: Um projeto para testes de integração está incluído, que testa suas próprias solicitações.
- **Endpoints**: O projeto inclui endpoints para Usuário, UF (Unidade Federal), Município e CEPs.

## Ferramentas

- **Visual Studio Code**: O editor de código usado neste curso.
- **Mock**: Usado para criar dados fictícios baseados em nosso modelo de negócios, para verificar o comportamento de nossas aplicações. Pode ser usado para emular tanto repositórios de dados quanto objetos individuais em testes unitários.
- **Faker .NETCore**: Usado para criar dados fictícios (Nome, email, Endereço, Telefone entre outros).

## Compatibilidade

A API, Visual Studio Code, MySQL e MS-SQL-Server podem ser usados no Windows, Linux e Mac.

## Atualizações

No final do curso, o projeto será atualizado do .NET Core 3.1 para o .NET 5.0, e do .NET 5.0 para o .NET 6.0.
