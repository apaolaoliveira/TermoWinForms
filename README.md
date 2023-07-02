<h1 align="center"> Termo </h1>

> ![Static Badge](https://img.shields.io/badge/status-finalizado-blue)  
> Tabalho da Academia do Programador  
> Programado em inglês no Windows Forms  
> Feito por Paola Oliveira em 15/05/2023

<br>

## Sobre

Projeto totalmente inspirado pelo <a title="Jogar" alt="Link do jogo Termo" href="https://term.ooo/">Termo</a>,
este jogo desafia os usuários a adivinharem uma única palavra de cinco letras todos os dias.
Com base no feedback disponível a cada tentativa, os jogadores são instigados a exercitar suas mentes enquanto se divertem. 
Sendo assim, tive como objetivo criar uma aplicação que fosse fiel à referência original, mantendo as regras e o design muito semelhantes.

<br>

## Funcionalidades

- Escolhe aleatóriamente uma palavra secreta para ser adivinhada
- Permite escrever nos campos de letras pelo teclado da tela
- Possui a implementação do Backspace, Enter e Reset
- Possibilita ao usuário jogar quantas vezes quiser
- Mostra o feedback da letra de acordo com o chute, onde cada cor tem o seu significado:
    - `Verde` → A letra existe na palavra e está na posição correta
    - `Amarelo` → Tem a letra, mas está na posição errada
    - `Preto` → Não há essa letra na palavra
- Verifica se os campos estão preenchidos corretamente 

<br>

## Como executar 

*Pré-requisitos:* <a title="página da microsoft dotnet" href="https://dotnet.microsoft.com/download"> dotnet 6.0 </a> e <a title="página do git" href="https://git-scm.com/"> Git </a>  
*Onde executar:* Prompt de comando ou Git Bash

```Shell
# clonar repositório
git clone https://github.com/apaolaoliveira/TermoWinForms

# entrar na pasta executável 
cd TermoWinForms/TermoWinForms

# compilar o projeto
dotnet build

# executar a aplicação
dotnet run
```

<br>

## Mídia

<div>
  <img title="Layout da tela" width="437" heigth="506" src="https://gcdnb.pbrd.co/images/aEfUWH9P33Q6.png?o=1" />
  <img title="Acertando a palvra" width="437" heigth="506" src="https://gcdnb.pbrd.co/images/3kBPUsGB9kTc.gif?o=1" />
  <img title="Errando a palavra" width="437" heigth="506" src="https://gcdnb.pbrd.co/images/DPGKcqzb5kVl.gif?o=1" />
  <img title="Verificações dos campos" width="437" heigth="506" src="https://gcdnb.pbrd.co/images/U9Usdt0unQHX.gif?o=1" />
</div>

<br>

## Tecnologias e Ferramentas
 
 `C#` `Visual Studio` `Git`
