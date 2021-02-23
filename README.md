## Criar projeto Console

dotnet new console -n <NomeProjeto>   


## Executar projeto

dotnet run 

Ou se estivermos na pasta da Solution:

dotnet run --project <ProjetoPrincipal>/<ProjetoPrincipal>.csproj

## Executar novamente automaticamente a cada alteração realizada no código fonte:

dotnet watch run

## Criar projeto classlib

dotnet new classlib -n <NomeProjeto>.Lib 


## Criar uma Solution e adicionar os projetos

dotnet new sln -n <NomeDaSolucao>

dotnet sln <NomeDaSolucao>.sln add Projeto1/Projeto1.csproj Projeto2/Projeto2.csproj


## Referenciar projetos

dotnet add <Projeto>/<Projeto>.csproj reference <ProjetoReferencia>.Lib/<ProjetoReferencia>.Lib.csproj





