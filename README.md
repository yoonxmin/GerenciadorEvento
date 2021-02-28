# GerenciadorEvento

Neste presente documento, está a descrição de funcionamento do projeto e os programas os quais o mesmo foi desenvolvido.

O projeto é um Gerenciador de Eventos, esta que foi desenvolvido no Visual Studio utilizando a liguagem de programação C#. Neste projeto, o usuário poderá Cadastrar, Alterar, Excluir e Listar os participantes, as salas e os cafés, que farão parte do evento. O usuário também poderá atribuir as salas e os espaços de café ao participante. O mesmo possui uma interface simples e prática, com objetivo de melhor entendimento e praticidade para o usuário.

No arquivo "GerenciadorEvento" possuí as seguintes pastas:

- ConexaoMySQL - Onde é estabelecida a conexão do código com o banco de dados e a inserção e recuperação de dados;

- Controller

- Entidades - Onde esta declarado as entidades que são usadas no sistema;

-TrataDados - Onde ocorre a verificação e inconsistência das entidades;

-Visual - Onde possui a parte visual (janelas) do sistema.

Como um dos requisitos do desafio, o sistema possui uma persistência de dados, que foi criado utilizando o programa MySQL Workbench usando o localhost. Então, para poder executar o programa, deve-se baixar o MySQL Workbench, inserir o user "root" sem a necessidade de senha e iniciar um servidor com o nome "GerenciadorEvento". Todas as informações precisam ser iguais ao código, para que não haja conflito e para que ele possa ser executado.


