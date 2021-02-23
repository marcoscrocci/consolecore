## Criar projeto Console

terça-feira, 23 de fevereiro de 2021
19:44

dotnet new console -n <NomeProjeto>   


## Executar projeto

terça-feira, 23 de fevereiro de 2021
19:45

dotnet run 

Ou se estivermos na pasta da Solution:

dotnet run --project <ProjetoPrincipal>/<ProjetoPrincipal>.csproj

## Executar novamente automaticamente a cada alteração realizada no código fonte:

dotnet watch run

## Criar projeto classlib

terça-feira, 23 de fevereiro de 2021
19:45

dotnet new classlib -n <NomeProjeto>.Lib 


## Criar uma Solution e adicionar os projetos

terça-feira, 23 de fevereiro de 2021
19:46

dotnet new sln -n <NomeDaSolucao>

dotnet sln <NomeDaSolucao>.sln add Projeto1/Projeto1.csproj Projeto2/Projeto2.csproj


## Referenciar projetos

terça-feira, 23 de fevereiro de 2021
19:47

dotnet add <Projeto>/<Projeto>.csproj reference <ProjetoReferencia>.Lib/<ProjetoReferencia>.Lib.csproj





