using System;

class exercicio08
{
    static void Main(string[] args)
    {
        int[,] mtz = new int[4, 4]; // Matriz 4x4
        Random r = new Random(); // Objeto para geração de números aleatórios

        // Preenchendo a matriz com valores aleatórios de 1 a 9
        for (int i = 0; i < mtz.GetLength(0); i++)
        {
            for (int j = 0; j < mtz.GetLength(1); j++)
            {
                mtz[i, j] = r.Next(1, 10); // Valores entre 1 e 9
            }
        }

        // Imprimindo a matriz
        ImprimirMatriz(mtz);

        // Calculando e exibindo a soma da diagonal principal
        int somaDiagonalPrincipal = 0;
        for (int i = 0; i < mtz.GetLength(0); i++)
        {
            somaDiagonalPrincipal += mtz[i, i];
        }

        Console.WriteLine($"\nA soma da diagonal principal é: {somaDiagonalPrincipal}");
    }

    // Função para imprimir a matriz
    static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
