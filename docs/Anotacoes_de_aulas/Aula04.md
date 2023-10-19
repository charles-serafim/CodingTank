# Aula 04 - 09/10/2023

### Exercícios e Desafios da aula
[https://github.com/AlunosDiverseDEV2023/CodingTank1/tree/main/docs/Exercicios/Aula04](https://github.com/AlunosDiverseDEV2023/CodingTank1/tree/main/docs/Exercicios/Aula04)


``` csharp
    Console.WriteLine($"Valor da gorjeta: R$ {valorGorjeta.ToString("0.00")} " +
    $"\r\nValor total a pagar: R$ {(valorConta + valorGorjeta).ToString("0.00")} \n");
```

## Continuação: Estruturas de Repetição

### While

``` csharp
    int contador = 0;
    while (contador < 5)
    {
        // Código a ser repetido
        contador++;
    }
```

### Do... While

``` csharp
    int contador = 0;
    do
    {
        // Código a ser repetido
        contador++;
    }
    while (contador < 5);
```

## Tratamento de Erros

O tratamento de erros em C# é uma técnica essencial para lidar com exceções que podem ocorrer durante a execução de um programa. Exceções são eventos não planejados que ocorrem durante a execução do código e podem interromper a execução normal do programa se não forem tratadas adequadamente. O tratamento de erros permite que você lide com exceções de maneira controlada, evitando a quebra do programa.

Padrão chamado Polly -> repete as tentativas após um determinado período de tempo; Também pode ser utilizado fila.
Ver: [https://github.com/App-vNext/Polly](https://github.com/App-vNext/Polly).

### Try

Adequado de utilizar em trechos de código onde exceções podem ser geradas. Exemplo: entradas de dados pelos usuários.

``` csharp
    try // é onde as exceções vão ser geradas
    {
        int x = 10;
        int y = 0;
        int resultado = x  y;
        Console.WriteLine(resultado);
    }
```

### Catch

``` csharp
    try // é onde as exceções vão ser geradas
    {
        int x = 10;
        int y = 0;
        int resultado = x  y;
        Console.WriteLine(resultado);
    }
    catch (DivideByZeroException ex) // é onde as exceções serão tratadas
    {
        Console.WriteLine("Erro: Tentativa de divisão po zero.");
    }
```

_Try-Catch Cala-boca_: Um try catch que captura uma exceção porém não toma uma atitude em relação a ela, não faz nada com essa informação e muito menos trata a exceção.

### Finally

``` csharp
    FileStream arquivo = null
    try // é onde as exceções vão ser geradas
    {
        arquivo = new FileStream("arquivo.txt", FileMode.Open);
    }
    catch (IOException ex) // é onde as exceções serão tratadas
    {
        Console.WriteLine("Erro de ES: " + ex.Message);
    }
    finally // opcional -> vai definir atitudes a serem tomadas com a exceção
    {
        if(arquivo != null)
        {
            arquivo.Close();
        }
    }
```

### Catchs personalizadas

``` csharp
    catch (DivideByZeroException ex)
    {
        
    }
    catch (MinhaNovaExcecao ex)
    {

    }
```

