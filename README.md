# 🐭 Jogo do Ratinho no Labirinto 🧀

--

## Sobre o Projeto
Este projeto implementa um jogo de labirinto utilizando a estrutura de dados **Pilha** e a linguagem **C#**.
O objetivo é guiar um ratinho até encontrar seu tão desejado **queijo** dentro do labirinto.

--

## Descrição sobre o jogo 
- O mapa do labirinto é gerado aleatoriamente e usa os seguintes símbolos:
  - `.` → Caminho livre para o rato explorar
  - `|` → Obstáculos que o rato não pode atravessar
  - `Q` → A recompensa final: o queijo!
  - O jogo utiliza uma **pilha** para controlar a movimentação do rato,
 garantindo que ele possa retroceder caso fique preso em um beco sem saída.

--

## Imagem
![image](https://github.com/user-attachments/assets/2b0a2f6c-4114-4f72-8219-9ec191acb597)

--

## Como foi Criado
- **Linguagem:** C#
- **Estrutura de Dados:** Pilha
- **Bibliotecas:** `System`, `System.Collections.Generic`, `System.Threading`

--

## Como executar o jogo
```sh
git clone https://github.com/seu-repositorio.git
cd nome-do-repositorio
dotnet run

