# Aula 03 - 06/10/2023

### Exercícios e Desafios da aula
[https://github.com/AlunosDiverseDEV2023/CodingTank1/tree/main/docs/Exercicios/Aula03](https://github.com/AlunosDiverseDEV2023/CodingTank1/tree/main/docs/Exercicios/Aula03)

## Tratamento de exceção com TryParse()

``` csharp
    if(double.TryParse(Console.ReadLine(), out double pesoPeixe) == false)
    {
        Console.WriteLine("Não deu certo!");
        continue;
    }
```