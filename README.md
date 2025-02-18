# API de Gerenciamento de Produtos

Uma API RESTful desenvolvida em .NET Core 8.0, utilizando o Entity Framework Core para persistência de dados. Esta API permite realizar operações CRUD (Criar, Ler, Atualizar e Deletar) sobre produtos.

## 🛠 Tecnologias Utilizadas
- **.NET Core 8.0**
- **Entity Framework Core** para acesso e manipulação de dados
- **SQL Server** (ou outro banco de dados de sua escolha)
  

## 🚀 Como Rodar o Projeto Localmente

### Passos:

### 1️⃣ Clone o Repositório
Clone o repositório do projeto utilizando o comando git:

`git clone https://github.com/pimentazil/WebApiCoordly.git`


### 2️⃣ Aplicar as Migrações e Criar o Banco de Dados

Após clonar o repositório, navegue até a pasta do projeto e aplique as migrações para criar o banco de dados:

`dotnet ef database update --project WebApiCoordly.Infrastructure --startup-project WebApiCoordly.Api`


3️⃣ Rodar a API Localmente
Com as migrações aplicadas, inicie o servidor localmente utilizando o seguinte comando:

dotnet run
