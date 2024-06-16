using System;
class exercicio07
{
static void Main()
    {
        // Definindo a matriz 5x5
        int[,] M = new int[5, 5];

        // Preenchendo a matriz com valores aleatórios entre 1 e 10
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                M[i, j] = random.Next(1, 11); // números aleatórios de 1 a 10
            }
        }

        // Imprimindo a matriz preenchida para visualização
        Console.WriteLine("Matriz M:");
        ImprimirMatriz(M);

        // Chamando as funções para calcular as somas
        Console.WriteLine("\nSomas:");
        Console.WriteLine("a) Soma da linha 4: " + SomaLinha(M, 4));
        Console.WriteLine("b) Soma da coluna 2: " + SomaColuna(M, 2));
        Console.WriteLine("c) Soma da diagonal principal: " + SomaDiagonalPrincipal(M));
        Console.WriteLine("d) Soma da diagonal secundária: " + SomaDiagonalSecundaria(M));
        Console.WriteLine("e) Soma de todos os elementos: " + SomaTotalMatriz(M));
    }

    // Função para imprimir a matriz
    static void ImprimirMatriz(int[,] matriz)
    {
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Função para calcular a soma da linha específica
    static int SomaLinha(int[,] matriz, int linha)
    {
        int soma = 0;
        int colunas = matriz.GetLength(1);

        for (int j = 0; j < colunas; j++)
        {
            soma += matriz[linha, j];
        }

        return soma;
    }

    // Função para calcular a soma da coluna específica
    static int SomaColuna(int[,] matriz, int coluna)
    {
        int soma = 0;
        int linhas = matriz.GetLength(0);

        for (int i = 0; i < linhas; i++)
        {
            soma += matriz[i, coluna];
        }

        return soma;
    }

    // Função para calcular a soma da diagonal principal
    static int SomaDiagonalPrincipal(int[,] matriz)
    {
        int soma = 0;
        int ordem = matriz.GetLength(0);

        for (int i = 0; i < ordem; i++)
        {
            soma += matriz[i, i];
        }

        return soma;
    }

    // Função para calcular a soma da diagonal secundária
    static int SomaDiagonalSecundaria(int[,] matriz)
    {
        int soma = 0;
        int ordem = matriz.GetLength(0);

        for (int i = 0; i < ordem; i++)
        {
            soma += matriz[i, ordem - 1 - i];
        }

        return soma;
    }

    // Função para calcular a soma de todos os elementos da matriz
    static int SomaTotalMatriz(int[,] matriz)
    {
        int soma = 0;
        int linhas = matriz.GetLength(0);
        int colunas = matriz.GetLength(1);

        for (int i = 0; i < linhas; i++)
        {
            for (int j = 0; j < colunas; j++)
            {
                soma += matriz[i, j];
            }
        }

        return soma;
    }












}
