# Aula 02 - 05/10/2023

## 1. Strings

### 1.1. Declaração

``` csharp
    string minhaString;
    minhaString = "Isso é uma string";

    string minhaOutraString;
    minhaOutraString = "e essa aqui também é!";
```

### 1.2. Concatenação e Interpolação

``` csharp
    // concatenação
    string stringConcatenada = minhaString + " " + minhaOutraString;

    // interpolação
    string maisUmaStringConcatenada = ${minhaString} {minhaOutraString};

    // interpolação
    string outraStringConcatenada = string.Format("{0} {1}", minhaString, minhaOutraString);

    // concatenação
    string maisOutraStringConcatenada = string.Concat(minhaString, " ", minhaOutraString);

    StringBuilder builder = new StringBuilder();
    for (int i = 0; i < 10; i++)
    {
        builder.Append($"Item {i}, ");
    }
    string soMaisUmaStringConcatenada = builder.ToString();

    StringBuilder outroBuilder = new StringBuilder();
    outroBuilder.Append("Hello, ");
    outroBuilder.Append("world!");
    Console.WriteLine(outroBuilder.ToString());
```

### 1.3. Outras funções de Strings

``` csharp
    string stringSubstituida = minhaString.Replace("string", "barata");
```

``` csharp
    Console.Write("Insira o seu ultimo nome, idade e altura (mesma linha): ");
    string[] vet = Console.ReadLine().Split(' ');

    string ultNome = vet[0];
    int idade = int.Parse(vet[1]);
    double altura = double.Parse(vet[2]);

    Console.WriteLine(ultNome);
    Console.WriteLine(idade);
    Console.WriteLine(altura.ToString("F2"));
```

``` csharp
    string exemplo = "Exemplo de Texto";
    string exemploEspacos = "    Exemplo sem espaço    ";

    // copia para a string cortada os primeiros 7 caracteres da string exemplo -> cortada = "Exemplo"
    string cortada = exemplo.Substring(0, 7);

    // capitaliza todos os caracteres da string exemplo -> maiuscula == "EXEMPLO DE TEXTO"
    string maiuscula = exemplo.ToUpper();

    // todos os caracteres da string exemplo serão minúsculos -> minuscula == "exemplo de texto"
    string minuscula = exemplo.ToUpper();

    // remove espaços ao final e no iniciao da string -> semEspacosDemais == "Exemplo sem espaço"
    string semEspacosDemais = exemploEspacos.Trim();

    // remove todos os espaços -> semEspacoNenhum == "Exemplosemespaço"
    string semEspacoNenhum = exemploEspacos.Replace(" ", "");
    
    // coloca na variável comprimento o tamanho da string exemplo -> comprimento == 16
    int comprimento = exemplo.Length();

    // remove os espaços e já dá o comprimento -> numeroCaracteres == 14
    int numeroCaracteres = exemplo.Replace(" ", "").Length();

    // guarda a entrada do usuário já formatando para minúsculas -> nomeMinusculo = "charles serafim"
    Console.WriteLine("Digite o seu nome: ");
    string nomeMinusculo = Console.ReadLine().ToLower(); // usuário digita "Charles Serafim"

    // CultureInfo formata de acordo com o país passado -> numeroFormatado == "123.456,780"
    double numero = 123456.78;
    CultureInfo CI = CultureInfo.GetCultureInfo("pt-BR");
    string numeroFormatado = numero.ToString("N", CI);

    // transforma somente a primeira letra em maiúscula utilizando as funções ToUpper e Substring, juntamente com concatenação de strings e char -> saida == "Exemplo de texto"
    string exemploPrimeiraMaiuscula = "exemplo de texto";
    Console.WriteLine(char.ToUpper(texto2[0]) + texto2.Substring(1));

    // regex: verifica se algo corresponde a um padrão
    Console.WriteLine("Digite sim ou não");
    string input = Console.ReadLine();
    string pattern = @"^Não";
    bool isMatch = Regex.IsMatch(input, pattern);
    if(isMatch)
    {
        Console.WriteLine("A string corresponde ao padrão.");
    }
    else
    {
        Console.WriteLine("A string não corresponde ao padrão.");
    }

    // outros exemplos de regex -> telefone: (31 9 2345-2356)
    string phonePattern = @"\(\d{2}\) \d{5}-\d{4}";
    string phonePattern2 = @"\(\d{2}\) \d{4,5}-\d{4}";
    string phonePatternWith9 = @"\(\d{2}\) 9\d{4}-\d{4}";

    // verificar um reger com mais de um padrão: Regex.Matches

```

