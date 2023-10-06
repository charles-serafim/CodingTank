# Aula 01 - 04/10/2023

### Exercícios e Desafios da aula
[https://github.com/AlunosDiverseDEV2023/CodingTank1/tree/main/docs/Exercicios/Aula01](https://github.com/AlunosDiverseDEV2023/CodingTank1/tree/main/docs/Exercicios/Aula01)

## 1. Definições

### 1.1. Algoritmo

Um algoritmo é uma sequência de passos. Exemplo:

```
    Se a nota do aluno for maior ou igual 7
        Aprovado
    Se não for
        Reprovado
```

Podemos relatar outros exemplos do dia a dia, como uma receita culinária, ou o passo a passo das primeiras coisas que fazemos ao acordar. Toda sequência de passos pode ser transformada em um algoritmo.

### 1.2. Bloco de Código

É usado para agrupar nenhum ou mais declarações. O bloco é delimitado por um par de chaves e pode opcionalmente ser nomeado. Exemplo:

``` javascript
    {
        console.log("Bloco de código");
    }
```

### 1.3. Comentários

É usado para você escrever qualquer coisa dentro, documentar um código

``` javascript
    // console.log -> serve para mostrar algo na tela

    console.log("Comentários");

    // console.log("Esse código não será mais executado");
```

### 1.4. Estrutura de dados

Tem como objetivo organizar e administrar dados

```
    Lista de aprovados: (Estrutura de Dados)
        1 - Fulano
        1 - Beltrano
```

Dentro das estruturas de dados, podemos realizar operações como adição, remoção, edição, assim como percorrer a estrutura, buscar elementos, ordenar os elementos. Há estruturas de dados das mais diversas complexidades e com as mais diversas funções.

### 1.5. Sentença de Código

Corresponde a um passo do algoritmo ou a uma declaração. Se o código fonte descreve um algoritmo, então sentenças correspondem a passos do algoritmo. Exemplo:

``` javascript
    // Isso é uma sentença de código
    console.log("Hello, world!");
```

Dentro das estruturas de dados, podemos realizar operações como adição, remoção, edição, assim como percorrer a estrutura, buscar elementos, ordenar os elementos. Há estruturas de dados das mais diversas complexidades e com as mais diversas funções.


## 2. O C sharp

### 2.1. Introdução

C# é uma linguagem de programação moderna, orientada a objetos e fortemente tipada (ao declarar uma variável, você precisa especificar seu tipo de forma explícita) desenvolvida pela Microsoft. Ela faz parte da plataforma .NET e é amplamente usada para desenvolvimento de aplicativos Windows, aplicativos da web, jogos e muito mais.

Surgiu como uma linguagem pra competir com Java. O C# roda dentro de um framework, o .NET, e muitas aplicações rodam dentro do MVC do ASP.NET.

Diversos produtos de Cloud, como GCT, Azure ou AWS possuem suporte para o C#.

### 2.2. Tipos de dados

C# é uma linguagem fortemente tipada. Isso significa que devemos declarar o tipo de uma variável que indica o valor que ela armazenará, como um número int, um float ou decimal, string etc.

```
    - Tipos numéricos integrais (int, long, short, byte);
    - Tipos numéricos de ponto flutuante (float, double, decimal);
    - Tipos de caracteres (char);
    - Tipos booleanos (bool);
    - Tipos de texto (string);
    - Tipos de data e hora (DateTime, TimeSpan);
    - Tipos de enumeração (enum);
    - Tipos de array (array);
    - Tipos de referência (object, dynamic);
```

### 2.3. Variáveis

Em C#, 

### Código

``` csharp
    namespace Aula1
    {
        class Program
        {
            static void Main(string[] args)
            {
                string nome = args[0];
                Console.WriteLine("Hello, World!");
            }
        }
    }
```

* namespace: utilizado para agrupar arquivos dentro de um mesmo "pacote"

* string[] args: parâmetros utilizados na linha de comando, que são passados para o programa quando rodamos o arquivo executável. No exemplo, a string nome receberia a string armazenada em args[0];

### 2.4. Conversão de tipos de variáveis

