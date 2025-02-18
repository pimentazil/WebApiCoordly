# API de Gerenciamento de Produtos

Uma API RESTful desenvolvida em .NET Core 8.0, utilizando o Entity Framework Core para persistência de dados. Esta API permite realizar operações CRUD (Criar, Ler, Atualizar e Deletar) sobre produtos.

## 🛠 Tecnologias Utilizadas
- **.NET Core 8.0**
- **Entity Framework Core** para acesso e manipulação de dados
- **SQL Server** (ou outro banco de dados de sua escolha)
  
## 📝 Pré-requisitos
Antes de rodar a API localmente, verifique se você possui as seguintes dependências instaladas:

- **SQL Server Local ou Instância Remota**: O banco de dados pode ser o SQL Server LocalDB ou uma instância de SQL Server de sua escolha.
- **Visual Studio** ou **Visual Studio Code** para desenvolvimento local.
- **.NET SDK**: Certifique-se de que o .NET SDK esteja instalado em sua máquina. Você pode baixar a versão mais recente do SDK em [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).

## 🚀 Como Rodar o Projeto Localmente

### Passos:

### 1️⃣ Clone o Repositório
Clone o repositório do projeto utilizando o comando git:

`git clone https://github.com/pimentazil/WebApiCoordly.git`

### 2️⃣ Aplicar as Migrações e Criar o Banco de Dados

Após clonar o repositório, navegue até a pasta do projeto e aplique as migrações para criar o banco de dados:
    dotnet ef database update --project WebApiCoordly.Infrastructure --startup-project WebApiCoordly.Api

3️⃣ Rodar a API Localmente
Com as migrações aplicadas, inicie o servidor localmente utilizando o seguinte comando:

dotnet run