### 1.4. Conversão de Tipos

``` csharp
    // conversão implícita
    int numInteiro = 42;
    double numDecimal = inteiro;

    // conversão explícita
    double numDecimal2 = 42.5;
    int numInteiro2 = (int)numDecimal2;
```

### 1.5. Estruturas Condicionais

Em C#, assim como em muitas outras linguagens de programação, a estrutura condicional permite que você tome decisões no seu código com base em condições específicas. A estrutura condicional mais comum é o **if**, mas também existem variações como **else**, **else if** e **switch**.<br>

#### IF ELSE

No exemplo abaixo, o que está dentro do bloco de código entre chaves "{}" vai ser executado apenas se a condição expressa entre parênteses após o if seja verdadeira, ou seja, se o valor armazenado na variável idade for maior ou igual a 18.

``` csharp
    int idade = 18;
    if(idade >= 18)
    {
        Console.WriteLine("Você é maior de idade.");
    }
```
<br>

No exemplo abaixo, a palavra reservada "else" significa "se não", ou seja, se não for satisfeita a condição expressa pelo primeiro if, será analisada a condição do segundo if, e assim por diante. Ao final temos um else sozinho que abrange as possibilidades restantes, que será avaliado caso nenhuma das condições anteriores tenha sido satisfeita.<br><br>
Em outras palavras, o uso do else neste caso faz com que as condições sejam analisadas sequencialmente e faz com que a análise pare quando alguma condição for satisfeita.

``` csharp
    int nota = 85;
    if(nota >= 90)
    {
        Console.WriteLine("Sua nota é A.");
    }
    else if(nota >= 80)
    {
        Console.WriteLine("Sua nota é B.");
    }
    else if(nota >= 70)
    {
        Console.WriteLine("Sua nota é C.");
    }
    else
    {
        Console.WriteLine("Sua nota é D.");
    }

    // Saída:
        Sua nota é B.
```
<br>

Já neste exemplo, temos apenas o uso do if. Neste caso, as condições expressas em todos os ifs serão analisadas.<br><br>

``` csharp
    int nota = 85;
    if(nota >= 90)
    {
        Console.WriteLine("Sua nota é A.");
    }
    if(nota >= 80)
    {
        Console.WriteLine("Sua nota é B.");
    }
    if(nota >= 70)
    {
        Console.WriteLine("Sua nota é C.");
    }

    // Saída:
        Sua nota é B.
        Sua nota é C.
```
<br>

#### SWITCH CASE

Esta função faz a comparação de um argumento passado para ela com opções pré-estabelecidas e executa as funções contidas dentro do bloco **case**. A palavra **break** faz com que após a realização das operações do case, a execução do programa saia de dentro do **switch** e continue na linha após seu bloco de código.

``` csharp
    char operador = '+';
    double num1 = 18, num2 = 5, resultado = 0;

    switch(operador)
    {
        case '+':
            resultado = num1 + num2;
            break;
        

        case '-':
            resultado = num1 - num2;
            break;
        
        
        case '*':
            resultado = num1 * num2;
            break;
        
        
        case '/':
            resultado = num1 / num2;
            break;
        
        default:
            Console.WriteLine("Operador inválido");
            break;
    }

    Console.WriteLine("Resultado: " + resultado);
```

#### OPERADOR TERNÁRIO

Este operador faz a avaliação da expressão que vem antes do ponto de interrogação (?). Caso a condição seja verdadeira, será executado o que estiver do lado esquerdo dos dois pontos (:). Caso seja falsa, será executado o que está à direita.

``` csharp
    int numero = 10;
    string resultado = (nnumero % 2 == 0) ? "Par" : "Impar";
    string resultado2 = (numero > 0) ? "Maior que zero" : ((numero < 0) ? "Menor que zero" : "Zero")
```

Considerações: ponderar sobre a utilização exaustiva desses recursos. Refletir sobre a legibilidade do seu código, pois na vida profissional muitas vezes é importante que outras pessoas ou colegas de trabalho consigam compreender facilmente o código feito. Equilibrar a otimização do código com a legibilidade.