using System;
using System.Collections.Generic;
using System.Threading;
class Labirinto
{
    private const int limit = 15;

    static void mostrarLabirinto(char[,] array)
    {
        for (int i = 0; i < limit; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < limit; j++)
            {
                Console.Write($" {array[i, j]} ");
            }
        }
        Console.WriteLine();
    }

    static void criaLabirinto(char[,] meuLab)
    {
        Random random = new Random();
        for (int i = 0; i < limit; i++)
        {
            for (int j = 0; j < limit; j++)
            {
                meuLab[i, j] = random.Next(4) == 1 ? '|' : '.';
            }
        }

        for (int i = 0; i < limit; i++)
        {
            meuLab[0, i] = '*';
            meuLab[limit - 1, i] = '*';
            meuLab[i, 0] = '*';
            meuLab[i, limit - 1] = '*';
        }

        int x = random.Next(limit);
        int y = random.Next(limit);
        meuLab[x, y] = 'Q';
    }

    static void resolveLabirinto(char[,] labirinto, int i, int j)
    {
        Stack<(int,int)> pilha = new Stack<(int,int)>();
        // Stack<int> pilha_j = new Stack<int>();
        bool encontrou = false;
        labirinto[i,j] = 'v'; // marca a posição inicial como visitada
        while (encontrou == false) // não achar o queijo
        {
            if (labirinto[i, j] == 'Q')
            {
                labirinto[i, j] = 'v';
                Console.WriteLine("Achou o queijo! :) ");
                encontrou = true;
                break;
            }
            int count = 0;
            if (labirinto[i, j + 1] == '.' || labirinto[i, j + 1] == 'Q')
            {
                pilha.Push((i, j));
                //pilha_j.Push(j);
                j++;
                count++;
                labirinto[i, j] = 'v';
            }
            else if (labirinto[i + 1, j] == '.' || labirinto[i + 1, j] == 'Q')
            {
                pilha.Push((i, j));
                // pilha_j.Push(j);
                i++;
                count++;
                labirinto[i, j] = 'v';
            }
            else if (labirinto[i, j - 1] == '.' || labirinto[i, j - 1] == 'Q')
            {
                pilha.Push((i, j));
                //pilha_j.Push(j);
                j--;
                count++;
                labirinto[i, j] = 'v';
            }
            else if (labirinto[i - 1, j] == '.' || labirinto[i - 1, j] == 'Q')
            {
                pilha.Push((i, j));
                //pilha_j.Push(j);
                i--;
                count++;
                labirinto[i, j] = 'v';
            }
            else if (pilha.Count > 0)
            {
                (i, j) = pilha.Pop();
                // j = pilha_j.Pop();
                count--;
                labirinto[i, j] = 'x';
            }
            else
            {
                if (count == 0)
                {
                    Console.WriteLine("É impossivel encontrar o queijo! :( ");
                    break;
                }

            }
            // tentar para baixo
            // tentar pra traz
            // tentar cima
            // voltar i = pop pilha_i e j = pop pilha_j
            // if count > 0
            // else count == 0, impossivel encontrar o queijo
            // achou o queijo labirinto[i,j] = "Q"
            Thread.Sleep(1000);
            Console.Clear();
            mostrarLabirinto(labirinto);
        }

    }

    static void Main(string[] args)
    {
        char[,] maze = new char[limit, limit];
        int x, y;
        criaLabirinto(maze);
        mostrarLabirinto(maze);
        Console.WriteLine("\nPosições iniciais (linha e coluna):");
        x = Convert.ToInt32(Console.ReadLine());
        y = Convert.ToInt32(Console.ReadLine());
        resolveLabirinto(maze, x, y);
        Console.ReadKey();
        // pilha pra guardar posições que ele tentar
        // pilha que guarda i e j
        // j + 1 verifica se tem barra
        // descer na matriz i + 1
        //  traz na matriz é j - 1
        // subir na matriz é i - 1
    }
}