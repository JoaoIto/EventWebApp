Aqui está o **README.md** atualizado com os comandos do Entity Framework para gerenciamento de migrações e banco de dados:

---

# EventWebApp

O *EventWebApp* é uma aplicação desenvolvida para o gerenciamento de eventos, voltada para empresas de tecnologia que desejam organizar conferências, reuniões, meets e calls de forma prática e eficiente. A aplicação permite o cadastro e acompanhamento de eventos, além de promover a interação entre os usuários participantes.

## Funcionalidades

- **Cadastro de Eventos**: Os usuários podem criar eventos, especificando detalhes como nome, data e categoria.
- **Gerenciamento de Categorias**: A aplicação permite a criação e edição de categorias para organizar os eventos.
- **Interação com Comentários**: Cada evento pode receber comentários, promovendo a interação entre participantes.
- **Controle de Participação**: Os usuários podem confirmar presença em eventos, registrando sua participação.
- **Login Social**: Possui integração com Google e Microsoft, facilitando o acesso seguro dos usuários.
- **Controle de Acesso**: Algumas telas são públicas e outras são privadas. As telas privadas exigem que o usuário esteja logado.

## Configuração e Instalação

Para rodar o *EventWebApp*, você precisa ter instalado o **.NET Framework**, configurar a conexão com o banco de dados, e garantir que as migrações sejam aplicadas corretamente.

### 1. Clone o repositório:
```bash
git clone https://github.com/JoaoIto/EventWebApp
```

### 2. Configure a string de conexão no arquivo `App.config` ou `Web.config`:
Exemplo:
```xml
<connectionStrings>
  <add name="DefaultConnection" 
       connectionString="Data Source=JOAOITODESK;Initial Catalog=eventDb;Integrated Security=True;" 
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

### 3. Comandos do Entity Framework

Após configurar a string de conexão, execute os seguintes comandos no **Package Manager Console** para preparar o banco de dados:

#### Atualizar o banco de dados:
```powershell
Update-Database
- Atualiza o banco para uma migração específica.
```

### 4. Execute o projeto:
```bash
dotnet build
dotnet run
```

### 5. Verifique o banco de dados:
Após atualizar o banco de dados, acesse seu gerenciador SQL (como o SQL Server Management Studio) para verificar se as tabelas foram criadas corretamente.

---

## Estrutura do Projeto

O projeto segue o padrão MVC (Model-View-Controller), e está organizado da seguinte forma:
- **Models**: Contêm as entidades e a lógica de dados.
- **Controllers**: Gerenciam as operações de cada entidade.
- **Views**: Exibem as interfaces para os usuários.

## Contribuição

Contribuições são bem-vindas. Faça um *fork*, crie uma nova branch, e envie um *Pull Request* com as alterações.

## Licença

Esse projeto está sob a licença MIT.

--- 

Com essa seção, qualquer desenvolvedor terá uma explicação clara de como gerenciar as migrações e preparar o banco de dados da aplicação.
