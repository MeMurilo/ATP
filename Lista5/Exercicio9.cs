using System;

class exercicio9
{
    static void Main()
    {
        int[,] A = PreencherMatriz();
        int[,] B = PreencherMatriz();

        ImprimirMatriz("Matriz A:", A);
        ImprimirMatriz("Matriz B:", B);

        ImprimirMatriz("Matriz S (Soma de A e B):", CalcularOperacao(A, B, (x, y) => x + y));
        ImprimirMatriz("Matriz D (Diferença de A e B):", CalcularOperacao(A, B, (x, y) => x - y));
    }

    static int[,] PreencherMatriz()
    {
        Random rnd = new Random();
        int[,] matriz = new int[4, 6];

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                matriz[i, j] = rnd.Next(1, 10); // exemplo: preencher com números aleatórios de 1 a 10
            }
        }

        return matriz;
    }

    static int[,] CalcularOperacao(int[,] matrizA, int[,] matrizB, Func<int, int, int> operacao)
    {
        int[,] resultado = new int[4, 6];

        for (int i = 0; i < resultado.GetLength(0); i++)
        {
            for (int j = 0; j < resultado.GetLength(1); j++)
            {
                resultado[i, j] = operacao(matrizA[i, j], matrizB[i, j]);
            }
        }

        return resultado;
    }

    static void ImprimirMatriz(string mensagem, int[,] matriz)
    {
        Console.WriteLine(mensagem);
        
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
        
        Console.WriteLine();
    }
}
