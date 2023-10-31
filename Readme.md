# DIO - Bootcamp WEX - Desenvolvimento .NET e QA  - Testes Unitários com C#
www.dio.me

## Desafio de projeto
Desenvolver dois projetos, um Console Aplication utilizando POO. Uma Classe chamada Calculadora e suas funcionalidades. E outro projeto de Test do tipo xUnit para realizar os testes unitários.

## Premissas
A Calculadora só trabalhará com números inteiros. E o histórico deve mostrar somente as 3 últimas operações realizadas.
O projeto deve ser desenvolvido seguindo o padrão TDD - Test Driven Development.

## Projeto Console, sua Classe e Métodos

Essa é a classe do projeto console, onde fica a principal lógica do sistema.

**Classe Calculadora**

Classe responsável por realizar as operações básicas e exibição do histórico das ações realizadas.

| Classe          | Método                       | Objetivo                                                                                                                |
|---------------- |------------------------------|-------------------------------------------------------------------------------------------------------------------------|
| Calculadora | Somar      | Recebe dois números inteiros  e realiza a soma.                         |
| Calculadora | Subtrair | Recebe dois números inteiros  e realiza a substração do primeiro pelo segundo.               |
| Calculadora | Multiplicar      | Recebe dois números inteiros  e realiza a multiplicação. |
| Calculadora | Dividir     | Recebe dois números inteiros  e realiza a divisão do primeiro pelo segundo.                                                |
| Calculadora | Historico     | Mostra a lista das 3 ultimas operações realizadas.                                                |

**Program**

Programa do tipo console responsável por realizar diversas as funcionalidades, apresentando um menu interativo para o usuário, permitindo o usuário digitar os números e mostrar o resultado. Caso a opção seja o histórico, mostra o histórico das ultimas operações.

| Tarefa           | Descrição                                                 
|------------------|------------------------------|
| Menu de opções | Mostrar menu com 6 opções pedindo ao usuário que informe quak operação que ele deseja fazer: 1 - Soma, 2 - Subtração, 3 - Multiplicação, 4 - Divisão, 5 - Ver Histórico, 6 -  Sair                                                                            |
| Validar dados de entrada | Receber dois números e verificar se são do tipo inteiro              | 
| Histórico | Na opção histórico, sempre mostrar apenas as 3 últimas operações realizadas.              

## Projeto do tipo teste, sua classe e métodos

**Classe CalculadoraTest**

Classe responsável por realizar os testes da classe Calculadora.

| Classe               | Método de teste                               | Resultado esperado do teste
|----------------------|-----------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------|
| CalculadoraTest | Somar         | Receber dois números e verificar se a soma deles está certa. Realizar o teste com as entradas: 1, 2 e 4, 5   |
| CalculadoraTest | Subtrair                     | Receber dois números e verificar se a subtração deles está certa. Realizar o teste com as entradas: 2, 1 e 10, 5                      |
| CalculadoraTest | Multiplicar                 | Receber dois números e verificar se a multiplicação deles está certa. Realizar o teste com as entradas: 2, 5 e 3, 4                       |
| CalculadoraTest | Dividir         | Receber dois números e verificar se a divisão deles está certa. Realizar o teste com as entradas: 6, 2 e 10, 2                        |
| CalculadoraTest | Dividir           | Testar divisão por zero. Realizar o teste com as entradas: 3, 0                    |
| CalculadoraTest | Historico | Exibir a lista de histórico das últimas operações. Chamar as operações: Somar(2, 3) Somar(1, 5) Subtrair(5, 3) Multiplicar(6, 50) Dividir(50, 10)                 |


## Estrutura do projeto

O projeto  deve estar estruturado da seguinte maneira:

<picture>  
  <img alt="Estrutura" src="EstruturaProjeto.png" >
</picture>


## Solução
O projeto deve ser realizado do zero, tendo um arquivo de solução que agrupe os dois projetos (Console e Teste).

## Resolução
Os projetos foram desenvolvidos, seguindo o padrão TDD, primeiro foi realizado o projeto de Test, submetendo a Classe Calculadora sem a implementação dos métodos. Em seguida, foi realizado a implementação dos métodos na Classe Calculadora. Após essas duas etapas, foi criado a Classe Program e implementado a aplicação console Console e feito testes manuais adicionais, conforme mostra as imagens a seguir:

Projeto Test sendo executado
<picture>  
  <img alt="Projeto Teste sendo executado" src="https://github.com/GabrielaBrazSantos/teste-unitario-tdd/blob/main/ExecucaoTestes.PNG" >
</picture>

Programa Console sendo executado
<picture>  
  <img alt="Projeto Teste sendo executado" src="https://github.com/GabrielaBrazSantos/teste-unitario-tdd/blob/main/ExecucaoConsole.PNG" >
</picture>
