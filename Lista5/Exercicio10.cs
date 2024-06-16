using System;

class exercicio10
{
    static void Main(string[] args)
    {
        int[,] matriz = new int[10, 10];

        PreencherMatriz(matriz);
        Console.WriteLine("Matriz inicial:");
        MostrarMatriz(matriz);

        TrocarLinha(matriz, 2, 8);
        Console.WriteLine("\nMatriz após trocar a linha 2 com a linha 8:");
        MostrarMatriz(matriz);

        TrocarColuna(matriz, 4, 10);
        Console.WriteLine("\nMatriz após trocar a coluna 4 com a coluna 10:");
        MostrarMatriz(matriz);

        TrocarDiagonais(matriz);
        Console.WriteLine("\nMatriz após trocar a diagonal principal com a diagonal secundária:");
        MostrarMatriz(matriz);

        TrocarLinhaColuna(matriz, 5, 10);
        Console.WriteLine("\nMatriz após trocar a linha 5 com a coluna 10:");
        MostrarMatriz(matriz);
    }

    // Procedimento para preencher a matriz com valores aleatórios
    static void PreencherMatriz(int[,] matriz)
    {
        Random rnd = new Random();
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = rnd.Next(1, 100); // valores aleatórios de 1 a 99
            }
        }
    }

    // Procedimento para mostrar a matriz na tela
    static void MostrarMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Procedimento para trocar duas linhas da matriz
    static void TrocarLinha(int[,] matriz, int linha1, int linha2)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            int temp = matriz[linha1, j];
            matriz[linha1, j] = matriz[linha2, j];
            matriz[linha2, j] = temp;
        }
    }

    // Procedimento para trocar duas colunas da matriz
    static void TrocarColuna(int[,] matriz, int coluna1, int coluna2)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            int temp = matriz[i, coluna1 - 1];
            matriz[i, coluna1 - 1] = matriz[i, coluna2 - 1];
            matriz[i, coluna2 - 1] = temp;
        }
    }

    // Procedimento para trocar a diagonal principal com a diagonal secundária
    static void TrocarDiagonais(int[,] matriz)
    {
        int tamanho = matriz.GetLength(0);
        for (int i = 0; i < tamanho; i++)
        {
            int temp = matriz[i, i];
            matriz[i, i] = matriz[i, tamanho - 1 - i];
            matriz[i, tamanho - 1 - i] = temp;
        }
    }

    // Procedimento para trocar uma linha com uma coluna específica
    static void TrocarLinhaColuna(int[,] matriz, int linha, int coluna)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            int temp = matriz[linha, i];
            matriz[linha, i] = matriz[i, coluna - 1];
            matriz[i, coluna - 1] = temp;
        }
    }
}
