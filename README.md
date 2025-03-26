Olá, este projeto é de minha autoria mas fique a vontade para clona-lo a fim de estudos.
O objetivo desta API é gerenciar um estoque de produtos do tipo 'vestuário', 
sendo assim, criei um CRUD utilizando .net 8, Entity Framework (code-first).
Esta API foi feita em apenas uma camada, ou seja, dispensando a necessidade de injeção de dependência e interfaces,
utilizando apenas 2 classes principais além de uma única controller.

Para que o projeto funcione em sua máquina, siga os passos a seguir:
1 - Verifique a string de conexão do banco de dados em appsettings(raiz), altere para sua conexão de banco.
2 - Certifique-se de não há uma tabela nomeada 'Produtos' em sua instância de banco de dados.
3 - Clone o projeto em sua máquina local.
4 - Ao abrir o projeto no visual studio, DELETE a pasta 'Migrations' do projeto.
5 - Vá até ferramentas > gerenciamento de pacotes nuget > package manager console.
6 - Com o terminal aberto, digite o comando 'Add-migration INIT'.
7 - Após rodar esse comando, note que aparecerá uma pasta chamada 'Migrations' abaixo da pasta 'Controllers' com algumas classes embutidas. 
Essas classes são responsáveis por criar o script de banco de dados 'por baixo dos panos' através do EF, contendo os atributos da classe 'Produtos'.
Nesta etapa ainda não temos a tabela criada em banco, para que isso aconteça siga o próximo passo.
8 - Volte ao terminal e digite o comando 'Update-database', e de acordo com a connectionStrings setada,
a tabela deverá aparecer na instância de banco de dados, para meu caso é 'EntityFrameworkCore_DB',
para você, aparecerá o valor que setou em sua connectionstrings na variável 'database'.
9 - Com o Microsoft SQL Server Management Studio (ou sua IDE de preferência) aberto, 
clique em atualizar base de dados, procure por 'Tabelas', e note que a tabela 'Produtos' aparecerá.
10 - Com as conexões feitas, agora você já pode testar os endpoints via swagger.
