# Aula 03 - 06/10/2023

### Exercícios e Desafios da aula
[https://github.com/AlunosDiverseDEV2023/CodingTank1/tree/main/docs/Exercicios/Aula03](https://github.com/AlunosDiverseDEV2023/CodingTank1/tree/main/docs/Exercicios/Aula03)


## Comentários gerais sobre os exercícios

### Tratamento de exceção com TryParse()

``` csharp
    if(double.TryParse(Console.ReadLine(), out double pesoPeixe) == false)
    {
        Console.WriteLine("Não deu certo!");
        continue;
    }
```

### Identificação de palíndromos
``` csharp
    static void Main(string[] args)
    {
        string texto = "aqui é uma string";
        int tamanho = texto.Length;
        bool ehPalindromo = true;

        for(int i = 0; i < tamanho / 2; i++)
        {
            string letraComeco = texto[i].ToString();
            Console.WriteLine(letra);

            string letraFim = texto[tamanho - 1 - i].ToString();
            Console.WriteLine(letra);

            if(letraComeco != letraFim) ehPalindromo = false;
        }

        Console.WriteLine(ehPalindromo ? "É um palíndromo" : "Não é um palíndromo");
    }
```

## 1. Estruturas de Dados

### 1.1. Vetor ou Array

Um vetor, em inglês "array", é um agrupamento de variáveis do mesmo tipo. Esse agrupamento possui um valor fixo de quantas posições podemos armazenar.

``` csharp
    static void Main(string[] args)
    {
        // vetor => coleção de algo

        // os valores inteiros não preenchidos ficam com valor 0

        // vetor de tamanho 5
        int[] vetorInteiro = new int[5];

        // vetor sempre começa do índice 0 e termina no tamanho - 1
        vetorInteiro[0] = 1;
        vetorInteiro[1] = 2200;
        vetorInteiro[2] = 30;
        vetorInteiro[3] = 130;
        vetorInteiro[4] = 1130;

        int tamanhoAtual = vetorInteiro.Length;

        // aumentar tamanho do array
        Array.Resize(ref vetorInteiro, tamanhoAtual + 5);
        vetorInteiro[6] = 1131;

        // outra forma de inicialização
        int[] vetorInteiro = new int[5] { 1, 2, 3, 4, 5 };

        // percorrer o vetor utilizando for
        for(int i = 0; i < vetorInteiro.Length; i++)
        {
            Console.WriteLine($"indice: {i}; valor: {vetorInteiro[i]}");
        }

        // percorrer o vetor utilizando for
        for(int i = 0; i < vetorInteiro.Length; i++)
        {
            Console.WriteLine($"indice: {i}; valor: {vetorInteiro[i]}");
        }

        // percorrer o vetor utilizando foreach
        // executa um bloco de código para cada item dentro do vetor
        // não é necessario colocar contador nem indice
        foreach(var item in vetorInteiro)
        {
            int valorDoArray = item;
            Console.WriteLine(valorDoArray);
        }

        // percorrer o vetor utilizando while
        // enquanto a condição expressa for verdadeira, executa o bloco de código
        int contador = 0;
        while(contador < vetorInteiro.Length)
        {
            Console.WriteLine($"indice: {contador}; valor: {vetorInteiro[contador]}");
            contador++;
        }


        // while: continue e break
        bool condicao = true
        while(condicao)
        {
            Console.WriteLine("Informe seu time");
            string time = Console.ReadLine();

            if(time == "juventus")
            {
                bool condicao = false;
                // o continue interrompe a execução atual do bloco de código, porém continua a partir da próxima iteração do loop
                continue;
            }

            if(time == "ponte preta")
            {
                // o break interrompe a execução atual do bloco de código e encerra a execução do loop
                break;
            }

            Console.WriteLine($"Seu time é {time}");
        }

    }

    // stack: alocação estática. guardo um conjunto de memória no qual vou alocando  variáveis
    // stack overflow
    // heap: alocação dinâmica
    
```

### 1.2. Matriz
``` csharp
    static void Main(string[] args)
    {
        // matriz: vetor de 2 dimensões
        int[,] matriz = new int[2, 3];
        matriz[0, 0] = 1;
        matriz[0, 1] = 2;
        matriz[0, 2] = 4
        
        int[,] matriz2 = new int[2, 3]
        {
            {1, 2, 3},
            {4, 5, 6}
        };

        for(int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Console.WriteLine($"linha: {i}, coluna: {j}, valor: {matriz[i, j]}");
            }
        }
    }
```

### 1.3. Dicionário
O dicionário é uma matriz de duas dimensões com chave e valor de tipos diferentes
``` csharp
    static void Main(string[] args)
    {
        // exemplo de aplicação: banco de dados, JSON
        // mantém em memória sem a necessidade de ficar fazendo muitas requisições ao banco de dados
        // é bom para dados temporários

        // warning: verificar exemplos
        Dictionary<string, double> dic = new Dictionary<string, double>
        {
            { "chave1", 2 },
            { "chave2", 5.0 },
            { "chave3", 3.0 }
        };

        Console.WriteLine(dic["chave1"]);

        // há tipos análogos, como a Tupla<>, a List<>

        // curiosidade: é parecido com JSON

        foreach(var item in dic)
        {
            // é possível fazer alguns tipos de busca dentro do dicionário
            Console.WriteLite($"chave: {item.Key}, valor: {item.Value}");
        }

        List<string> keys = new List<string>(dic.Keys);
        for(int i = 0; i < keys.Count; i++)
        {
            var key = keys[i];
            var valor = dic[key];
        }
    }
```

Obs.: Uma string é um array de char!

Pesquisar:
- Stack e Heap no armazenando de memória
- Operações com vetores
- Biblioteca Linq
- Enum
- Do while