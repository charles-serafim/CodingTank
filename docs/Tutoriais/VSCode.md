# Instalar o SDK do .NET no Ubuntu

Links úteis:
<br>[https://learn.microsoft.com/pt-br/dotnet/core/install/linux-ubuntu](https://learn.microsoft.com/pt-br/dotnet/core/install/linux-ubuntu)
<br>


### Passo a passo


#### Passo 0: Verificar se o SDK já está instalado

Rodar os seguintes comandos no terminal:

```
    1   dotnet --list-sdks
    2   dotnet --list-runtimes
```

#### Passo 1: Instalar o SDK

```
    1   sudo apt-get update
    2   sudo apt-get install -y dotnet-sdk-7.0

```

#### Passo 2: Instalar dependências

```
    sudo apt install libc6
    sudo apt install libgcc1
    sudo apt install libgcc-s1
    sudo apt install libgssapi-krb5-2
    sudo apt install libicu70
    sudo apt install liblttng-ust1
    sudo apt install libssl3
    sudo apt install libstdc++6
    sudo apt install libunwind8
    sudo apt install zlib1g
```

#### Passo 3: Instalar VS Code

Instruções: [https://code.visualstudio.com/docs/setup/linux](https://code.visualstudio.com/docs/setup/linux)

Primeiramente, baixar o arquivo adequado à distribuição. No ubuntu, é a .deb, em [https://code.visualstudio.com/download](https://code.visualstudio.com/download).

#### Passo 4: Instalar extensões no VS Code

<div align="center">
    <p>Acessar o menu Extensions ou Extensões do VSCode</p>
    <img src="https://raw.githubusercontent.com/AlunosDiverseDEV2023/CodingTank1/main/docs/Assets/vscode1.png" width="600"><br><br>
    <p>Pesquisar "C#"</p>
    <img src="https://raw.githubusercontent.com/AlunosDiverseDEV2023/CodingTank1/main/docs/Assets/vscode2.png" width="600"><br><br>
    <p>Instalar as duas primeiras extensões listadas</p>
    <img src="https://raw.githubusercontent.com/AlunosDiverseDEV2023/CodingTank1/main/docs/Assets/extensoes1.png" width="400"><br><br>
    <img src="https://raw.githubusercontent.com/AlunosDiverseDEV2023/CodingTank1/main/docs/Assets/extensoes2.png" width="400">
</div>

#### Passo 5: Testando

Link: [https://learn.microsoft.com/pt-br/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-7-0](https://learn.microsoft.com/pt-br/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-7-0)

```
    1.  Criar uma pasta nomeada "HelloWorld" e abrir o VSCode dentro dela
    2.  Abrir o terminal dentro do VSCode selecionando Terminal > New Terminal ou Exibir > Terminal
    3.  Digitar no terminal "dotnet new console --framework net7.0"
    4.  Executar com o comando "dotnet run"
```

Após seguir estes passos, deve ser impressa na tela do terminal a mensagem "Hello, World!". Caso isso aconteça, o sdk foi instalado corretamente.
Pode-se utilizar os comandos do Passo 0 para verificar as versões do sdk e/ou runtime instaladas.