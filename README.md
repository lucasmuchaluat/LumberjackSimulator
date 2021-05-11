# LumberjackSimulator
Repositório para entrega do jogo First Person Explorer de Jogos Digitais 2021.1

## Identidade do jogo (Conceito)

Lumber, um lenhador e pescador, deve coletar madeiras específicas para conseguir fazer fogo e sobreviver às condições adversas da ilha desconhecida onde foi parar ao passar por uma tempestade enquanto ia pescar.

## Descrição da mecânica (Core Mechanics / System design)

É um jogo no estilo First Person Explorer. O objetivo é coletar 20 troncos de árvores coníferas, controlando um lenhador, que pode usar um machado e se deslocar com seu barco de pesca. Se o sol se por o jogo termina. Sempre que o personagem marreta 5 vezes uma árvore conífera, ela cai, é coletada e o jogador ganha um ponto. É necessário acumular 20 troncos de árvore para conseguir fazer um fogo duradouro o suficiente para se aquecer e assar sua comida. Durante o jogo, além de se locomover, o jogador tem a opção de dirigir seu barco, podendo se locomover entre as ilhas mais rápido e coletar as madeiras necessárias o quanto antes.

## Características (Mundo do jogo)

O jogo se passa em um arquipélago desconhecido, onde Lumber precisa sobreviver durante a noite para planejar a volta ao seu lar. O mundo é para ser explorado e instigar a curiosidade do player. Nele há três tipos de árvores: coníferas (altas e finas, boas para fazer fogueiras), broadleafs (mais robustas, dão frutos e proteger do sol) e palmeiras (coqueiros sob a areia). Ainda é possível navegar pelas águas em torno da ilha e pilotar um barco. A ideia é expor o jogador a um ambiente completo com múltiplos estímulos, que o fará mudara maneira de jogar a cada vez.

## Arte

O jogo é no formato 3D, com uma arte animada e colorida (água, planta, árvores, sol). Uma estética amigável e bem leve. A ideia é torná-la a mais simples e menos vulgar possível para que os jogadores se sintam instigados a explorar o mapa.

## Música/Trilha Sonora

* INTRO: [Clone Wars Intro] (https://youtu.be/i5chHfK6sCc)
* IN GAME: [Skyrim - Around the Fire](https://youtu.be/xHO3rIeVugs)
* ENDGAME (VITÓRIA): [Creedence Clearwater Revival - Fortunate Son](https://youtu.be/ZWijx_AgPiA)
* ENDGAME (DERROTA): [Civilization VI](https://youtu.be/PM8GPN0jPPA)

## Interface

A interface adotada é a mais simples e intuitiva possível. Inicialmente, há uma cutscene que explica o contexto e prepara a narrativa do jogo. Em seguida, ao clicar em "INICIAR", o jogador começa em seu barco. Depois, ele pode controlá-lo, até decidir descer em alguma ilha do arquipélago. Enquanto joga, na tela aparecerá o countdown de quanto tempo falta para o sol se por, além da quantidade de madeiras já coletadas pelo jogador. Quando acabar, há tanto uma cutscene para a vitória, quanto uma para a derrota, que completam e finalizam a narrativa do jogo.

## Controles

* PLAYER: Suas teclas de comando são WASD (para se locomover). SHIFT (enquanto pressiona alguma das teclas mencionadas anteriormente) para correr rápido. SPACE para pular. Tecla 3 para ativar/desativar o machado. Botão esquerdo do mouse (enquanto o machado estiver ativado) para dar o golpe. Tecla 1 caso queira alternar para o modo BARCO. Movimento do mouse controla a visão.
* BARCO: Suas teclas de comando são WASD (para direcionar o leme). Tecla 2 caso queira alternar para o modo Player (First Person Explorer).

## Dificuldade

A dificuldade do jogo é única e exclusivamente tempo. Porém, o objetivo de 20 árvores cortadas é extremamente razoável para os 6 minutos dados para o sol se por. O jogo foi feito para ser explorado e desbravar o ambiente. 

## Fluxo do jogo

Cutscene Ínicio ==> Tela de Menu ==> Tela do Jogo ==> Cutscene Final ==> Tela de Menu

## Personagens

Lumber, um lenhador que gosta de pescar. Sabe se virar, consegue caçar, colher frutos e ainda fazer fogueira. Mas para isso, precisa de matéria prima. Lenhador por natureza, pescador por opção, Lumber se ve na obrigação de se aquecer e assar seu peixe para planejar com calma sua volta pra casa.

## Definições gerais

* Gênero: First Person Explorer / Aventura / Cenário Iterativo;

* Plataformas: Unity 3D;

* Público alvo: Jogadores curiosos e apaixonados por uma boa narrativa.

## Referências

* Barco e Mar baseados no modelo open source da [Hibby Games](https://youtu.be/s_RIfCfMlPc)
* Mecânica de corte inspirada no modelo da survival island montada por [Funnyguy77](https://www.youtube.com/channel/UCt14Ssh96qEknKNjUsdutDQ)
* Day and Night cycle inspirado no canal do [Probably Spoonie](https://www.youtube.com/user/618Lonewolf/featured)
* Cutscene inspirado no tutorial do [How to Do](https://www.youtube.com/channel/UCCHLW0sg4HBjMU4yscSsbqQ)
