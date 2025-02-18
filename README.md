API de Gerenciamento de Produtos
Esta é uma API simples para gerenciamento de produtos, com operações CRUD (Criar, Ler, Atualizar e Deletar). A API foi desenvolvida utilizando .NET Core 8.0 e utiliza o Entity Framework Core para persistência de dados.

Como Rodar o Projeto Localmente
Requisitos
SQL Server Local ou outro banco de dados de sua escolha: Você pode usar o SQL Server LocalDB ou uma instância do SQL Server.
Visual Studio ou Visual Studio Code: Para desenvolvimento local, caso queira fazer alterações no código.
.NET SDK: Para compilar e rodar o projeto.
Passos para Rodar o Projeto
Clone o Repositório
Clone este repositório para sua máquina local usando o seguinte comando:

bash
Copiar
Editar
git clone https://github.com/pimentazil/WebApiCoordly.git
Abra o Projeto no Visual Studio ou Visual Studio Code
Abra a pasta do projeto no Visual Studio ou Visual Studio Code.

Restaurar Dependências
Execute o seguinte comando na raiz do projeto para restaurar as dependências do .NET:

bash
Copiar
Editar
dotnet restore
Aplicar as Migrações e Criar o Banco de Dados
Para criar o banco de dados e aplicar as migrações, execute o seguinte comando:

bash
Copiar
Editar
dotnet ef database update --project WebApiCoordly.Infrastructure --startup-project WebApiCoordly.Api
Este comando aplica as migrações no banco de dados configurado no projeto.

Rodar a API Localmente
Após aplicar as migrações, você pode rodar a API localmente utilizando o comando:

bash
Copiar
Editar
dotnet run --project WebApiCoordly.Api
Isso irá iniciar o servidor localmente e a API estará disponível no endereço http://localhost:5000 (ou outro, conforme configurado).

Acessando o Swagger para Testar a API
Abrir o Swagger
Depois que o projeto estiver rodando, você pode acessar o Swagger para testar a API. Abra o navegador e vá para a URL:

bash
Copiar
Editar
http://localhost:5000/swagger
Isso abrirá o Swagger, onde você poderá visualizar os endpoints da API e testar as operações CRUD (Criar, Ler, Atualizar e Deletar) diretamente no navegador.
