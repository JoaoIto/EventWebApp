# EventWebApp

O *EventWebApp* é uma aplicação desenvolvida para o gerenciamento de eventos, voltada para empresas de tecnologia que desejam organizar conferências, reuniões, meets e calls de forma prática e eficiente. A aplicação permite o cadastro e acompanhamento de eventos, além de promover a interação entre os usuários participantes.

## Funcionalidades

- **Cadastro de Eventos**: Os usuários podem criar eventos, especificando detalhes como nome, data e categoria.
- **Gerenciamento de Categorias**: A aplicação permite a criação e edição de categorias para organizar os eventos.
- **Interação com Comentários**: Cada evento pode receber comentários, promovendo a interação entre participantes.
- **Controle de Participação**: Os usuários podem confirmar presença em eventos, registrando sua participação.
- **Login Social**: Possui integração com Google e Microsoft, facilitando o acesso seguro dos usuários.
- **Controle de Acesso**: Algumas telas são públicas e outras são privadas. As telas privadas exigem que o usuário esteja logado.

## Estrutura do Projeto

A aplicação é estruturada em três camadas principais: Model, View e Controller (MVC).

- **Models**: Contêm a lógica de dados, definindo as entidades da aplicação:
  - `Evento`: representa cada evento, com atributos como nome e data.
  - `Categoria`: organiza eventos em diferentes categorias.
  - `Comentario`: permite que os usuários comentem nos eventos.
  - `Participacao`: registra a participação de usuários em eventos.
  - `Usuario`: gerencia as informações de cada usuário cadastrado na plataforma.

- **Controllers**: Controlam as operações das principais entidades do sistema:
  - `EventoesController`: gerencia as operações relacionadas a eventos.
  - `CategoriasController`: controla as operações de criação e edição de categorias.
  - `ComentariosController`: gerencia as interações nos eventos por meio dos comentários.

- **Views**: Exibe a interface para o usuário interagir com as funcionalidades da aplicação, incluindo telas públicas e privadas. 

## Tecnologias Utilizadas

- **.NET**: Framework principal para o desenvolvimento do backend.
- **JavaScript**: Adicionado para aumentar a interatividade da interface.
- **C#**: Linguagem utilizada para construir o backend e a lógica do sistema.

## Configuração e Instalação

Para rodar o *EventWebApp*, você precisa ter instalado o **.NET Framework** e configurar a conexão com o banco de dados, que pode ser definida no arquivo de configuração da aplicação.

1. Clone o repositório:
   ```bash
   git clone https://github.com/JoaoIto/EventWebApp
   ```

2. Configure o banco de dados e as strings de conexão:
   ```bash
   Data Source=JOAOITODESK;Initial Catalog=eventDb;Integrated Security=True;
   ```

3. Instale as dependências e execute o projeto:
   ```bash
   dotnet build
   dotnet run
   ```

4. Acesse a aplicação pelo navegador no endereço `http://localhost:5000`.

## Segurança e Controle de Acesso

A aplicação possui autenticação via Google e Microsoft para controle de acesso. Algumas páginas e funcionalidades são protegidas e acessíveis apenas para usuários logados, incluindo a criação de novos eventos e a confirmação de participação.

## Estrutura de Telas

- **Públicas**:
  - Página inicial: exibe os eventos principais e uma visão geral das categorias.
  - Detalhes de evento: mostra os detalhes de cada evento para que qualquer visitante possa visualizá-los.

- **Privadas**:
  - Criação de evento: acessível apenas para usuários logados.
  - Confirmação de participação: controle de presença nos eventos.
  - Edição de evento: permite ajustes em eventos existentes.
  - Comentários: adiciona interatividade e troca de opiniões entre os participantes.
  - Gerenciamento de categorias: administração das categorias de eventos.
  - Configurações de usuário: permite aos usuários atualizarem informações pessoais.

## Contribuição

Contribuições são bem-vindas. Para isso, faça um fork do repositório, crie uma branch com as alterações e abra um Pull Request.

## Licença

Esse projeto está sob a licença MIT. 

--- 
